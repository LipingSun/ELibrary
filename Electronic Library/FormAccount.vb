Public Class AccountForm

    Dim db As ELibraryEntities = New ELibraryEntities()

    Private Sub AccountForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim member = LoginForm.member
        DNameLabel.Text = member.FirstName + " " + member.LastName
        DEmailLabel.Text = member.Email
        DAddressLabel.Text = member.StreetAddress + ", " + member.City + ", " + member.State + ", " + member.ZipCode

        AccountResourceListView.Items.Clear()
        
        Dim checkouts = db.Checkouts.Where(Function(c) c.MemberID = member.MemberID And c.ReturnDate Is Nothing)
        For Each c As Checkout In checkouts
            Dim item = AccountResourceListView.Items.Add(c.Resource.Title)
            item.Tag = c
            item.SubItems.Add(c.CheckOutDate)
            Dim due = CDate(c.CheckOutDate).AddDays(CInt(c.Resource.CheckOutPeriod))
            item.SubItems.Add(due)
        Next

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click, MyBase.FormClosed
        Me.Close()
        SearchForm.Show()
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        If AccountResourceListView.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a resource first")
            Return
        End If
        Dim item = AccountResourceListView.SelectedItems.Item(0)
        item.Tag.ReturnDate = Date.Now.Date
        db.saveChanges()
        AccountResourceListView.Items.Remove(item)
        MessageBox.Show("Return Succeed!")
    End Sub

    Private Sub RenewBotton_Click(sender As Object, e As EventArgs) Handles RenewBotton.Click
        If AccountResourceListView.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a resource first")
            Return
        End If
        Dim item = AccountResourceListView.SelectedItems.Item(0)
        item.Tag.ReturnDate = Date.Now.Date
        Dim newCheckout As Checkout = New Checkout()
        newCheckout.CheckoutID = db.Checkouts.Max(Function(checkout) CInt(checkout.CheckoutID)) + 1
        newCheckout.ResourceID = item.Tag.ResourceID
        newCheckout.MemberID = LoginForm.member.MemberID
        newCheckout.CheckOutDate = Date.Now.Date
        db.Checkouts.Add(newCheckout)
        db.SaveChanges()
        AccountResourceListView.Items.Remove(item)
        item.Tag = newCheckout
        item.SubItems.Item(1).Text = newCheckout.CheckOutDate
        item.SubItems.Item(2).Text = CDate(newCheckout.CheckOutDate).AddDays(CInt(newCheckout.Resource.CheckOutPeriod))
        AccountResourceListView.Items.Add(item)
        MessageBox.Show("Renew Succeed!")
    End Sub
End Class
