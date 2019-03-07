Imports System.Data.SqlClient

Public Class brand
    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("ต้องการกลับสู่หน้าหลักหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then

            main.Show()
            Me.Hide()

        End If




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("ต้องการแก้ไขข้อมูลหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then

            connect_open()
            sql = String.Format("update brand Set bra_name='{0}' where bra_id='{1}'", txt_show_2.Text, txt_sohw_1.Text)
            cmd = New SqlCommand(sql, cn)
            If cmd.ExecuteNonQuery >= 1 Then
                MsgBox("แก้ไขข้อมูลสำเร็จ")
                update()
                update2()
            Else
                MsgBox("แก้ไขไม่สำเร็จ")
            End If

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_add_1.Text = "" Or txt_add_2.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If



        connect_open()
        sql = "select * from  brand where bra_id ='" & txt_add_1.Text & "' "
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        Dim dts As DataTable = ds.Tables("table")
        If dts.Rows.Count > 0 Then
            MsgBox("มี รหัสยี่ห้อนี่อยู่ในระบบแล้ว")
            Return
        End If



        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("ต้องการเพิ่มข้อมูลหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then
            sql = "insert into brand(bra_id,bra_name)values(@id,@name)"
            cmd = New SqlCommand(sql, cn)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("id", txt_add_1.Text)
            cmd.Parameters.AddWithValue("name", txt_add_2.Text)
            If cmd.ExecuteNonQuery >= 1 Then
                MsgBox("เพิ่มประเภทสินค้าสำเร็จ")
                txt_add_1.Clear()
                txt_add_2.Clear()
                Update()
                update2()

            Else
                MsgBox("เพิ่มประเภทสินค้าไม่สำเร็จ")
            End If
        End If
    End Sub
    Private Sub update()
        connect_open()
        sql = "select * from brand"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        datagrid_brand1.DataSource = ds.Tables("table")
    End Sub
    Private Sub update2()
        connect_open()
        sql = "select * from brand"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        datagrid_brand2.DataSource = ds.Tables("table")
    End Sub

    Private Sub brand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        update()
        update2()

        datagrid_brand1.Columns(0).Width = 200
        datagrid_brand1.Columns(1).Width = 268
        datagrid_brand1.Columns(0).HeaderText = "รหัสยี่ห้อสินค้า"
        datagrid_brand1.Columns(1).HeaderText = "ชื่อยี่ห้อ"

        datagrid_brand2.Columns(0).Width = 200
        datagrid_brand2.Columns(1).Width = 268
        datagrid_brand2.Columns(0).HeaderText = "รหัสยี่ห้อสินค้า"
        datagrid_brand2.Columns(1).HeaderText = "ชื่อยี่ห้อ"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_add_1.Clear()
        txt_add_2.Clear()

    End Sub


    Private Sub datagrid_brand2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_brand2.CellClick
        Dim i As Integer = datagrid_brand2.CurrentRow.Index
        Dim key As String = datagrid_brand2.Item(0, i).Value

        txt_sohw_1.Text = datagrid_brand2.Item(0, i).Value
        txt_show_2.Text = datagrid_brand2.Item(1, i).Value
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("ต้องการลบข้อมูลหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then

            Dim i As Integer = datagrid_brand1.CurrentRow.Index
            Dim key As String = datagrid_brand2.Item(0, i).Value


            sql = "delete from brand where bra_id='" & key & "'"
            cmd = New SqlCommand(sql, cn)
            If cmd.ExecuteNonQuery >= 1 Then
                MsgBox("ลบสำเร็จ")
                update()
                update2()

            Else
                MsgBox("ลบผิดพลาด")

            End If
        End If
    End Sub
End Class