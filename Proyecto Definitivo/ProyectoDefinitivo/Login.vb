Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Login
    Dim ConnectionString As String = "Data Source=PabloPorras-PC;Initial Catalog=Inventory;Integrated Security=True"
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim Email As String
        Dim Password As String
        Email = TextBoxEmail.Text
        Password = TextBoxPassword.Text


        Dim Connection As New SqlConnection(ConnectionString)

        Dim commandselect As SqlCommand


        Dim SelectQuery As String
        SelectQuery = "Select CompleteName, Email, Password, TypeOfUser FROM Profile WHERE Email ='" & TextBoxEmail.Text & "' AND Password='" & TextBoxPassword.Text & "'"
        commandselect = New SqlCommand(SelectQuery, Connection)
        Connection.Open()

        Dim reader As SqlDataReader
        reader = commandselect.ExecuteReader()
        Dim TypeOfUser As String

        If reader.HasRows Then

            If reader.Read() Then
                If TextBoxEmail.Text = reader.GetString(1) And TextBoxPassword.Text = reader.GetString(2) Then

                    TypeOfUser = reader.GetInt32(3)

                    If TypeOfUser = 1 Then

                        HomeCliente.Show()


                    ElseIf TypeOfUser = 2 Then

                        HomeAM.Show()



                    End If
                Else

                    MsgBox("Correo o Contraseña incorrectos")

                End If


            End If

        End If


        Connection.Close()


    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        FormularioDeRegistro.Show()
    End Sub


    Public Function validar_Mail(ByVal sMail As String) As Boolean
        ' retorna true o false   
        Return Regex.IsMatch(sMail,
               "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$")
    End Function

    Private Sub TextBoxEmail_Leave(sender As Object, e As EventArgs) Handles TextBoxEmail.Leave


        If validar_Mail(LCase(TextBoxEmail.Text)) = False Then
            MessageBox.Show("Dirección de correo electronico no válida, el correo debe tener el formato: nombre@dominio.com, " &
            " por favor escriba un correo válido", "Validación de correo electronico", MessageBoxButtons.OK,
            MessageBoxIcon.Exclamation)
            TextBoxEmail.Focus()
            TextBoxEmail.SelectAll()
        End If




    End Sub
End Class


