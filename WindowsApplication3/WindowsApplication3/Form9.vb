Imports System.Data.SqlClient
Imports System.Data

Public Class Form9

    Protected Const SqlConnectionString As String = _
        "Server=(local);" & _
        "DataBase=;" & _
        "Integrated Security=SSPI"

    Protected connectionString As String = SqlConnectionString

    Public Function Initialize()
        Form2.Visible = False
        Form3.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label6.Visible = False
        Return 1
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            Label6.Visible = True
        Else
            Dim strSQL As String = _
            "USE Shop" & vbCrLf & _
            "EXEC Discounts_Insert " &
            TextBox1.Text &
            ", " &
            TextBox2.Text

            Try
                ' The SqlConnection class allows you to communicate with SQL Server.
                ' The constructor accepts a connection string as an argument.  This
                ' connection string uses Integrated Security, which means that you 
                ' must have a login in SQL Server, or be part of the Administrators
                ' group for this to work.
                Dim dbConnection As New SqlConnection(connectionString)

                ' A SqlCommand object is used to execute the SQL commands.
                Dim cmd As New SqlCommand(strSQL, dbConnection)

                ' Open the connection, execute the command, and close the connection.
                ' It is more efficient to ExecuteNonQuery when data is not being 
                ' returned.
                dbConnection.Open()
                cmd.ExecuteNonQuery()
                dbConnection.Close()

            Catch sqlExc As SqlException
            End Try

            Form3.Initialize()
            Form3.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Initialize()
        Form3.Visible = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class