Imports System.Data.SqlClient
Public Class SaleDetail
    Private Sub SaleDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        update()
        datasale.Columns(0).HeaderText = "เลขที่ใบเสร็จ"
        datasale.Columns(1).HeaderText = "รหัสสินค้า"
        datasale.Columns(2).HeaderText = "ชื่อสินค้า"
        datasale.Columns(3).HeaderText = "จำนวน"
        datasale.Columns(4).HeaderText = "ราคา"

        datasale.Columns(0).Width = 130
        datasale.Columns(1).Width = 115
        datasale.Columns(2).Width = 135
        datasale.Columns(3).Width = 100
        datasale.Columns(4).Width = 100
        caltotal()



    End Sub


    Private Sub caltotal()
        Dim total, net As Double
        For i = 0 To datasale.RowCount - 1
            total = total + Val(datasale.Item(4, i).Value)
        Next

        net = total
        lblNet.Text = FormatNumber(net, 2)
    End Sub
    Private Sub update()
        connect_open()
        sql = "select * from SaleDetail1"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        datasale.DataSource = ds.Tables("table")
    End Sub

    Private Sub datasale_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datasale.CellContentClick

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("ต้องการกลับสู่หน้าหลักหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then
            main.Show()
            Me.Close()
        End If
    End Sub
End Class