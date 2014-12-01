Imports System.Data.SqlClient
Imports System.Data

Public Class Form7
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            Label6.Visible = True
        Else
            Dim strSQL As String = _
            "USE Shop" & vbCrLf & _
            "EXEC Stock_Insert " &
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
                MessageBox.Show(sqlExc.ToString, "SQL Exception Error!", _
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Form3.Initialize()
            Form3.Visible = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Initialize()
        Form3.Visible = True
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class