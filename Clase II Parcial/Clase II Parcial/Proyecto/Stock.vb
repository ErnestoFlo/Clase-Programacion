Public Class Stock
    Dim conexion As ConexionCrud = New ConexionCrud
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()

        'Dim mostrar As String = "select st.IdCodigo, st.identidad , st.nombre, st.puesto, te.modelo,te.tipoPaquete,te.Descripcion, te.cantidad from Center.stock st inner join Center.telefonos te on st.idPuesto = te.id"

        'If conexion.MostrarAsignacion(mostrar) = False Then
        'MessageBox.Show("No se ha hecho ninguna asignacion", "Error de carga", MessageBoxButtons.OK, MessageBoxIcon.Error)

        'End If
        llenarDataGridStock(DGstock)
    End Sub

End Class