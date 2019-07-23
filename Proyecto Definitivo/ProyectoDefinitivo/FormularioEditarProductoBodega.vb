﻿Imports System.Data.SqlClient
Public Class FormularioEditar

    Dim ConnectionString As String = "Data Source=PabloPorras-PC;Initial Catalog=Inventory;Integrated Security=True"

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Dim Name As String
        Dim Brand As String
        Dim Category As String
        Dim Code As Integer
        Dim Quantity As Integer
        Dim Price As Integer



        'le asignamos valor a las variables





        Name = TextBoxName.Text
        Brand = TextBoxBrand.Text
        Category = TextBoxCategory.Text
        Quantity = Integer.Parse(NumericUpDownQuantity.Value)
        Code = Integer.Parse(TextBoxCode.Text)
        Price = Integer.Parse(TextBoxPrice.Text)



        Dim Connection As New SqlConnection(ConnectionString)
        Dim Query As String

        Query = "UPDATE Products SET Name=@Name, Brand=@Brand, Category=@Category, Code=@Code, Quantity=@Quantity, Price=@Price WHERE Id = '" & LabelIdProduct.Text & "'"

        Dim Command As SqlCommand
        Command = New SqlCommand(Query, Connection)

        With Command

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


        InventarioAM.DataGridView2.DataSource = Nothing
        InventarioAM.LoadGridView()

        Me.Close()



    End Sub

    Private Sub FormularioEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LabelIdProduct.Text = InventarioAM.DataGridView2.Item(0, InventarioAM.rowOfGridView).Value.ToString

        TextBoxName.Text = InventarioAM.DataGridView2.Item(1, InventarioAM.rowOfGridView).Value.ToString

        TextBoxBrand.Text = InventarioAM.DataGridView2.Item(2, InventarioAM.rowOfGridView).Value.ToString

        TextBoxCategory.Text = InventarioAM.DataGridView2.Item(3, InventarioAM.rowOfGridView).Value.ToString

        TextBoxCode.Text = InventarioAM.DataGridView2.Item(4, InventarioAM.rowOfGridView).Value.ToString

        NumericUpDownQuantity.Value = InventarioAM.DataGridView2.Item(5, InventarioAM.rowOfGridView).Value

        TextBoxPrice.Text = InventarioAM.DataGridView2.Item(6, InventarioAM.rowOfGridView).Value.ToString



    End Sub

    Private Sub TextBoxBrand_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBrand.TextChanged

    End Sub
End Class