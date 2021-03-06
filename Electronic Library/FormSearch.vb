﻿Public Class SearchForm
    Dim db As ELibraryEntities = New ELibraryEntities()

    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles  MyBase.VisibleChanged 
        KeywordComboBox.SelectedIndex = 0
        SearchResourceListView.Items.Clear()
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

        Dim resources = db.Resources.SqlQuery("SELECT * FROM Resources WHERE " + KeywordComboBox.Text + " LIKE '%" + KeywordTextBox.Text + "%'")
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
            Dim isAvailable = False
            If checkouts.Count() = 0 Then
                isAvailable = True
            Else
                isAvailable = checkouts.All(Function(c) c.ReturnDate IsNot Nothing)
            End If
            
            item.SubItems.Add(isAvailable)
            item.ToolTipText = r.BookInfo
            item.Name = r.ResourceID
            item.Tag = r
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

    Private Sub CheckOutButton_Click(sender As Object, e As EventArgs) Handles CheckOutButton.Click
        If SearchResourceListView.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a resource first")
            Return
        End If

        If SearchResourceListView.SelectedItems.Item(0).SubItems.Item(7).Text = "False" Then
            MessageBox.Show("The resource is not available")
            Return
        End If
        Dim newCheckout As Checkout = New Checkout()
        newCheckout.CheckoutID = db.Checkouts.Max(Function(checkout) CInt(checkout.CheckoutID)) + 1
        newCheckout.ResourceID = SearchResourceListView.SelectedItems.Item(0).Tag.ResourceID
        newCheckout.MemberID = LoginForm.member.MemberID
        newCheckout.CheckOutDate = Date.Now.Date
        
        db.Checkouts.Add(newCheckout)
        db.SaveChanges()
        SearchResourceListView.SelectedItems.Item(0).SubItems.Item(7).Text = "False"
        MessageBox.Show("Checkout Succeed!")
    End Sub

    Private Sub AccountButton_Click(sender As Object, e As EventArgs) Handles AccountButton.Click
        Me.Hide()
        AccountForm.ShowDialog()
    End Sub

End Class