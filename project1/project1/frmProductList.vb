Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class frmProductList

    Dim strSQL As String
    Dim myCon As New SqlConnection()
    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet
    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim r As Integer = dgvProduct.CurrentCell.RowIndex
        proIDFind = dgvProduct.Item(0, r).Value
        Me.Close()
    End Sub

    Private Sub frmProductList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        connect_open()
        strSQL = "Select pro_id,pro_name,pro_price From product"
        myDA = New SqlDataAdapter(strSQL, cn)
        myDS.Clear()
        myDA.Fill(myDS, "myPro")
        dgvProduct.DataSource = myDS.Tables("myPro")
        dgvProduct.Columns(0).HeaderText = "รหัสสินค้า"
        dgvProduct.Columns(1).HeaderText = "ชื่อสินค้า"
        dgvProduct.Columns(2).HeaderText = "ราคาสินค้า"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub



    Private Sub dgvProduct_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellDoubleClick
        Call btnSelect_Click(sender, e)
    End Sub

End Class