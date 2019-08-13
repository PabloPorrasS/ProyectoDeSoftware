Imports System.Data.SqlClient
Public Class Facturas
    Public rowOfGridview As Integer

    Dim ConnectionString As String = "Data Source=SP-LA-LAB9-13;Initial Catalog=Inventory;Integrated Security=True"

    Private Sub Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadGridView()

    End Sub

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

        Dim Bills As New DataTable

        SelectQuery = "SELECT  Id_Profile 'Id_Profile', Id 'Id', Fecha 'Date' FROM Bills WHERE Id_Profile ='" & Id & "'"
        commandselect = New SqlCommand(SelectQuery, Connection)
        Dim dataAdapter As New SqlDataAdapter(commandselect)
        dataAdapter.Fill(Bills)
        DataGridView1.DataSource = Bills

        DataGridView1.Columns(0).Visible = False
        DataGridView1.Columns(1).Visible = False

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        rowOfGridview = DataGridView1.CurrentRow.Index


    End Sub
End Class