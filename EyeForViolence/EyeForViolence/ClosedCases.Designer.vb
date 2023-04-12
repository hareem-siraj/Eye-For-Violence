<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClosedCases
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.crimeCombobox = New System.Windows.Forms.ComboBox()
        Me.radioCrime = New System.Windows.Forms.RadioButton()
        Me.arrestTextbox = New System.Windows.Forms.TextBox()
        Me.arrestRadio = New System.Windows.Forms.RadioButton()
        Me.dateTextbox = New System.Windows.Forms.TextBox()
        Me.dateRadio = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Maroon
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 28)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(568, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 44)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "CLOSED CASES"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EyeForViolence.My.Resources.Resources.EyeForViolence_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(843, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'crimeCombobox
        '
        Me.crimeCombobox.Enabled = False
        Me.crimeCombobox.FormattingEnabled = True
        Me.crimeCombobox.Location = New System.Drawing.Point(682, 354)
        Me.crimeCombobox.Name = "crimeCombobox"
        Me.crimeCombobox.Size = New System.Drawing.Size(195, 23)
        Me.crimeCombobox.TabIndex = 75
        '
        'radioCrime
        '
        Me.radioCrime.AutoSize = True
        Me.radioCrime.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioCrime.ForeColor = System.Drawing.Color.White
        Me.radioCrime.Location = New System.Drawing.Point(573, 351)
        Me.radioCrime.Name = "radioCrime"
        Me.radioCrime.Size = New System.Drawing.Size(103, 26)
        Me.radioCrime.TabIndex = 74
        Me.radioCrime.TabStop = True
        Me.radioCrime.Text = "By Crime:"
        Me.radioCrime.UseVisualStyleBackColor = True
        '
        'arrestTextbox
        '
        Me.arrestTextbox.Enabled = False
        Me.arrestTextbox.Location = New System.Drawing.Point(743, 266)
        Me.arrestTextbox.Name = "arrestTextbox"
        Me.arrestTextbox.Size = New System.Drawing.Size(195, 23)
        Me.arrestTextbox.TabIndex = 73
        Me.arrestTextbox.Text = "DD/MM/YYYY"
        '
        'arrestRadio
        '
        Me.arrestRadio.AutoSize = True
        Me.arrestRadio.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.arrestRadio.ForeColor = System.Drawing.Color.White
        Me.arrestRadio.Location = New System.Drawing.Point(573, 263)
        Me.arrestRadio.Name = "arrestRadio"
        Me.arrestRadio.Size = New System.Drawing.Size(168, 26)
        Me.arrestRadio.TabIndex = 72
        Me.arrestRadio.TabStop = True
        Me.arrestRadio.Text = "By Assigning Date:"
        Me.arrestRadio.UseVisualStyleBackColor = True
        '
        'dateTextbox
        '
        Me.dateTextbox.Enabled = False
        Me.dateTextbox.Location = New System.Drawing.Point(736, 222)
        Me.dateTextbox.Name = "dateTextbox"
        Me.dateTextbox.Size = New System.Drawing.Size(195, 23)
        Me.dateTextbox.TabIndex = 71
        Me.dateTextbox.Text = "Enter suspect name..."
        '
        'dateRadio
        '
        Me.dateRadio.AutoSize = True
        Me.dateRadio.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dateRadio.ForeColor = System.Drawing.Color.White
        Me.dateRadio.Location = New System.Drawing.Point(573, 219)
        Me.dateRadio.Name = "dateRadio"
        Me.dateRadio.Size = New System.Drawing.Size(157, 26)
        Me.dateRadio.TabIndex = 70
        Me.dateRadio.TabStop = True
        Me.dateRadio.Text = "By Main Suspect:"
        Me.dateRadio.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Maroon
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(408, 566)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 28)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "VIEW CASE DETAILS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Maroon
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(12, 566)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 28)
        Me.Button4.TabIndex = 68
        Me.Button4.Text = "LOG NEW CASE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(876, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 28)
        Me.Button2.TabIndex = 67
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(573, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 28)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "FILTER SEARCH:"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(12, 165)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(545, 395)
        Me.ListBox1.TabIndex = 65
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(743, 309)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 23)
        Me.TextBox1.TabIndex = 77
        Me.TextBox1.Text = "DD/MM/YYYY"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(573, 306)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(152, 26)
        Me.RadioButton1.TabIndex = 76
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "By Closing Date:"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ClosedCases
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(967, 661)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.crimeCombobox)
        Me.Controls.Add(Me.radioCrime)
        Me.Controls.Add(Me.arrestTextbox)
        Me.Controls.Add(Me.arrestRadio)
        Me.Controls.Add(Me.dateTextbox)
        Me.Controls.Add(Me.dateRadio)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ClosedCases"
        Me.Text = "Closed Cases - Me"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents crimeCombobox As ComboBox
    Friend WithEvents radioCrime As RadioButton
    Friend WithEvents arrestTextbox As TextBox
    Friend WithEvents arrestRadio As RadioButton
    Friend WithEvents dateTextbox As TextBox
    Friend WithEvents dateRadio As RadioButton
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
End Class
