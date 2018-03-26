<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConferenceOptionForm
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
        Me.lblConference = New System.Windows.Forms.Label()
        Me.chkConRegis = New System.Windows.Forms.CheckBox()
        Me.chkOpenNightDinner = New System.Windows.Forms.CheckBox()
        Me.lblPreConference = New System.Windows.Forms.Label()
        Me.lblSelectOne = New System.Windows.Forms.Label()
        Me.lstPreConSelect = New System.Windows.Forms.ListBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblConference
        '
        Me.lblConference.AutoSize = True
        Me.lblConference.Location = New System.Drawing.Point(13, 13)
        Me.lblConference.Name = "lblConference"
        Me.lblConference.Size = New System.Drawing.Size(62, 13)
        Me.lblConference.TabIndex = 0
        Me.lblConference.Text = "Conference"
        '
        'chkConRegis
        '
        Me.chkConRegis.AutoSize = True
        Me.chkConRegis.Location = New System.Drawing.Point(16, 50)
        Me.chkConRegis.Name = "chkConRegis"
        Me.chkConRegis.Size = New System.Drawing.Size(170, 17)
        Me.chkConRegis.TabIndex = 1
        Me.chkConRegis.Text = "Conference Registration: $895"
        Me.chkConRegis.UseVisualStyleBackColor = True
        '
        'chkOpenNightDinner
        '
        Me.chkOpenNightDinner.AutoSize = True
        Me.chkOpenNightDinner.Location = New System.Drawing.Point(16, 89)
        Me.chkOpenNightDinner.Name = "chkOpenNightDinner"
        Me.chkOpenNightDinner.Size = New System.Drawing.Size(212, 17)
        Me.chkOpenNightDinner.TabIndex = 2
        Me.chkOpenNightDinner.Text = "Opening Night Dinner and Keynote:$30"
        Me.chkOpenNightDinner.UseVisualStyleBackColor = True
        '
        'lblPreConference
        '
        Me.lblPreConference.AutoSize = True
        Me.lblPreConference.Location = New System.Drawing.Point(355, 13)
        Me.lblPreConference.Name = "lblPreConference"
        Me.lblPreConference.Size = New System.Drawing.Size(129, 13)
        Me.lblPreConference.TabIndex = 3
        Me.lblPreConference.Text = "Preconference Workshop"
        '
        'lblSelectOne
        '
        Me.lblSelectOne.AutoSize = True
        Me.lblSelectOne.Location = New System.Drawing.Point(355, 54)
        Me.lblSelectOne.Name = "lblSelectOne"
        Me.lblSelectOne.Size = New System.Drawing.Size(60, 13)
        Me.lblSelectOne.TabIndex = 4
        Me.lblSelectOne.Text = "Select One"
        '
        'lstPreConSelect
        '
        Me.lstPreConSelect.FormattingEnabled = True
        Me.lstPreConSelect.Items.AddRange(New Object() {"Intro to E-Commerce", "The Future of the Web", "Advanced Visual Basic", "Network Securirty"})
        Me.lstPreConSelect.Location = New System.Drawing.Point(358, 71)
        Me.lstPreConSelect.Name = "lstPreConSelect"
        Me.lstPreConSelect.Size = New System.Drawing.Size(120, 69)
        Me.lstPreConSelect.TabIndex = 5
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(358, 191)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(464, 191)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'ConferenceOptionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 230)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lstPreConSelect)
        Me.Controls.Add(Me.lblSelectOne)
        Me.Controls.Add(Me.lblPreConference)
        Me.Controls.Add(Me.chkOpenNightDinner)
        Me.Controls.Add(Me.chkConRegis)
        Me.Controls.Add(Me.lblConference)
        Me.Name = "ConferenceOptionForm"
        Me.Text = "Conference Option"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblConference As Label
    Friend WithEvents chkConRegis As CheckBox
    Friend WithEvents chkOpenNightDinner As CheckBox
    Friend WithEvents lblPreConference As Label
    Friend WithEvents lblSelectOne As Label
    Friend WithEvents lstPreConSelect As ListBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnClose As Button
End Class
