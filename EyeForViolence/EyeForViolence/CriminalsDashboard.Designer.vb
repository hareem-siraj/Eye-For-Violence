<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CriminalsDashboard
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.radioName = New System.Windows.Forms.RadioButton()
        Me.nameTextbox = New System.Windows.Forms.TextBox()
        Me.radioCrime = New System.Windows.Forms.RadioButton()
        Me.crimeCombobox = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dateTextbox = New System.Windows.Forms.TextBox()
        Me.dateRadio = New System.Windows.Forms.RadioButton()
        Me.arrestTextbox = New System.Windows.Forms.TextBox()
        Me.arrestRadio = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radioNB = New System.Windows.Forms.RadioButton()
        Me.radioFemale = New System.Windows.Forms.RadioButton()
        Me.radioMale = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(611, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 44)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "CRIMINALS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EyeForViolence.My.Resources.Resources.EyeForViolence_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(829, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
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
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(12, 160)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(546, 463)
        Me.ListBox1.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(579, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 28)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "FILTER SEARCH:"
        '
        'radioName
        '
        Me.radioName.AutoSize = True
        Me.radioName.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioName.Location = New System.Drawing.Point(579, 210)
        Me.radioName.Name = "radioName"
        Me.radioName.Size = New System.Drawing.Size(100, 26)
        Me.radioName.TabIndex = 15
        Me.radioName.TabStop = True
        Me.radioName.Text = "By Name:"
        Me.radioName.UseVisualStyleBackColor = True
        '
        'nameTextbox
        '
        Me.nameTextbox.Enabled = False
        Me.nameTextbox.Location = New System.Drawing.Point(685, 210)
        Me.nameTextbox.Name = "nameTextbox"
        Me.nameTextbox.Size = New System.Drawing.Size(195, 23)
        Me.nameTextbox.TabIndex = 16
        Me.nameTextbox.Text = "Enter name..."
        '
        'radioCrime
        '
        Me.radioCrime.AutoSize = True
        Me.radioCrime.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioCrime.Location = New System.Drawing.Point(579, 291)
        Me.radioCrime.Name = "radioCrime"
        Me.radioCrime.Size = New System.Drawing.Size(103, 26)
        Me.radioCrime.TabIndex = 17
        Me.radioCrime.TabStop = True
        Me.radioCrime.Text = "By Crime:"
        Me.radioCrime.UseVisualStyleBackColor = True
        '
        'crimeCombobox
        '
        Me.crimeCombobox.Enabled = False
        Me.crimeCombobox.FormattingEnabled = True
        Me.crimeCombobox.Location = New System.Drawing.Point(685, 294)
        Me.crimeCombobox.Name = "crimeCombobox"
        Me.crimeCombobox.Size = New System.Drawing.Size(195, 23)
        Me.crimeCombobox.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(879, 160)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 28)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'dateTextbox
        '
        Me.dateTextbox.Enabled = False
        Me.dateTextbox.Location = New System.Drawing.Point(703, 458)
        Me.dateTextbox.Name = "dateTextbox"
        Me.dateTextbox.Size = New System.Drawing.Size(195, 23)
        Me.dateTextbox.TabIndex = 22
        Me.dateTextbox.Text = "DD/MM/YYYY"
        '
        'dateRadio
        '
        Me.dateRadio.AutoSize = True
        Me.dateRadio.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dateRadio.Location = New System.Drawing.Point(579, 455)
        Me.dateRadio.Name = "dateRadio"
        Me.dateRadio.Size = New System.Drawing.Size(118, 26)
        Me.dateRadio.TabIndex = 21
        Me.dateRadio.TabStop = True
        Me.dateRadio.Text = "Arrest Date:"
        Me.dateRadio.UseVisualStyleBackColor = True
        '
        'arrestTextbox
        '
        Me.arrestTextbox.Enabled = False
        Me.arrestTextbox.Location = New System.Drawing.Point(741, 502)
        Me.arrestTextbox.Name = "arrestTextbox"
        Me.arrestTextbox.Size = New System.Drawing.Size(195, 23)
        Me.arrestTextbox.TabIndex = 24
        Me.arrestTextbox.Text = "Enter arrest officer name..."
        '
        'arrestRadio
        '
        Me.arrestRadio.AutoSize = True
        Me.arrestRadio.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.arrestRadio.Location = New System.Drawing.Point(579, 499)
        Me.arrestRadio.Name = "arrestRadio"
        Me.arrestRadio.Size = New System.Drawing.Size(156, 26)
        Me.arrestRadio.TabIndex = 23
        Me.arrestRadio.TabStop = True
        Me.arrestRadio.Text = "By Arrest Officer:"
        Me.arrestRadio.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Maroon
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(434, 638)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 28)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "VIEW CRIMINAL"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Maroon
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(12, 638)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 28)
        Me.Button4.TabIndex = 26
        Me.Button4.Text = "ADD RECORD"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(739, 251)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(195, 23)
        Me.TextBox1.TabIndex = 28
        Me.TextBox1.Text = "Enter criminal's NIC number..."
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RadioButton1.Location = New System.Drawing.Point(579, 248)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(154, 26)
        Me.RadioButton1.TabIndex = 27
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "By NIC Number:"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radioNB)
        Me.GroupBox2.Controls.Add(Me.radioFemale)
        Me.GroupBox2.Controls.Add(Me.radioMale)
        Me.GroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(634, 332)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 104)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gender"
        '
        'radioNB
        '
        Me.radioNB.AutoSize = True
        Me.radioNB.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioNB.Location = New System.Drawing.Point(19, 60)
        Me.radioNB.Name = "radioNB"
        Me.radioNB.Size = New System.Drawing.Size(115, 26)
        Me.radioNB.TabIndex = 20
        Me.radioNB.TabStop = True
        Me.radioNB.Text = "Non-Binary"
        Me.radioNB.UseVisualStyleBackColor = True
        '
        'radioFemale
        '
        Me.radioFemale.AutoSize = True
        Me.radioFemale.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioFemale.Location = New System.Drawing.Point(110, 28)
        Me.radioFemale.Name = "radioFemale"
        Me.radioFemale.Size = New System.Drawing.Size(81, 26)
        Me.radioFemale.TabIndex = 19
        Me.radioFemale.TabStop = True
        Me.radioFemale.Text = "Female"
        Me.radioFemale.UseVisualStyleBackColor = True
        '
        'radioMale
        '
        Me.radioMale.AutoSize = True
        Me.radioMale.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioMale.Location = New System.Drawing.Point(19, 28)
        Me.radioMale.Name = "radioMale"
        Me.radioMale.Size = New System.Drawing.Size(65, 26)
        Me.radioMale.TabIndex = 18
        Me.radioMale.TabStop = True
        Me.radioMale.Text = "Male"
        Me.radioMale.UseVisualStyleBackColor = True
        '
        'CriminalsDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(953, 731)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.arrestTextbox)
        Me.Controls.Add(Me.arrestRadio)
        Me.Controls.Add(Me.dateTextbox)
        Me.Controls.Add(Me.dateRadio)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.crimeCombobox)
        Me.Controls.Add(Me.radioCrime)
        Me.Controls.Add(Me.nameTextbox)
        Me.Controls.Add(Me.radioName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "CriminalsDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Criminals"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents radioName As RadioButton
    Friend WithEvents nameTextbox As TextBox
    Friend WithEvents radioCrime As RadioButton
    Friend WithEvents crimeCombobox As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents dateTextbox As TextBox
    Friend WithEvents dateRadio As RadioButton
    Friend WithEvents arrestTextbox As TextBox
    Friend WithEvents arrestRadio As RadioButton
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radioFemale As RadioButton
    Friend WithEvents radioMale As RadioButton
    Friend WithEvents radioNB As RadioButton
End Class
