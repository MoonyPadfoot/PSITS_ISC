Module connection
    Public con As New OleDb.OleDbConnection
    Public comm As New OleDb.OleDbCommand
    Public sql As String
    Public da As OleDb.OleDbDataAdapter
    Public reader As OleDb.OleDbDataReader
    Public Sub openCon()
        con.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0;data source=F:\PSITS_DB\dbPSITS_ISC.mde" '"Provider=Microsoft.Jet.Oledb.4.0;data source=C:\Users\tabah\Documents\Chicken\db_Chicken.mdb"
        con.Open()
    End Sub
    Public Sub closeCon()
        con.Close()
        con.Dispose()
    End Sub
End Module
