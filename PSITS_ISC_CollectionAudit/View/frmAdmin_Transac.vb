Public Class frmAdmin_Transac
    Dim cls As New clsClerk
    Private Sub frmAdmin_Transac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls.loadDG_Student()
        cls.loadDg_Fee()
        With cboStud_Srch
            .Items.Add("STUDENT ID")
            .Items.Add("FAMILY NAME")
            .Items.Add("GIVEN NAME")
            .Items.Add("EXTENSION NAME")
            .Items.Add("MIDDLE INITIAL")
            .Items.Add("COURSE & YEAR")
        End With
        '   Dim cbo As DataGridViewComboBoxColumn
        '       cbo = Me.DataGridView1.Columns.Item(4)
        '      cbo.Items.Add("SMALL")
        '     cbo.Items.Add("MEDIUM")
        '    cbo.Items.Add("LARGE")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class