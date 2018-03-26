Public Class MainForm
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Text = String.Empty
        txtCompany.Text = String.Empty
        txtAddress.Text = String.Empty
        txtCity.Text = String.Empty
        txtEmail.Text = String.Empty
        txtState.Text = String.Empty
        txtZip.Text = String.Empty
        lblTotalVal.Text = String.Empty
    End Sub

    Private Sub lblConferOption_Click(sender As Object, e As EventArgs) Handles lblConferOption.Click
        'Create an instance of new ConferenceOptionForm
        Dim frmConfOption As New ConferenceOptionForm

        'Display the Conference Option Form
        frmConfOption.ShowDialog()

        'show the total registration cost
        lblTotalVal.Text = dblTotal
    End Sub
End Class
