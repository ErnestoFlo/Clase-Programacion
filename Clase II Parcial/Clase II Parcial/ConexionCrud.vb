Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class ConexionCrud

    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=CompuCenter;Integrated Security=True")
    Public cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public comando As SqlCommand

    Public Sub conectar()
        Try
            conexion.Open()
        Catch ex As Exception
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub


    Function eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim elimina As String = "delete from " + tabla + "where " + condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As Integer = comando.ExecuteNonQuery
        conexion.Close()

        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function actualizar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Int16 = comando.ExecuteNonQuery
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Function Insertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class



