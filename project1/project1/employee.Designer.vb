<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class employee
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.datagrid_search = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtserch = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.txt_edit_id = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rad_edit_fmale = New System.Windows.Forms.RadioButton()
        Me.rad_edit_male = New System.Windows.Forms.RadioButton()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txt_edit_password = New System.Windows.Forms.TextBox()
        Me.txt_edit_username = New System.Windows.Forms.TextBox()
        Me.txt_edit_tel = New System.Windows.Forms.TextBox()
        Me.txt_edit_lastname = New System.Windows.Forms.TextBox()
        Me.txt_edit_name = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_add_id = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.rad_female = New System.Windows.Forms.RadioButton()
        Me.Rad_male = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_add_password = New System.Windows.Forms.TextBox()
        Me.txt_add_username = New System.Windows.Forms.TextBox()
        Me.txt_add_tel = New System.Windows.Forms.TextBox()
        Me.txt_add_lastname = New System.Windows.Forms.TextBox()
        Me.txt_add_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txt_showid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rad_showfmale = New System.Windows.Forms.RadioButton()
        Me.rad_showmale = New System.Windows.Forms.RadioButton()
        Me.txt_showpassword = New System.Windows.Forms.TextBox()
        Me.txt_showusername = New System.Windows.Forms.TextBox()
        Me.txt_showtel = New System.Windows.Forms.TextBox()
        Me.txt_showlastname = New System.Windows.Forms.TextBox()
        Me.txt_showname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        CType(Me.datagrid_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.datagrid_search)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 630)
        Me.Panel1.TabIndex = 0
        '
        'datagrid_search
        '
        Me.datagrid_search.AllowUserToAddRows = False
        Me.datagrid_search.AllowUserToDeleteRows = False
        Me.datagrid_search.BackgroundColor = System.Drawing.Color.White
        Me.datagrid_search.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.datagrid_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagrid_search.Location = New System.Drawing.Point(0, 130)
        Me.datagrid_search.Name = "datagrid_search"
        Me.datagrid_search.ReadOnly = True
        Me.datagrid_search.RowHeadersVisible = False
        Me.datagrid_search.RowTemplate.Height = 24
        Me.datagrid_search.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagrid_search.Size = New System.Drawing.Size(269, 500)
        Me.datagrid_search.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.txtserch)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(269, 130)
        Me.Panel2.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("FC Active", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button3.Location = New System.Drawing.Point(108, 68)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 44)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "ค้นหา"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ค้นหา"
        '
        'txtserch
        '
        Me.txtserch.Location = New System.Drawing.Point(66, 25)
        Me.txtserch.Multiline = True
        Me.txtserch.Name = "txtserch"
        Me.txtserch.Size = New System.Drawing.Size(179, 27)
        Me.txtserch.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.txt_edit_id)
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.rad_edit_fmale)
        Me.TabPage4.Controls.Add(Me.rad_edit_male)
        Me.TabPage4.Controls.Add(Me.Button5)
        Me.TabPage4.Controls.Add(Me.txt_edit_password)
        Me.TabPage4.Controls.Add(Me.txt_edit_username)
        Me.TabPage4.Controls.Add(Me.txt_edit_tel)
        Me.TabPage4.Controls.Add(Me.txt_edit_lastname)
        Me.TabPage4.Controls.Add(Me.txt_edit_name)
        Me.TabPage4.Controls.Add(Me.Label13)
        Me.TabPage4.Controls.Add(Me.Label14)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.Label21)
        Me.TabPage4.Controls.Add(Me.Label22)
        Me.TabPage4.Font = New System.Drawing.Font("FC Active", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage4.Location = New System.Drawing.Point(4, 33)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(718, 461)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "แก้ไข"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'txt_edit_id
        '
        Me.txt_edit_id.Enabled = False
        Me.txt_edit_id.Location = New System.Drawing.Point(160, 46)
        Me.txt_edit_id.Multiline = True
        Me.txt_edit_id.Name = "txt_edit_id"
        Me.txt_edit_id.Size = New System.Drawing.Size(196, 35)
        Me.txt_edit_id.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label12.Location = New System.Drawing.Point(36, 239)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 28)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "เพศ"
        '
        'rad_edit_fmale
        '
        Me.rad_edit_fmale.AutoSize = True
        Me.rad_edit_fmale.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rad_edit_fmale.Location = New System.Drawing.Point(228, 239)
        Me.rad_edit_fmale.Name = "rad_edit_fmale"
        Me.rad_edit_fmale.Size = New System.Drawing.Size(71, 32)
        Me.rad_edit_fmale.TabIndex = 48
        Me.rad_edit_fmale.TabStop = True
        Me.rad_edit_fmale.Text = "หญิง"
        Me.rad_edit_fmale.UseVisualStyleBackColor = True
        '
        'rad_edit_male
        '
        Me.rad_edit_male.AutoSize = True
        Me.rad_edit_male.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rad_edit_male.Location = New System.Drawing.Point(162, 239)
        Me.rad_edit_male.Name = "rad_edit_male"
        Me.rad_edit_male.Size = New System.Drawing.Size(64, 32)
        Me.rad_edit_male.TabIndex = 47
        Me.rad_edit_male.TabStop = True
        Me.rad_edit_male.Text = "ชาย"
        Me.rad_edit_male.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button5.Location = New System.Drawing.Point(249, 321)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(107, 42)
        Me.Button5.TabIndex = 45
        Me.Button5.Text = "แก้ไข"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'txt_edit_password
        '
        Me.txt_edit_password.Location = New System.Drawing.Point(489, 178)
        Me.txt_edit_password.Multiline = True
        Me.txt_edit_password.Name = "txt_edit_password"
        Me.txt_edit_password.Size = New System.Drawing.Size(196, 33)
        Me.txt_edit_password.TabIndex = 44
        '
        'txt_edit_username
        '
        Me.txt_edit_username.Location = New System.Drawing.Point(489, 110)
        Me.txt_edit_username.Multiline = True
        Me.txt_edit_username.Name = "txt_edit_username"
        Me.txt_edit_username.Size = New System.Drawing.Size(196, 33)
        Me.txt_edit_username.TabIndex = 43
        '
        'txt_edit_tel
        '
        Me.txt_edit_tel.Location = New System.Drawing.Point(489, 50)
        Me.txt_edit_tel.Multiline = True
        Me.txt_edit_tel.Name = "txt_edit_tel"
        Me.txt_edit_tel.Size = New System.Drawing.Size(196, 28)
        Me.txt_edit_tel.TabIndex = 42
        '
        'txt_edit_lastname
        '
        Me.txt_edit_lastname.Location = New System.Drawing.Point(160, 175)
        Me.txt_edit_lastname.Multiline = True
        Me.txt_edit_lastname.Name = "txt_edit_lastname"
        Me.txt_edit_lastname.Size = New System.Drawing.Size(196, 31)
        Me.txt_edit_lastname.TabIndex = 41
        '
        'txt_edit_name
        '
        Me.txt_edit_name.Location = New System.Drawing.Point(160, 115)
        Me.txt_edit_name.Multiline = True
        Me.txt_edit_name.Name = "txt_edit_name"
        Me.txt_edit_name.Size = New System.Drawing.Size(196, 35)
        Me.txt_edit_name.TabIndex = 40
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label13.Location = New System.Drawing.Point(370, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 28)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "เบอร์โทรศัพท์"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label14.Location = New System.Drawing.Point(376, 178)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 28)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Password"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label15.Location = New System.Drawing.Point(370, 110)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 28)
        Me.Label15.TabIndex = 37
        Me.Label15.Text = "Username"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label16.Location = New System.Drawing.Point(34, 175)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 28)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "นามสกุล"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label21.Location = New System.Drawing.Point(34, 53)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(115, 28)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "รหัสพนักงาน"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label22.Location = New System.Drawing.Point(34, 115)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(34, 28)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "ชื่อ"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txt_add_id)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.rad_female)
        Me.TabPage2.Controls.Add(Me.Rad_male)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.txt_add_password)
        Me.TabPage2.Controls.Add(Me.txt_add_username)
        Me.TabPage2.Controls.Add(Me.txt_add_tel)
        Me.TabPage2.Controls.Add(Me.txt_add_lastname)
        Me.TabPage2.Controls.Add(Me.txt_add_name)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label18)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(718, 461)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "เพิ่ม"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txt_add_id
        '
        Me.txt_add_id.Location = New System.Drawing.Point(145, 32)
        Me.txt_add_id.Multiline = True
        Me.txt_add_id.Name = "txt_add_id"
        Me.txt_add_id.Size = New System.Drawing.Size(196, 35)
        Me.txt_add_id.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label17.Location = New System.Drawing.Point(21, 225)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(44, 28)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "เพศ"
        '
        'rad_female
        '
        Me.rad_female.AutoSize = True
        Me.rad_female.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rad_female.Location = New System.Drawing.Point(213, 225)
        Me.rad_female.Name = "rad_female"
        Me.rad_female.Size = New System.Drawing.Size(71, 32)
        Me.rad_female.TabIndex = 23
        Me.rad_female.TabStop = True
        Me.rad_female.Text = "หญิง"
        Me.rad_female.UseVisualStyleBackColor = True
        '
        'Rad_male
        '
        Me.Rad_male.AutoSize = True
        Me.Rad_male.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Rad_male.Location = New System.Drawing.Point(147, 225)
        Me.Rad_male.Name = "Rad_male"
        Me.Rad_male.Size = New System.Drawing.Size(64, 32)
        Me.Rad_male.TabIndex = 22
        Me.Rad_male.TabStop = True
        Me.Rad_male.Text = "ชาย"
        Me.Rad_male.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button2.Location = New System.Drawing.Point(370, 318)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 42)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "เคลียร์"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Button1.Location = New System.Drawing.Point(227, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 42)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "เพิ่ม"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_add_password
        '
        Me.txt_add_password.Location = New System.Drawing.Point(474, 164)
        Me.txt_add_password.Multiline = True
        Me.txt_add_password.Name = "txt_add_password"
        Me.txt_add_password.Size = New System.Drawing.Size(196, 33)
        Me.txt_add_password.TabIndex = 19
        '
        'txt_add_username
        '
        Me.txt_add_username.Location = New System.Drawing.Point(474, 96)
        Me.txt_add_username.Multiline = True
        Me.txt_add_username.Name = "txt_add_username"
        Me.txt_add_username.Size = New System.Drawing.Size(196, 33)
        Me.txt_add_username.TabIndex = 18
        '
        'txt_add_tel
        '
        Me.txt_add_tel.Location = New System.Drawing.Point(474, 36)
        Me.txt_add_tel.Multiline = True
        Me.txt_add_tel.Name = "txt_add_tel"
        Me.txt_add_tel.Size = New System.Drawing.Size(196, 28)
        Me.txt_add_tel.TabIndex = 17
        '
        'txt_add_lastname
        '
        Me.txt_add_lastname.Location = New System.Drawing.Point(145, 161)
        Me.txt_add_lastname.Multiline = True
        Me.txt_add_lastname.Name = "txt_add_lastname"
        Me.txt_add_lastname.Size = New System.Drawing.Size(196, 31)
        Me.txt_add_lastname.TabIndex = 16
        '
        'txt_add_name
        '
        Me.txt_add_name.Location = New System.Drawing.Point(145, 101)
        Me.txt_add_name.Multiline = True
        Me.txt_add_name.Name = "txt_add_name"
        Me.txt_add_name.Size = New System.Drawing.Size(196, 35)
        Me.txt_add_name.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label7.Location = New System.Drawing.Point(355, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 28)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "เบอร์โทรศัพท์"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label8.Location = New System.Drawing.Point(361, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 28)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Password"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label9.Location = New System.Drawing.Point(355, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 28)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Username"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label10.Location = New System.Drawing.Point(19, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 28)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "นามสกุล"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label18.Location = New System.Drawing.Point(19, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(115, 28)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "รหัสพนักงาน"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label11.Location = New System.Drawing.Point(19, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 28)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "ชื่อ"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txt_showid)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.rad_showfmale)
        Me.TabPage1.Controls.Add(Me.rad_showmale)
        Me.TabPage1.Controls.Add(Me.txt_showpassword)
        Me.TabPage1.Controls.Add(Me.txt_showusername)
        Me.TabPage1.Controls.Add(Me.txt_showtel)
        Me.TabPage1.Controls.Add(Me.txt_showlastname)
        Me.TabPage1.Controls.Add(Me.txt_showname)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 33)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(718, 461)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "แสดงข้อมูล"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txt_showid
        '
        Me.txt_showid.Enabled = False
        Me.txt_showid.Location = New System.Drawing.Point(157, 54)
        Me.txt_showid.Multiline = True
        Me.txt_showid.Name = "txt_showid"
        Me.txt_showid.Size = New System.Drawing.Size(196, 31)
        Me.txt_showid.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 243)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 28)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "เพศ"
        '
        'rad_showfmale
        '
        Me.rad_showfmale.AutoSize = True
        Me.rad_showfmale.Enabled = False
        Me.rad_showfmale.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rad_showfmale.Location = New System.Drawing.Point(225, 243)
        Me.rad_showfmale.Name = "rad_showfmale"
        Me.rad_showfmale.Size = New System.Drawing.Size(71, 32)
        Me.rad_showfmale.TabIndex = 38
        Me.rad_showfmale.TabStop = True
        Me.rad_showfmale.Text = "หญิง"
        Me.rad_showfmale.UseVisualStyleBackColor = True
        '
        'rad_showmale
        '
        Me.rad_showmale.AutoSize = True
        Me.rad_showmale.Enabled = False
        Me.rad_showmale.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.rad_showmale.Location = New System.Drawing.Point(159, 243)
        Me.rad_showmale.Name = "rad_showmale"
        Me.rad_showmale.Size = New System.Drawing.Size(64, 32)
        Me.rad_showmale.TabIndex = 37
        Me.rad_showmale.TabStop = True
        Me.rad_showmale.Text = "ชาย"
        Me.rad_showmale.UseVisualStyleBackColor = True
        '
        'txt_showpassword
        '
        Me.txt_showpassword.Enabled = False
        Me.txt_showpassword.Location = New System.Drawing.Point(486, 182)
        Me.txt_showpassword.Multiline = True
        Me.txt_showpassword.Name = "txt_showpassword"
        Me.txt_showpassword.Size = New System.Drawing.Size(196, 33)
        Me.txt_showpassword.TabIndex = 36
        '
        'txt_showusername
        '
        Me.txt_showusername.Enabled = False
        Me.txt_showusername.Location = New System.Drawing.Point(486, 114)
        Me.txt_showusername.Multiline = True
        Me.txt_showusername.Name = "txt_showusername"
        Me.txt_showusername.Size = New System.Drawing.Size(196, 33)
        Me.txt_showusername.TabIndex = 35
        '
        'txt_showtel
        '
        Me.txt_showtel.Enabled = False
        Me.txt_showtel.Location = New System.Drawing.Point(486, 54)
        Me.txt_showtel.Multiline = True
        Me.txt_showtel.Name = "txt_showtel"
        Me.txt_showtel.Size = New System.Drawing.Size(196, 28)
        Me.txt_showtel.TabIndex = 34
        '
        'txt_showlastname
        '
        Me.txt_showlastname.Enabled = False
        Me.txt_showlastname.Location = New System.Drawing.Point(157, 179)
        Me.txt_showlastname.Multiline = True
        Me.txt_showlastname.Name = "txt_showlastname"
        Me.txt_showlastname.Size = New System.Drawing.Size(196, 31)
        Me.txt_showlastname.TabIndex = 33
        '
        'txt_showname
        '
        Me.txt_showname.Enabled = False
        Me.txt_showname.Location = New System.Drawing.Point(157, 119)
        Me.txt_showname.Multiline = True
        Me.txt_showname.Name = "txt_showname"
        Me.txt_showname.Size = New System.Drawing.Size(196, 35)
        Me.txt_showname.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(367, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 28)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "เบอร์โทรศัพท์"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(373, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 28)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(367, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 28)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Username"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 28)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "นามสกุล"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label19.Location = New System.Drawing.Point(31, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(115, 28)
        Me.Label19.TabIndex = 26
        Me.Label19.Text = "รหัสพนักงาน"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label20.Location = New System.Drawing.Point(31, 119)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 28)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "ชื่อ"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(269, 129)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(726, 498)
        Me.TabControl1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkOrange
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(269, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(726, 103)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.Image = Global.project1.My.Resources.Resources._1
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(145, 100)
        Me.ToolStripButton4.Text = "ลบข้อมูล"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Font = New System.Drawing.Font("FC Active", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = Global.project1.My.Resources.Resources.logout
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(145, 100)
        Me.ToolStripButton1.Text = "กลับสู่หน้าหลัก"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(995, 630)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "employee"
        Me.Panel1.ResumeLayout(False)
        CType(Me.datagrid_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents datagrid_search As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtserch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_add_password As TextBox
    Friend WithEvents txt_add_username As TextBox
    Friend WithEvents txt_add_tel As TextBox
    Friend WithEvents txt_add_lastname As TextBox
    Friend WithEvents txt_add_name As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents Label17 As Label
    Friend WithEvents rad_female As RadioButton
    Friend WithEvents Rad_male As RadioButton
    Friend WithEvents txt_add_id As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_showid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents rad_showfmale As RadioButton
    Friend WithEvents rad_showmale As RadioButton
    Friend WithEvents txt_showpassword As TextBox
    Friend WithEvents txt_showusername As TextBox
    Friend WithEvents txt_showtel As TextBox
    Friend WithEvents txt_showlastname As TextBox
    Friend WithEvents txt_showname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents txt_edit_id As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents rad_edit_fmale As RadioButton
    Friend WithEvents rad_edit_male As RadioButton
    Friend WithEvents Button5 As Button
    Friend WithEvents txt_edit_password As TextBox
    Friend WithEvents txt_edit_username As TextBox
    Friend WithEvents txt_edit_tel As TextBox
    Friend WithEvents txt_edit_lastname As TextBox
    Friend WithEvents txt_edit_name As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Button3 As Button
End Class
