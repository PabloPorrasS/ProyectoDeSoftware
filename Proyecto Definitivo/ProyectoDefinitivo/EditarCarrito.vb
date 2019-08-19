Imports System.Data.SqlClient
Public Class EditarCarrito

    Dim ConnectionString As String = "Data Source=PABLOPORRAS-PC;Initial Catalog=Inventory;Integrated Security=True"


    Private Sub editar_carrito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelProductName.Text = Carrito.DataGridView1.Item(2, Carrito.rowOfGridview).Value.ToString

        NumericUpDownQuantityClient.Value = Carrito.DataGridView1.Item(6, Carrito.rowOfGridview).Value


    End Sub

    Private Sub ButtonSaveClient_Click(sender As Object, e As EventArgs) Handles ButtonSaveClient.Click

        Dim Name As String
        Dim Quantity As Integer
        Dim TotalPrice As Integer
        Dim Price As Integer

        LabelProductName.Text = Carrito.DataGridView1.Item(2, Carrito.rowOfGridview).Value.ToString

        Quantity = NumericUpDownQuantityClient.Value

         Dim commandselect As SqlCommand
        Dim Connection As New SqlConnection(ConnectionString)


        Dim SelectQuery As String
        SelectQuery = "Select Price FROM Products WHERE Name ='" & LabelProductName.Text & "'"
        commandselect = New SqlCommand(SelectQuery, Connection)
        Connection.Open()

        Dim reader As SqlDataReader
        reader = commandselect.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Price = reader.GetInt32(0)

        End If


        TotalPrice = Quantity * Price

        Connection.Close()

        Dim Query As String

        Query = "UPDATE ShoppingCart SET Quantiy=@Quantity, TotalPrice=@TotalPrice WHERE Id_Profile = '" & HomeCliente.LabelId_Profile.Text & "' And Name = '" & LabelProductName.Text & "'"

        Dim Command As SqlCommand
        Command = New SqlCommand(Query, Connection)

        With Command
            .Parameters.AddWithValue("@Quantity", Quantity)
            .Parameters.AddWithValue("@TotalPrice", TotalPrice)

        End With

        Connection.Open()
        Command.ExecuteNonQuery()
        Command.Dispose()
        Connection.Close()





        Carrito.DataGridView1.DataSource = Nothing
        Carrito.LoadGridView()
        Me.Close()

    End Sub

    Private Sub NumericUpDownQuantityClient_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownQuantityClient.ValueChanged

    End Sub

    Private Sub NumericUpDownQuantityClient_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NumericUpDownQuantityClient.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub
End Class
