Imports System.Data.SqlClient
Public Class PedidosCliente

    Dim Name As String
    Dim Brand As String
    Dim Category As String
    Dim Code As Integer
    Dim Quantity As Integer
    Dim Price As Integer
    Dim IdProduct As Integer


    Public rowOfGridview As Integer

    Dim ConnectionString As String = "Data Source=SP-LA-LAB6-10;Initial Catalog=Inventory;User ID=sa;Password=123456"
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



    End Sub







    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick



        rowOfGridview = DataGridView1.CurrentRow.Index





    End Sub
End Class