Imports System.Diagnostics

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetBatteryStatus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        GetBatteryStatus()
    End Sub

    Sub GetBatteryStatus()
        Dim power As PowerStatus = SystemInformation.PowerStatus

        lblChargePc.Text = power.BatteryLifePercent * 100 & "%"
        pbCharge.Value = power.BatteryLifePercent * 100

        Select Case power.BatteryChargeStatus
            Case BatteryChargeStatus.Charging
                lblCharging.Text = "Charging"
            Case BatteryChargeStatus.Critical
                lblCharging.Text = "Critically Low"
            Case BatteryChargeStatus.High
                lblCharging.Text = "Almost Full"
            Case BatteryChargeStatus.Low
                lblCharging.Text = "Low Battery"
            Case BatteryChargeStatus.NoSystemBattery
                lblCharging.Text = "Battery removed"
            Case BatteryChargeStatus.Unknown
                lblCharging.Text = "Unknown"
        End Select

        If power.PowerLineStatus = PowerLineStatus.Online Then
            lblPowerLineStatus.Text = "Plugged in"
        ElseIf power.PowerLineStatus = PowerLineStatus.Offline Then
            lblPowerLineStatus.Text = "Disconnected"
        Else
            lblPowerLineStatus.Text = "Unknown"
        End If

        Select Case power.BatteryLifeRemaining
            Case Is > -1
                lblLifeRemain.Text = power.BatteryLifeRemaining & " seconds"
            Case -1
                lblLifeRemain.Text = "Unknown"
        End Select

        Select Case power.BatteryFullLifetime
            Case Is > -1
                lblFullLifetime.Text = power.BatteryFullLifetime & " seconds"
            Case -1
                lblFullLifetime.Text = "Unknown"
        End Select

        Dim batt As New PerformanceCounter()
        With batt
            .CategoryName = "Battery Status"
            .CounterName = "Remaining Capacity"
            .InstanceName = "ACPI\PNP0C0A\0_0"
        End With
    End Sub
End Class
