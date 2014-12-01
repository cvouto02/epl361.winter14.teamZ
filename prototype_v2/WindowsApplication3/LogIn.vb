Imports System.Drawing.Point

''' <summary>
''' Author: Saroj Gajraj
''' </summary>
''' <remarks></remarks>
''' 
Public Class LogIn
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Function Initialize()
        Form1.Visible = False
        Form3.Visible = False
        Label7.Visible = False
        Label6.Visible = False
        Label5.Visible = False
        Label6.Text = "0"
        txtPassword.Text = ""
        Return 1
    End Function

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PnlVirtualKeyboard = New System.Windows.Forms.Panel()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.txtUname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.PnlAlpha = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PnlVirtualKeyboard
        '
        Me.PnlVirtualKeyboard.Location = New System.Drawing.Point(12, 292)
        Me.PnlVirtualKeyboard.Name = "PnlVirtualKeyboard"
        Me.PnlVirtualKeyboard.Size = New System.Drawing.Size(931, 96)
        Me.PnlVirtualKeyboard.TabIndex = 16
        '
        'BtnOk
        '
        Me.BtnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOk.Location = New System.Drawing.Point(330, 65)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(81, 27)
        Me.BtnOk.TabIndex = 2
        Me.BtnOk.Text = "&Ok"
        '
        'txtUname
        '
        Me.txtUname.Location = New System.Drawing.Point(407, 3)
        Me.txtUname.Name = "txtUname"
        Me.txtUname.Size = New System.Drawing.Size(141, 20)
        Me.txtUname.TabIndex = 0
        Me.txtUname.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "User Name :"
        Me.Label1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(323, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 14)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password :"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(407, 29)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(141, 20)
        Me.txtPassword.TabIndex = 1
        '
        'BtnCancel
        '
        Me.BtnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(474, 65)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(81, 27)
        Me.BtnCancel.TabIndex = 3
        Me.BtnCancel.Text = "&Cancel"
        '
        'PnlAlpha
        '
        Me.PnlAlpha.Location = New System.Drawing.Point(12, 146)
        Me.PnlAlpha.Name = "PnlAlpha"
        Me.PnlAlpha.Size = New System.Drawing.Size(934, 146)
        Me.PnlAlpha.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(410, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(410, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 20)
        Me.Label4.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(395, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Insert Password"
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(480, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "0"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(395, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Wrong Password"
        Me.Label7.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(417, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 27)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "&DEL"
        '
        'LogIn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(958, 395)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PnlAlpha)
        Me.Controls.Add(Me.PnlVirtualKeyboard)
        Me.Controls.Add(Me.BtnOk)
        Me.Controls.Add(Me.txtUname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Name = "LogIn"
        Me.ShowIcon = False
        Me.Text = "LogIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim cnt As Long
    Dim myArray(9) As Long ''Array of Numbers
    Dim myAlphaArray(36) As Long ''Array of Alphabates
    Dim bolpassword As Boolean = False
    Dim bolUName As Boolean = False


    ''' <summary>
    ''' Executes when form loads
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''Load Random Numeric Buttons.
        GenerateRandomNumbers()

        ''Load Random Alphabate Buttons.
        GenerateRandomAlphabates()
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' On click of "OK" button. Username and password are validated. Displays appropriate message.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BtnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOk.Click
        'If (txtUname.Text.Trim = "123" And txtPassword.Text.Trim = "123") Then
        'MsgBox("Loggin successfull")
        'Else
        'MsgBox("Access Denied")
        'End If
        If (txtPassword.Text = "") Then
            Label5.Visible = True
        ElseIf (Label6.Text < "3") Then
            Label5.Visible = False
            If (txtPassword.Text = "EPL361") Then
                Form1.Initialize()
                Form1.Visible = True
            ElseIf (txtPassword.Text = "!EPL361!") Then
                Form3.Initialize()
                Form3.Visible = True
            Else
                Label7.Visible = True
                Label6.Visible = True
                Label6.Text = Label6.Text + 1
            End If
        ElseIf (txtPassword.Text = "!EPL361!") Then
            Label5.Visible = False
            Form3.Initialize()
            Form3.Visible = True
        Else
            Label5.Visible = False
        End If
        txtPassword.Text = ""
    End Sub

    ''' <summary>
    ''' Main Program to generate Random numbers.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GenerateRandomNumbers()
        For Me.cnt = 1 To UBound(myArray)
            myArray(cnt) = cnt
        Next
        ' RandomizeArray(myArray, 10, False)
        CreateButtons(PnlVirtualKeyboard, False, myArray)
    End Sub


    ''' <summary>
    ''' Dynamic button generation.
    ''' </summary>
    ''' <param name="pnl"></param>
    ''' <param name="Alpha"></param>
    ''' <param name="arr"></param>
    ''' <remarks></remarks>
    Sub CreateButtons(ByVal pnl As Panel, ByVal Alpha As Boolean, ByVal arr() As Long)
        Dim x As Integer = 4
        Dim y As Integer = 7
        Dim btn As Button
        Dim noOfBtn As Integer = 1

        For intRows As Integer = 0 To 3
            ''Reset x co-ordinaste for buttons
            x = 7
            For intColumns As Integer = 0 To 11
                ''Create instance of new button.
                btn = New Button()
                btn.FlatStyle = FlatStyle.Flat

                ''Add button to the appropriate panel.
                pnl.Controls.Add(btn)

                ''Set button location.
                btn.Location = New Point(x, y)

                ''Set button text
                btn.Text = IIf(Alpha, Chr(arr(pnl.Controls.GetChildIndex(btn))), arr(pnl.Controls.GetChildIndex(btn)))

                ''Add handler on CLick Event of all buttons.
                AddHandler btn.Click, AddressOf btn_Click

                ''Set x co-ordinate for next button
                x = x + 76

                ''Check wheather all buttons are created . if yes then exit.
                If noOfBtn = IIf(Alpha, 36, 10) Then Exit Sub Else noOfBtn += 1
            Next

            ''Set y co-ordinate for buttons.
            y = y + 29
        Next
    End Sub

    ''' <summary>
    ''' Used to fill alphabatical array values.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub GenerateRandomAlphabates()
        myAlphaArray(0) = 81
        myAlphaArray(1) = 87
        myAlphaArray(2) = 69
        myAlphaArray(3) = 82
        myAlphaArray(4) = 84
        myAlphaArray(5) = 89
        myAlphaArray(6) = 85
        myAlphaArray(7) = 73
        myAlphaArray(8) = 79
        myAlphaArray(9) = 80
        myAlphaArray(10) = 91
        myAlphaArray(11) = 93
        myAlphaArray(12) = 65
        myAlphaArray(13) = 83
        myAlphaArray(14) = 68
        myAlphaArray(15) = 70
        myAlphaArray(16) = 71
        myAlphaArray(17) = 72
        myAlphaArray(18) = 74
        myAlphaArray(19) = 75
        myAlphaArray(20) = 76
        myAlphaArray(21) = 59
        myAlphaArray(22) = 39
        myAlphaArray(23) = 92
        myAlphaArray(24) = 90
        myAlphaArray(25) = 88
        myAlphaArray(26) = 67
        myAlphaArray(27) = 86
        myAlphaArray(28) = 66
        myAlphaArray(29) = 78
        myAlphaArray(30) = 77
        myAlphaArray(31) = 33
        myAlphaArray(32) = 64
        myAlphaArray(33) = 35
        myAlphaArray(34) = 37
        myAlphaArray(35) = 94
        'RandomizeArray(myAlphaArray, 91, True)
        CreateButtons(PnlAlpha, True, myAlphaArray)
    End Sub


    ''' <summary>
    ''' Re-arrange array values to create random array.
    ''' </summary>
    ''' <param name="arr"></param>
    ''' <param name="maxval"></param>
    ''' <param name="alpha"></param>
    ''' <remarks></remarks>
    Private Sub RandomizeArray(ByVal arr() As Long, ByVal maxval As Integer, ByVal alpha As Boolean)
        Dim a As Integer
        Dim intrnd As New Random

        For i As Integer = 0 To IIf(alpha, 25, 9)
regen:
            a = intrnd.Next(IIf(alpha, 65, 0), maxval)

            ''If a random no already exists then create a new random no.
            If Not alreadyExists(a, i, arr) Then arr(i) = a Else GoTo regen
        Next
    End Sub

    ''' <summary>
    ''' Check wheather newly created random number already exists in the array or not.
    ''' </summary>
    ''' <param name="no"></param>
    ''' <param name="indx"></param>
    ''' <param name="arr"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function alreadyExists(ByVal no As Integer, ByVal indx As Integer, ByVal arr() As Long) As Boolean
        If indx = 0 Then Return False
        For i As Integer = 0 To indx
            If no = arr(i) Then
                Return True
            End If
        Next
        Return False
    End Function

    ''' <summary>
    ''' Delegate for all Button click.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ShowNumber(Char.Parse(CType(sender, Button).Text.Trim))
    End Sub

    ''' <summary>
    '''  Show button value into the textbox.
    ''' </summary>
    ''' <param name="ch"></param>
    ''' <remarks></remarks>
    Sub ShowNumber(ByVal ch As Char)
        If bolUName Then
            txtUname.Text = txtUname.Text + ch
            txtUname.Focus()
        ElseIf bolpassword Then
            txtPassword.Text = txtPassword.Text + ch
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        bolpassword = True
        bolUName = False
    End Sub

    Private Sub txtUname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUname.GotFocus
        bolUName = True
        bolpassword = False
    End Sub

    Private Sub PnlAlpha_Paint(sender As Object, e As PaintEventArgs) Handles PnlAlpha.Paint

    End Sub

    Private Sub txtUname_TextChanged(sender As Object, e As EventArgs) Handles txtUname.TextChanged

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtPassword.Text.Length <> 0 Then
            txtPassword.Text = txtPassword.Text.Substring(0, txtPassword.Text.Length - 1)
        End If
    End Sub
End Class
