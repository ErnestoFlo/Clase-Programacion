﻿Imports System.Runtime.InteropServices

Public Class MenuPersonalizado

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles PanelForms.Paint

    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelLateral.Width = 165 Then
            TimerOcultarMenu.Enabled = True
        ElseIf PanelLateral.Width = 45 Then
            TimerMostrar.Enabled = True
        End If
    End Sub

    Private Sub TimerOcultarMenu_Tick(sender As Object, e As EventArgs) Handles TimerOcultarMenu.Tick
        If PanelLateral.Width <= 45 Then
            Me.TimerOcultarMenu.Enabled = False
        Else
            Me.PanelLateral.Width = PanelLateral.Width - 20
        End If
    End Sub

    Private Sub TimerMostrar_Tick(sender As Object, e As EventArgs) Handles TimerMostrar.Tick
        If PanelLateral.Width >= 165 Then
            Me.TimerMostrar.Enabled = False
        Else
            Me.PanelLateral.Width = PanelLateral.Width + 20
        End If
    End Sub

    Private Sub PanelSuperior_Paint(sender As Object, e As PaintEventArgs) Handles PanelSuperior.Paint

    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click

    End Sub
End Class

