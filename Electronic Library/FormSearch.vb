

Public Class SearchForm
    Dim db As ELibraryEntities = New ELibraryEntities()
    Dim username As String = LoginForm.UserNameTextBox.Text

    Private Sub FormSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeywordComboBox.SelectedIndex = 0
        EqualOrLikeComboBox.SelectedIndex = 0
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Me.Close()
        LoginForm.Visible = True
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchResourceListView.Items.Clear()
        If KeywordTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter keyword")
            Return
        End If

        Dim resources = db.Resources.Where(Function(r) r.Title = KeywordTextBox.Text)
        If resources.Count() = 0 Then
            MessageBox.Show("No resource found")
        End If
        For Each r As Resource In resources
            Dim item = SearchResourceListView.Items.Add(r.Title)
            item.SubItems.Add(r.AuthorFirst + " " + r.AuthorLast)
            item.SubItems.Add(r.PublicationDate)
            item.SubItems.Add(r.Series)
            item.SubItems.Add(r.ISBN)
            item.SubItems.Add(r.Subject_1 + " " + r.Subject_2)
            item.SubItems.Add(r.CheckOutPeriod)
            Dim checkouts = db.Checkouts.Where(Function(c) c.ResourceID = r.ResourceID)
            Dim latestCheckout = checkouts.Max(Function(c) c.CheckOutDate)
            Dim isAvailable = checkouts.FirstOrDefault(Function(c) c.CheckOutDate = latestCheckout).ReturnDate IsNot Nothing
            item.SubItems.Add(isAvailable)
            item.ToolTipText = r.BookInfo
        Next

    End Sub

    Private Sub SearchForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        KeywordTextBox.Clear()
        SearchResourceListView.Items.Clear()
    End Sub

    Private Sub SearchResourceListView_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles SearchResourceListView.MouseDoubleClick
        MessageBox.Show(SearchResourceListView.SelectedItems(0).ToolTipText)
    End Sub
End Class