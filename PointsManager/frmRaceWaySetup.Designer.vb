<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRaceWaySetup
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtRacewayName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtRacewayAddr = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbTracks = New System.Windows.Forms.ComboBox
        Me.butAddTrack = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Raceway Name :"
        '
        'txtRacewayName
        '
        Me.txtRacewayName.Location = New System.Drawing.Point(183, 57)
        Me.txtRacewayName.Name = "txtRacewayName"
        Me.txtRacewayName.Size = New System.Drawing.Size(320, 26)
        Me.txtRacewayName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Raceway Addr :"
        '
        'txtRacewayAddr
        '
        Me.txtRacewayAddr.Location = New System.Drawing.Point(183, 97)
        Me.txtRacewayAddr.Name = "txtRacewayAddr"
        Me.txtRacewayAddr.Size = New System.Drawing.Size(320, 26)
        Me.txtRacewayAddr.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Raceway Tracks :"
        '
        'cmbTracks
        '
        Me.cmbTracks.FormattingEnabled = True
        Me.cmbTracks.Location = New System.Drawing.Point(183, 143)
        Me.cmbTracks.Name = "cmbTracks"
        Me.cmbTracks.Size = New System.Drawing.Size(320, 28)
        Me.cmbTracks.Sorted = True
        Me.cmbTracks.TabIndex = 5
        '
        'butAddTrack
        '
        Me.butAddTrack.Location = New System.Drawing.Point(144, 199)
        Me.butAddTrack.Name = "butAddTrack"
        Me.butAddTrack.Size = New System.Drawing.Size(155, 59)
        Me.butAddTrack.TabIndex = 6
        Me.butAddTrack.Text = "Add New Track"
        Me.butAddTrack.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(345, 199)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 59)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Remove Selected Track"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Crimson
        Me.Button2.Location = New System.Drawing.Point(260, 295)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(110, 54)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Save and Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmRaceWaySetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 374)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.butAddTrack)
        Me.Controls.Add(Me.cmbTracks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRacewayAddr)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRacewayName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmRaceWaySetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Raceway Set Up Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRacewayName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRacewayAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTracks As System.Windows.Forms.ComboBox
    Friend WithEvents butAddTrack As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
