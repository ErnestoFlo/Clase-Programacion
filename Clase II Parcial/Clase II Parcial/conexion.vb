Imports System.Data.Sql
Imports System.Data.SqlClient

Module conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=CompuCenter;Integrated Security=True")
    Public cn As SqlConnection
    Public adaptador As SqlDataAdapter
    Public dt As DataTable
    Public comando As SqlCommand
    Public dr As SqlDataReader


    Sub llenarDataGridEmpleados(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("Select * from Center.empleados", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Sub llenarDataGridStock(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("select st.identidad , st.nombre, st.puesto, te.paquete, te.cantidad, te.modelo from Center.stock st inner join Center.telefonos te on st.idPuesto = te.id", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Sub llenarDataGridTelefonos(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("Select telefonos.id, telefonos.puesto, telefonos.paquete, telefonos.cantidad from Center.telefonos", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
    End Sub

    Sub abrirConexion()
        Try
            cn = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=CompuCenter;Integrated Security=True")
            cn.Open()
            MessageBox.Show("CONECTADO")
        Catch ex As Exception
            MessageBox.Show("Nose pudo abrir" + ex.ToString)
            cn.Close()
        End Try
    End Sub

    Function validarEmpleados(ByVal codigo As String) As Boolean
        Dim respuesta As Boolean = False
        Try
            conexion.Open()
            comando = New SqlCommand("select * from Center.empelados where IdCodigo = '" + codigo + "'", conexion)
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

End Module
