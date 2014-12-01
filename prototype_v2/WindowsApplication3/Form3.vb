Public Class Form3
    Public Function Initialize()
        LogIn.Visible = False
        Form2.Visible = False
        Form4.Visible = False
        Form6.Visible = False
        Form7.Visible = False
        Form8.Visible = False
        Form9.Visible = False
        Return 1
    End Function

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        LogIn.Initialize()
        LogIn.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form4.Initialize()
        Form4.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form6.Initialize()
        Form6.Visible = True
    End Sub

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        End
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form7.Initialize()
        Form7.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form8.Initialize()
        Form8.VAT5()
        Form8.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form8.Initialize()
        Form8.VAT19()
        Form8.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form8.Initialize()
        Form8.DAILY()
        Form8.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form8.Initialize()
        Form8.MONTHLY()
        Form8.Visible = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form9.Initialize()
        Form9.Visible = True
    End Sub
End Class