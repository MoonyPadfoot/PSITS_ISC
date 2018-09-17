Public Class clsClerk
    Public Sub loadDg_Fee()
        Try
            openCon()
            sql = "SELECT * FROM tblFee"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim ds As New DataSet
            ds.Clear()

            da.Fill(ds)
            frmAdmin_Transac.dgFee.DataSource = ds.Tables(0)

            With frmAdmin_Transac.dgFee
                .Columns(0).HeaderText = "FEE ID"
                .Columns(1).HeaderText = "DESCRIPTION"
                .Columns(2).HeaderText = "FEE"
            End With
        Catch ex As Exception
            MessageBox.Show("Nothing to Show", "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            closeCon()
        End Try
    End Sub
    Public Sub loadDG_Student()
        Try
            openCon()
            sql = "SELECT stud_ID FROM tblStudent"
            Dim da As New OleDb.OleDbDataAdapter(sql, con)
            Dim ds As New DataSet
            ds.Clear()

            da.Fill(ds)
            frmAdmin_Transac.dgStudent.DataSource = ds.Tables(0)

            With frmAdmin_Transac.dgStudent
                .Columns(0).HeaderText = "FEE ID"
            End With
        Catch ex As Exception
            MessageBox.Show("Nothing to Show", "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            closeCon()
        End Try
    End Sub
End Class
