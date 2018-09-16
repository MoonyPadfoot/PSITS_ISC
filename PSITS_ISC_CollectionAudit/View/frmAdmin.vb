Public Class frmAdmin
    Dim admin As New clsAdmin
    Dim flagU As Integer = 0
    Dim flagP As Integer = 0
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        admin.User = Me.tbUser.Text
        admin.Pass = Me.tbPass.Text
        If admin.Auth() = True Then
            MessageBox.Show("Welcome!")
            lblUser.ForeColor = Color.FromArgb(56, 142, 60)
            lblPass.ForeColor = Color.FromArgb(56, 142, 60)
        Else
            lblUser.ForeColor = Color.Red
            lblPass.ForeColor = Color.Red
        End If
    End Sub
    Private Sub pnlHeader_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlHeader.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub pnlHeader_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlHeader.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub pnlHeader_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlHeader.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

    Private Sub pbClose_DoubleClick(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub tbUser_GotFocus(sender As Object, e As EventArgs) Handles tbUser.GotFocus
        If flagU = 1 Then
            Exit Sub
        End If
        lblUser.ForeColor = Color.FromArgb(56, 142, 60)
        lblUser_Shdw.Visible = True
        tbUser.Text = ""
        flagU = 1
    End Sub

    Private Sub tbPass_GotFocus(sender As Object, e As EventArgs) Handles tbPass.GotFocus
        If flagP = 1 Then
            Exit Sub
        End If
        lblPass.ForeColor = Color.FromArgb(56, 142, 60)
        lblPass_Shdw.Visible = True
        tbPass.Text = ""
        tbPass.PasswordChar = "*"
        tbPass.Font = New Font("centurygothic", 14, FontStyle.Bold)
        flagP = 1
    End Sub

    Private Sub tbUser_lostfocus(sender As Object, e As EventArgs) Handles tbUser.LostFocus
        lblUser.ForeColor = Color.FromArgb(46, 204, 113)
        lblUser_Shdw.Visible = False
    End Sub
    Private Sub tbPass_lostfocus(sender As Object, e As EventArgs) Handles tbPass.LostFocus
        lblPass.ForeColor = Color.FromArgb(46, 204, 113)
        lblPass_Shdw.Visible = False
    End Sub

    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.ForeColor = Color.FromArgb(97, 97, 97)
    End Sub
    Private Sub Label1_Mouseleave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.FromArgb(117, 117, 117)
    End Sub

    Private Sub Button1_click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class