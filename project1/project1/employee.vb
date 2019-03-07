Imports System.Data.SqlClient

Public Class employee
    Dim gender As String
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtserch.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        connect_open()
        sql = "select * from employee where emp_usersname ='" & txt_add_username.Text & "' "
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        Dim dts As DataTable = ds.Tables("table")
        If dts.Rows.Count > 0 Then
            MsgBox("มี username นี่อยู่ในระบบแล้ว")
            Return
        End If


        If txt_add_id.Text = "" Or txt_add_username.Text = "" Or txt_add_password.Text = "" Or txt_add_name.Text = "" Or txt_add_lastname.Text = "" Or txt_add_tel.Text = "" Then
            MessageBox.Show("ใส่ข้อมูลให้ครบถ้วน")
            Exit Sub
        End If

        connect_open()
        sql = "insert into employee(emp_id,emp_usersname,emp_password,emp_name,emp_lastname,emp_sex,emp_tel) values(@id,@username,@password,@name,@lastname,@sex,@tel)"
        cmd = New SqlCommand(sql, cn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", txt_add_id.Text)
        cmd.Parameters.AddWithValue("username", txt_add_username.Text)
        cmd.Parameters.AddWithValue("password", txt_add_password.Text)
        cmd.Parameters.AddWithValue("name", txt_add_name.Text)
        cmd.Parameters.AddWithValue("lastname", txt_add_lastname.Text)
        cmd.Parameters.AddWithValue("sex", gender)
        cmd.Parameters.AddWithValue("tel", txt_add_tel.Text)


        If cmd.ExecuteNonQuery >= 1 Then
            MsgBox("เพิ่มข้อมูลพนักงานสำเร็จ")
            update()
            txt_add_id.Clear()
            txt_add_username.Clear()
            txt_add_password.Clear()
            txt_add_name.Clear()
            txt_add_lastname.Clear()
            txt_add_tel.Clear()
            Rad_male.Checked = False
            rad_female.Checked = False
        Else
            MsgBox("เพิ่มข้อมูลพนักงานไม่สำเร็จ")
        End If




    End Sub

    Private Sub employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_employee()
        datagrid_search.Columns(0).HeaderText = "รหัสพนักงาน"
        datagrid_search.Columns(1).HeaderText = "Username"
        datagrid_search.Columns(2).HeaderText = "Password"
        datagrid_search.Columns(3).HeaderText = "ชื่อ"
        datagrid_search.Columns(4).HeaderText = "นามสกุล"
        datagrid_search.Columns(5).HeaderText = "เพศ"
        datagrid_search.Columns(6).HeaderText = "เบอร์โทรศัพท์"
        Rad_male.Select()



    End Sub

    Public Sub load_employee()
        connect_open()
        sql = "select * from employee"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        datagrid_search.DataSource = ds.Tables("table")
    End Sub



    Private Sub datagrid_search_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_search.CellClick
        Dim i As Integer = datagrid_search.CurrentRow.Index
        Dim key As String = datagrid_search.Item(0, i).Value

        txt_showid.Text = datagrid_search.Item(0, i).Value
        txt_showusername.Text = datagrid_search.Item(1, i).Value
        txt_showpassword.Text = datagrid_search.Item(2, i).Value
        txt_showname.Text = datagrid_search.Item(3, i).Value
        txt_showlastname.Text = datagrid_search.Item(4, i).Value
        txt_showtel.Text = datagrid_search.Item(6, i).Value

        If datagrid_search.Rows(e.RowIndex).Cells(5).Value.ToString = "ชาย" Then
            rad_showmale.Checked = True
        ElseIf datagrid_search.Rows(e.RowIndex).Cells(5).Value.ToString = "หญิง" Then
            rad_showfmale.Checked = True
        End If
        '================================================================================================================'
        txt_edit_id.Text = datagrid_search.Item(0, i).Value
        txt_edit_username.Text = datagrid_search.Item(1, i).Value
        txt_edit_password.Text = datagrid_search.Item(2, i).Value
        txt_edit_name.Text = datagrid_search.Item(3, i).Value
        txt_edit_lastname.Text = datagrid_search.Item(4, i).Value
        txt_edit_tel.Text = datagrid_search.Item(6, i).Value

        If datagrid_search.Rows(e.RowIndex).Cells(5).Value.ToString = "ชาย" Then
            rad_edit_male.Checked = True
        ElseIf datagrid_search.Rows(e.RowIndex).Cells(5).Value.ToString = "หญิง" Then
            rad_edit_fmale.Checked = True
        End If
        '=========================================================================================================================='


    End Sub

    Private Sub datagrid_search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_search.CellContentClick

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs)

        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("ต้องการลบข้อมูลหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then

            Dim i As Integer = datagrid_search.CurrentRow.Index
            Dim key As String = datagrid_search.Item(0, i).Value
            sql = "delete from employee where emp_usersname='" & key & "'"
            cmd = New SqlCommand(sql, cn)
            If cmd.ExecuteNonQuery >= 1 Then
                MsgBox("ลบสำเร็จ")
                update()

            Else
                MsgBox("ลบผิดพลาด")

            End If


        End If


    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs)

        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("ต้องการแก้ไขข้อมูลหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then

            connect_open()
            sql = String.Format("update employee Set emp_password='{0}',emp_name='{1}',emp_lastname='{2}',emp_tel='{3}' where emp_usersname='{4}'", txt_edit_password.Text, txt_edit_username.Text, txt_edit_lastname.Text, txt_edit_tel.Text, txt_edit_username.Text)
            cmd = New SqlCommand(sql, cn)
            If cmd.ExecuteNonQuery >= 1 Then
                MsgBox("แก้ไขข้อมูลพนักงานสำเร็จ")
                update()

            Else
                MsgBox("แก้ไขไม่สำเร็จ")
            End If

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_add_id.Clear()
        txt_add_username.Clear()
        txt_add_password.Clear()
        txt_add_name.Clear()
        txt_add_lastname.Clear()
        txt_add_tel.Clear()

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs)
        main.Show()
        Me.Hide()
    End Sub

    Private Sub update()
        connect_open()
        sql = "select * from employee"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        datagrid_search.DataSource = ds.Tables("table")
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click

        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("ต้องการลบข้อมูลหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then

            Dim i As Integer = datagrid_search.CurrentRow.Index
            Dim key As String = datagrid_search.Item(0, i).Value
            sql = "delete from employee where emp_id='" & key & "'"
            cmd = New SqlCommand(sql, cn)
            If cmd.ExecuteNonQuery >= 1 Then
                MsgBox("ลบสำเร็จ")
                update()

            Else
                MsgBox("ลบผิดพลาด")

            End If


        End If
    End Sub

    Private Sub Rad_male_CheckedChanged(sender As Object, e As EventArgs) Handles Rad_male.CheckedChanged
        gender = "ชาย"
    End Sub

    Private Sub rad_female_CheckedChanged(sender As Object, e As EventArgs) Handles rad_female.CheckedChanged
        gender = "หญิง"
    End Sub

    Private Sub rad_showmale_CheckedChanged(sender As Object, e As EventArgs) Handles rad_showmale.CheckedChanged

    End Sub

    Private Sub rad_showfmale_CheckedChanged(sender As Object, e As EventArgs) Handles rad_showfmale.CheckedChanged

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("ต้องการกลับสู่หน้าหลักหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then
            main.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click

        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("ต้องการแก้ไขข้อมูลหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then

            connect_open()

            sql = String.Format("update employee Set emp_usersname='{0}',emp_password='{1}',emp_name='{2}',emp_lastname='{3}',emp_sex='{4}',emp_tel='{5}' where emp_id='{6}'", txt_edit_username.Text, txt_edit_password.Text, txt_edit_name.Text, txt_edit_lastname.Text, gender, txt_edit_tel.Text, txt_edit_id.Text)
            cmd = New SqlCommand(sql, cn)
            If cmd.ExecuteNonQuery >= 1 Then
                MsgBox("แก้ไขข้อมูลพนักงานสำเร็จ")
                update()

            Else
                MsgBox("แก้ไขไม่สำเร็จ")
            End If

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click


        connect_open()
            sql = String.Format("select * from employee where emp_id like '%{0}%'or emp_name like '%{0}%'or emp_name like'%{0}%'or emp_lastname like'%{0}%'or emp_tel like'%{0}%' ", txtserch.Text)

            datagrid_search.DataSource = cmd_excutedatatable()


    End Sub

    Private Sub rad_edit_male_CheckedChanged(sender As Object, e As EventArgs) Handles rad_edit_male.CheckedChanged
        gender = "ชาย"
    End Sub

    Private Sub rad_edit_fmale_CheckedChanged(sender As Object, e As EventArgs) Handles rad_edit_fmale.CheckedChanged
        gender = "หญิง"
    End Sub
End Class