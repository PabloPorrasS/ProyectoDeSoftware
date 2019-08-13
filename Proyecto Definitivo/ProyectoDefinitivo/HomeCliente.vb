Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class HomeCliente
    Dim ConnectionString As String = "Data Source=SP-LA-LAB9-13;Initial Catalog=Inventory;Integrated Security=True"

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim Id As Integer


        Dim Connection As New SqlConnection(ConnectionString)


        Dim commandselect As SqlCommand


        Dim SelectQuery As String
        SelectQuery = "Select Id FROM Profile WHERE Email ='" & Login.TextBoxEmail.Text & "'"
        commandselect = New SqlCommand(SelectQuery, Connection)
        Connection.Open()

        Dim reader As SqlDataReader
        reader = commandselect.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Id = reader.GetInt32(0)

        End If

        LabelId_Profile.Text = Id

        Connection.Close()


        SelectQuery = "Select * FROM Profile WHERE Email = '" & Login.TextBoxEmail.Text & "'"
        commandselect = New SqlCommand(SelectQuery, Connection)


        Connection.Open()
        reader = commandselect.ExecuteReader


        While reader.HasRows ' Has rows es mientras tenga columnas
            reader.Read()

            LabelTypeOfUser.Text = reader.GetInt32(6).ToString

            Exit While

        End While


    End Sub

    Private Sub ButtonMyInventory_Click_1(sender As Object, e As EventArgs) Handles ButtonMyInventory.Click
        InventarioCliente.Show()

    End Sub

    Private Sub ButtonOrders_Click(sender As Object, e As EventArgs) Handles ButtonOrders.Click
        PedidosCliente.Show()
    End Sub

    Private Sub ButtonEditProfile_Click(sender As Object, e As EventArgs) Handles ButtonEditProfile.Click
        EditarPerfil.Show()

    End Sub

    Private Sub ButtonShoppingCart_Click(sender As Object, e As EventArgs) Handles ButtonShoppingCart.Click
        Carrito.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim cryRpt As New ReportDocument
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        cryRpt.Load("C:\Users\Laboratorio\Source\Repos\PabloPorrasS\ProyectoDeSoftware\Proyecto Definitivo\ProyectoDefinitivo\CrystalReport1.rpt")

        With crConnectionInfo
            .ServerName = "SP-LA-LAB6-10"
            .DatabaseName = "Inventory"
            .UserID = "sa"
            .Password = "123456"
        End With

        CrTables = cryRpt.Database.Tables
        For Each CrTable In CrTables
            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)
        Next

        CrystalReportViewer1.ReportSource = cryRpt
        CrystalReportViewer1.Refresh()
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load




    End Sub

    Private Sub ButtonDelivery_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonBill_Click(sender As Object, e As EventArgs) Handles ButtonBill.Click
        Facturas.Show()

    End Sub
End Class
