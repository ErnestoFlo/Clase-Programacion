Public Class Telefono
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DGListado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) 

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Telefono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()
        llenarDataGridTelefonos(DataGridView1)
    End Sub
End Class