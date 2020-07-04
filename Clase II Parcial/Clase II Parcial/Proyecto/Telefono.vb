Public Class Telefono
    Dim codigo As String
    Dim identidadEmp As String
    Dim NombreEmp As String
    Dim puesto As String
    Dim idPuesto As String

    Dim conexion As ConexionCrud = New ConexionCrud

    Private Sub Telefono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()
        llenarDataGridTelefonos(DGtelefono)
    End Sub

    Private Sub busquedaDeDatos()
        conexion.Consulta("select * from Center.empleados where IdCodigo = '" + txtCodigo.Text + "'", "Center.empleados")
        DGtelefono.DataSource = conexion.ds.Tables("Center.empleados")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        conexion.Consulta("select * from Center.empleados where IdCodigo = '" + txtCodigo.Text + "'", "Center.empleados")

        If (conexion.validarEmpleados(txtCodigo.Text) = False) Then
            MessageBox.Show("Error en la busqueda, el empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            busquedaDeDatos()

        End If
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Try
            Dim agregar As String = "insert into mostrarStock values( 3 ,' 501-1993-1654 ',' Luis Fernando Oseguera ',' Jefe de TI (Desarrollo) ',' 3 ')"
            If (conexion.Insertar(agregar)) Then
                MessageBox.Show("Asignacion de Telefono Exitosa!!!", "Ingreso de Telefono", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al agregar el telefono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            conexion.conexion.Close()

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
        conexion.conexion.Close()
    End Sub

    Private Sub DGtelefono_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGtelefono.CellContentClick
        Try
            Dim dgempleados As DataGridViewRow = DGtelefono.Rows(e.RowIndex)
            codigo = dgempleados.Cells(0).Value.ToString()
            identidadEmp = dgempleados.Cells(1).Value.ToString()
            NombreEmp = dgempleados.Cells(2).Value.ToString()
            puesto = dgempleados.Cells(6).Value.ToString()
            idPuesto = dgempleados.Cells(7).Value.ToString()

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
        conexion.conexion.Close()

    End Sub


End Class