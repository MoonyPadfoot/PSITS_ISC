<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClerk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClerk))
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.pnlPass = New System.Windows.Forms.Panel()
        Me.pbPass = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.pnlUser = New System.Windows.Forms.Panel()
        Me.pbUser = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUser_Shdw = New System.Windows.Forms.Label()
        Me.lblPass_Shdw = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlPass.SuspendLayout()
        CType(Me.pbPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlUser.SuspendLayout()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbPass
        '
        Me.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPass.Dock = System.Windows.Forms.DockStyle.Right
        Me.tbPass.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.tbPass.Location = New System.Drawing.Point(34, 0)
        Me.tbPass.Multiline = True
        Me.tbPass.Name = "tbPass"
        Me.tbPass.ShortcutsEnabled = False
        Me.tbPass.Size = New System.Drawing.Size(93, 27)
        Me.tbPass.TabIndex = 1
        Me.tbPass.Text = "password"
        '
        'pnlPass
        '
        Me.pnlPass.Controls.Add(Me.pbPass)
        Me.pnlPass.Controls.Add(Me.tbPass)
        Me.pnlPass.Location = New System.Drawing.Point(55, 274)
        Me.pnlPass.Name = "pnlPass"
        Me.pnlPass.Size = New System.Drawing.Size(127, 27)
        Me.pnlPass.TabIndex = 17
        '
        'pbPass
        '
        Me.pbPass.BackgroundImage = Global.PSITS_ISC_CollectionAudit.My.Resources.Resources.icons8_lock_24
        Me.pbPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbPass.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbPass.Location = New System.Drawing.Point(0, 0)
        Me.pbPass.Name = "pbPass"
        Me.pbPass.Size = New System.Drawing.Size(28, 27)
        Me.pbPass.TabIndex = 14
        Me.pbPass.TabStop = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(54, 330)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(132, 43)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(55, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "forgot your password?"
        '
        'tbUser
        '
        Me.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbUser.Dock = System.Windows.Forms.DockStyle.Right
        Me.tbUser.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.tbUser.Location = New System.Drawing.Point(34, 0)
        Me.tbUser.Multiline = True
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(93, 27)
        Me.tbUser.TabIndex = 0
        Me.tbUser.Text = "username"
        '
        'pnlUser
        '
        Me.pnlUser.Controls.Add(Me.pbUser)
        Me.pnlUser.Controls.Add(Me.tbUser)
        Me.pnlUser.Location = New System.Drawing.Point(55, 220)
        Me.pnlUser.Name = "pnlUser"
        Me.pnlUser.Size = New System.Drawing.Size(127, 27)
        Me.pnlUser.TabIndex = 16
        '
        'pbUser
        '
        Me.pbUser.BackgroundImage = Global.PSITS_ISC_CollectionAudit.My.Resources.Resources.icons8_account_24
        Me.pbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pbUser.Dock = System.Windows.Forms.DockStyle.Left
        Me.pbUser.Location = New System.Drawing.Point(0, 0)
        Me.pbUser.Name = "pbUser"
        Me.pbUser.Size = New System.Drawing.Size(28, 27)
        Me.pbUser.TabIndex = 13
        Me.pbUser.TabStop = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblUser.Location = New System.Drawing.Point(52, 235)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(133, 13)
        Me.lblUser.TabIndex = 21
        Me.lblUser.Text = "_____________________"
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.lblPass.Location = New System.Drawing.Point(53, 289)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(133, 13)
        Me.lblPass.TabIndex = 22
        Me.lblPass.Text = "_____________________"
        '
        'lblUser_Shdw
        '
        Me.lblUser_Shdw.AutoSize = True
        Me.lblUser_Shdw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblUser_Shdw.Location = New System.Drawing.Point(52, 236)
        Me.lblUser_Shdw.Name = "lblUser_Shdw"
        Me.lblUser_Shdw.Size = New System.Drawing.Size(133, 13)
        Me.lblUser_Shdw.TabIndex = 23
        Me.lblUser_Shdw.Text = "_____________________"
        Me.lblUser_Shdw.Visible = False
        '
        'lblPass_Shdw
        '
        Me.lblPass_Shdw.AutoSize = True
        Me.lblPass_Shdw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblPass_Shdw.Location = New System.Drawing.Point(53, 290)
        Me.lblPass_Shdw.Name = "lblPass_Shdw"
        Me.lblPass_Shdw.Size = New System.Drawing.Size(133, 13)
        Me.lblPass_Shdw.TabIndex = 24
        Me.lblPass_Shdw.Text = "_____________________"
        Me.lblPass_Shdw.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(88, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "CLERK"
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.Button1)
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(233, 430)
        Me.pnlHeader.TabIndex = 28
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(203, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.PSITS_ISC_CollectionAudit.My.Resources.Resources.if_Rounded___High_Ultra_Colour10___Circuit_Board_2250032
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(54, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 140)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'frmClerk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(233, 429)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pnlPass)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnlUser)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.lblUser_Shdw)
        Me.Controls.Add(Me.lblPass_Shdw)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClerk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmClerk"
        Me.pnlPass.ResumeLayout(False)
        Me.pnlPass.PerformLayout()
        CType(Me.pbPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlUser.ResumeLayout(False)
        Me.pnlUser.PerformLayout()
        CType(Me.pbUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbPass As TextBox
    Friend WithEvents pnlPass As Panel
    Friend WithEvents pbPass As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbUser As TextBox
    Friend WithEvents pnlUser As Panel
    Friend WithEvents pbUser As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents lblPass As Label
    Friend WithEvents lblUser_Shdw As Label
    Friend WithEvents lblPass_Shdw As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents pnlHeader As Panel
End Class
