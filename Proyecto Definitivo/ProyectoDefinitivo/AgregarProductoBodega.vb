Imports System.Data.SqlClient
Public Class AgregarProductoBodega
    Dim ConnectionString As String = "Data Source=PabloPorras-PC;Initial Catalog=Inventory;Integrated Security=True"
    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim Code As String
        Dim Name As String
        Dim Brand As String
        Dim Quantity As Integer
        Dim Category As String
        Dim Price As String

        Code = TextBoxCode.Text
        Name = TextBoxName.Text
        Brand = TextBoxBrand.Text
        Quantity = Integer.Parse(NumericUpDownQuantity.Value)
        Category = TextBoxCategory.Text
        Price = TextBoxPrice.Text

        Dim Query As String
        Dim Connection As New SqlConnection(ConnectionString)
        Dim Command As SqlCommand

        Query = "INSERT INTO Products (Name, Brand, Category, Code, Quantity, Price) VALUES (@Name, @Brand, @Category, @Code, @Quantity, @Price)"

        Command = New SqlCommand(Query, Connection)


        With Command

            .Parameters.AddWithValue("@Name", Name)
            .Parameters.AddWithValue("@Brand", Brand)
            .Parameters.AddWithValue("@Category", Category)
            .Parameters.AddWithValue("@Code", Code)
            .Parameters.AddWithValue("@Quantity", Quantity)
            .Parameters.AddWithValue("@Price", Price)


        End With

        MsgBox("Tú nuevo producto ha sido guardado con la siguiente información" & vbCrLf & vbCrLf & "Nombre: " & Name & vbCrLf & "Marca: " & Brand & vbCrLf & "Category: " & Category & vbCrLf & "Code: " & Code & vbCrLf & "Cantidad: " & Quantity & vbCrLf & "Precio: " & Price)

        Connection.Open()
        Command.ExecuteNonQuery()
        Command.Dispose()
        Connection.Close()

        Me.Close()

        InventarioAM.DataGridView2.DataSource = Nothing
        InventarioAM.LoadGridView()


    End Sub

    Private Sub AgregarProductoBodega_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class