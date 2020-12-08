Imports System.Data.Sql
Imports System.Data.SqlClient
Module arreglos
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=Biblioteca;Integrated Security=True")
    Public cn As SqlConnection
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Public comando As SqlCommand
    Public dr As SqlDataReader
    Sub abrirConexion()
        Try
            cn = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=Biblioteca;Integrated Security=True")
            cn.Open()
        Catch ex As Exception
            MessageBox.Show("Nose pudo abrir" + ex.ToString)
            cn.Close()
        End Try
    End Sub

    Sub llenarDataGrid(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select pres.idPrestamo as IdPrestado, concat(alu.nombre, ' ', alu.apellido) as NombreCompleto, lib.nombre as Nombre, pres.fechaVencimiento from proyecto.Prestamo as pres
inner join proyecto.Alumno as alu on alu.idAlumno = pres.alumnoid
inner join proyecto.libros as lib on lib.idLibro = pres.libroid", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub
End Module
