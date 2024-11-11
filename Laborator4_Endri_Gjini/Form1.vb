Public Class Form1
    Dim num As Double
    Dim name As String
    Dim pressed As Boolean = False
    Dim dot As Boolean = False



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Prevent resizing
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button10.Click, Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click

        Dim clickedButton As Button = CType(sender, Button)
        TextBox1.Text += clickedButton.Text
        pressed = False

    End Sub

    Private Sub Button_Arithmetic_Click(sender As Object, e As EventArgs) Handles Button15.Click, Button13.Click, Button17.Click, Button14.Click, Button20.Click
        If TextBox1.Text = "" Then
            Return
        End If

        If pressed Then
            Return

        End If
        num = TextBox1.Text
        name = CType(sender, Button).Name
        TextBox1.Text = ""
        pressed = True
        dot = False

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Select Case name
            Case "Button15"
                TextBox1.Text = num + TextBox1.Text
            Case "Button14"
                TextBox1.Text = num - TextBox1.Text
            Case "Button13"
                TextBox1.Text = num * TextBox1.Text
            Case "Button17"
                TextBox1.Text = num / TextBox1.Text
            Case "Button20"
                TextBox1.Text = Math.Pow(num, TextBox1.Text)

        End Select
        name = ""
        dot = False


    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If dot Then
            Return
        End If
        If TextBox1.Text = "" Then
            TextBox1.Text += "0."
        Else
            TextBox1.Text += "."
        End If
        dot = True


    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = ""
        name = ""
        dot = False
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If TextBox1.Text = "" Then
            Return
        End If
        TextBox1.Text *= TextBox1.Text
        dot = False
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If TextBox1.Text = "" Then
            Return
        End If
        TextBox1.Text = Math.Sqrt(TextBox1.Text)
        dot = False
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True
        End If
        dot = False
    End Sub


End Class
