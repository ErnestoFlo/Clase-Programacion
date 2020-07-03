Imports System.Runtime.InteropServices

Public Class Login

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Dim Usuario As String
    Dim contra As String
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Usuario = "ADMIN"
        contra = "12345"
    End Sub

    Private Sub btnRegistrarse_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Registro.Show()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        If txtContraseña.Text = contra And txtUsuario.Text = Usuario Then
            MsgBox("Ingreso al sistema Exitosamente!", vbInformation + vbOK, "Informacion")
            Me.Hide()
            PantallaDeCarga.Show()
        Else
            MsgBox("Ingreso fallido, vuelva a intentarlo...", vbObjectError + vbOK, "Error")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        If MsgBox("Desea salir de la aplicacion?", vbQuestion + vbYesNo, "Salir") = vbYes Then
            End
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub
End Class