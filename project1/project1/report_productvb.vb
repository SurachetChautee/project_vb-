Public Class report_productvb
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            report_emp.Show()
            Me.Close()
        ElseIf ComboBox1.SelectedIndex = 1 Then

        ElseIf ComboBox1.SelectedIndex = 2 Then
            report_SaleDetail.Show()
            Me.Close()
        ElseIf ComboBox1.SelectedIndex = 3 Then
            report_Productreceiptdetails.Show()
            Me.Close()
        End If
    End Sub

    Private Sub report_productvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 1
    End Sub
End Class