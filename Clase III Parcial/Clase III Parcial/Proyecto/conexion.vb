Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=Biblioteca;Integrated Security=True")
    'Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public cmb As SqlCommandBuilder
    Public cmbB As SqlCommand
    Public dr As SqlDataReader
    Public scmb As SqlCommandBuilder
    Public dt As New DataTable
    Public cn As SqlConnection
    Public adaptador As SqlDataAdapter



    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("CONECTADO")

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)

        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        Try
            ds.Tables.Clear()
            da = New SqlDataAdapter(sql, conexion)
            cmb = New SqlCommandBuilder(da)
            da.Fill(ds, tabla)
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try

    End Sub

    Sub abrirConexion()
        Try
            cn = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=Biblioteca;Integrated Security=True")
            cn.Open()
        Catch ex As Exception
            MessageBox.Show("Nose pudo abrir" + ex.ToString)
            cn.Close()
        End Try
    End Sub

    Sub llenarDatagrib(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("Select * from proyecto.Prestamo", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Public Function insertarUsuario(idPrestamo As Integer, idAlumno As String, idLibro As Integer, fechaPrestamo As String, fechaVencimiento As String)
        Try
            conexion.Open()
            cmbB = New SqlCommand("InsertarPrestamo", conexion)
            cmbB.CommandType = CommandType.StoredProcedure
            Dim idEstado As Integer
            idEstado = 4

            cmbB.Parameters.AddWithValue("@idPrestamo", idPrestamo)
            cmbB.Parameters.AddWithValue("@idAlumno", idAlumno)
            cmbB.Parameters.AddWithValue("@idLibro", idLibro)
            cmbB.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo)
            cmbB.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento)
            cmbB.Parameters.AddWithValue("@idEstado", idEstado)
            If cmbB.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
            Return False
        End Try
    End Function

    Public Function editarUsuario(idPrestamo As Integer, idAlumno As String, idLibro As Integer, fechaPrestamo As String, fechaVencimiento As String)
        Try
            conexion.Open()
            cmbB = New SqlCommand("EditarPrestamo", conexion)
            cmbB.CommandType = CommandType.StoredProcedure
            Dim idEstado As Integer
            idEstado = 4

            cmbB.Parameters.AddWithValue("@idPrestamo", idPrestamo)
            cmbB.Parameters.AddWithValue("@idAlumno", idAlumno)
            cmbB.Parameters.AddWithValue("@idLibro", idLibro)
            cmbB.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo)
            cmbB.Parameters.AddWithValue("@fechaVencimiento", fechaVencimiento)
            cmbB.Parameters.AddWithValue("@idEstado", idEstado)
            If cmbB.ExecuteNonQuery <> 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Function validarEmpleados(ByVal id As String) As Boolean
        Dim respuesta As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from proyecto.Prestamo where idPrestamo = '" + id + "'", conexion)
            dr = comando.ExecuteReader
            If dr.Read Then
                respuesta = True
                dr.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return respuesta
    End Function
End Class
