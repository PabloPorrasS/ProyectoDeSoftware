Imports System.Data.SqlClient
Public Class EditarCarrito

    Dim ConnectionString As String = "Data Source=SP-LA-LAB9-13;Initial Catalog=Inventory;Integrated Security=True"


    Private Sub editar_carrito_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LabelProductName.Text = Carrito.DataGridView1.Item(2, Carrito.rowOfGridview).Value.ToString

        NumericUpDownQuantityClient.Value = Carrito.DataGridView1.Item(6, Carrito.rowOfGridview).Value

        TextBoxPriceNew.Text = Carrito.DataGridView1.Item(7, Carrito.rowOfGridview).Value

    End Sub

    Private Sub ButtonSaveClient_Click(sender As Object, e As EventArgs) Handles ButtonSaveClient.Click

        Dim Name As String
        Dim Quantity As Integer
        Dim Price As Integer

        LabelProductName.Text = Carrito.DataGridView1.Item(2, Carrito.rowOfGridview).Value.ToString

        Quantity = NumericUpDownQuantityClient.Value

        Price = Integer.Parse(TextBoxPriceNew.Text)



        Dim Connection As New SqlConnection(ConnectionString)
        Dim Query As String

        Query = "UPDATE ShoppingCart SET Price=@Price WHERE Id_Profile = '" & InventarioCliente.Id_Profile.Text & "' And Name = '" & LabelProductName.Text & "'"

        Dim Command As SqlCommand
        Command = New SqlCommand(Query, Connection)

        With Command
            .Parameters.AddWithValue("@Price", Price)
        End With

        Connection.Open()
        Command.ExecuteNonQuery()
        Command.Dispose()
        Connection.Close()



        Carrito.DataGridView1.DataSource = Nothing
        Carrito.LoadGridView()
        Me.Close()

    End Sub
End Class
