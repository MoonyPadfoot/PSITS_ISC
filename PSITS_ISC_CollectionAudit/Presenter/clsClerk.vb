Public Class clsClerk
    Public Sub loadDg()
        Try
            openCon()
            sql = "SELECT * FROM tblFee_Log"
            comm = New OleDb.OleDbCommand(sql, con)
            Dim dt As New DataTable

            dt.Load(comm.ExecuteReader())
            reader = comm.ExecuteReader()

            Dim x As Integer = 0

            While reader.Read
                Dim feeID = dt.Rows(x).Item(0)
                Dim desc = dt.Rows(x).Item(1)
                Dim amount = Val(dt.Rows(x).Item(2))
                frmAdmin_Transac.DataGridView1.Rows.Add(New String() {feeID, desc, Format(amount, "P#,##0.00")})
                x += 1
            End While
        Catch ex As Exception
            MessageBox.Show("Nothing to Show", "DATA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            closeCon()
        End Try
    End Sub
End Class
