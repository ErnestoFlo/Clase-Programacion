Public Class MainPageUsuario
    Private Sub btnStock_Click(sender As Object, e As EventArgs)
        Private Sub AbrirFormulario(frmHijo As Object)
        Try
            If (panelCentral.Controls.Count > 0) Then
                panelCentral.Controls.RemoveAt(0)
            Else
                Dim frm As Form
                frm = frmHijo
                frm.TopLevel = False
                frm.Dock = DockStyle.Fill
                panelCentral.Controls.Add(frm)
                panelCentral.Tag = frm
                frm.Show()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormulario(New EMPLEADOS)
    End Sub
End Class