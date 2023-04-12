<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CasesDashboard
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.arrestTextbox = New System.Windows.Forms.TextBox()
        Me.arrestRadio = New System.Windows.Forms.RadioButton()
        Me.dateTextbox = New System.Windows.Forms.TextBox()
        Me.dateRadio = New System.Windows.Forms.RadioButton()
        Me.areaTextbox = New System.Windows.Forms.TextBox()
        Me.radioArea = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioClosed = New System.Windows.Forms.RadioButton()
        Me.radioActive = New System.Windows.Forms.RadioButton()
        Me.crimeCombobox = New System.Windows.Forms.ComboBox()
        Me.radioCrime = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(454, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(366, 44)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "DEPARTMENT CASES"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EyeForViolence.My.Resources.Resources.EyeForViolence_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(826, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(12, 167)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(545, 395)
        Me.ListBox1.TabIndex = 19
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Maroon
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(876, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(62, 28)
        Me.Button2.TabIndex = 33
        Me.Button2.Text = "RESET"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(573, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 28)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "FILTER SEARCH:"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Maroon
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(12, 568)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 28)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "LOG NEW CASE"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Maroon
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(408, 568)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 28)
        Me.Button3.TabIndex = 39
        Me.Button3.Text = "VIEW CASE DETAILS"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'arrestTextbox
        '
        Me.arrestTextbox.Enabled = False
        Me.arrestTextbox.Location = New System.Drawing.Point(743, 309)
        Me.arrestTextbox.Name = "arrestTextbox"
        Me.arrestTextbox.Size = New System.Drawing.Size(195, 23)
        Me.arrestTextbox.TabIndex = 47
        Me.arrestTextbox.Text = "DD/MM/YYYY"
        '
        'arrestRadio
        '
        Me.arrestRadio.AutoSize = True
        Me.arrestRadio.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.arrestRadio.ForeColor = System.Drawing.Color.White
        Me.arrestRadio.Location = New System.Drawing.Point(573, 306)
        Me.arrestRadio.Name = "arrestRadio"
        Me.arrestRadio.Size = New System.Drawing.Size(168, 26)
        Me.arrestRadio.TabIndex = 46
        Me.arrestRadio.TabStop = True
        Me.arrestRadio.Text = "By Assigning Date:"
        Me.arrestRadio.UseVisualStyleBackColor = True
        '
        'dateTextbox
        '
        Me.dateTextbox.Enabled = False
        Me.dateTextbox.Location = New System.Drawing.Point(736, 265)
        Me.dateTextbox.Name = "dateTextbox"
        Me.dateTextbox.Size = New System.Drawing.Size(195, 23)
        Me.dateTextbox.TabIndex = 45
        Me.dateTextbox.Text = "Enter suspect name..."
        '
        'dateRadio
        '
        Me.dateRadio.AutoSize = True
        Me.dateRadio.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dateRadio.ForeColor = System.Drawing.Color.White
        Me.dateRadio.Location = New System.Drawing.Point(573, 262)
        Me.dateRadio.Name = "dateRadio"
        Me.dateRadio.Size = New System.Drawing.Size(157, 26)
        Me.dateRadio.TabIndex = 44
        Me.dateRadio.TabStop = True
        Me.dateRadio.Text = "By Main Suspect:"
        Me.dateRadio.UseVisualStyleBackColor = True
        '
        'areaTextbox
        '
        Me.areaTextbox.Enabled = False
        Me.areaTextbox.Location = New System.Drawing.Point(725, 223)
        Me.areaTextbox.Name = "areaTextbox"
        Me.areaTextbox.Size = New System.Drawing.Size(195, 23)
        Me.areaTextbox.TabIndex = 41
        Me.areaTextbox.Text = "Enter officer name..."
        '
        'radioArea
        '
        Me.radioArea.AutoSize = True
        Me.radioArea.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioArea.ForeColor = System.Drawing.Color.White
        Me.radioArea.Location = New System.Drawing.Point(573, 220)
        Me.radioArea.Name = "radioArea"
        Me.radioArea.Size = New System.Drawing.Size(146, 26)
        Me.radioArea.TabIndex = 40
        Me.radioArea.TabStop = True
        Me.radioArea.Text = "By Lead Officer:"
        Me.radioArea.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioClosed)
        Me.GroupBox1.Controls.Add(Me.radioActive)
        Me.GroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(645, 348)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 73)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Case Type"
        '
        'radioClosed
        '
        Me.radioClosed.AutoSize = True
        Me.radioClosed.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioClosed.Location = New System.Drawing.Point(110, 28)
        Me.radioClosed.Name = "radioClosed"
        Me.radioClosed.Size = New System.Drawing.Size(79, 26)
        Me.radioClosed.TabIndex = 19
        Me.radioClosed.TabStop = True
        Me.radioClosed.Text = "Closed"
        Me.radioClosed.UseVisualStyleBackColor = True
        '
        'radioActive
        '
        Me.radioActive.AutoSize = True
        Me.radioActive.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioActive.Location = New System.Drawing.Point(19, 28)
        Me.radioActive.Name = "radioActive"
        Me.radioActive.Size = New System.Drawing.Size(75, 26)
        Me.radioActive.TabIndex = 18
        Me.radioActive.TabStop = True
        Me.radioActive.Text = "Active"
        Me.radioActive.UseVisualStyleBackColor = True
        '
        'crimeCombobox
        '
        Me.crimeCombobox.Enabled = False
        Me.crimeCombobox.FormattingEnabled = True
        Me.crimeCombobox.Location = New System.Drawing.Point(682, 445)
        Me.crimeCombobox.Name = "crimeCombobox"
        Me.crimeCombobox.Size = New System.Drawing.Size(195, 23)
        Me.crimeCombobox.TabIndex = 50
        '
        'radioCrime
        '
        Me.radioCrime.AutoSize = True
        Me.radioCrime.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.radioCrime.ForeColor = System.Drawing.Color.White
        Me.radioCrime.Location = New System.Drawing.Point(573, 442)
        Me.radioCrime.Name = "radioCrime"
        Me.radioCrime.Size = New System.Drawing.Size(103, 26)
        Me.radioCrime.TabIndex = 49
        Me.radioCrime.TabStop = True
        Me.radioCrime.Text = "By Crime:"
        Me.radioCrime.UseVisualStyleBackColor = True
        '
        'CasesDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(950, 678)
        Me.Controls.Add(Me.crimeCombobox)
        Me.Controls.Add(Me.radioCrime)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.arrestTextbox)
        Me.Controls.Add(Me.arrestRadio)
        Me.Controls.Add(Me.dateTextbox)
        Me.Controls.Add(Me.dateRadio)
        Me.Controls.Add(Me.areaTextbox)
        Me.Controls.Add(Me.radioArea)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "CasesDashboard"
        Me.Text = "Cases - Department"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents arrestTextbox As TextBox
    Friend WithEvents arrestRadio As RadioButton
    Friend WithEvents dateTextbox As TextBox
    Friend WithEvents dateRadio As RadioButton
    Friend WithEvents areaTextbox As TextBox
    Friend WithEvents radioArea As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radioClosed As RadioButton
    Friend WithEvents radioActive As RadioButton
    Friend WithEvents crimeCombobox As ComboBox
    Friend WithEvents radioCrime As RadioButton
End Class
