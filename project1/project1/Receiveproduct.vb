Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class Receive_product
    Dim strSQL As String
    Dim myComm As New SqlCommand
    Dim myDR As SqlDataReader
    Private Sub btnSale_Click(sender As Object, e As EventArgs) Handles btnSale.Click
        lblSaleDate.Text = Date.Now
        name_emp()
        gbDetail.Enabled = True
        btn_save.Enabled = True
        txt_saleid.Enabled = True
        btnSale.Enabled = False
    End Sub
    Private Sub name_emp()
        With main
            Dim name As String
            name = .lbl_name.Text
            lblEmployee.Text = name
        End With
    End Sub

    Private Sub Receive_product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_save.Enabled = False
        txt_saleid.Enabled = False

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtProID.Text = "" Or txt_proname.Text = "" Or txt_price.Text = "" Or txtSaleAmount.Text = "" Then
            MessageBox.Show("กรุณาเลือกสินค้า", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub

        End If

        Dim found As Boolean = False
        Dim total As Double
        For i = 0 To dgvSale.RowCount - 1
            If txtProID.Text = dgvSale.Item(0, i).Value Then
                dgvSale.Item(3, i).Value = Val(dgvSale.Item(3, i).Value) + Val(txtSaleAmount.Text)
                total = Val(dgvSale.Item(2, i).Value) * Val(dgvSale.Item(3, i).Value)
                dgvSale.Item(4, i).Value = total
                found = True
                Exit For
            End If
        Next

        If found = False Then
            Dim n As Integer
            dgvSale.Rows.Add()
            n = dgvSale.Rows.Count
            dgvSale.Item(0, n - 1).Value = txtProID.Text
            dgvSale.Item(1, n - 1).Value = txt_proname.Text
            dgvSale.Item(2, n - 1).Value = txt_price.Text
            dgvSale.Item(3, n - 1).Value = txtSaleAmount.Text
            dgvSale.Item(4, n - 1).Value = lblSaleTotal.Text


        End If

        Call caltotal()
        txtProID.Clear()
        txt_proname.Text = ""
        txt_price.Text = ""
        txtSaleAmount.Text = ""
        lblSaleTotal.Text = ""
        txtProID.Focus()

    End Sub

    Private Sub caltotal()
        Dim total, net As Double
        For i = 0 To dgvSale.RowCount - 1
            total = total + Val(dgvSale.Item(4, i).Value)
        Next
        net = total
        lblTotal.Text = FormatNumber(total, 2)
        lblNet.Text = FormatNumber(net, 2)
    End Sub

    Private Sub txtSaleAmount_TextChanged(sender As Object, e As EventArgs) Handles txtSaleAmount.TextChanged
        lblSaleTotal.Text = Val(txt_price.Text) * Val(txtSaleAmount.Text)
        If Val(lblSaleTotal.Text) = 0 Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("ต้องการลบรายการสินค้าหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then
            dgvSale.Rows.Remove(dgvSale.SelectedRows(0))
            caltotal()
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        connect_open()
        'บันทึกหัวใบเสร็จ
        strSQL = "Insert into Receive_product(sale_id,sale_date,emp_id) " &
                " Values(@sid, @sdate, @e_id)"
        myComm = New SqlCommand(strSQL, cn)
        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text
        myComm.Parameters.AddWithValue("sid", txt_saleid.Text)
        myComm.Parameters.Add("sdate", SqlDbType.Date).Value = lblSaleDate.Text
        myComm.Parameters.AddWithValue("e_id", lblEmployee.Text)
        myComm.ExecuteNonQuery()

        For i = 0 To dgvSale.RowCount - 1
            'บันทึกรายการขาย
            strSQL = "Insert into Product_receipt_detail(sale_id,pro_id,pro_name,amount,pro_price) " &
           " Values(@sid, @pid,@pname, @samount, @pprice)"
            myComm.CommandText = strSQL
            myComm.Parameters.Clear()
            myComm.Parameters.AddWithValue("sid", txt_saleid.Text)
            myComm.Parameters.AddWithValue("pid", dgvSale.Item(0, i).Value)
            myComm.Parameters.AddWithValue("pname", dgvSale.Item(1, i).Value)
            myComm.Parameters.AddWithValue("samount", dgvSale.Item(3, i).Value)
            myComm.Parameters.AddWithValue("pprice", dgvSale.Item(2, i).Value)
            myComm.ExecuteNonQuery()


            'ตัดสต๊อก
            strSQL = "update product set pro_number = pro_number + @samount " &
                " Where pro_id = @pid "
            myComm.CommandText = strSQL
            myComm.ExecuteNonQuery()
        Next
        MessageBox.Show("บันทึกการขายสินค้าเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        dgvSale.Rows.Clear()
        txt_saleid.Text = ""
        lblSaleDate.Text = ""
        lblEmployee.Text = ""
        lblTotal.Text = ""
        lblNet.Text = ""
        cn.Close()
        btn_save.Enabled = False
        btnSale.Enabled = True

    End Sub





    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        proIDFind = ""
        Dim frmFindPro As New frmProductList
        frmFindPro.ShowDialog()
        If proIDFind <> "" Then
            txtProID.Text = proIDFind
            Call findProduct()
        Else
            txtProID.Focus()
        End If

    End Sub
    Private Sub findProduct()
        connect_open()
        strSQL = "Select pro_name,pro_price from product where pro_id = @pid "
        myComm = New SqlCommand(strSQL, cn)
        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text
        myComm.Parameters.AddWithValue("pid", txtProID.Text)
        myDR = myComm.ExecuteReader
        If myDR.HasRows Then
            myDR.Read()
            txt_proname.Text = myDR.Item("pro_name")
            txt_price.Text = ""
            txt_price.Focus()

            myDR.Close()

            connect_open()

            strSQL = "select pro_id from product where pro_id = @pidd"
            myComm = New SqlCommand(strSQL, cn)
            myComm.Parameters.Clear()
            myComm.Parameters.AddWithValue("pidd", txtProID.Text)
            myDR = myComm.ExecuteReader
            If myDR.HasRows Then
                myDR.Read()
                txtProID.Clear()
                txtProID.Text = myDR.Item("pro_id")
            End If

        Else
            MessageBox.Show("ไม่พบสินค้าตามรหัสที่ท่านระบุ", "Data not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProID.SelectAll()
            txtProID.Focus()
        End If
        myDR.Close()
    End Sub

    Private Sub txtProID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProID.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtProID.Text = txtProID.Text.Trim
            If txtProID.Text.Length = 0 Then
                Exit Sub
            End If
            Call findProduct()

        End If
    End Sub
End Class