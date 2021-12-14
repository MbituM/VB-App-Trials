Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim np As String
        Dim adult, child As String
        Dim total As Integer
        Dim cost As String
        Dim choice As String
        Dim nadult, nchild As Integer
        Dim output As String

        output = lbloutput.Text

        choice = "Your Selected Plan is : " + vbCr + vbCr
        adult = "0"
        child = "0"
        total = 0
        nchild = 0
        nadult = 0

        adult = cboadult.Text
        cboadult.Items.Add("1")
        cboadult.Items.Add("2")
        cboadult.Items.Add("3")
        cboadult.Items.Add("4")

        If adult = "1" Then
            nadult = 1
        ElseIf adult = "2" Then
            nadult = 2
        ElseIf adult = "3" Then
            nadult = 3
        ElseIf adult = "4" Then
            nadult = 4
        End If

        child = cbochild.Text
        cbochild.Items.Add("1")
        cbochild.Items.Add("2")
        cbochild.Items.Add("3")
        cbochild.Items.Add("4")

        If child = "1" Then
            nchild = 1
        ElseIf child = "2" Then
            nchild = 2
        ElseIf child = "3" Then
            nchild = 3
        ElseIf child = "4" Then
            nchild = 4
        End If

        Try
            If adult = "0" Then
                MsgBox("There must be at least one adult")
            End If
        Catch ex As Exception

        End Try

        np = cbonp.Text
        cbonp.Items.Add("Regular Healthy Eating Plan ($50 pcm/adult)($35 pcm/child)")
        cbonp.Items.Add("Weightlifter Eating Plan ($80 pcm/adult)")
        cbonp.Items.Add("Endurance Trainer Eating Plan ($70 pcm/adult)")
        cbonp.Items.Add("Gluten Free Healthy Eating Plan ($55 pcm/adult)($40 pcm/child)")
        cbonp.Items.Add("Gluten Free Weightlifter Eating Plan ($85 pcm/adult)")
        cbonp.Items.Add("Gluten Free Endurance Trainer Eating Plan ($75 pcm/adult)")
        cbonp.Items.Add("Vegetarian Healthy Eating Plan ($50 pcm/adult)($35 pcm/child)")
        cbonp.Items.Add("Vegeterian Weightlifter Eating Plan ($80 pcm/adult)")
        cbonp.Items.Add("Vegeterian Endurance Trainer Eating Plan ($70 pcm/adult)")

        If np = "Regular Healthy Eating Plan ($50 pcm/adult)($35 pcm/child)" Then
            choice = choice + "Regular Healthy Eating Plan ($50 pcm/adult)($35 pcm/child)"
            total = total + (nadult * 50) + (nchild * 35)
        ElseIf np = "Weightlifter Eating Plan ($80 pcm/adult)" Then
            choice = choice + "Weightlifter Eating Plan ($80 pcm/adult)"
            total = total + (nadult * 50) + (nchild * 35)
        ElseIf np = "Endurance Trainer Eating Plan ($70 pcm/adult)" Then
            choice = choice + "Endurance Trainer Eating Plan ($70 pcm/adult)"
            total = total + (nadult * 50) + (nchild * 35)
        ElseIf np = "Gluten Free Healthy Eating Plan ($55 pcm/adult)($40 pcm/child)" Then
            choice = choice + "Gluten Free Healthy Eating Plan ($55 pcm/adult)($40 pcm/child)"
            total = total + (nadult * 50) + (nchild * 35)
        ElseIf np = "Gluten Free Weightlifter Eating Plan ($85 pcm/adult)" Then
            choice = choice + "Gluten Free Weightlifter Eating Plan ($85 pcm/adult)"
            total = total + (nadult * 50) + (nchild * 35)
        ElseIf np = "Gluten Free Endurance Trainer Eating Plan ($75 pcm/adult)" Then
            choice = choice + "Gluten Free Endurance Trainer Eating Plan ($75 pcm/adult)"
            total = total + (nadult * 50) + (nchild * 35)
        ElseIf np = "Vegetarian Healthy Eating Plan ($50 pcm/adult)($35 pcm/child)" Then
            choice = choice + "Vegetarian Healthy Eating Plan ($50 pcm/adult)($35 pcm/child)"
            total = total + (nadult * 50) + (nchild * 35)
        ElseIf np = "Vegeterian Weightlifter Eating Plan ($80 pcm/adult)" Then
            choice = choice + "Vegeterian Weightlifter Eating Plan ($80 pcm/adult)"
            total = total + (nadult * 50) + (nchild * 35)
        ElseIf np = "Vegeterian Endurance Trainer Eating Plan ($70 pcm/adult)" Then
            choice = choice + "Vegeterian Endurance Trainer Eating Plan ($70 pcm/adult)"
            total = total + (nadult * 50) + (nchild * 35)
        End If

        cost = total
        MsgBox("For " & nadult & " adult's' and " & nchild & " kid's'" & vbCr & choice & vbCr & "The Total Cost is : " & total)

    End Sub
End Class
