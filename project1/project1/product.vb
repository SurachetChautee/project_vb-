Imports System.Data.SqlClient

Public Class product
    Dim strsql As String
    Dim gender As String
    Dim mydr As SqlDataReader
    Private Sub product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_product()
        type()
        brand()


        datagrid_product.Columns(0).Width = 130
        datagrid_product.Columns(1).Width = 171
        datagrid_product.Columns(2).Width = 130
        datagrid_product.Columns(3).Width = 130
        datagrid_product.Columns(4).Width = 130
        datagrid_product.Columns(5).Width = 130


        datagrid_product.Columns(0).HeaderText = "รหัสสินค้า"
        datagrid_product.Columns(1).HeaderText = "ชื่อสินค้า"
        datagrid_product.Columns(2).HeaderText = "ประเภท"
        datagrid_product.Columns(3).HeaderText = "ยี่ห้อ"
        datagrid_product.Columns(4).HeaderText = "จำนวน"
        datagrid_product.Columns(5).HeaderText = "ราคา"

    End Sub
    Private Sub load_product()
        connect_open()
        sql = "select * from product"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        datagrid_product.DataSource = ds.Tables("table")
    End Sub
    Private Sub type()
        strsql = "select * from category"
        cmd = New SqlCommand(strsql, cn)
        cmd.CommandTimeout = 15
        cmd.CommandType = CommandType.Text
        mydr = cmd.ExecuteReader
        If mydr.HasRows Then
            While mydr.Read
                cbo_category.Items.Add(mydr.Item("ca_name"))
            End While
            cbo_category.SelectedIndex = 0
        Else
            MessageBox.Show("")
            Me.Close()
        End If
        mydr.Close()
    End Sub

    Private Sub brand()
        strsql = "select * from brand"
        cmd = New SqlCommand(strsql, cn)
        cmd.CommandTimeout = 15
        cmd.CommandType = CommandType.Text
        mydr = cmd.ExecuteReader
        If mydr.HasRows Then
            While mydr.Read
                cbo_brand.Items.Add(mydr.Item("bra_name"))
            End While
            cbo_brand.SelectedIndex = 0
        Else
            MessageBox.Show("")
            Me.Close()
        End If
        mydr.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim ca_id As String
        connect_open()
        strsql = "select ca_id from category where ca_name = @category"
        cmd = New SqlCommand(strsql, cn)
        cmd.CommandType = CommandType.Text
        cmd.CommandTimeout = 15
        cmd.Parameters.AddWithValue("category", cbo_category.SelectedItem)
        mydr = cmd.ExecuteReader
        mydr.Read()
        ca_id = mydr.Item("ca_id")
        mydr.Close()


        Dim bra_id As String
        connect_open()
        strsql = "select bra_id from brand where bra_name = @brand"
        cmd = New SqlCommand(strsql, cn)
        cmd.CommandType = CommandType.Text
        cmd.CommandTimeout = 15
        cmd.Parameters.AddWithValue("brand", cbo_brand.SelectedItem)
        mydr = cmd.ExecuteReader
        mydr.Read()
        bra_id = mydr.Item("bra_id")
        mydr.Close()




        sql = "insert into product(pro_id,pro_name,pro_number,pro_price,ca_id,bra_id)values(@id,@name,@number,@price,@category,@brand)"
        cmd = New SqlCommand(sql, cn)
        cmd.CommandType = CommandType.Text
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("id", txt_add_id.Text)
        cmd.Parameters.AddWithValue("name", txt_add_name.Text)
        cmd.Parameters.AddWithValue("number", txt_add_number.Text)
        cmd.Parameters.AddWithValue("price", txt_add_price.Text)
        cmd.Parameters.AddWithValue("category", ca_id)
        cmd.Parameters.AddWithValue("brand", bra_id)

        If cmd.ExecuteNonQuery >= 1 Then
            MsgBox("เพิ่มข้อสินค้าสำเร็จ")
            update()

        Else
            MsgBox("เพิ่มข้อมูลสินค้าไม่สำเร็จ")
        End If

    End Sub


    Private Sub update()
        connect_open()
        sql = "select * from product"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        datagrid_product.DataSource = ds.Tables("table")
    End Sub
End Class