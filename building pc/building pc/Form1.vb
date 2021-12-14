Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cpuchoice, hddchoice, oschoice, graphicschoice, monitorchoice, peripheralschoice As String
        Dim total As Integer
        total = 0.0
        cpuchoice = cbocpuchoice.Text
        cbocpuchoice.Items.Add("Intel pentium G4400")
        cbocpuchoice.Items.Add("Intel i7 4790")
        cbocpuchoice.Items.Add("AMD  A46300")

        If cpuchoice = cbocpuchoice.SelectedItem Then
            MessageBox.Show("CPU choice= Intel pentium G4400")
            total = total + 40.0
        ElseIf cpuchoice = cbocpuchoice.SelectedItem Then
            MessageBox.Show("CPU choice= Intel i7 4790")
            total = total + 60.0

        ElseIf cpuchoice = cbocpuchoice.SelectedItem Then
            MessageBox.Show("CPU choice= AMD  A46300")
            total = total + 90.0
        End If
        graphicschoice = cbographicschoice.Text
        cbographicschoice.Items.Add("rizen")
        cbographicschoice.Items.Add("g-force")
        cbographicschoice.Items.Add("intel")


        If graphicschoice = cbographicschoice.SelectedItem Then
            MessageBox.Show("Graphics choice choice= rizen")
            total = total + 540.0
        ElseIf graphicschoice = cbographicschoice.SelectedItem Then
            MessageBox.Show("Graphics choice= g-force")
            total = total + 660.0

        ElseIf graphicschoice = cbographicschoice.SelectedItem Then
            MessageBox.Show("Graphics choice= intel")
            total = total + 290.0
        End If
        hddchoice = cbohddchoice.Text
        cbohddchoice.Items.Add("HDD = 160GB")
        cbohddchoice.Items.Add("HDD = 250GB")
        cbohddchoice.Items.Add("HDD = 500GB")
        cbohddchoice.Items.Add("HDD = 1TB")


        If cbohddchoice = cbohddchoice.SelectedItem Then
            MessageBox.Show("HDD= 160GB")
            total = total + 240.0
        ElseIf hddchoice = cbohddchoice.SelectedItem Then
            MessageBox.Show("HDD = 250GB")
            total = total + 660.0

        ElseIf hddchoice = cbohddchoice.SelectedItem Then
            MessageBox.Show("HDD = 500GB")
            total = total + 470.0

        ElseIf hddchoice = cbohddchoice.SelectedItem Then
            MessageBox.Show("HDD = 1TB")
            total = total + 130
        End If
        oschoice = cbooschoice.Text
        cbooschoice.Items.Add("windows 7")
        cbooschoice.Items.Add("windows 8")
        cbooschoice.Items.Add("windows 11")
        cbooschoice.Items.Add("Linux")

        If oschoice = cbooschoice.SelectedItem Then
            MessageBox.Show("OS choice choice= Windows 7")
            total = total + 430.0
        ElseIf oschoice = cbooschoice.SelectedItem Then
            MessageBox.Show("OS choice= windows 8")
            total = total + 650.0

        ElseIf oschoice = cbooschoice.SelectedItem Then
            MessageBox.Show("OS choice= Windows 11")
            total = total + 500.0
        ElseIf oschoice = cbooschoice.SelectedItem Then
            MessageBox.Show("OS choice= Linux")
            total = total + 900.0

        End If
        monitorchoice = cbomonitorChoice.Text
        cbomonitorChoice.Items.Add("HD+ 1600*900")
        cbomonitorChoice.Items.Add("WSXGA 1280*1024")
        cbomonitorChoice.Items.Add("FHD 1920*1080")
        cbomonitorChoice.Items.Add("WUXGA 1920*1200")

        If monitorchoice = cbomonitorChoice.SelectedItem Then
            MessageBox.Show("Monitor choice = HD+ 1600*900")
            total = total + 150.0
        ElseIf monitorChoice = cbomonitorChoice.SelectedItem Then
            MessageBox.Show("monitor choice= WSXGA 1280*1024 ")
            total = total + 180.0

        ElseIf monitorChoice = cbomonitorChoice.SelectedItem Then
            MessageBox.Show("monitor choice= FHD 1920*1080 ")
            total = total + 170.0

        ElseIf monitorChoice = cbomonitorChoice.SelectedItem Then
            MessageBox.Show("monitor choice= WUXGA 1920*1200 ")
            total = total + 130.0
        End If
        peripheralschoice = cbocpuchoice.Text
        cboperipheralsChoice.Items.Add("inkjet")
        cboperipheralsChoice.Items.Add("DVD drive")
        cboperipheralsChoice.Items.Add("card reader")


        If peripheralschoice = cboperipheralsChoice.SelectedItem Then
            MessageBox.Show("peripheral choice = Inkjet")
            total = total + 40.0
        ElseIf peripheralsChoice = cboperipheralsChoice.SelectedItem Then
            MessageBox.Show("peripheral choice= DVD drive ")
            total = total + 35.0

        ElseIf peripheralsChoice = cboperipheralsChoice.SelectedItem Then
            MessageBox.Show("peripheral choice= Scanner ")
            total = total + 125.0

        ElseIf peripheralsChoice = cboperipheralsChoice.SelectedItem Then
            MessageBox.Show("peripheral choice= portable HDD ")
            total = total + 165.0
        ElseIf peripheralschoice = cboperipheralsChoice.SelectedItem Then
            MessageBox.Show("peripheral choice= card reader ")
            total = total + 15.0
        End If
        MessageBox.Show(cpuchoice + hddchoice + peripheralschoice + oschoice + graphicschoice + monitorchoice + "the total cost is:" + total)

    End Sub
End Class
