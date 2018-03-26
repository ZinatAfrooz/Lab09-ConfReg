Public Class ConferenceOptionForm
    Public dblInroEcommerce As Double = 0.0
    Public dblFutureWeb As Double = 0.0
    Public dblAdvanceBasic As Double = 0.0
    Public dblNetworkSecurity As Double = 0.0
    Public dblNightDinner As Double = 0.0


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        If chkConRegis.Checked Then
            If lstPreConSelect.SelectedIndex = 0 Then
                dblInroEcommerce = 295.0
            ElseIf lstPreConSelect.SelectedIndex = 1 Then
                dblFutureWeb = 295.0
            ElseIf lstPreConSelect.SelectedIndex = 2 Then
                dblAdvanceBasic = 395.0
            ElseIf lstPreConSelect.SelectedIndex = 3 Then
                dblNetworkSecurity = 395.0
            Else
                dblInroEcommerce = 0.0
                dblFutureWeb = 0.0
                dblAdvanceBasic = 0.0
                dblNetworkSecurity = 0.0
                dblNightDinner = 0.0
            End If

            If chkOpenNightDinner.Checked Then
                dblNightDinner = 30.0
            End If

            'dblTotal = dblConfRegis + dblInroEcommerce + dblFutureWeb + dblAdvanceBasic + dblNetworkSecurity + dblNightDinner
            TotalRegisCost(dblInroEcommerce, dblFutureWeb, dblAdvanceBasic, dblNetworkSecurity, dblNightDinner)

            'close the Conference option form
            Me.Close()

        Else
            MessageBox.Show("Please check conference registration")
        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        chkConRegis.Checked = False
        chkOpenNightDinner.Checked = False
    End Sub
End Class