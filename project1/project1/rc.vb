Imports System.Data.SqlClient
Public Class rc
    Dim strsql As String
    Dim mydr As SqlDataReader
    Private Sub rc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_bill_rc()
        ComboBox1.Enabled = False
        ComboBox1.SelectedIndex = ComboBox1.Items.Count - 1
    End Sub
    Private Sub load_bill_rc()
        connect_open()
        strsql = "select * from Product_receipt_detail1"
        cmd = New SqlCommand(strsql, cn)
        cmd.CommandTimeout = 15
        cmd.CommandType = CommandType.Text
        mydr = cmd.ExecuteReader
        If mydr.HasRows Then
            While mydr.Read
                ComboBox1.Items.Add(mydr.Item("rc_id"))
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

        strsql = "SELECT Receive_product1.*, Product_receipt_detail1.*
                    FROM Receive_product1 INNER JOIN
                  Product_receipt_detail1 ON Receive_product1.rc_id = Product_receipt_detail1.rc_id
                    Where Receive_product1.rc_id = '" & ComboBox1.SelectedItem & "'"

        da = New SqlDataAdapter(strsql, cn)
        ds = New DataSet
        da.Fill(ds, "rc")
        Dim FrmReport As New CrystalReport6
        FrmReport.SetDataSource(ds.Tables("rc"))
        CrystalReportViewer1.ReportSource = FrmReport
        CrystalReportViewer1.Show()


    End Sub
End Class