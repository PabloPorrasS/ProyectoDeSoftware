Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared




Public Class VisorFactura
    Dim ConnectionString As String = "Data Source=PABLOPORRAS-PC;Initial Catalog=Inventory;Integrated Security=True"
    Public cryRpt As New ReportDocument

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub VisorFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ParametroId As Integer = HomeCliente.LabelId_Profile.Text

        Dim Connection As New SqlConnection(ConnectionString)
        'Dim Command As New SqlCommand




        Dim Command As SqlCommand = New SqlCommand("GeneralSalesReport", Connection)


        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        cryRpt.Load("C:\Users\Pablo Porras\Source\Repos\ProyectoDeSoftware3\Proyecto Definitivo\ProyectoDefinitivo\CrystalReport1.rpt")

        With crConnectionInfo
            .ServerName = "PABLOPORRAS-PC"
            .DatabaseName = "Inventory"
            '.UserID = "sa"
            '.Password = "123456"
        End With

        CrTables = cryRpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next

        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()




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

    Private Sub ButtonDownloadBill_Click(sender As Object, e As EventArgs) Handles ButtonDownloadBill.Click


        'Dim CrExportOptions As ExportOptions
        'Dim CrDiskFileDestinationOptions As New _
        'DiskFileDestinationOptions()
        'Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
        'CrDiskFileDestinationOptions.DiskFileName = "C:\test123.pdf"
        'CrExportOptions = cryRpt.ExportOptions
        'With CrExportOptions
        '    .ExportDestinationType = ExportDestinationType.DiskFile
        '    .ExportFormatType = ExportFormatType.PortableDocFormat
        '    .DestinationOptions = CrDiskFileDestinationOptions
        '    .FormatOptions = CrFormatTypeOptions
        'End With


        'cryRpt.Export(CrExportOptions)

        'cryRpt.Close()
        'cryRpt.Dispose()

        Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportClass ' Report Name 
        CrReport = CrystalReportViewer1.ReportSource

        Try
            CrReport.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\Users\Pablo Porras\Downloads\factura.pdf")

        Catch err As Exception

            MessageBox.Show(err.ToString())

        End Try

        MessageBox.Show("La factura se descargó con éxito")
    End Sub









End Class