Public Class main
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim d As DateTime = Now
        ' Label2.Text = Date.Now

    End Sub

    Private Sub พนกงานToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim from1 As New Form1
        Form1.ShowDialog()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        employee.Show()
        Me.Hide()


    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click

        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("กลับสู่หน้า Longin หรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then
            Me.Close()
            longin.Show()
            With longin
                .txt_username.Clear()
                .txt_password.Clear()
            End With
        End If
    End Sub

    Private Sub ToolStripButton3_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        product.Show()
        Me.Hide()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click


    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub
End Class
