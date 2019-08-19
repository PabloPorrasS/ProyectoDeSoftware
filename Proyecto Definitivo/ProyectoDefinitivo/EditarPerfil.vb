Imports System.Data.SqlClient
Public Class EditarPerfil
    Dim ConnectionString As String = "Data Source=SP-LA-LAB9-13;Initial Catalog=Inventory;Integrated Security=True"

    Private Sub EditarPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim Connection As New SqlConnection(ConnectionString)
        Dim Command As New SqlCommand
        Dim DataAdapter As New SqlDataAdapter
        Dim DataTable As DataTable

        With Command

            .CommandType = CommandType.Text
            .CommandText = "SELECT * FROM TypeOfBusiness"
            .Connection = Connection

        End With

        DataTable = New DataTable
        DataAdapter.SelectCommand = Command
        DataAdapter.Fill(DataTable)

        With ComboBoxTypeOfBusiness
            .DataSource = DataTable
            .DisplayMember = "TypeOfBusiness"
            .ValueMember = "Id"

        End With

        Dim Id As Integer


        Dim commandselect As SqlCommand
        Dim SelectQuery As String
        SelectQuery = "Select * FROM Profile WHERE Email = '" & Login.TextBoxEmail.Text & "'"
        commandselect = New SqlCommand(SelectQuery, Connection)
        Connection.Open()


        Dim reader As SqlDataReader
        reader = commandselect.ExecuteReader()



        Dim Name As String
        Dim Email As String
        Dim Password As String
        Dim TypeOfBussiness As Integer
        Dim Ubication As String


        While reader.HasRows

            reader.Read()
            LabelIdProfile.Text = reader.GetInt32(0).ToString
            Name = Reader.GetString(1)

            Password = reader.GetString(5)
            TypeOfBussiness = reader.GetInt32(6)
            Ubication = reader.GetString(3)

            Exit While

        End While

        TextBoxCompleteName.Text = Name
        ComboBoxTypeOfBusiness.SelectedIndex = TypeOfBussiness - 1

        TextBoxPassword.Text = Password
        TextBoxUbication.Text = Ubication





    End Sub

    Private Sub ButtonSaveChanges_Click(sender As Object, e As EventArgs) Handles ButtonSaveChanges.Click

        Dim Name As String
        Dim TypeOfBusiness As String
        Dim Email As String
        Dim Password As String
        Dim Ubication As String
        Dim Institution As String

        'le asignamos valor a las variables
        Name = TextBoxCompleteName.Text
        TypeOfBusiness = Integer.Parse(ComboBoxTypeOfBusiness.SelectedValue.ToString)

        Password = TextBoxPassword.Text
        Ubication = TextBoxUbication.Text


        Dim Connection As New SqlConnection(ConnectionString)
        Dim Query As String

        Query = "UPDATE Profile SET CompleteName=@Name, IdTypeOfBusiness=@TypeOfBusiness, Password=@Password, Ubication=@Ubication WHERE Id = '" & LabelIdProfile.Text & "'"


        Dim Command As SqlCommand
        Command = New SqlCommand(Query, Connection)

        With Command

            .Parameters.AddWithValue("@Name", Name)
            .Parameters.AddWithValue("@TypeOfBusiness", TypeOfBusiness)

            .Parameters.AddWithValue("@Password", Password)
            .Parameters.AddWithValue("@Ubication", Ubication)


        End With

        Connection.Open()
        Command.ExecuteNonQuery()
        Command.Dispose()
        Connection.Close()


        MsgBox("Tú perfil ha sido guardado con la siguiente información" & vbCrLf & vbCrLf & "Nombre: " & Name & vbCrLf & "Tipo de Negocio: " & TypeOfBusiness & vbCrLf & "Password: " & Password & vbCrLf & "Ubication: " & Ubication)

        Me.Close()

    End Sub

    Private Sub TextBoxCompleteName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCompleteName.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub

    Private Sub TextBoxUbication_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUbication.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else e.Handled = True
        End If
    End Sub
   