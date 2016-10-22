Imports System.Data.SQLite
Public Class Login
    Public sqlconn As New SQLiteConnection("data source = elibrary.db")

    Public Function Hascoonection() As Boolean
        Try
            sqlconn.open()
            sqlconn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public memberID As String
    Dim MemberName As String
    Dim MemberPassword As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        If Hascoonection() = True Then
            MessageBox.Show("Successful connection")
        Else
            MessageBox.Show("Unsucessful")
        End If

        Dim sqlcmd1 As New SQLiteCommand("SELECT Email, Password, MemberID, FirstName FROM Member WHERE (Email = '" & UserNameTextBox.Text & "')", sqlconn)

        sqlconn.Open()
        Dim sqlreader As SQLiteDataReader = sqlcmd1.ExecuteReader()

        If UserNameTextBox.Text = String.Empty Or PasswordTextBox.Text = String.Empty Then
            MessageBox.Show("Please enter email and password")

        ElseIf sqlreader.Read() = True Then
            memberID = sqlreader("MemberID").ToString()
            MemberName = sqlreader("FirstName").ToString()
            MemberPassword = sqlreader("Password").ToString()


            If MemberPassword = PasswordTextBox.Text Then
                MessageBox.Show("Login Sucessful!")
                MessageBox.Show("Select successful" & "  " & memberID & "  " & MemberName & "  " & MemberPassword)
                Search.Show()
            Else
                MessageBox.Show("login unsuccessful - email or password incorrect")
            End If
        Else
            MessageBox.Show("login unsuccessful - email or password incorrect")
        End If




    End Sub

    Private Sub UserNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UserNameTextBox.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub NameLabel_Click(sender As Object, e As EventArgs) Handles NameLabel.Click

    End Sub
End Class
