﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report_productvb
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport21 = New project1.CrystalReport2()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport21
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1245, 780)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("FC Active", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ข้อมูลพนักงาน", "สินค้าทั้งหมด", "รายละเอียดการขาย", "รายละเอียดการรับสินค้า"})
        Me.ComboBox1.Location = New System.Drawing.Point(507, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(225, 34)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Text = "--โปรดเลือกรายการ--"
        '
        'report_productvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1245, 780)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "report_productvb"
        Me.Text = "report_productvb"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport21 As CrystalReport2
    Friend WithEvents ComboBox1 As ComboBox
End Class
