Public Class Prestatarios
    Dim conexion As conexion = New conexion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        mostrarDatos()

        abrirConexion()
        llenarDataGrid(DGlibros)
    End Sub
    Private Sub mostrarDatos()
        conexion.Consulta("select * from proyecto.Prestamo", "proyecto.Prestamo")
        DGlibros.DataSource = conexion.ds.Tables("proyecto.Prestamo")
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Ingresar()
        MessageBox.Show("Ingreso exitoso", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
        conexion.conexion.Close()
        mostrarDatos()
    End Sub

    Private Sub Ingresar()
        If txtAlumno.Text = "" Or txtFechaEntrega.Text = "" Or txtFechaPrestamo.Text = "" Or Then

        End If
        Dim idPrestamo, idLibro As Integer
        Dim idAlumno, fechaPrestamo, fechaVencimiento As String
        idPrestamo = tstPrestamo.Text
        idAlumno = txtAlumno.Text
        idLibro = txtIdLibro.Text
        fechaPrestamo = txtFechaPrestamo.Text
        fechaVencimiento = txtFechaEntrega.Text

        Try
            If conexion.insertarUsuario(idPrestamo, idAlumno, idLibro, fechaPrestamo, fechaVencimiento) Then
                MessageBox.Show("Ingresado correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al ingresar", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexion.conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub editar()
        Dim idPrestamo, idLibro As Integer
        Dim idAlumno, fechaPrestamo, fechaVencimiento As String
        idPrestamo = tstPrestamo.Text
        idAlumno = txtAlumno.Text
        idLibro = txtIdLibro.Text
        fechaPrestamo = txtFechaPrestamo.Text
        fechaVencimiento = txtFechaEntrega.Text
        Try
            If (conexion.editarUsuario(idPrestamo, idAlumno, idLibro, fechaPrestamo, fechaVencimiento)) Then
                MsgBox("Editado Exitosamente")
                'conexion.conexion.Close()
            Else
                MsgBox("Error al editar")
                'conexion.conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        editar()
        mostrarDatos()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtAlumno.Clear()
        txtFechaEntrega.Clear()
        txtFechaPrestamo.Clear()
        txtIdLibro.Clear()
        tstPrestamo.Clear()

        conexion.conectar()
        mostrarDatos()
        abrirConexion()
    End Sub
    Private Sub busquedaDeDatos()
        conexion.Consulta("select * from proyecto.Prestamo where idPrestamo = '" + tstPrestamo.Text + "'", "proyecto.Prestamo")
        DGlibros.DataSource = conexion.ds.Tables("proyecto.Prestamo")
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        conexion.conectar()
        abrirConexion()
        conexion.Consulta("select * from proyecto.Prestamo where idPrestamo = '" + tstPrestamo.Text + "'", "proyecto.Prestamo")

        If (conexion.validarEmpleados(tstPrestamo.Text) = False) Then
            MessageBox.Show("Error en la busqueda, el empleado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            busquedaDeDatos()

        End If
    End Sub
End Class