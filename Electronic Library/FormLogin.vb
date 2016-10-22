Public Class LoginForm

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        If UserNameTextBox.Text = String.Empty Or PasswordTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter email and password")
        Else
            Dim db = New ELibraryEntities()
            Dim member = db.Members.FirstOrDefault(Function(m) m.Email = UserNameTextBox.Text)
            If member Is Nothing Then
                MessageBox.Show("login unsuccessful - email incorrect")
            ElseIf member.Password <> PasswordTextBox.Text Then
                MessageBox.Show("login unsuccessful - password incorrect")
            Else
                MessageBox.Show("Login Sucessful!")
                Me.Visible = False
                SearchForm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub
End Class
