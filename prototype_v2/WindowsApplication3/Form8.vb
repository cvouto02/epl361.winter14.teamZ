Imports System.Data.SqlClient
Imports System.Data
Public Class Form8
    Protected Const SqlConnectionString As String = _
      "Server=(local);" & _
      "DataBase=;" & _
      "Integrated Security=SSPI"

    Protected connectionString As String = SqlConnectionString

    Public Function Initialize()
        Form2.Visible = False
        Form3.Visible = False

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

            Dim newColumn As Integer = Me.DataGridView1.Columns.Add("OrderNumber", "Order#")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "Order#"

            newColumn = Me.DataGridView1.Columns.Add("BarCodeP", "Barcode")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "Barcode"

            newColumn = Me.DataGridView1.Columns.Add("NameP", "Name")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "NameP"

            newColumn = Me.DataGridView1.Columns.Add("PriceP", "Price")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "Price"

            newColumn = Me.DataGridView1.Columns.Add("VAT", "V.A.T.")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "V.A.T"

            newColumn = Me.DataGridView1.Columns.Add("QuantityP", "Quantity")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "Quantity"


            newColumn = Me.DataGridView1.Columns.Add("OrderDate", "OrderDate")
            Me.DataGridView1.Columns(newColumn).DataPropertyName = "OrderDate"

          

        End If

        Me.DataGridView1.Rows.Clear()
        Return 1
    End Function


    Public Function VAT5()
        Dim dbConnection As New SqlConnection(connectionString)
        Dim cmd1 As New SqlCommand(("Shop.dbo.maxOrder"), dbConnection)
        cmd1.CommandType = CommandType.StoredProcedure
        'Dim BARC As Integer = Integer.Parse(TextBox1.Text)
        cmd1.Parameters.Add("@MAXON", SqlDbType.Int)
        cmd1.Parameters("@MAXON").Direction = ParameterDirection.Output
        dbConnection.Open()
        cmd1.ExecuteNonQuery()
        dbConnection.Close()
        For counter = 1 To cmd1.Parameters("@MAXON").Value
            Dim dbConnection2 As New SqlConnection(connectionString)
            Dim cmd2 As New SqlCommand(("Shop.dbo.getDetails"), dbConnection2)
            cmd2.CommandType = CommandType.StoredProcedure
            'Dim BARC As Integer = Integer.Parse(TextBox1.Text)
            cmd2.Parameters.Add("@OrN", SqlDbType.Int, ParameterDirection.Input).Value = counter
            cmd2.Parameters.Add("@Barcode", SqlDbType.Int)
            cmd2.Parameters("@Barcode").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@Name", SqlDbType.NVarChar, 50)
            cmd2.Parameters("@Name").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@Price", SqlDbType.Money)
            cmd2.Parameters("@Price").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@VAT", SqlDbType.Money)
            cmd2.Parameters("@VAT").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@Quantity", SqlDbType.Int)
            cmd2.Parameters("@Quantity").Direction = ParameterDirection.Output
            dbConnection2.Open()
            cmd2.ExecuteNonQuery()
            dbConnection2.Close()
            If (cmd2.Parameters("@Name").Value.ToString <> "") Then
                If ((cmd2.Parameters("@VAT").Value) = 5) Then
                    DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {counter, cmd2.Parameters("@Barcode").Value.ToString(), cmd2.Parameters("@Name").Value.ToString(), cmd2.Parameters("@Price").Value.ToString(), cmd2.Parameters("@VAT").Value.ToString(), cmd2.Parameters("@Quantity").Value.ToString(), "--"})
                End If
            End If
        Next
        DataGridView1.AutoResizeColumns()
        Return 1
    End Function

    Public Function VAT19()
        Dim dbConnection As New SqlConnection(connectionString)
        Dim cmd1 As New SqlCommand(("Shop.dbo.maxOrder"), dbConnection)
        cmd1.CommandType = CommandType.StoredProcedure
        'Dim BARC As Integer = Integer.Parse(TextBox1.Text)
        cmd1.Parameters.Add("@MAXON", SqlDbType.Int)
        cmd1.Parameters("@MAXON").Direction = ParameterDirection.Output
        dbConnection.Open()
        cmd1.ExecuteNonQuery()
        dbConnection.Close()
        For counter = 1 To cmd1.Parameters("@MAXON").Value
            Dim dbConnection2 As New SqlConnection(connectionString)
            Dim cmd2 As New SqlCommand(("Shop.dbo.getDetails"), dbConnection2)
            cmd2.CommandType = CommandType.StoredProcedure
            'Dim BARC As Integer = Integer.Parse(TextBox1.Text)
            cmd2.Parameters.Add("@OrN", SqlDbType.Int, ParameterDirection.Input).Value = counter
            cmd2.Parameters.Add("@Barcode", SqlDbType.Int)
            cmd2.Parameters("@Barcode").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@Name", SqlDbType.NVarChar, 50)
            cmd2.Parameters("@Name").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@Price", SqlDbType.Money)
            cmd2.Parameters("@Price").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@VAT", SqlDbType.Money)
            cmd2.Parameters("@VAT").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@Quantity", SqlDbType.Int)
            cmd2.Parameters("@Quantity").Direction = ParameterDirection.Output
            dbConnection2.Open()
            cmd2.ExecuteNonQuery()
            dbConnection2.Close()
            If (cmd2.Parameters("@Name").Value.ToString <> "") Then
                If ((cmd2.Parameters("@VAT").Value) = 19) Then
                    DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {counter, cmd2.Parameters("@Barcode").Value.ToString(), cmd2.Parameters("@Name").Value.ToString(), cmd2.Parameters("@Price").Value.ToString(), cmd2.Parameters("@VAT").Value.ToString(), cmd2.Parameters("@Quantity").Value.ToString(), "--"})
                End If
            End If
        Next
        DataGridView1.AutoResizeColumns()
        Return 1

    End Function

    Public Function DAILY()
        Dim dbConnection As New SqlConnection(connectionString)
        Dim cmd1 As New SqlCommand(("Shop.dbo.maxOrder"), dbConnection)
        cmd1.CommandType = CommandType.StoredProcedure
        'Dim BARC As Integer = Integer.Parse(TextBox1.Text)
        cmd1.Parameters.Add("@MAXON", SqlDbType.Int)
        cmd1.Parameters("@MAXON").Direction = ParameterDirection.Output
        dbConnection.Open()
        cmd1.ExecuteNonQuery()
        dbConnection.Close()
        For counter = 1 To cmd1.Parameters("@MAXON").Value
            Dim dbConnection2 As New SqlConnection(connectionString)
            Dim cmd2 As New SqlCommand(("Shop.dbo.getDaily"), dbConnection2)
            cmd2.CommandType = CommandType.StoredProcedure
            'Dim BARC As Integer = Integer.Parse(TextBox1.Text)
            cmd2.Parameters.Add("@OrN", SqlDbType.Int, ParameterDirection.Input).Value = counter
            cmd2.Parameters.Add("@Barcode", SqlDbType.Int)
            cmd2.Parameters("@Barcode").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@Name", SqlDbType.NVarChar, 50)
            cmd2.Parameters("@Name").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@Price", SqlDbType.Money)
            cmd2.Parameters("@Price").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@VAT", SqlDbType.Money)
            cmd2.Parameters("@VAT").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@Quantity", SqlDbType.Int)
            cmd2.Parameters("@Quantity").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@Dates", SqlDbType.Date)
            cmd2.Parameters("@Dates").Direction = ParameterDirection.Output
            dbConnection2.Open()
            cmd2.ExecuteNonQuery()
            dbConnection2.Close()
            If (cmd2.Parameters("@Dates").Value.ToString <> "") Then
                Dim today = (cmd2.Parameters("@Dates").Value.ToString.Substring(0, 2))
                today = (cmd2.Parameters("@Dates").Value.ToString.Substring(3, 2))
                If (((String.Compare((cmd2.Parameters("@Dates").Value.ToString.Substring(3, 2)), (DateTime.Now.ToString.Substring(3, 2)))) = 0) And ((String.Compare((cmd2.Parameters("@Dates").Value.ToString.Substring(0, 2)), (DateTime.Now.ToString.Substring(0, 2)))) = 0)) Then
                    DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {counter, cmd2.Parameters("@Barcode").Value.ToString(), cmd2.Parameters("@Name").Value.ToString(), cmd2.Parameters("@Price").Value.ToString(), cmd2.Parameters("@VAT").Value.ToString(), cmd2.Parameters("@Quantity").Value.ToString(), cmd2.Parameters("@Dates").Value.ToString()})
                End If
            End If
        Next
        DataGridView1.AutoResizeColumns()
        Return 1
    End Function


    Public Function MONTHLY()
        Dim dbConnection As New SqlConnection(connectionString)
        Dim cmd1 As New SqlCommand(("Shop.dbo.maxOrder"), dbConnection)
        cmd1.CommandType = CommandType.StoredProcedure
        'Dim BARC As Integer = Integer.Parse(TextBox1.Text)
        cmd1.Parameters.Add("@MAXON", SqlDbType.Int)
        cmd1.Parameters("@MAXON").Direction = ParameterDirection.Output
        dbConnection.Open()
        cmd1.ExecuteNonQuery()
        dbConnection.Close()
        For counter = 1 To cmd1.Parameters("@MAXON").Value
            Dim dbConnection2 As New SqlConnection(connectionString)
            Dim cmd2 As New SqlCommand(("Shop.dbo.getDaily"), dbConnection2)
            cmd2.CommandType = CommandType.StoredProcedure
            'Dim BARC As Integer = Integer.Parse(TextBox1.Text)
            cmd2.Parameters.Add("@OrN", SqlDbType.Int, ParameterDirection.Input).Value = counter
            cmd2.Parameters.Add("@Barcode", SqlDbType.Int)
            cmd2.Parameters("@Barcode").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@Name", SqlDbType.NVarChar, 50)
            cmd2.Parameters("@Name").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@Price", SqlDbType.Money)
            cmd2.Parameters("@Price").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@VAT", SqlDbType.Money)
            cmd2.Parameters("@VAT").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@Quantity", SqlDbType.Int)
            cmd2.Parameters("@Quantity").Direction = ParameterDirection.Output
            cmd2.Parameters.Add("@Dates", SqlDbType.Date)
            cmd2.Parameters("@Dates").Direction = ParameterDirection.Output
            dbConnection2.Open()
            cmd2.ExecuteNonQuery()
            dbConnection2.Close()
            If (cmd2.Parameters("@Dates").Value.ToString <> "") Then
                If ((String.Compare((cmd2.Parameters("@Dates").Value.ToString.Substring(3, 2)), (DateTime.Now.ToString.Substring(3, 2)))) = 0) Then
                    DataGridView1.Rows.Insert(DataGridView1.RowCount - 1, New String() {counter, cmd2.Parameters("@Barcode").Value.ToString(), cmd2.Parameters("@Name").Value.ToString(), cmd2.Parameters("@Price").Value.ToString(), cmd2.Parameters("@VAT").Value.ToString(), cmd2.Parameters("@Quantity").Value.ToString(), cmd2.Parameters("@Dates").Value.ToString()})
                End If
            End If
        Next
        DataGridView1.AutoResizeColumns()
        Return 1
    End Function

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Initialize()
        Form3.Visible = True
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class