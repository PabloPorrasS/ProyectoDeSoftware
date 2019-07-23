Imports System.Data.SqlClient
Public Class FormularioEditar

    Dim ConnectionString As String = "Data Source=PABLOPORRAS-PC;Initial Catalog=Inventory;Integrated Security=True"

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        Dim Name As String
        Dim Brand As String
        Dim Category As String
        Dim Code As Integer
        Dim Quantity As Integer
        Dim Price As Integer



        'le asignamos valor a las variables


        LabelProductCode.Text = (ComboBoxName.SelectedValue).ToString
        'Name = ComboBoxName.SelectedItem
        Brand = TextBoxBrand.Text
        Category = TextBoxCategory.Text
        Quantity = Integer.Parse(NumericUpDownQuantity.Value)
        Code = TextBoxCode.Text
        Price = Integer.Parse(TextBoxPrice.Text)



        Dim Connection As New SqlConnection(ConnectionString)
        Dim Query As String

        Query = "UPDATE Products SET Brand=@Brand, Category=@Category, Code=@Code, Quantity=@Quantity, Price=@Price WHERE Name = '" & LabelProductCode.Text & "'"

        Dim Command As SqlCommand
        Command = New SqlCommand(Query, Connection)

        'With Command


        '    .Parameters.AddWithValue("@Brand", Brand)
        '    .Parameters.AddWithConnection As New SqlConnection(ConnectionString)
        'Dim commandDelete As New SqlCommand("DELETE FROM ClientProducts WHERE Id_Profile = " & Id_Profile.Text & " AND Id_Products = " & Id_Products.Text, Connection)

        '    Connection.Open()
        '    commandDelete.ExecuteNonQuery()
        '    Connection.Close()
        '    Me.Close()

        '    Value("@Category", Category)
        '    .Parameters.AddWithValue("@Code", Code)
        '    .Parameters.AddWithValue("@Quantity", Quantity)
        '    .Parameters.AddWithValue("@Price", Price)


        'End With

        Connection.Open()
        Command.ExecuteNonQuery()
        Command.Dispose()
        Connection.Close()








    End Sub

    Private Sub FormularioEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim Connection As New SqlConnection(ConnectionString)
        Dim Command As New SqlCommand
        Dim DataAdapter As New SqlDataAdapter
        Dim DataTable As DataTable

        With Command

            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM Products"
            .Connection = Connection

        End With

        DataTable = New DataTable
        DataAdapter.SelectCommand = Command
        DataAdapter.Fill(DataTable)

        With ComboBoxName
            .DataSource = DataTable
            .DisplayMember = "Name"
            .ValueMember = "Name"

        End With


        'LabelProductCode.Text = ComboBoxName.SelectedIndex.ToString



        'Dim commandselect As SqlCommand
        'Dim SelectQuery As String
        'SelectQuery = "Select * FROM Products WHERE Name = '" & LabelProductCode.Text & "'"
        'commandselect = New SqlCommand(SelectQuery, Connection)
        'Connection.Open()

        'Dim Reader As SqlDataReader
        'Reader = commandselect.ExecuteReader

        'Dim Name As String
        'Dim Brand As String
        'Dim Category As String
        'Dim Code As Integer
        'Dim Quantity As Integer
        'Dim Price As Integer



        'While Reader.HasRows ' Has rows es mientras tenga columnas
        '    Reader.Read()
        '    Name = Reader.GetString(0)
        '    Brand = Reader.GetString(1)
        '    Category = Reader.GetString(2)
        '    Quantity = Reader.GetInt32(4)
        '    Price = Reader.GetInt32(5)
        '    Code = Reader.GetInt32(3)

        '    Exit While

        'End While


        'TextBoxBrand.Text = Brand
        'NumericUpDownQuantity.Value = Quantity
        'TextBoxCategory.Text = Category
        'TextBoxPrice.Text = Price
        'TextBoxCode.Text = Code


        ''commandselect.ExecuteNonQuery()
        ''commandselect.Dispose()
        'Connection.Close()



    End Sub

    Private Sub ComboBoxName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxName.SelectedIndexChanged


        LabelProductCode.Text = (ComboBoxName.SelectedValue).ToString

        Dim Connection As New SqlConnection(ConnectionString)

        Dim commandselect As SqlCommand
        Dim SelectQuery As String
        SelectQuery = "Select * FROM Products WHERE Name = '" & LabelProductCode.Text & "'"
        commandselect = New SqlCommand(SelectQuery, Connection)
        Connection.Open()

        Dim Reader As SqlDataReader
        Reader = commandselect.ExecuteReader

        Dim Name As String
        Dim Brand As String
        Dim Category As String
        Dim Code As Integer
        Dim Quantity As Integer
        Dim Price As Integer



        While Reader.HasRows ' Has rows es mientras tenga columnas
            Reader.Read()
            Name = Reader.GetString(0)
            Brand = Reader.GetString(1)
            Category = Reader.GetString(2)
            Quantity = Reader.GetInt32(4)
            Price = Reader.GetInt32(5)
            Code = Reader.GetInt32(3)

            Exit While

        End While


        TextBoxBrand.Text = Brand
        NumericUpDownQuantity.Value = Quantity
        TextBoxCategory.Text = Category
        TextBoxPrice.Text = Price
        TextBoxCode.Text = Code


        'commandselect.ExecuteNonQuery()
        'commandselect.Dispose()
        Connection.Close()




    End Sub
End Class