Imports System.Data.SqlClient
Public Class PedidosCliente

    Dim Name As String
    Dim Brand As String
    Dim Category As String
    Dim Code As Integer
    Dim Quantity As Integer
    Dim Price As Integer
    Dim IdProduct As Integer


    Dim rowOfGridview As Integer 'obtendra el numero de fila del gridview

    Dim ConnectionString As String = "Data Source=PabloPorras-PC;Initial Catalog=Inventory;Integrated Security=True"
    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub PedidosCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'InventoryDataSet4.Products' Puede moverla o quitarla según sea necesario.
        'Me.ProductsTableAdapter1.Fill(Me.InventoryDataSet4.Products)
        'TODO: esta línea de código carga datos en la tabla 'InventoryDataSet3.Products' Puede moverla o quitarla según sea necesario.
        'Me.ProductsTableAdapter.Fill(Me.InventoryDataSet3.Products)

        LoadGridView()


    End Sub


    Sub LoadGridView()

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

        Id_Profile.Text = Id

        Connection.Close()




        Dim ProductsTable As New DataTable

        SelectQuery = "SELECT Id 'Id', Name 'Nombre', Brand 'Marca', Category 'Categoria', Code 'Codigo', Quantity 'Cantidad', Price 'Precio' FROM Products"
        commandselect = New SqlCommand(SelectQuery, Connection)
        Dim dataAdapter As New SqlDataAdapter(commandselect)
        dataAdapter.Fill(ProductsTable)
        DataGridView1.DataSource = ProductsTable

        DataGridView1.Columns(0).Visible = False



    End Sub

    Private Sub ButtonAddToCart_Click(sender As Object, e As EventArgs) Handles ButtonAddToCart.Click

        NuevoProductoCliente.Show()


        'Dim Id As Integer
        'Id = Id_Profile.Text


        'Dim IdProduct As Integer

        'Dim conexion As String
        'conexion = NuevoProductoCliente.TextBoxPriceNew.Text


        'IdProduct = DataGridView1.Item(0, rowOfGridview).Value
        'Name = DataGridView1.Item(1, rowOfGridview).Value.ToString
        'Brand = DataGridView1.Item(2, rowOfGridview).Value.ToString
        'Category = DataGridView1.Item(3, rowOfGridview).Value.ToString
        'Code = DataGridView1.Item(4, rowOfGridview).Value
        'Quantity = NuevoProductoCliente.NumericUpDownQuantityClient.Value
        'Price = Integer.Parse(conexion)
        'Dim Connection As New SqlConnection(ConnectionString)
        'Dim Query As String

        'Query = "INSERT INTO ShoppingCart (Id_Product, Id_Profile, Name, Brand, Category, Code, Quantity, Price) VALUES (@Id_Product, @Id, @Name, @Brand, @Category, @Code, @Quantity, @Price)"

        'Dim Command As SqlCommand
        'Command = New SqlCommand(Query, Connection)

        'With Command

        '    .Parameters.AddWithValue("@Id_Product", IdProduct)
        '    .Parameters.AddWithValue("@Id", Id)
        '    .Parameters.AddWithValue("@Name", Name)
        '    .Parameters.AddWithValue("@Brand", Brand)
        '    .Parameters.AddWithValue("@Category", Category)
        '    .Parameters.AddWithValue("@Code", Code)
        '    .Parameters.AddWithValue("@Quantity", Quantity)
        '    .Parameters.AddWithValue("@Price", Price)

        'End With

        'Connection.Open()
        'Command.ExecuteNonQuery()
        'Command.Dispose()
        'Connection.Close()




    End Sub







    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



        rowOfGridview = DataGridView1.CurrentRow.Index





    End Sub
End Class