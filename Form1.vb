Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const IPhone As Integer = 5000
        Const Samsung As Integer = 4500
        Const Huawei As Integer = 3500
        Const Xiaomi As Integer = 2500
        Const Vivo As Integer = 3000
        Const Oppo As Integer = 3399
        Dim sum As Integer
        If CheckBox1.Checked = True Then
            sum += IPhone

        End If
        If CheckBox2.Checked = True Then
            sum += Samsung

        End If
        If CheckBox3.Checked = True Then
            sum += Huawei
        End If
        If CheckBox4.Checked = True Then
            sum += Xiaomi

        End If
        If CheckBox5.Checked = True Then
            sum += Vivo

        End If
        If CheckBox6.Checked = True Then
            sum += Oppo
        End If
        LblTotal.Text = sum.ToString("C")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
    End Sub
End Class
