Public Class FormDashboard
    Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        CriminalsDashboard.Show()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click


        If MessageBox.Show("Confirm logout?", "Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then

            Form1.Show()
            Me.Close()


        End If




    End Sub

    Private Sub LaunchReports_Click(sender As Object, e As EventArgs) Handles LaunchReports.Click

        ReportsDashboard.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        CasesDashboard.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ActiveCases.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClosedCases.Show()
    End Sub
End Class