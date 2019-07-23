Imports System.Data.SqlClient
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
End Class
