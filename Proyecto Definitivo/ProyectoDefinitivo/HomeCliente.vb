Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class HomeCliente
    Dim ConnectionString As String = "Data Source=PABLOPORRAS-PC;Initial Catalog=Inventory;Integrated Security=True"

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


    Private Sub ButtonDelivery_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonBill_Click(sender As Object, e As EventArgs)
        Facturas.Show()

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel2.Paint

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

        LabelNameWelcome.Text = welcomeName

        Connection.Close()
    End Sub

    Private Sub ButtonEditProfile_Click_1(sender As Object, e As EventArgs) 
        EditarPerfil.Show()
    End Sub

    Private Sub ButtonShoppingCart_Click_1(sender As Object, e As EventArgs) Handles ButtonShoppingCart.Click
        Carrito.Show()
        Carrito.LoadGridView()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Carrito.Show()
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
        NuevoProductoCliente.Close()
        Me.Close()

    End Sub
End Class
