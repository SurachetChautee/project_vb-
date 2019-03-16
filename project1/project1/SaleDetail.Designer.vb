<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SaleDetail
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
        Me.datasale = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.datasale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'datasale
        '
        Me.datasale.AllowUserToAddRows = False
        Me.datasale.AllowUserToDeleteRows = False
        Me.datasale.AllowUserToResizeColumns = False
        Me.datasale.BackgroundColor = System.Drawing.SystemColors.GrayText
        Me.datasale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datasale.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.datasale.Location = New System.Drawing.Point(115, 256)
        Me.datasale.Name = "datasale"
        Me.datasale.RowHeadersVisible = False
        Me.datasale.RowTemplate.Height = 24
        Me.datasale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datasale.Size = New System.Drawing.Size(775, 354)
        Me.datasale.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkOrange
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1014, 103)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("FC Active", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 58)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "รายละเอียดการขาย"
        '
        'lblNet
        '
        Me.lblNet.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblNet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNet.Font = New System.Drawing.Font("FC Active", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.ForeColor = System.Drawing.Color.Lime
        Me.lblNet.Location = New System.Drawing.Point(604, 653)
        Me.lblNet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(286, 51)
        Me.lblNet.TabIndex = 3
        Me.lblNet.Text = " 0.00"
        Me.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("FC Active", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(276, 658)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(303, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ยอดขายทั้งหมด"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(287, 653)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(303, 28)
        Me.Label4.TabIndex = 5
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SaleDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1014, 801)
        Me.Controls.Add(Me.lblNet)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.datasale)
        Me.Name = "SaleDetail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SaleDetail"
        CType(Me.datasale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datasale As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNet As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
