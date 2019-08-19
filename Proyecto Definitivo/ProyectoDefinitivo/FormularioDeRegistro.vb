Imports System.Data.SqlClient
Public Class FormularioDeRegistro
    Dim ConnectionString As String = "Data Source=PABLOPORRAS-PC;Initial Catalog=Inventory;Integrated Security=True"
    Private Sub FormularioDeRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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


    End Sub

    Private Sub ButtonSaveRegister_Click(sender As Object, e As EventArgs) Handles ButtonSaveRegister.Click


        Dim CompleteName As String
        Dim TypeOfBusiness As String
        Dim Ubication As String
        Dim Email As String
        Dim Password As String
        Dim TypeOfUser As Integer

        'le asignamos valor a las variables
        CompleteName = TextBoxCompleteName.Text
        TypeOfBusiness = Integer.Parse(ComboBoxTypeOfBusiness.SelectedValue.ToString)
        Ubication = TextBoxUbication.Text
        Email = TextBoxEmail.Text
        Password = TextBoxPassword.Text
        TypeOfUser = 1


        Dim Connection As New SqlConnection(ConnectionString)
        Dim Query As String

        Query = "INSERT INTO Profile (CompleteName, IdTypeOfBusiness, Ubication, Email, Password, TypeOfUser) VALUES (@CompleteName, @IdTypeOfBusiness, @Ubication, @Email, @Password, @TypeOfUser)"
        Dim Command As SqlCommand
        Command = New SqlCommand(Query, Connection)

        With Command

            .Parameters.AddWithValue("@CompleteName", CompleteName)
            .Parameters.AddWithValue("@IdTypeOfBusiness", TypeOfBusiness)
            .Parameters.AddWithValue("@Ubication", Ubication)
            .Parameters.AddWithValue("@Email", Email)
            .Parameters.AddWithValue("@Password", Password)
            .Parameters.AddWithValue("@TypeOfUser", TypeOfUser)

        End With

        Connection.Open()
        Command.ExecuteNonQuery()
        Command.Dispose()
        Connection.Close()

        'Try


        'Catch ex As Exception

        'End Try

        MsgBox("Tú perfil ha sido guardado con la siguiente información" & vbCrLf & vbCrLf & "Nombre: " & CompleteName & vbCrLf & "Email: " & Email & vbCrLf & "Contraseña: " & Password & vbCrLf & "Tipo de Negocio: " & TypeOfBusiness & vbCrLf & "Ubicación del negocio: " & Ubication)
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
End Class