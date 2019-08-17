Imports System.Data.SqlClient
Public Class NuevoProductoCliente
    Dim ConnectionString As String = "Data Source=PABLOPORRAS-PC;Initial Catalog=Inventory;Integrated Security=True"
    Dim Name As String
    Dim Brand As String
    Dim Category As String
    Dim Code As Integer
    Dim Quantity As Integer
    Dim Price As Integer
    Dim IdProduct As Integer
    Dim TotalPrice As Integer




    Private Sub NuevoProductoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Connection As New SqlConnection(ConnectionString)
        Dim Command As New SqlCommand
        Dim DataAdapter As New SqlDataAdapter
        Dim DataTable As DataTable



    End Sub

    Private Sub ButtonSaveClient_Click(sender As Object, e As EventArgs) Handles ButtonSaveClient.Click

        Dim Id As Integer
        Id = PedidosCliente.Id_Profile.Text

        Dim rowOfGridView As Integer
        rowOfGridView = PedidosCliente.DataGridView1.CurrentRow.Index




        Dim IdProduct As Integer



        IdProduct = PedidosCliente.DataGridView1.Item(0, rowOfGridView).Value
        Name = PedidosCliente.DataGridView1.Item(1, rowOfGridview).Value.ToString
        Brand = PedidosCliente.DataGridView1.Item(2, rowOfGridview).Value.ToString
        Category = PedidosCliente.DataGridView1.Item(3, rowOfGridview).Value.ToString
        Code = PedidosCliente.DataGridView1.Item(4, rowOfGridview).Value
        Quantity = NumericUpDownQuantityClient.Value
        Price = Integer.Parse(PedidosCliente.DataGridView1.Item(6, rowOfGridView).Value)

        Dim Connection As New SqlConnection(ConnectionString)
        Dim Query As String

        TotalPrice = Quantity * Price

        Query = "INSERT INTO ShoppingCart (Id_Product, Id_Profile, Name, Brand, Category, Code, Quantiy, Price) VALUES (@Id_Product, @Id, @Name, @Brand, @Category, @Code, @Quantity, @Price)"

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


        End With

        Connection.Open()
        Command.ExecuteNonQuery()
        Command.Dispose()
        Connection.Close()

        PedidosCliente.DataGridView1.DataSource = Nothing
        PedidosCliente.LoadGridView()


        Me.Close()


    End Sub
End Class