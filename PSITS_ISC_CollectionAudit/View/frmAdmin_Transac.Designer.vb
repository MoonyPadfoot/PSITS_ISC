<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin_Transac
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgFee = New System.Windows.Forms.DataGridView()
        Me.dgStudent = New System.Windows.Forms.DataGridView()
        Me.cboStud_Srch = New System.Windows.Forms.ComboBox()
        Me.tbStud_Srch = New System.Windows.Forms.TextBox()
        CType(Me.dgFee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(734, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgFee
        '
        Me.dgFee.AllowUserToAddRows = False
        Me.dgFee.AllowUserToDeleteRows = False
        Me.dgFee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFee.Location = New System.Drawing.Point(329, 69)
        Me.dgFee.Name = "dgFee"
        Me.dgFee.ReadOnly = True
        Me.dgFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgFee.Size = New System.Drawing.Size(390, 230)
        Me.dgFee.TabIndex = 2
        '
        'dgStudent
        '
        Me.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgStudent.Location = New System.Drawing.Point(150, 69)
        Me.dgStudent.Name = "dgStudent"
        Me.dgStudent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgStudent.Size = New System.Drawing.Size(142, 230)
        Me.dgStudent.TabIndex = 3
        '
        'cboStud_Srch
        '
        Me.cboStud_Srch.FormattingEnabled = True
        Me.cboStud_Srch.Location = New System.Drawing.Point(25, 43)
        Me.cboStud_Srch.Name = "cboStud_Srch"
        Me.cboStud_Srch.Size = New System.Drawing.Size(121, 21)
        Me.cboStud_Srch.TabIndex = 4
        Me.cboStud_Srch.Text = "-SEARCH BY-"
        '
        'tbStud_Srch
        '
        Me.tbStud_Srch.Location = New System.Drawing.Point(152, 44)
        Me.tbStud_Srch.Name = "tbStud_Srch"
        Me.tbStud_Srch.Size = New System.Drawing.Size(89, 20)
        Me.tbStud_Srch.TabIndex = 5
        '
        'frmAdmin_Transac
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(871, 400)
        Me.Controls.Add(Me.tbStud_Srch)
        Me.Controls.Add(Me.cboStud_Srch)
        Me.Controls.Add(Me.dgStudent)
        Me.Controls.Add(Me.dgFee)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmAdmin_Transac"
        Me.Text = "frmClerk_"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgFee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents dgFee As DataGridView
    Friend WithEvents dgStudent As DataGridView
    Friend WithEvents cboStud_Srch As ComboBox
    Friend WithEvents tbStud_Srch As TextBox
End Class
