Public Class Form5
    Public Function Initialize(cost)
        Form2.Visible = False
        Form3.Visible = False
        Form1.Visible = False
        Button20.Visible = False
        Button100.Visible = True
        Label3.Text = cost
        TextBox1.Text = ""
        Label2.Text = "0.00"
        Label6.Visible = False
        Return 1
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button100_Click(sender As Object, e As EventArgs) Handles Button100.Click
        If (TextBox1.Text = "") Then
            Label2.Text = "0.00"
            Label6.Visible = False
            Button100.Visible = False
            Button20.Visible = True
        ElseIf (CDec(TextBox1.Text) - CDec(Label3.Text) < 0) Then
            Label6.Visible = True
        Else
            Label6.Visible = False
            Label2.Text = Math.Round(TextBox1.Text - Label3.Text, 2, MidpointRounding.AwayFromZero)
            Button100.Visible = False
            Button20.Visible = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Form1.Initialize()
        Form1.Visible = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = TextBox1.Text + "2"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox1.Text = TextBox1.Text + "3"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        TextBox1.Text = TextBox1.Text + "4"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        TextBox1.Text = TextBox1.Text + "5"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        TextBox1.Text = TextBox1.Text + "6"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        TextBox1.Text = TextBox1.Text + "7"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        TextBox1.Text = TextBox1.Text + "8"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

        TextBox1.Text = TextBox1.Text + "9"

    End Sub


    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
            If TextBox1.Text <> "" Then
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
            End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + ","
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class