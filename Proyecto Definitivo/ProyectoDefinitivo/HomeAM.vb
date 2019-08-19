Imports System.Data.SqlClient
Public Class HomeAM
    Dim ConnectionString As String = "Data Source=PABLOPORRAS-PC;Initial Catalog=Inventory;Integrated Security=True"
    Private Sub ButtonInventory_Click(sender As Object, e As EventArgs) Handles ButtonInventory.Click

        InventarioAM.Show()


    End Sub

    Private Sub HomeAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim welcomeName As String

        Dim Connection As New SqlConnection(ConnectionString)

        Dim commandselect As SqlCommand

        Dim SelectQuery As String
        SelectQuery = "Select * FROM Profile WHERE Email ='" & Login.TextBoxEmail.Text & "'"
        commandselect = New SqlCommand(SelectQuery, Connection)
        Connection.Open()

        Dim reader As SqlDataReader
        reader = commandselect.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            welcomeName = reader.GetString(1)

        End If

        LabelNameWelcomeAM.Text = welcomeName

        Connection.Close()
    End Sub

    Private Sub ButtonBill_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ButtonShoppingCart_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Login.TextBoxEmail.Text = ""
        Login.TextBoxPassword.Text = ""
        AgregarProductoBodega.Close()
        Carrito.Close()
        EditarCarrito.Close()
        EditarPerfil.Close()
        EditarProductoTienda.Close()
        Facturas.Close()
        FormularioDeRegistro.Close()
        FormularioEditar.Close()
        InventarioAM.Close()
        InventarioCliente.Close()
        NuevoProductoCliente.Close()
        PedidosCliente.Close()
        Me.Close()

    End Sub
End Class