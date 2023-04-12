Public Class CriminalsDashboard
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()



    End Sub

    Private Sub CriminalsDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Run categories query

        crimeCombobox.Items.Add("Select category...")
        crimeCombobox.SelectedIndex = 0




    End Sub

    Private Sub radioName_CheckedChanged(sender As Object, e As EventArgs) Handles radioName.CheckedChanged
        If radioName.Checked = True Then
            nameTextbox.Enabled = True
            nameTextbox.Clear()
        Else
            nameTextbox.Enabled = False
            nameTextbox.Text = "Enter name..."
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        radioName.Checked = False
        radioCrime.Checked = False
        arrestRadio.Checked = False
        dateRadio.Checked = False
    End Sub

    Private Sub activeRadio_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub radioCrime_CheckedChanged(sender As Object, e As EventArgs) Handles radioCrime.CheckedChanged
        If radioCrime.Checked = True Then
            crimeCombobox.Enabled = True
        Else
            crimeCombobox.Enabled = False
            crimeCombobox.SelectedIndex = 0
        End If
    End Sub

    Private Sub arrestRadio_CheckedChanged(sender As Object, e As EventArgs) Handles arrestRadio.CheckedChanged
        If arrestRadio.Checked = True Then
            arrestTextbox.Enabled = True
            arrestTextbox.Clear()
        Else
            arrestTextbox.Enabled = False
            arrestTextbox.Text = "Enter arrrest officer name..."
        End If
    End Sub

    Private Sub dateRadio_CheckedChanged(sender As Object, e As EventArgs) Handles dateRadio.CheckedChanged
        If dateRadio.Checked = True Then
            dateTextbox.Enabled = True
            dateTextbox.Clear()
        Else
            dateTextbox.Enabled = False
            dateTextbox.Text = "DD/MM/YYYY"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles radioNB.CheckedChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ViewCriminal.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddCriminal.Show()
    End Sub
End Class