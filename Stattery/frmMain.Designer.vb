<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblChargePc = New System.Windows.Forms.Label()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCharging = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblLifeRemain = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFullLifetime = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPowerLineStatus = New System.Windows.Forms.Label()
        Me.pbCharge = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'lblChargePc
        '
        Me.lblChargePc.Location = New System.Drawing.Point(9, 65)
        Me.lblChargePc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChargePc.Name = "lblChargePc"
        Me.lblChargePc.Size = New System.Drawing.Size(462, 31)
        Me.lblChargePc.TabIndex = 0
        Me.lblChargePc.Text = "lblChargePc"
        Me.lblChargePc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmrMain
        '
        Me.tmrMain.Enabled = True
        Me.tmrMain.Interval = 1000
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(9, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(462, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Battery Charge:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 95)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mode:"
        '
        'lblCharging
        '
        Me.lblCharging.AutoSize = True
        Me.lblCharging.Location = New System.Drawing.Point(110, 95)
        Me.lblCharging.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCharging.Name = "lblCharging"
        Me.lblCharging.Size = New System.Drawing.Size(88, 20)
        Me.lblCharging.TabIndex = 2
        Me.lblCharging.Text = "lblCharging"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 95)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Time Remain:"
        '
        'lblLifeRemain
        '
        Me.lblLifeRemain.AutoSize = True
        Me.lblLifeRemain.Location = New System.Drawing.Point(378, 95)
        Me.lblLifeRemain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLifeRemain.Name = "lblLifeRemain"
        Me.lblLifeRemain.Size = New System.Drawing.Size(105, 20)
        Me.lblLifeRemain.TabIndex = 4
        Me.lblLifeRemain.Text = "lblLifeRemain"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(274, 122)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Time Total:"
        '
        'lblFullLifetime
        '
        Me.lblFullLifetime.AutoSize = True
        Me.lblFullLifetime.Location = New System.Drawing.Point(378, 122)
        Me.lblFullLifetime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFullLifetime.Name = "lblFullLifetime"
        Me.lblFullLifetime.Size = New System.Drawing.Size(105, 20)
        Me.lblFullLifetime.TabIndex = 6
        Me.lblFullLifetime.Text = "lblFullLifetime"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 122)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Power Line:"
        '
        'lblPowerLineStatus
        '
        Me.lblPowerLineStatus.AutoSize = True
        Me.lblPowerLineStatus.Location = New System.Drawing.Point(110, 122)
        Me.lblPowerLineStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPowerLineStatus.Name = "lblPowerLineStatus"
        Me.lblPowerLineStatus.Size = New System.Drawing.Size(145, 20)
        Me.lblPowerLineStatus.TabIndex = 8
        Me.lblPowerLineStatus.Text = "lblPowerLineStatus"
        '
        'pbCharge
        '
        Me.pbCharge.Location = New System.Drawing.Point(9, 45)
        Me.pbCharge.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbCharge.Name = "pbCharge"
        Me.pbCharge.Size = New System.Drawing.Size(462, 15)
        Me.pbCharge.TabIndex = 10
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 158)
        Me.Controls.Add(Me.pbCharge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblPowerLineStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblFullLifetime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblLifeRemain)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCharging)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblChargePc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.Text = "Stattery"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblChargePc As System.Windows.Forms.Label
    Friend WithEvents tmrMain As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCharging As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblLifeRemain As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblFullLifetime As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPowerLineStatus As System.Windows.Forms.Label
    Friend WithEvents pbCharge As System.Windows.Forms.ProgressBar

End Class
