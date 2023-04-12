Public Class ReportsDashboard
    Private Sub ReportsDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        crimeCombobox.Items.Add("Select category...")
        crimeCombobox.SelectedIndex = 0


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub radioArea_CheckedChanged(sender As Object, e As EventArgs) Handles radioArea.CheckedChanged

        If radioArea.Checked = True Then
            areaTextbox.Enabled = True
            areaTextbox.Clear()
        Else
            areaTextbox.Enabled = False
            areaTextbox.Text = "Enter area..."
        End If

    End Sub

    Private Sub radioCrime_CheckedChanged(sender As Object, e As EventArgs) Handles radioCrime.CheckedChanged

        If radioCrime.Checked = True Then
            crimeCombobox.Enabled = True
        Else
            crimeCombobox.Enabled = False
            crimeCombobox.SelectedIndex = 0
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

    Private Sub arrestRadio_CheckedChanged(sender As Object, e As EventArgs) Handles arrestRadio.CheckedChanged

        If arrestRadio.Checked = True Then
            arrestTextbox.Enabled = True
            arrestTextbox.Clear()
        Else
            arrestTextbox.Enabled = False
            arrestTextbox.Text = "Enter name of reporter..."
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        radioArea.Checked = False
        radioCrime.Checked = False
        dateRadio.Checked = False
        arrestRadio.Checked = False

    End Sub
End Class