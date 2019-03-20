Public Class report_Productreceiptdetails
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            report_emp.Show()
            Me.Close()
        ElseIf ComboBox1.SelectedIndex = 1 Then
            report_productvb.Show()
            Me.Close()
        ElseIf ComboBox1.SelectedIndex = 2 Then
            report_SaleDetail.Show()
            Me.Close()

        ElseIf ComboBox1.SelectedIndex = 3 Then

        End If
    End Sub

    Private Sub report_Productreceiptdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 3
    End Sub
End Class