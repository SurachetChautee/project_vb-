Imports System.Data.SqlClient

Public Class bill
    Dim strsql As String

    Dim mydr As SqlDataReader
    Dim myDA As SqlDataAdapter
    Dim myDS As DataSet
    Private Sub bill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_bill()
        ComboBox1.Enabled = False
        ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
    End Sub
    Private Sub load_bill()
        connect_open()
        strsql = "select * from sale1"
        cmd = New SqlCommand(strsql, cn)
        cmd.CommandTimeout = 15
        cmd.CommandType = CommandType.Text
        mydr = cmd.ExecuteReader
        If mydr.HasRows Then
            While mydr.Read
                ComboBox1.Items.Add(mydr.Item("sale_id"))
            End While
            ComboBox1.SelectedIndex = 0
        Else
            MessageBox.Show("")
            Me.Close()
        End If
        mydr.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        mydr.Close()
        connect_open()

        strsql = "SELECT sale1.*, SaleDetail1.*
                    From sale1 INNER Join
                  SaleDetail1 On sale1.sale_id = SaleDetail1.sale_id
                    Where SaleDetail1.sale_id = '" & ComboBox1.SelectedItem & "'"

        da = New SqlDataAdapter(strsql, cn)
        ds = New DataSet
        da.Fill(ds, "bill")
        Dim FrmReport As New CrystalReport5
        FrmReport.SetDataSource(ds.Tables("bill"))
        CrystalReportViewer1.ReportSource = FrmReport
        CrystalReportViewer1.Show()
    End Sub
End Class