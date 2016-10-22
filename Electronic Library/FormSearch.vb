Public Class SearchForm

    Private Sub Delete1Button_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Keyword1ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KeywordComboBox.SelectedIndexChanged

    End Sub

    Private Sub FormSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeywordComboBox.SelectedIndex = 0
        LikeComboBox.SelectedIndex = 0
    End Sub
End Class