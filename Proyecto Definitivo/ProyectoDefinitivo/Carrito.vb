﻿Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Carrito
    Dim ConnectionString As String = "Data Source=PABLOPORRAS-PC;Initial Catalog=Inventory;Integrated Security=True"
    Public rowOfGridview As Integer
    Dim Name As String
    Dim Brand As String
    Dim Category As String
    Dim Code As Integer
    Dim Quantity As Integer
    Dim Price As Integer
    Dim IdProduct As Integer
    Public cryRpt As New ReportDocument

    Private Sub Carrito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadGridView()

    End Sub

    Sub LoadGridView()

        Dim Id_Profile As Integer

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
            Id_Profile = reader.GetInt32(0)

        End If

        PedidosCliente.Id_Profile.Text = Id_Profile

        Connection.Close()

        Dim ProductsTable As New DataTable

        SelectQuery = "SELECT Id_Product 'Id_Product', Id_Profile 'Id_Profile', Name 'Nombre', Brand 'Marca', Category 'Categoria', Code 'Codigo', Quantiy 'Cantidad', Price 'Precio unitario', TotalPrice 'Precio Total' FROM ShoppingCart WHERE Id_Profile ='" & HomeCliente.LabelId_Profile.Text & "'"
        commandselect = New SqlCommand(SelectQuery, Connection)
        Dim dataAdapter As New SqlDataAdapter(commandselect)
        dataAdapter.Fill(ProductsTable)
        DataGridView1.DataSource = ProductsTable

        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = False

    End Sub

    Private Sub ButtonDeleteCart_Click(sender As Object, e As EventArgs) Handles ButtonDeleteCart.Click

        Dim IdProduct As Integer

        IdProduct = DataGridView1.Item(0, rowOfGridview).Value

        Dim Connection As New SqlConnection(ConnectionString)
        Dim commandDelete As New SqlCommand("DELETE FROM ShoppingCart WHERE Id_Product ='" & IdProduct & "'", Connection)

        Connection.Open()
        commandDelete.ExecuteNonQuery()
        Connection.Close()

        DataGridView1.DataSource = Nothing
        LoadGridView()

    End Sub

    Private Sub ButtonInventory_Click(sender As Object, e As EventArgs) Handles ButtonInventory.Click
        InventarioCliente.Show()
        Me.Hide()
        InventarioCliente.LoadGridView()
    End Sub

    Private Sub ButtonBill_Click(sender As Object, e As EventArgs)
        Facturas.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonAddNewProduct_Click(sender As Object, e As EventArgs) Handles ButtonConfirmPurchase.Click

        Dim Id As Integer
        Id = PedidosCliente.Id_Profile.Text
        Dim invoiced As Integer = 0

        Dim IdProduct As Integer
        Dim IdProfile As Integer

        IdProduct = DataGridView1.Item(0, rowOfGridview).Value
        IdProfile = DataGridView1.Item(1, rowOfGridview).Value
        Name = DataGridView1.Item(2, rowOfGridview).Value.ToString
        Brand = DataGridView1.Item(3, rowOfGridview).Value.ToString
        Category = DataGridView1.Item(4, rowOfGridview).Value.ToString
        Code = DataGridView1.Item(5, rowOfGridview).Value
        Quantity = DataGridView1.Item(6, rowOfGridview).Value
        Price = DataGridView1.Item(7, rowOfGridview).Value
        Dim Connection As New SqlConnection(ConnectionString)
        Dim Query As String

        Query = "INSERT INTO ClientProducts (Id_Product, Id_Profile, Name, Brand, Category, Code, Quantity, Price, Invoiced) VALUES (@Id_Product, @Id, @Name, @Brand, @Category, @Code, @Quantity, @Price, @Invoiced)"

        Dim Command As SqlCommand
        Command = New SqlCommand(Query, Connection)

        With Command

            .Parameters.AddWithValue("@Id_Product", IdProduct)
            .Parameters.AddWithValue("@Id", Id)
            .Parameters.AddWithValue("@Name", Name)
            .Parameters.AddWithValue("@Brand", Brand)
            .Parameters.AddWithValue("@Category", Category)
            .Parameters.AddWithValue("@Code", Code)
            .Parameters.AddWithValue("@Quantity", Quantity)
            .Parameters.AddWithValue("@Price", Price)
            .Parameters.AddWithValue("@Invoiced", invoiced)

        End With

        Connection.Open()
        Command.ExecuteNonQuery()
        Command.Dispose()
        Connection.Close()

        Dim NewQuantityProducts As Integer
        Dim QuantityAM As Integer

        Dim commandselect As SqlCommand
        Dim SelectQuery As String
        SelectQuery = "Select * FROM Products WHERE Id ='" & IdProduct & "'"
        commandselect = New SqlCommand(SelectQuery, Connection)
        Connection.Open()

        Dim reader As SqlDataReader
        reader = commandselect.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            QuantityAM = reader.GetInt32(5)

        End If

        NewQuantityProducts = QuantityAM - Quantity

        Connection.Close()

        Query = "UPDATE Products SET Quantity=@NewQuantityProducts WHERE Id = '" & IdProduct & "'"

        Command = New SqlCommand(Query, Connection)

        With Command
            .Parameters.AddWithValue("@NewQuantityProducts", NewQuantityProducts)

        End With

        Connection.Open()
        Command.ExecuteNonQuery()
        Command.Dispose()
        Connection.Close()

        Query = "DELETE FROM ShoppingCart WHERE Id_Product ='" & IdProduct & "'"
        Command = New SqlCommand(Query, Connection)
        Connection.Open()
        Command.ExecuteNonQuery()
        Command.Dispose()
        Connection.Close()

        DataGridView1.DataSource = Nothing
        LoadGridView()

        MessageBox.Show("El Producto " + Name + " fue agregado al inventario")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        rowOfGridview = DataGridView1.CurrentRow.Index
    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click
        EditarCarrito.Show()
    End Sub

    Private Sub ButtonGenerateBill_Click(sender As Object, e As EventArgs) Handles ButtonGenerateBill.Click

        'Dim ParametroId As Integer = HomeCliente.LabelId_Profile.Text

        'Dim Connection As SqlConnection = New SqlConnection(ConnectionString)

        'Dim Command As SqlCommand = New SqlCommand("GeneralSalesReport", Connection)


        'Dim crtableLogoninfos As New TableLogOnInfos
        'Dim crtableLogoninfo As New TableLogOnInfo
        'Dim crConnectionInfo As New ConnectionInfo
        'Dim CrTables As Tables
        'Dim CrTable As Table

        'cryRpt.Load("C:\Users\Pablo Porras\Source\Repos\ProyectoDeSoftware3\Proyecto Definitivo\ProyectoDefinitivo\CrystalReport1.rpt")

        'With crConnectionInfo
        '    .ServerName = "PABLOPORRAS-PC"
        '    .DatabaseName = "Inventory"
        '    '.UserID = "sa"
        '    '.Password = "123456"
        'End With

        'CrTables = cryRpt.Database.Tables
        'For Each CrTable In CrTables
        '    crtableLogoninfo = CrTable.LogOnInfo
        '    crtableLogoninfo.ConnectionInfo = crConnectionInfo
        '    CrTable.ApplyLogOnInfo(crtableLogoninfo)
        'Next

        'VisorFactura.CrystalReportViewer1.ReportSource = cryRpt
        'VisorFactura.CrystalReportViewer1.Refresh()

        VisorFactura.Show()



    End Sub

    Private Sub ButtonOrders_Click(sender As Object, e As EventArgs) Handles ButtonOrders.Click
        PedidosCliente.Show()
        Me.Hide()
        PedidosCliente.LoadGridView()

    End Sub

    Private Sub ButtonShoppingCart_Click(sender As Object, e As EventArgs) Handles ButtonShoppingCart.Click

    End Sub
End Class