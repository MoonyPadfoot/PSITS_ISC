Public Class frmAdmin_Transac
    Dim cls As New clsClerk
    Private Sub frmAdmin_Transac_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cls.loadDg()
        Dim cbo As DataGridViewComboBoxColumn
        cbo = Me.DataGridView1.Columns.Item(4)
        cbo.Items.Add("SMALL")
        cbo.Items.Add("MEDIUM")
        cbo.Items.Add("LARGE")
    End Sub

End Class