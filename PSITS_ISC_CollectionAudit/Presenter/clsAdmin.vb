Public Class clsAdmin
    Public Property User
    Public Property Pass
    Public Function Auth()
        Try
            openCon()
            sql = "SELECT * FROM tblAdmin WHERE username = @0 AND  password = @1 " '@0 AND password = @1 "
            comm = New OleDb.OleDbCommand(sql, con)
            Dim dt As New DataTable

            comm.Parameters.AddWithValue("@0", Me.User)
            comm.Parameters.AddWithValue("@1", Me.Pass)

            dt.Load(comm.ExecuteReader())
            reader = comm.ExecuteReader()

            Dim checkUser As String
            Dim checkPass As String
            checkUser = dt.Rows(0).Item(0)
            checkPass = dt.Rows(0).Item(1)

            If String.Compare(checkUser, User) = 0 And String.Compare(checkPass, Pass) = 0 Then
                closeCon()
                Return True
            End If
            closeCon()
            Return False
        Catch
            Return False
            closeCon()
        End Try
    End Function
End Class
