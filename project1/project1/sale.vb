Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class sale

    Dim strSQL As String
    Dim myComm As New SqlCommand
    Dim myDR As SqlDataReader

    Private Function getNewBill() As String

        ''
        Dim newBillID As String = ""
        Dim lastBillID As String

        Dim curYear As Integer = Format(Date.Now, "yyyy") + 543
        connect_open()
        strSQL = "Select Max(sale_id) as maxSale from sale Where sale_id Like 'S" & curYear & "%' "
        myComm = New SqlCommand(strSQL, cn)
        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text
        myDR = myComm.ExecuteReader
        myDR.Read()

        If Not IsDBNull(myDR.Item("maxSale")) Then
            lastBillID = myDR.Item("maxSale")
            lastBillID = Mid(lastBillID, 7)
            newBillID = Val(lastBillID) + 1
            Select Case newBillID.Length
                Case 1 : newBillID = "000000" & newBillID
                Case 2 : newBillID = "00000" & newBillID
                Case 3 : newBillID = "0000" & newBillID
                Case 4 : newBillID = "000" & newBillID
                Case 5 : newBillID = "00" & newBillID
                Case 6 : newBillID = "0" & newBillID
            End Select
            newBillID = "S" & curYear & "/" & newBillID
        Else
            newBillID = "S" & curYear & "/0000001"
        End If
        myDR.Close()
        cn.Close()
        Return newBillID
    End Function


    Private Sub sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_save.Enabled = False
        ' lblSaleID.Text = getNewBill()
    End Sub

    Private Sub btnSale_Click(sender As Object, e As EventArgs) Handles btnSale.Click
        Dim dts As DataTable = cmd_excutedatatable()
        lblEmployee.Text = dts.Rows(0)("emp_name") & " " & dts.Rows(0)("emp_lastname")
        lblSaleDate.Text = Date.Now
        lblSaleID.Text = getNewBill()
        gbDetail.Enabled = True
        btn_save.Enabled = True




        btnSale.Enabled = False
    End Sub

    Private Sub txtProID_TextChanged(sender As Object, e As EventArgs) Handles txtProID.TextChanged
        lblProName.Text = ""
        lblProPrice.Text = ""
        txtSaleAmount.Text = ""
        lblSaleTotal.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        main.Show()
        Me.Hide()
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
            lblProName.Text = myDR.Item("pro_name")
            lblProPrice.Text = myDR.Item("pro_price")
            txtSaleAmount.Text = "1"
            txtSaleAmount.Focus()
        Else
            MessageBox.Show("ไม่พบสินค้าตามรหัสที่ท่านระบุ", "Data not found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtProID.SelectAll()
            txtProID.Focus()
        End If
        myDR.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
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
            dgvSale.Item(1, n - 1).Value = lblProName.Text
            dgvSale.Item(2, n - 1).Value = lblProPrice.Text
            dgvSale.Item(3, n - 1).Value = txtSaleAmount.Text
            dgvSale.Item(4, n - 1).Value = lblSaleTotal.Text
        End If
        Call caltotal()
        txtProID.Clear()
        lblProName.Text = ""
        lblProPrice.Text = ""
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
        lblSaleTotal.Text = Val(lblProPrice.Text) * Val(txtSaleAmount.Text)
        If Val(lblSaleTotal.Text) = 0 Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

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

    Private Sub txtSaleAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaleAmount.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) = 13 Then
                Call btnAdd_Click(sender, e)
            ElseIf Asc(e.KeyChar) <> 8 Then
                e.KeyChar = Nothing
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        connect_open()
        'บันทึกหัวใบเสร็จ
        strSQL = "Insert into Sale(sale_id,sale_date,emp_id) " &
                " Values(@sid, @sdate, @e_id)"
        myComm = New SqlCommand(strSQL, cn)
        myComm.CommandTimeout = 15
        myComm.CommandType = CommandType.Text
        myComm.Parameters.AddWithValue("sid", lblSaleID.Text)
        myComm.Parameters.Add("sdate", SqlDbType.Date).Value = lblSaleDate.Text
        myComm.Parameters.AddWithValue("e_id", lblEmployee.Text)
        myComm.ExecuteNonQuery()


        For i = 0 To dgvSale.RowCount - 1
            'บันทึกรายการขาย
            strSQL = "Insert into SaleDetail(sale_id,pro_id,amount,proprice) " &
           " Values(@sid, @pid, @samount, @pprice)"
            myComm.CommandText = strSQL
            myComm.Parameters.Clear()
            myComm.Parameters.AddWithValue("sid", lblSaleID.Text)
            myComm.Parameters.AddWithValue("pid", dgvSale.Item(0, i).Value)
            myComm.Parameters.AddWithValue("samount", dgvSale.Item(3, i).Value)
            myComm.Parameters.AddWithValue("pprice", dgvSale.Item(2, i).Value)
            myComm.ExecuteNonQuery()

            'ตัดสต๊อก
            strSQL = "update product set pro_number = pro_number - @samount " &
                " Where pro_id = @pid "
            myComm.CommandText = strSQL
            myComm.ExecuteNonQuery()
        Next
        MessageBox.Show("บันทึกการขายสินค้าเรียบร้อย", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        dgvSale.Rows.Clear()
        lblSaleID.Text = ""
        lblSaleDate.Text = ""
        lblEmployee.Text = ""
        lblTotal.Text = ""
        lblNet.Text = ""
        cn.Close()
        btn_save.Enabled = False
        btnSale.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("ต้องการลบรายการสินค้าหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then
            dgvSale.Rows.Remove(dgvSale.SelectedRows(0))
            caltotal()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        main.Show()
        Me.Close()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("ต้องการกลับสู่หน้าหลักหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then
            main.Show()
            Me.Hide()
        End If
    End Sub
End Class