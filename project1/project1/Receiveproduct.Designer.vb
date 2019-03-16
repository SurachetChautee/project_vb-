<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Receive_product
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btnSale = New System.Windows.Forms.Button()
        Me.gbHead = New System.Windows.Forms.GroupBox()
        Me.txt_saleid = New System.Windows.Forms.TextBox()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSaleDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDetail = New System.Windows.Forms.GroupBox()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txt_price = New System.Windows.Forms.TextBox()
        Me.txt_proname = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvSale = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSaleTotal = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSaleAmount = New System.Windows.Forms.TextBox()
        Me.txtProID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gbHead.SuspendLayout()
        Me.gbDetail.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.btnSale)
        Me.GroupBox1.Location = New System.Drawing.Point(1169, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(575, 186)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.White
        Me.btn_save.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.Image = Global.project1.My.Resources.Resources.save
        Me.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_save.Location = New System.Drawing.Point(353, 36)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(175, 46)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btnSale
        '
        Me.btnSale.BackColor = System.Drawing.Color.White
        Me.btnSale.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSale.Image = Global.project1.My.Resources.Resources.receipt
        Me.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSale.Location = New System.Drawing.Point(22, 36)
        Me.btnSale.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(256, 46)
        Me.btnSale.TabIndex = 1
        Me.btnSale.Text = "เปิดบิลขาย"
        Me.btnSale.UseVisualStyleBackColor = False
        '
        'gbHead
        '
        Me.gbHead.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.gbHead.Controls.Add(Me.txt_saleid)
        Me.gbHead.Controls.Add(Me.lblEmployee)
        Me.gbHead.Controls.Add(Me.Label7)
        Me.gbHead.Controls.Add(Me.lblSaleDate)
        Me.gbHead.Controls.Add(Me.Label3)
        Me.gbHead.Controls.Add(Me.Label1)
        Me.gbHead.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.gbHead.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbHead.Location = New System.Drawing.Point(160, 90)
        Me.gbHead.Margin = New System.Windows.Forms.Padding(4)
        Me.gbHead.Name = "gbHead"
        Me.gbHead.Padding = New System.Windows.Forms.Padding(4)
        Me.gbHead.Size = New System.Drawing.Size(1001, 186)
        Me.gbHead.TabIndex = 6
        Me.gbHead.TabStop = False
        Me.gbHead.Text = "ข้อมูลการขายสินค้า"
        '
        'txt_saleid
        '
        Me.txt_saleid.Location = New System.Drawing.Point(193, 44)
        Me.txt_saleid.Multiline = True
        Me.txt_saleid.Name = "txt_saleid"
        Me.txt_saleid.Size = New System.Drawing.Size(254, 48)
        Me.txt_saleid.TabIndex = 1
        '
        'lblEmployee
        '
        Me.lblEmployee.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblEmployee.ForeColor = System.Drawing.Color.Black
        Me.lblEmployee.Location = New System.Drawing.Point(193, 112)
        Me.lblEmployee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(739, 48)
        Me.lblEmployee.TabIndex = 0
        Me.lblEmployee.Text = " "
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(9, 112)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 28)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ผู้บันทึก"
        '
        'lblSaleDate
        '
        Me.lblSaleDate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblSaleDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaleDate.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSaleDate.ForeColor = System.Drawing.Color.Black
        Me.lblSaleDate.Location = New System.Drawing.Point(543, 44)
        Me.lblSaleDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaleDate.Name = "lblSaleDate"
        Me.lblSaleDate.Size = New System.Drawing.Size(389, 48)
        Me.lblSaleDate.TabIndex = 0
        Me.lblSaleDate.Text = " "
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(471, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "วันที่ขาย"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(9, 45)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "หมายเลขใบเสร็จ"
        '
        'gbDetail
        '
        Me.gbDetail.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.gbDetail.Controls.Add(Me.btnFind)
        Me.gbDetail.Controls.Add(Me.txt_price)
        Me.gbDetail.Controls.Add(Me.txt_proname)
        Me.gbDetail.Controls.Add(Me.GroupBox2)
        Me.gbDetail.Controls.Add(Me.Button2)
        Me.gbDetail.Controls.Add(Me.dgvSale)
        Me.gbDetail.Controls.Add(Me.lblSaleTotal)
        Me.gbDetail.Controls.Add(Me.btnAdd)
        Me.gbDetail.Controls.Add(Me.txtSaleAmount)
        Me.gbDetail.Controls.Add(Me.txtProID)
        Me.gbDetail.Controls.Add(Me.Label10)
        Me.gbDetail.Controls.Add(Me.Label4)
        Me.gbDetail.Controls.Add(Me.Label13)
        Me.gbDetail.Controls.Add(Me.Label12)
        Me.gbDetail.Controls.Add(Me.Label11)
        Me.gbDetail.Controls.Add(Me.Label9)
        Me.gbDetail.Enabled = False
        Me.gbDetail.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.gbDetail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.gbDetail.Location = New System.Drawing.Point(160, 293)
        Me.gbDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.gbDetail.Name = "gbDetail"
        Me.gbDetail.Padding = New System.Windows.Forms.Padding(4)
        Me.gbDetail.Size = New System.Drawing.Size(1584, 669)
        Me.gbDetail.TabIndex = 4
        Me.gbDetail.TabStop = False
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.Transparent
        Me.btnFind.Image = Global.project1.My.Resources.Resources._2222
        Me.btnFind.Location = New System.Drawing.Point(143, 88)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(37, 32)
        Me.btnFind.TabIndex = 3
        Me.btnFind.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'txt_price
        '
        Me.txt_price.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_price.Location = New System.Drawing.Point(516, 84)
        Me.txt_price.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_price.Multiline = True
        Me.txt_price.Name = "txt_price"
        Me.txt_price.Size = New System.Drawing.Size(150, 40)
        Me.txt_price.TabIndex = 6
        '
        'txt_proname
        '
        Me.txt_proname.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txt_proname.Location = New System.Drawing.Point(206, 84)
        Me.txt_proname.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_proname.Multiline = True
        Me.txt_proname.Name = "txt_proname"
        Me.txt_proname.Size = New System.Drawing.Size(231, 40)
        Me.txt_proname.TabIndex = 5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblNet)
        Me.GroupBox2.Location = New System.Drawing.Point(859, 419)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(599, 180)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("FC Active", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(280, 33)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(286, 51)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = " 0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("FC Active", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(18, 52)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รวมเป็นเงิน"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("FC Active", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(7, 117)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(233, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "จำนวนเงินที่ต้องชำระ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNet
        '
        Me.lblNet.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Font = New System.Drawing.Font("FC Active", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.ForeColor = System.Drawing.Color.Lime
        Me.lblNet.Location = New System.Drawing.Point(280, 117)
        Me.lblNet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(286, 51)
        Me.lblNet.TabIndex = 0
        Me.lblNet.Text = " 0.00"
        Me.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = Global.project1.My.Resources.Resources.trash
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1336, 70)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 54)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ลบสินค้า"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgvSale
        '
        Me.dgvSale.AllowUserToAddRows = False
        Me.dgvSale.AllowUserToDeleteRows = False
        Me.dgvSale.AllowUserToResizeColumns = False
        Me.dgvSale.AllowUserToResizeRows = False
        Me.dgvSale.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvSale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvSale.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSale.Location = New System.Drawing.Point(19, 160)
        Me.dgvSale.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvSale.MultiSelect = False
        Me.dgvSale.Name = "dgvSale"
        Me.dgvSale.ReadOnly = True
        Me.dgvSale.RowHeadersVisible = False
        Me.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSale.Size = New System.Drawing.Size(1477, 230)
        Me.dgvSale.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "รหัส"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "ชื่อ"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 340
        '
        'Column3
        '
        Me.Column3.HeaderText = "ราคา"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "จำนวน"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 110
        '
        'Column5
        '
        Me.Column5.HeaderText = "เป็นเงิน"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 200
        '
        'lblSaleTotal
        '
        Me.lblSaleTotal.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblSaleTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaleTotal.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSaleTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSaleTotal.Location = New System.Drawing.Point(873, 84)
        Me.lblSaleTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaleTotal.Name = "lblSaleTotal"
        Me.lblSaleTotal.Size = New System.Drawing.Size(150, 40)
        Me.lblSaleTotal.TabIndex = 0
        Me.lblSaleTotal.Text = " "
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Image = Global.project1.My.Resources.Resources.add__1_
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(1137, 70)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(168, 54)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "เพิ่มสินค้า"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtSaleAmount
        '
        Me.txtSaleAmount.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSaleAmount.Location = New System.Drawing.Point(698, 84)
        Me.txtSaleAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaleAmount.Multiline = True
        Me.txtSaleAmount.Name = "txtSaleAmount"
        Me.txtSaleAmount.Size = New System.Drawing.Size(150, 41)
        Me.txtSaleAmount.TabIndex = 1
        '
        'txtProID
        '
        Me.txtProID.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProID.Location = New System.Drawing.Point(19, 84)
        Me.txtProID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProID.Multiline = True
        Me.txtProID.Name = "txtProID"
        Me.txtProID.Size = New System.Drawing.Size(116, 40)
        Me.txtProID.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(201, 52)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(277, 28)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ชื่อสินค้า"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(609, 440)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(303, 28)
        Me.Label4.TabIndex = 0
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(868, 52)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 28)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "เป็นเงิน"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(693, 52)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 28)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "จำนวน"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(511, 52)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 28)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ราคาต่อหน่วย"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(15, 52)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 28)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "รหัสสินค้า"
        '
        'Receive_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1813, 913)
        Me.Controls.Add(Me.gbDetail)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbHead)
        Me.Name = "Receive_product"
        Me.Text = "Receive_product"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.gbHead.ResumeLayout(False)
        Me.gbHead.PerformLayout()
        Me.gbDetail.ResumeLayout(False)
        Me.gbDetail.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btnSale As Button
    Friend WithEvents gbHead As GroupBox
    Friend WithEvents lblEmployee As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSaleDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbDetail As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents dgvSale As DataGridView
    Friend WithEvents lblSaleTotal As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSaleAmount As TextBox
    Friend WithEvents txtProID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_saleid As TextBox
    Friend WithEvents txt_price As TextBox
    Friend WithEvents txt_proname As TextBox
    Friend WithEvents cbo_brand As ComboBox
    Friend WithEvents cbo_category As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents btnFind As Button
End Class
