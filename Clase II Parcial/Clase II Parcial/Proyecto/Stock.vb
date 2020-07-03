Public Class Stock
    Private Sub Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()
        llenarDataGridStock(DGCelulares)
    End Sub
End Class