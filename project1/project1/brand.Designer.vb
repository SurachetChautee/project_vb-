<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class brand
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.datagrid_brand1 = New System.Windows.Forms.DataGridView()
        Me.txt_add_1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_add_2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.datagrid_brand2 = New System.Windows.Forms.DataGridView()
        Me.txt_sohw_1 = New System.Windows.Forms.TextBox()
        Me.txt_show_2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.datagrid_brand1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.datagrid_brand2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkOrange
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(638, 103)
        Me.ToolStrip1.TabIndex = 0
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
        Me.TabControl1.Size = New System.Drawing.Size(638, 665)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Info
        Me.TabPage1.Controls.Add(Me.datagrid_brand1)
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
        Me.TabPage1.Size = New System.Drawing.Size(630, 626)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "เพิ่ม"
        '
        'datagrid_brand1
        '
        Me.datagrid_brand1.AllowUserToAddRows = False
        Me.datagrid_brand1.AllowUserToDeleteRows = False
        Me.datagrid_brand1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_brand1.Location = New System.Drawing.Point(0, 0)
        Me.datagrid_brand1.Name = "datagrid_brand1"
        Me.datagrid_brand1.ReadOnly = True
        Me.datagrid_brand1.RowHeadersVisible = False
        Me.datagrid_brand1.RowTemplate.Height = 24
        Me.datagrid_brand1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_brand1.Size = New System.Drawing.Size(630, 300)
        Me.datagrid_brand1.TabIndex = 5
        '
        'txt_add_1
        '
        Me.txt_add_1.Location = New System.Drawing.Point(222, 332)
        Me.txt_add_1.Multiline = True
        Me.txt_add_1.Name = "txt_add_1"
        Me.txt_add_1.Size = New System.Drawing.Size(226, 44)
        Me.txt_add_1.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(343, 513)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 41)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "เคลียร์"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_add_2
        '
        Me.txt_add_2.Location = New System.Drawing.Point(222, 430)
        Me.txt_add_2.Multiline = True
        Me.txt_add_2.Name = "txt_add_2"
        Me.txt_add_2.Size = New System.Drawing.Size(226, 44)
        Me.txt_add_2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "รหัสยี่ห้อ"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(222, 513)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "เพิ่ม"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 420)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ชื่อยี่ห้อ"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Info
        Me.TabPage2.Controls.Add(Me.datagrid_brand2)
        Me.TabPage2.Controls.Add(Me.txt_sohw_1)
        Me.TabPage2.Controls.Add(Me.txt_show_2)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Button4)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 35)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(630, 626)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "แก้ไข"
        '
        'datagrid_brand2
        '
        Me.datagrid_brand2.AllowUserToAddRows = False
        Me.datagrid_brand2.AllowUserToDeleteRows = False
        Me.datagrid_brand2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_brand2.Location = New System.Drawing.Point(0, 0)
        Me.datagrid_brand2.Name = "datagrid_brand2"
        Me.datagrid_brand2.ReadOnly = True
        Me.datagrid_brand2.RowHeadersVisible = False
        Me.datagrid_brand2.RowTemplate.Height = 24
        Me.datagrid_brand2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_brand2.Size = New System.Drawing.Size(630, 294)
        Me.datagrid_brand2.TabIndex = 12
        '
        'txt_sohw_1
        '
        Me.txt_sohw_1.Enabled = False
        Me.txt_sohw_1.Location = New System.Drawing.Point(219, 320)
        Me.txt_sohw_1.Multiline = True
        Me.txt_sohw_1.Name = "txt_sohw_1"
        Me.txt_sohw_1.Size = New System.Drawing.Size(226, 44)
        Me.txt_sohw_1.TabIndex = 7
        '
        'txt_show_2
        '
        Me.txt_show_2.Location = New System.Drawing.Point(219, 418)
        Me.txt_show_2.Multiline = True
        Me.txt_show_2.Name = "txt_show_2"
        Me.txt_show_2.Size = New System.Drawing.Size(226, 44)
        Me.txt_show_2.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "รหัสยี่ห้อ"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(277, 496)
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
        Me.Label4.Location = New System.Drawing.Point(34, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 29)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ชื่อยี่ห้อ"
        '
        'brand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 768)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "brand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "brand"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.datagrid_brand1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.datagrid_brand2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents datagrid_brand1 As DataGridView
    Friend WithEvents txt_add_1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_add_2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents datagrid_brand2 As DataGridView
    Friend WithEvents txt_sohw_1 As TextBox
    Friend WithEvents txt_show_2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
End Class
