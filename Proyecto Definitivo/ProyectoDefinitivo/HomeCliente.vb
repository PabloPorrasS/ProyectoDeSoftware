Imports System.Data.SqlClient
Public Class HomeCliente
    Dim ConnectionString As String = "Data Source=PabloPorras-PC;Initial Catalog=Inventory;Integrated Security=True"
    'Private Sub ButtonInventory_Click(sender As Object, e As EventArgs) Handles ButtonInventory.Click

    '    If LabelTypeOfUser.Text = 1 Then
    '        InventarioCliente.Show()

    '    End If

    '    If LabelTypeOfUser.Text = 2 Then
    '        InventarioAM.Show()

    '    End If


    'End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim Connection As New SqlConnection(ConnectionString)
        Dim SelectQuery As String
        Dim commandSelect As New SqlCommand
        Dim Reader As SqlDataReader


        SelectQuery = "Select * FROM Profile WHERE Email = '" & Login.TextBoxEmail.Text & "'"
        commandSelect = New SqlCommand(SelectQuery, Connection)


        Connection.Open()
        Reader = commandSelect.ExecuteReader


        While Reader.HasRows ' Has rows es mientras tenga columnas
            Reader.Read()

            LabelTypeOfUser.Text = Reader.GetInt32(6).ToString

            Exit While

        End While


    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub


    Private Sub ButtonMyInventory_Click_1(sender As Object, e As EventArgs) Handles ButtonMyInventory.Click
        InventarioCliente.Show()

    End Sub

    Private Sub ButtonOrders_Click(sender As Object, e As EventArgs) Handles ButtonOrders.Click
        PedidosCliente.show
    End Sub

    Private Sub ButtonEditProfile_Click(sender As Object, e As EventArgs) Handles ButtonEditProfile.Click
        EditarPerfil.Show()

    End Sub

    Private Sub ButtonShoppingCart_Click(sender As Object, e As EventArgs) Handles ButtonShoppingCart.Click
        Carrito.Show()
    End Sub
End Class
