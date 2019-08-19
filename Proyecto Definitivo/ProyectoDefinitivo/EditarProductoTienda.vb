Imports System.Data.SqlClient
Public Class EditarProductoTienda
    Dim ConnectionString As String = "Data Source=SP-LA-LAB9-14;Initial Catalog=Inventory;Integrated Security=True"


    Private Sub EditarProductoTienda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelProductName.Text = InventarioCliente.DataGridView1.Item(2, InventarioCliente.rowOfGridview).Value.ToString
        TextBoxPriceNew.Text = InventarioCliente.DataGridView1.Item(7, InventarioCliente.rowOfGridview).Value


    End Sub

    Private Sub ButtonSaveClient_Click(sender As Object, e As EventArgs) Handles ButtonSaveClient.Click

        Dim Name As String
        Dim Price As Integer

        LabelProductName.Text = InventarioCliente.DataGridView1.Item(2, InventarioCliente.rowOfGridview).Value.ToString

        Price = Integer.Parse(TextBoxPriceNew.Text)



        Dim Connection As New SqlConnection(ConnectionString)
        Dim Query As String

        Query = "UPDATE ClientProducts SET Price=@Price WHERE Id_Profile = '" & InventarioCliente.Id_Profile.Text & "' And Name = '" & LabelProductName.Text & "'"

        Dim Command As SqlCommand
        Command = New SqlCommand(Query, Connection)

        With Command
            .Parameters.AddWithValue("@Price", Price)
        End With

        Connection.Open()
        Command.ExecuteNonQuery()
        Command.Dispose()
        Connection.Close()



        InventarioCliente.DataGridView1.DataSource = Nothing
        InventarioCliente.LoadGridView()
        Me.Close()


    End Sub

    Private Sub TextBoxPriceNew_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPriceNew.KeyPress
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