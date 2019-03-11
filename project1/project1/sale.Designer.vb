<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sale
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbDetail = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgvSale = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblSaleTotal = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSaleAmount = New System.Windows.Forms.TextBox()
        Me.txtProID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblProPrice = New System.Windows.Forms.Label()
        Me.lblProName = New System.Windows.Forms.Label()
        Me.gbHead = New System.Windows.Forms.GroupBox()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSaleDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSaleID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnSale = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbDetail.SuspendLayout()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbHead.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDetail
        '
        Me.gbDetail.BackColor = System.Drawing.SystemColors.Info
        Me.gbDetail.Controls.Add(Me.Button2)
        Me.gbDetail.Controls.Add(Me.dgvSale)
        Me.gbDetail.Controls.Add(Me.lblNet)
        Me.gbDetail.Controls.Add(Me.lblTotal)
        Me.gbDetail.Controls.Add(Me.lblSaleTotal)
        Me.gbDetail.Controls.Add(Me.btnFind)
        Me.gbDetail.Controls.Add(Me.btnAdd)
        Me.gbDetail.Controls.Add(Me.txtSaleAmount)
        Me.gbDetail.Controls.Add(Me.txtProID)
        Me.gbDetail.Controls.Add(Me.Label10)
        Me.gbDetail.Controls.Add(Me.Label5)
        Me.gbDetail.Controls.Add(Me.Label4)
        Me.gbDetail.Controls.Add(Me.Label2)
        Me.gbDetail.Controls.Add(Me.Label13)
        Me.gbDetail.Controls.Add(Me.Label12)
        Me.gbDetail.Controls.Add(Me.Label11)
        Me.gbDetail.Controls.Add(Me.Label9)
        Me.gbDetail.Controls.Add(Me.lblProPrice)
        Me.gbDetail.Controls.Add(Me.lblProName)
        Me.gbDetail.Enabled = False
        Me.gbDetail.Location = New System.Drawing.Point(13, 315)
        Me.gbDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.gbDetail.Name = "gbDetail"
        Me.gbDetail.Padding = New System.Windows.Forms.Padding(4)
        Me.gbDetail.Size = New System.Drawing.Size(1233, 514)
        Me.gbDetail.TabIndex = 3
        Me.gbDetail.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Coral
        Me.Button2.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Image = Global.project1.My.Resources.Resources.trash
        Me.Button2.Location = New System.Drawing.Point(1141, 46)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 54)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dgvSale
        '
        Me.dgvSale.AllowUserToAddRows = False
        Me.dgvSale.AllowUserToDeleteRows = False
        Me.dgvSale.AllowUserToResizeColumns = False
        Me.dgvSale.AllowUserToResizeRows = False
        Me.dgvSale.BackgroundColor = System.Drawing.Color.SandyBrown
        Me.dgvSale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvSale.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSale.Location = New System.Drawing.Point(16, 113)
        Me.dgvSale.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvSale.MultiSelect = False
        Me.dgvSale.Name = "dgvSale"
        Me.dgvSale.ReadOnly = True
        Me.dgvSale.RowHeadersVisible = False
        Me.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSale.Size = New System.Drawing.Size(1195, 230)
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
        'lblNet
        '
        Me.lblNet.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNet.Font = New System.Drawing.Font("FC Active", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.ForeColor = System.Drawing.Color.Lime
        Me.lblNet.Location = New System.Drawing.Point(926, 445)
        Me.lblNet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(286, 51)
        Me.lblNet.TabIndex = 0
        Me.lblNet.Text = " 0.00"
        Me.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("FC Active", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Red
        Me.lblTotal.Location = New System.Drawing.Point(925, 367)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(286, 51)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = " 0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSaleTotal
        '
        Me.lblSaleTotal.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblSaleTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaleTotal.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSaleTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSaleTotal.Location = New System.Drawing.Point(869, 65)
        Me.lblSaleTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaleTotal.Name = "lblSaleTotal"
        Me.lblSaleTotal.Size = New System.Drawing.Size(150, 28)
        Me.lblSaleTotal.TabIndex = 0
        Me.lblSaleTotal.Text = " "
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.Silver
        Me.btnFind.Location = New System.Drawing.Point(140, 60)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(37, 32)
        Me.btnFind.TabIndex = 1
        Me.btnFind.Text = "..."
        Me.btnFind.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Coral
        Me.btnAdd.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnAdd.Image = Global.project1.My.Resources.Resources.add
        Me.btnAdd.Location = New System.Drawing.Point(1052, 46)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(70, 54)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtSaleAmount
        '
        Me.txtSaleAmount.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtSaleAmount.Location = New System.Drawing.Point(695, 64)
        Me.txtSaleAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaleAmount.Multiline = True
        Me.txtSaleAmount.Name = "txtSaleAmount"
        Me.txtSaleAmount.Size = New System.Drawing.Size(150, 28)
        Me.txtSaleAmount.TabIndex = 1
        '
        'txtProID
        '
        Me.txtProID.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.txtProID.Location = New System.Drawing.Point(16, 61)
        Me.txtProID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProID.Multiline = True
        Me.txtProID.Name = "txtProID"
        Me.txtProID.Size = New System.Drawing.Size(116, 30)
        Me.txtProID.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(198, 35)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(277, 28)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ชื่อสินค้า"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(609, 445)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(303, 28)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "จำนวนเงินที่ต้องชำระ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(598, 367)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รวมเป็นเงิน"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(865, 19)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 28)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "เป็นเงิน"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(691, 19)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 28)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "จำนวน"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(522, 19)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 28)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ราคาต่อหน่วย"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 19)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 28)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "รหัสสินค้า"
        '
        'lblProPrice
        '
        Me.lblProPrice.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblProPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProPrice.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblProPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblProPrice.Location = New System.Drawing.Point(521, 61)
        Me.lblProPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProPrice.Name = "lblProPrice"
        Me.lblProPrice.Size = New System.Drawing.Size(150, 28)
        Me.lblProPrice.TabIndex = 0
        Me.lblProPrice.Text = " "
        '
        'lblProName
        '
        Me.lblProName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblProName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProName.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblProName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblProName.Location = New System.Drawing.Point(203, 63)
        Me.lblProName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProName.Name = "lblProName"
        Me.lblProName.Size = New System.Drawing.Size(300, 30)
        Me.lblProName.TabIndex = 0
        Me.lblProName.Text = " "
        '
        'gbHead
        '
        Me.gbHead.BackColor = System.Drawing.SystemColors.Info
        Me.gbHead.Controls.Add(Me.lblEmployee)
        Me.gbHead.Controls.Add(Me.Label7)
        Me.gbHead.Controls.Add(Me.lblSaleDate)
        Me.gbHead.Controls.Add(Me.Label3)
        Me.gbHead.Controls.Add(Me.lblSaleID)
        Me.gbHead.Controls.Add(Me.Label1)
        Me.gbHead.Location = New System.Drawing.Point(13, 151)
        Me.gbHead.Margin = New System.Windows.Forms.Padding(4)
        Me.gbHead.Name = "gbHead"
        Me.gbHead.Padding = New System.Windows.Forms.Padding(4)
        Me.gbHead.Size = New System.Drawing.Size(793, 156)
        Me.gbHead.TabIndex = 2
        Me.gbHead.TabStop = False
        '
        'lblEmployee
        '
        Me.lblEmployee.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblEmployee.ForeColor = System.Drawing.Color.Black
        Me.lblEmployee.Location = New System.Drawing.Point(191, 86)
        Me.lblEmployee.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(563, 48)
        Me.lblEmployee.TabIndex = 0
        Me.lblEmployee.Text = " "
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 86)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 28)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "พนักขาย"
        '
        'lblSaleDate
        '
        Me.lblSaleDate.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblSaleDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaleDate.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSaleDate.ForeColor = System.Drawing.Color.Black
        Me.lblSaleDate.Location = New System.Drawing.Point(521, 16)
        Me.lblSaleDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaleDate.Name = "lblSaleDate"
        Me.lblSaleDate.Size = New System.Drawing.Size(233, 48)
        Me.lblSaleDate.TabIndex = 0
        Me.lblSaleDate.Text = " "
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(458, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 28)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "วันที่ขาย"
        '
        'lblSaleID
        '
        Me.lblSaleID.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblSaleID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSaleID.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblSaleID.ForeColor = System.Drawing.Color.Black
        Me.lblSaleID.Location = New System.Drawing.Point(191, 20)
        Me.lblSaleID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaleID.Name = "lblSaleID"
        Me.lblSaleID.Size = New System.Drawing.Size(239, 48)
        Me.lblSaleID.TabIndex = 0
        Me.lblSaleID.Text = " "
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "หมายเลขใบเสร็จ"
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btn_save.Location = New System.Drawing.Point(229, 20)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(171, 46)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "บันทึก"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Enabled = False
        Me.btnPrint.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(10, 86)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(171, 46)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "พิมพ์ใบเสร็จรับเงิน"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnSale
        '
        Me.btnSale.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnSale.Location = New System.Drawing.Point(10, 20)
        Me.btnSale.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(171, 46)
        Me.btnSale.TabIndex = 1
        Me.btnSale.Text = "เปิดบิลขาย"
        Me.btnSale.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkOrange
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1267, 103)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.Image = Global.project1.My.Resources.Resources._2
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(145, 100)
        Me.ToolStripButton4.Text = "กลับสู่หน้าหลัก"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.btnSale)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Location = New System.Drawing.Point(824, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 155)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1267, 892)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbDetail)
        Me.Controls.Add(Me.gbHead)
        Me.Name = "sale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sale"
        Me.gbDetail.ResumeLayout(False)
        Me.gbDetail.PerformLayout()
        CType(Me.dgvSale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbHead.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbDetail As GroupBox
    Friend WithEvents dgvSale As DataGridView
    Friend WithEvents lblNet As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblSaleTotal As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents txtSaleAmount As TextBox
    Friend WithEvents txtProID As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblProPrice As Label
    Friend WithEvents lblProName As Label
    Friend WithEvents gbHead As GroupBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnSale As Button
    Friend WithEvents lblEmployee As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSaleDate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSaleID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_save As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
