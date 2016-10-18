Public Class FormSearch

    Private Sub Delete1Button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Keyword1ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Keyword1ComboBox.SelectedIndexChanged

    End Sub

    Private Sub FormSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Keyword1ComboBox.SelectedIndex = 0
    End Sub
End Class