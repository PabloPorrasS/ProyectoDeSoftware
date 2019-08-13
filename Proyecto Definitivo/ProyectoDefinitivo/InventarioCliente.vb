Imports System.Data.SqlClient
Public Class InventarioCliente
    Public rowOfGridview As Integer

    Dim ConnectionString As String = "Data Source=SP-LA-LAB9-13;Initial Catalog=Inventory;Integrated Security=True"



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

        Dim ClientProducts As New DataTable

        SelectQuery = "SELECT  Id_Profile 'Id_Profile', Id_Product 'Id_Product', Name 'Nombre', Brand 'Marca', Category 'Categoria', Code 'Codigo', Quantity 'Cantidad', Price 'Precio' FROM ClientProducts WHERE Id_Profile ='" & Id & "'"
        commandselect = New SqlCommand(SelectQuery, Connection)
        Dim dataAdapter As New SqlDataAdapter(commandselect)
        dataAdapter.Fill(ClientProducts)
        DataGridView1.DataSource = ClientProducts

        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = False

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False



    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        rowOfGridview = DataGridView1.CurrentRow.Index

    End Sub


    Private Sub ButtonDeleteProduct_Click(sender As Object, e As EventArgs) Handles ButtonDeleteProduct.Click

        Dim IdProduct As Integer

        IdProduct = DataGridView1.Item(1, rowOfGridview).Value

        Dim Connection As New SqlConnection(ConnectionString)
        Dim commandDelete As New SqlCommand("DELETE FROM ClientProducts WHERE Id_Product ='" & IdProduct & "'", Connection)

        Connection.Open()
        commandDelete.ExecuteNonQuery()
        Connection.Close()
        Me.Close()

        'DataGridView1.DataSource = Nothing
        LoadGridView()



    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub

    Private Sub ButtonBill_Click(sender As Object, e As EventArgs) Handles ButtonBill.Click
        Facturas.Show()
        Me.Close()
    End Sub

    Private Sub ButtonOrders_Click(sender As Object, e As EventArgs) Handles ButtonOrders.Click
        PedidosCliente.Show()
        Me.Close()
    End Sub

    Private Sub ButtonShoppingCart_Click(sender As Object, e As EventArgs) Handles ButtonShoppingCart.Click
        Carrito.Show()
        Me.Hide()

    End Sub

    Private Sub InventarioCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadGridView()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub ButtonEdit_Click(sender As Object, e As EventArgs) Handles ButtonEdit.Click

        EditarProductoTienda.Show()


    End Sub

    Private Sub ButtonMyInventory_Click(sender As Object, e As EventArgs) Handles ButtonMyInventory.Click

    End Sub
End Class

