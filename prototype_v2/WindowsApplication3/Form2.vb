Public Class Form2
    Public Function Initialize()
        Form1.Visible = False
        Form3.Visible = False
        Label3.Visible = False
        Label1.Visible = False
        Label4.Visible = False
        Label3.Text = "0"
        TextBox1.Text = ""
        Return 1
    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") Then
            Label4.Visible = True
        ElseIf (Label3.Text < "3") Then
            Label4.Visible = False
            If (TextBox1.Text = "epl361") Then
                Form1.Initialize()
                Form1.Visible = True
            ElseIf (TextBox1.Text = "!epl361!") Then
                Form3.Initialize()
                Form3.Visible = True
            Else
                Label1.Visible = True
                Label3.Visible = True
                Label3.Text = Label3.Text + 1
            End If
        ElseIf (TextBox1.Text = "!epl361!") Then
            Label4.Visible = False
            Form3.Initialize()
            Form3.Visible = True
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class