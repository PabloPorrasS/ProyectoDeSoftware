Imports System.Data.SqlClient
Public Class InventarioAM
    Dim ConnectionString As String = "Data Source=PabloPorras-PC;Initial Catalog=Inventory;Integrated Security=True"

    Public rowOfGridView As Integer

    Private Sub ButtonAddNewProduct_Click(sender As Object, e As EventArgs) Handles ButtonAddNewProduct.Click
        AgregarProductoBodega.Show()
    End Sub

    Private Sub InventarioAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'InventoryDataSet2.Products' Puede moverla o quitarla según sea necesario.
        'Me.ProductsTableAdapter.Fill(Me.InventoryDataSet2.Products)

        LoadGridView2()



    End Sub

    Sub LoadGridView2()


        Dim Id As Integer


        Dim Connection As New SqlConnection(ConnectionString)

        Dim commandselect As SqlCommand

        Dim SelectQuery As String

        Dim ProductsTable As New DataTable

        SelectQuery = "SELECT Id 'Id', Name 'Nombre', Brand 'Marca', Category 'Categoria', Code 'Codigo', Quantity 'Cantidad', Price 'Precio' FROM Products"
        commandselect = New SqlCommand(SelectQuery, Connection)
        Dim dataAdapter As New SqlDataAdapter(commandselect)
        dataAdapter.Fill(ProductsTable)


        DataGridView2.DataSource = ProductsTable

        DataGridView2.Columns(0).Visible = False



    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        FormularioEditar.Show()

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

        SelectQuery = "SELECT Id 'Id', Name 'Nombre', Brand 'Marca', Category 'Categoria', Code 'Codigo', Quantity 'Cantidad', Price 'Precio' FROM Products"
        commandselect = New SqlCommand(SelectQuery, Connection)
        Dim dataAdapter As New SqlDataAdapter(commandselect)
        dataAdapter.Fill(ProductsTable)
        DataGridView2.DataSource = ProductsTable

        DataGridView2.Columns(0).Visible = False



    End Sub



    Private Sub Splitter1_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles Splitter1.SplitterMoved

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

        rowOfGridView = DataGridView2.CurrentRow.Index



    End Sub

    Private Sub ButtonDeleteProduct_Click(sender As Object, e As EventArgs) Handles ButtonDeleteProduct.Click

        Dim IdProduct As Integer

        IdProduct = DataGridView2.Item(0, rowOfGridView).Value

        Dim Connection As New SqlConnection(ConnectionString)
        Dim commandDelete As New SqlCommand("DELETE FROM Products WHERE Id ='" & IdProduct & "'", Connection)

        Connection.Open()
        commandDelete.ExecuteNonQuery()
        Connection.Close()

        DataGridView2.DataSource = Nothing
        LoadGridView()

    End Sub
End Class