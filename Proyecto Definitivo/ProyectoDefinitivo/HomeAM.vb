Imports System.Data.SqlClient
Public Class HomeAM
    Dim ConnectionString As String = "Data Source=PABLOPORRAS-PC;Initial Catalog=Inventory;Integrated Security=True"
    Private Sub ButtonInventory_Click(sender As Object, e As EventArgs) Handles ButtonInventory.Click

        InventarioAM.Show()


    End Sub

    Private Sub HomeAM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim welcomeName As Integer

        Dim Connection As New SqlConnection(ConnectionString)

        Dim commandselect As SqlCommand

        Dim SelectQuery As String
        SelectQuery = "Select CompleteName FROM Profile WHERE Email ='" & Login.TextBoxEmail.Text & "'"
        commandselect = New SqlCommand(SelectQuery, Connection)
        Connection.Open()

        Dim reader As SqlDataReader
        reader = commandselect.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            welcomeName = reader.GetInt32(1)

        End If

        LabelNameWelcomeAM.Text = welcomeName

        Connection.Close()
    End Sub

    Private Sub ButtonBill_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ButtonShoppingCart_Click(sender As Object, e As EventArgs)

    End Sub
End Class