<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Category
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
        Me.txt_add_1 = New System.Windows.Forms.TextBox()
        Me.txt_add_2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.datagrid_category = New System.Windows.Forms.DataGridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.datagrid_category2 = New System.Windows.Forms.DataGridView()
        Me.txt_sohw_1 = New System.Windows.Forms.TextBox()
        Me.txt_show_2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.datagrid_category, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.datagrid_category2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_add_1
        '
        Me.txt_add_1.Location = New System.Drawing.Point(211, 344)
        Me.txt_add_1.Multiline = True
        Me.txt_add_1.Name = "txt_add_1"
        Me.txt_add_1.Size = New System.Drawing.Size(226, 44)
        Me.txt_add_1.TabIndex = 0
        '
        'txt_add_2
        '
        Me.txt_add_2.Location = New System.Drawing.Point(211, 442)
        Me.txt_add_2.Multiline = True
        Me.txt_add_2.Name = "txt_add_2"
        Me.txt_add_2.Size = New System.Drawing.Size(226, 44)
        Me.txt_add_2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "รหัสประเภทสินค้า"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 432)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ชื่อประเภท"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(211, 525)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "เพิ่ม"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'datagrid_category
        '
        Me.datagrid_category.AllowUserToAddRows = False
        Me.datagrid_category.AllowUserToDeleteRows = False
        Me.datagrid_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_category.Location = New System.Drawing.Point(0, 0)
        Me.datagrid_category.Name = "datagrid_category"
        Me.datagrid_category.ReadOnly = True
        Me.datagrid_category.RowHeadersVisible = False
        Me.datagrid_category.RowTemplate.Height = 24
        Me.datagrid_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_category.Size = New System.Drawing.Size(630, 295)
        Me.datagrid_category.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(332, 525)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 41)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "เคลียร์"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkOrange
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(638, 103)
        Me.ToolStrip1.TabIndex = 7
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = Global.project1.My.Resources.Resources._11
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(145, 100)
        Me.ToolStripButton1.Text = "ลบข้อมูล"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 103)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(638, 725)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Info
        Me.TabPage1.Controls.Add(Me.datagrid_category)
        Me.TabPage1.Controls.Add(Me.txt_add_1)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.txt_add_2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 35)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(630, 686)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "เพิ่ม"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Info
        Me.TabPage2.Controls.Add(Me.datagrid_category2)
        Me.TabPage2.Controls.Add(Me.txt_sohw_1)
        Me.TabPage2.Controls.Add(Me.txt_show_2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 35)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(630, 686)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "แก้ไข"
        '
        'datagrid_category2
        '
        Me.datagrid_category2.AllowUserToAddRows = False
        Me.datagrid_category2.AllowUserToDeleteRows = False
        Me.datagrid_category2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_category2.Location = New System.Drawing.Point(0, 0)
        Me.datagrid_category2.Name = "datagrid_category2"
        Me.datagrid_category2.ReadOnly = True
        Me.datagrid_category2.RowHeadersVisible = False
        Me.datagrid_category2.RowTemplate.Height = 24
        Me.datagrid_category2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_category2.Size = New System.Drawing.Size(630, 298)
        Me.datagrid_category2.TabIndex = 12
        '
        'txt_sohw_1
        '
        Me.txt_sohw_1.Enabled = False
        Me.txt_sohw_1.Location = New System.Drawing.Point(219, 335)
        Me.txt_sohw_1.Multiline = True
        Me.txt_sohw_1.Name = "txt_sohw_1"
        Me.txt_sohw_1.Size = New System.Drawing.Size(226, 44)
        Me.txt_sohw_1.TabIndex = 7
        '
        'txt_show_2
        '
        Me.txt_show_2.Location = New System.Drawing.Point(219, 433)
        Me.txt_show_2.Multiline = True
        Me.txt_show_2.Name = "txt_show_2"
        Me.txt_show_2.Size = New System.Drawing.Size(226, 44)
        Me.txt_show_2.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 335)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "รหัสประเภทสินค้า"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(277, 511)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(105, 41)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "แก้ไข"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 423)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ชื่อประเภท"
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 828)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        CType(Me.datagrid_category, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.datagrid_category2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_add_1 As TextBox
    Friend WithEvents txt_add_2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents datagrid_category As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents datagrid_category2 As DataGridView
    Friend WithEvents txt_sohw_1 As TextBox
    Friend WithEvents txt_show_2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
End Class
