Imports System.Data.SqlClient
Imports System.Data

Public Class Form1
    Protected Const SqlConnectionString As String = _
       "Server=(local);" & _
       "DataBase=;" & _
       "Integrated Security=SSPI"

    Protected connectionString As String = SqlConnectionString

    Public Function Initialize()
        Label3.Text = "0.00"
        Form2.Visible = False
        Form5.Visible = False
        Form3.Visible = False
        LogIn.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        RadioButton1.Checked = True
        If DataGridView1.Columns.Count = 0 Then
            With Me.DataGridView1
                .Visible = True
                .AutoGenerateColumns = False
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Lavender
                .BackColor = Color.WhiteSmoke
                .ForeColor = Color.MidnightBlue
                .CellBorderStyle = DataGridViewCellBorderStyle.None
                .ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 8.0!, FontStyle.Bold)
                .ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke
                .DefaultCellStyle.ForeColor = Color.MidnightBlue
                .DefaultCellStyle.BackColor = Color.WhiteSmoke
            End With
            Dim newColumn As Integer = Me.DataGridView1.Columns.Add("NameP", "Name")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "NameP"

            newColumn = Me.DataGridView1.Columns.Add("PriceP", "Price")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "Price"

            newColumn = Me.DataGridView1.Columns.Add("VAT", "V.A.T.")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "V.A.T"

            newColumn = Me.DataGridView1.Columns.Add("QuantityP", "Quantity")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "Quantity"

            newColumn = Me.DataGridView1.Columns.Add("BarCodeP", "Barcode")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = ""

        End If

        Me.DataGridView1.Rows.Clear()
        Return 1
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "1"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "1"
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If (DataGridView1.RowCount Mod 2) - 1 = 0 Then
            DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Coca Cola Light", "0.50", "19", "4"})
        Else
            DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Water Medium", "3.00", "19", "1"})
        End If
        DataGridView1.AutoResizeColumns()

        Label3.Text = CDec(Label3.Text) + CDec(DataGridView1.Item(1, DataGridView1.RowCount - 2).Value * DataGridView1.Item(3, DataGridView1.RowCount - 2).Value) / 100
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (Button15.Visible = False) Then
            Button15.Visible = True
            Button16.Visible = True
            Button17.Visible = True
            Button19.Visible = True
        Else
            Button15.Visible = False
            Button16.Visible = False
            Button17.Visible = False
            Button19.Visible = False
        End If

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If (DataGridView1.RowCount Mod 2) - 1 = 0 Then
            DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Sandwitch Tuna", "3.50", "19", "1"})
        Else
            DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Sandwitch Ham", "3.00", "19", "1"})
        End If
        DataGridView1.AutoResizeColumns()

        Label3.Text = CDec(Label3.Text) + CDec(DataGridView1.Item(1, DataGridView1.RowCount - 2).Value * DataGridView1.Item(3, DataGridView1.RowCount - 2).Value) / 100
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Simerini", "1.80", "19", "1"})
        DataGridView1.AutoResizeColumns()

        Label3.Text = CDec(Label3.Text) + CDec(DataGridView1.Item(1, DataGridView1.RowCount - 2).Value * DataGridView1.Item(3, DataGridView1.RowCount - 2).Value) / 100
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Medical Gauze", "2.00", "19", "1"})
        DataGridView1.AutoResizeColumns()

        Label3.Text = CDec(Label3.Text) + CDec(DataGridView1.Item(1, DataGridView1.RowCount - 2).Value * DataGridView1.Item(3, DataGridView1.RowCount - 2).Value) / 100
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Button15.Visible = False
        Button16.Visible = False
        Button17.Visible = False
        Button19.Visible = False
        Dim cost = Label3.Text
       
        For counter = 1 To DataGridView1.RowCount - 1
            Dim strSQL2 As String = _
           "USE Shop" & vbCrLf & _
           "EXEC Stock_Reduce " &
            CInt(DataGridView1.Item(4, counter - 1).Value) &
           ", " &
            CInt(DataGridView1.Item(3, counter - 1).Value)

            Try
                ' The SqlConnection class allows you to communicate with SQL Server.
                ' The constructor accepts a connection string as an argument.  This
                ' connection string uses Integrated Security, which means that you 
                ' must have a login in SQL Server, or be part of the Administrators
                ' group for this to work.
                Dim dbConnection As New SqlConnection(connectionString)

                ' A SqlCommand object is used to execute the SQL commands.
                Dim cmd As New SqlCommand(strSQL2, dbConnection)

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



            Label3.Text = DataGridView1.Item(1, DataGridView1.RowCount - 2).Value * DataGridView1.Item(3, DataGridView1.RowCount - 2).Value

            Dim strSQL As String = _
           "USE Shop" & vbCrLf & _
           "EXEC Orders_Insert " &
           CInt(DataGridView1.Item(4, counter - 1).Value) &
           ", " &
           CInt(DataGridView1.Item(3, counter - 1).Value)

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
        Next

        TextBox1.Text = ""
        TextBox2.Text = ""
        Form5.Initialize(cost)
        Form5.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Visible = False
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        LogIn.Initialize()
        LogIn.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button15.Visible = False
        Button16.Visible = False
        Button17.Visible = False
        Button19.Visible = False
        If (TextBox2.Text = "") Then
            TextBox2.Text = "1"
        End If
        If (TextBox1.Text = "") Then
            Return
        End If
        Dim dbConnection As New SqlConnection(connectionString)
        Dim cmd1 As New SqlCommand(("Shop.dbo.Product_Find"), dbConnection)
        cmd1.CommandType = CommandType.StoredProcedure
        'Dim BARC As Integer = Integer.Parse(TextBox1.Text)
        cmd1.Parameters.Add("@Barcode", SqlDbType.Int, ParameterDirection.Input).Value = TextBox1.Text

        cmd1.Parameters.Add("@Name", SqlDbType.NVarChar, 50)
        cmd1.Parameters("@Name").Direction = ParameterDirection.Output
        cmd1.Parameters.Add("@Price", SqlDbType.Money)
        cmd1.Parameters("@Price").Direction = ParameterDirection.Output
        cmd1.Parameters.Add("@VAT", SqlDbType.Money)
        cmd1.Parameters("@VAT").Direction = ParameterDirection.Output
        dbConnection.Open()
        cmd1.ExecuteNonQuery()
        dbConnection.Close()

        Dim cmd2 As New SqlCommand(("Shop.dbo.getDiscounts"), dbConnection)
        cmd2.CommandType = CommandType.StoredProcedure
        'Dim BARC As Integer = Integer.Parse(TextBox1.Text)
        cmd2.Parameters.Add("@Barcode", SqlDbType.Int, ParameterDirection.Input).Value = TextBox1.Text

        cmd2.Parameters.Add("@Discount", SqlDbType.NVarChar, 50)
        cmd2.Parameters("@Discount").Direction = ParameterDirection.Output
        dbConnection.Open()
        cmd2.ExecuteNonQuery()
        dbConnection.Close()

        If (cmd1.Parameters("@Price").Value.ToString() = "") Then
            Return
        End If

        DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {cmd1.Parameters("@Name").Value.ToString(), Math.Round(((CDec(cmd1.Parameters("@Price").Value.ToString()) * CDec(100 - cmd2.Parameters("@Discount").Value.ToString())) / 100), 2, MidpointRounding.AwayFromZero), cmd1.Parameters("@VAT").Value.ToString(), TextBox2.Text, TextBox1.Text})
        ' ElseIf (DataGridView1.RowCount Mod 3) - 1 = 1 Then
        ' DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Kit-Kat Large", "1.50", "19", "2"})
        'Else
        'DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {"Water Medium", "3.00", "19", "1"})
        'End If
        DataGridView1.AutoResizeColumns()

        Label3.Text = CDec(Label3.Text) + CDec(DataGridView1.Item(1, DataGridView1.RowCount - 2).Value * DataGridView1.Item(3, DataGridView1.RowCount - 2).Value)

        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Initialize()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TextBox2.Text = ""
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "2"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "3"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "3"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "4"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "5"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "6"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "6"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "7"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "7"
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "8"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "9"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "9"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If RadioButton2.Checked Then
            TextBox2.Text = TextBox2.Text + "0"
        ElseIf RadioButton1.Checked Then
            TextBox1.Text = TextBox1.Text + "0"
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        If RadioButton2.Checked Then
            If TextBox2.Text.Length <> 0 Then
                TextBox2.Text = TextBox2.Text.Substring(0, TextBox2.Text.Length - 1)
            End If
        ElseIf RadioButton1.Checked Then
            If TextBox1.Text <> "" Then
                TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
                If TextBox1.Text = "0" Then
                    TextBox1.Text = ""
                End If
            End If
        End If
    End Sub

    Private Sub fileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles fileToolStripMenuItem.Click

    End Sub

    Private Sub exitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        End
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        TextBox2.Text = "1"

    End Sub

End Class
