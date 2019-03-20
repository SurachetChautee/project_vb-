Public Class report_emp
    Private Sub crystalReport11_InitReport(sender As Object, e As EventArgs)

    End Sub



    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then

        ElseIf ComboBox1.SelectedIndex = 1 Then
            report_productvb.Show()
            Me.Close()
        ElseIf ComboBox1.SelectedIndex = 2 Then
            report_SaleDetail.Show()
            Me.Close()
        ElseIf ComboBox1.SelectedIndex = 3 Then
            report_Productreceiptdetails.Show()
            Me.Close()
        End If
    End Sub

    Private Sub report_emp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub
End Class