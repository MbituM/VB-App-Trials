<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cbooschoice = New System.Windows.Forms.ComboBox()
        Me.cbomonitorChoice = New System.Windows.Forms.ComboBox()
        Me.cbohddchoice = New System.Windows.Forms.ComboBox()
        Me.cbographicschoice = New System.Windows.Forms.ComboBox()
        Me.cbocpuchoice = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboperipheralsChoice = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(86, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Total"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cbooschoice
        '
        Me.cbooschoice.FormattingEnabled = True
        Me.cbooschoice.Items.AddRange(New Object() {"windows 7", "windows 8", "windows 10", "windows 11", "Linux"})
        Me.cbooschoice.Location = New System.Drawing.Point(157, 85)
        Me.cbooschoice.Name = "cbooschoice"
        Me.cbooschoice.Size = New System.Drawing.Size(121, 21)
        Me.cbooschoice.TabIndex = 2
        '
        'cbomonitorChoice
        '
        Me.cbomonitorChoice.FormattingEnabled = True
        Me.cbomonitorChoice.Items.AddRange(New Object() {"HD+1600*900", "WSXGA1280*1024", "FHD1920*1080", "WUXGA1920*1200"})
        Me.cbomonitorChoice.Location = New System.Drawing.Point(157, 121)
        Me.cbomonitorChoice.Name = "cbomonitorChoice"
        Me.cbomonitorChoice.Size = New System.Drawing.Size(121, 21)
        Me.cbomonitorChoice.TabIndex = 4
        '
        'cbohddchoice
        '
        Me.cbohddchoice.FormattingEnabled = True
        Me.cbohddchoice.Items.AddRange(New Object() {"160GB", "250GB", "500GB", "1TB"})
        Me.cbohddchoice.Location = New System.Drawing.Point(157, 58)
        Me.cbohddchoice.Name = "cbohddchoice"
        Me.cbohddchoice.Size = New System.Drawing.Size(121, 21)
        Me.cbohddchoice.TabIndex = 1
        '
        'cbographicschoice
        '
        Me.cbographicschoice.FormattingEnabled = True
        Me.cbographicschoice.Items.AddRange(New Object() {"rizen ", "g-force", "intel", ""})
        Me.cbographicschoice.Location = New System.Drawing.Point(157, 31)
        Me.cbographicschoice.Name = "cbographicschoice"
        Me.cbographicschoice.Size = New System.Drawing.Size(121, 21)
        Me.cbographicschoice.TabIndex = 5
        '
        'cbocpuchoice
        '
        Me.cbocpuchoice.FormattingEnabled = True
        Me.cbocpuchoice.Items.AddRange(New Object() {"intel pentium G4400", "intel i7 4790", "AMD  A46300"})
        Me.cbocpuchoice.Location = New System.Drawing.Point(157, 4)
        Me.cbocpuchoice.Name = "cbocpuchoice"
        Me.cbocpuchoice.Size = New System.Drawing.Size(121, 21)
        Me.cbocpuchoice.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CPU"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "GRAPICS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "HDD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "OS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "MONITOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "peripherals"
        '
        'cboperipheralsChoice
        '
        Me.cboperipheralsChoice.FormattingEnabled = True
        Me.cboperipheralsChoice.Items.AddRange(New Object() {"portableHDD", "DVD", "inkjet printer", "scanner", "card reader"})
        Me.cboperipheralsChoice.Location = New System.Drawing.Point(157, 163)
        Me.cboperipheralsChoice.Name = "cboperipheralsChoice"
        Me.cboperipheralsChoice.Size = New System.Drawing.Size(121, 21)
        Me.cboperipheralsChoice.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cboperipheralsChoice)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbohddchoice)
        Me.Controls.Add(Me.cbomonitorChoice)
        Me.Controls.Add(Me.cbographicschoice)
        Me.Controls.Add(Me.cbooschoice)
        Me.Controls.Add(Me.cbocpuchoice)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Shonky computers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents cbooschoice As ComboBox
    Friend WithEvents cbomonitorChoice As ComboBox
    Friend WithEvents cbohddchoice As ComboBox
    Friend WithEvents cbographicschoice As ComboBox
    Friend WithEvents cbocpuchoice As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboperipheralsChoice As ComboBox
End Class
