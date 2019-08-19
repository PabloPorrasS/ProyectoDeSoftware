Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class VisorFactura
    Dim ConnectionString As String = "Data Source=PABLOPORRAS-PC;Initial Catalog=Inventory;Integrated Security=True"
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub VisorFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ParametroId As Integer = HomeCliente.LabelId_Profile.Text

        Dim Connection As New SqlConnection(ConnectionString)
        Dim Command As New SqlCommand

        Connection.Open()
        Command.Connection = Connection
        Command.Parameters.Clear()
        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "GeneralSalesReport"
        Command.Parameters.AddWithValue("@Id", ParametroId)
        Command.ExecuteNonQuery()
        Connection.Close()

        Dim DataSet As New DataSet
        Dim DataAdapter As New SqlDataAdapter


        Connection.Open()
        Command.Connection = Connection
        Command.CommandType = CommandType.StoredProcedure
        Command.CommandText = "GeneralSalesReport"
        Command.ExecuteNonQuery()

        DataAdapter.SelectCommand = Command
        DataAdapter.Fill(DataSet, "GeneralSalesReport")

        Dim Rpt As New CrystalReport1
        Rpt.SetDataSource(DataSet)
        CrystalReportViewer1.ReportSource = Rpt

        Connection.Close()
        Dim Query As String
        Dim invoiced As Integer = 1

        Query = "UPDATE ClientProducts SET Invoiced=@Invoiced WHERE Id_Profile = '" & HomeCliente.LabelId_Profile.Text & "'"

        Command = New SqlCommand(Query, Connection)

        With Command
            .Parameters.AddWithValue("@Invoiced", Invoiced)

        End With

        Connection.Open()
        Command.ExecuteNonQuery()
        Command.Dispose()
        Connection.Close()




    End Sub
End Class