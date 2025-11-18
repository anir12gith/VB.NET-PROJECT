Public Class Form1
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        GroupBox3.Hide()
        GroupBox4.Hide()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter
        Label1.ForeColor = Color.LightGray
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.ForeColor = Color.White
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter
        Label2.ForeColor = Color.LightGray
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.White
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As EventArgs) Handles Label3.MouseEnter
        Label3.ForeColor = Color.LightGray
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.White
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As EventArgs) Handles Label4.MouseEnter
        Label4.ForeColor = Color.LightGray
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.White
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        GroupBox3.Show()
        GroupBox4.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox3.Hide()
        Button1.Hide()
        GroupBox4.Hide()
        GroupBox5.Hide()
        Button14.Hide()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
    End Sub

    Private Sub CheckBoxes_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged, CheckBox2.CheckedChanged, CheckBox3.CheckedChanged, CheckBox4.CheckedChanged, CheckBox5.CheckedChanged, CheckBox6.CheckedChanged, CheckBox7.CheckedChanged, CheckBox8.CheckedChanged, CheckBox9.CheckedChanged, CheckBox10.CheckedChanged, CheckBox11.CheckedChanged, CheckBox12.CheckedChanged, CheckBox13.CheckedChanged, CheckBox14.CheckedChanged, CheckBox15.CheckedChanged, CheckBox16.CheckedChanged, CheckBox17.CheckedChanged, CheckBox18.CheckedChanged
        Dim price As Integer
        Dim total As Integer
        If CheckBox1.Checked = True Then
            price += 55
        End If
        If CheckBox2.Checked = True Then
            price += 45
        End If
        If CheckBox3.Checked = True Then
            price += 24
        End If
        If CheckBox4.Checked = True Then
            price += 60
        End If
        If CheckBox5.Checked = True Then
            price += 16
        End If
        If CheckBox6.Checked = True Then
            price += 25
        End If


        If CheckBox7.Checked = True Then
            price += 35
        End If
        If CheckBox8.Checked = True Then
            price += 50
        End If
        If CheckBox9.Checked = True Then
            price += 40
        End If
        If CheckBox10.Checked = True Then
            price += 25
        End If
        If CheckBox11.Checked = True Then
            price += 30
        End If
        If CheckBox12.Checked = True Then
            price += 27
        End If
        If CheckBox13.Checked = True Then
            price += 10
        End If
        If CheckBox14.Checked = True Then
            price += 30
        End If
        If CheckBox15.Checked = True Then
            price += 17
        End If
        If CheckBox16.Checked = True Then
            price += 25
        End If
        If CheckBox17.Checked = True Then
            price += 20
        End If
        If CheckBox18.Checked = True Then
            price += 20
        End If


        total = price
        Label6.Text = "TOTAL : " & total & "DH"

        If total > 0 Then
            Button1.Show()
            Button14.Show()
        Else
            Button1.Hide()
            Button14.Hide()
        End If

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Label6.Text = "TOTAL : 0DH"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        GroupBox3.Hide()
        GroupBox4.Show()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        GroupBox5.Show()
        PictureBox25.Show()
        PictureBox26.Show()
        PictureBox27.Show()
        PictureBox24.ImageLocation = "C:\Users\Admin\Desktop\vbapp\coca.png"
        GroupBox5.BackColor = Color.Red
        Label43.Text = "Coca Cola"
        Label43.BackColor = Color.Red
        Label44.BackColor = Color.Red
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        PictureBox24.ImageLocation = "C:\Users\Admin\Desktop\vbapp\sprite.png"
        GroupBox5.BackColor = Color.Green
        Label43.Text = "Sprite Canette"
        Label43.BackColor = Color.Green
        Label44.BackColor = Color.Green
    End Sub

    Private Sub Button21_Click_1(sender As Object, e As EventArgs) Handles Button21.Click
        GroupBox5.Hide()
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        PictureBox24.ImageLocation = "C:\Users\Admin\Desktop\vbapp\fanta.png"
        GroupBox5.BackColor = Color.Orange
        Label43.Text = "Fanta Canette"
        Label43.BackColor = Color.Orange
        Label44.BackColor = Color.Orange
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        PictureBox24.ImageLocation = "C:\Users\Admin\Desktop\vbapp\coca.png"
        GroupBox5.BackColor = Color.Red
        Label43.Text = "Coca Cola"
        Label43.BackColor = Color.Red
        Label44.BackColor = Color.Red
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        GroupBox5.Show()
        PictureBox24.ImageLocation = "C:\Users\Admin\Desktop\vbapp\mokhito.png"
        GroupBox5.BackColor = Color.LightGreen
        Label43.Text = "Mokhito"
        Label44.Text = "Price : 30DH"
        Label43.BackColor = Color.LightGreen
        Label44.BackColor = Color.LightGreen
        PictureBox25.Hide()
        PictureBox26.Hide()
        PictureBox27.Hide()

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        GroupBox5.Show()
        PictureBox24.ImageLocation = "C:\Users\Admin\Desktop\vbapp\orange.png"
        GroupBox5.BackColor = Color.OrangeRed
        Label43.Text = "Orange"
        Label44.Text = "Price : 17DH"
        Label43.BackColor = Color.OrangeRed
        Label44.BackColor = Color.OrangeRed
        PictureBox25.Hide()
        PictureBox26.Hide()
        PictureBox27.Hide()
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        GroupBox5.Show()
        PictureBox24.ImageLocation = "C:\Users\Admin\Desktop\vbapp\panachi.png"
        GroupBox5.BackColor = Color.DarkRed
        Label43.Text = "Panachi"
        Label44.Text = "Price : 20DH"
        Label43.BackColor = Color.DarkRed
        Label44.BackColor = Color.DarkRed
        PictureBox25.Hide()
        PictureBox26.Hide()
        PictureBox27.Hide()
    End Sub
End Class
