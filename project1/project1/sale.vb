Public Class sale
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dts As DataTable = cmd_excutedatatable()
        txt_emp_sale.Text = dts.Rows(0)("emp_name") & " " & dts.Rows(0)("emp_lastname")
        txt_date_sale.Text = Date.Now

    End Sub

    Private Sub sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class