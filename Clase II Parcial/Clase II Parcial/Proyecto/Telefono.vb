﻿Imports System.Data.SqlClient

Public Class Telefono
    ' Nconexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-L87VDHJ;Initial Catalog=CompuCenter;Integrated Security=True")

    Dim codigo As String
    Dim identidadEmp As String
    Dim NombreEmp As String
    Dim puesto As String
    Dim idPuesto As String

    Dim conexion As ConexionCrud = New ConexionCrud

    Private Sub Telefono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()
        llenarDataGridTelefonos(DGtelefono)
        llenarDataGridStock(DgStock)
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
        conexion.conexion.Close()

    End Sub

    Private Sub mostrarDatos()
        conexion.Consulta("select * from Center.stock", "Center.stock")
        DgStock.DataSource = conexion.ds.Tables("Center.stock")
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click

        Try

            If (conexion.validarStock(txtCodigo.Text) = False) Then
                Dim agregar As String = "insert into Center.stock values(" + txtCodigo.Text + ",'" + txtIdentidad.Text + "','" + txtNombre.Text + "','" + txtPuesto.Text + "','" + txtPrueba.Text + "')"
                If (conexion.Insertar(agregar)) Then
                    MessageBox.Show("Empleado agregado correctamente!!!", "Ingreso de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrarDatos()
                    conexion.conexion.Close()
                Else
                    MessageBox.Show("Error al agregar el Empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MsgBox("Este empleado ya existe", vbObjectError)
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
            txtCodigo.Text = dgempleados.Cells(0).Value.ToString()
            txtIdentidad.Text = dgempleados.Cells(1).Value.ToString()
            txtNombre.Text = dgempleados.Cells(2).Value.ToString()
            txtPuesto.Text = dgempleados.Cells(6).Value.ToString()
            txtPrueba.Text = dgempleados.Cells(7).Value.ToString()

        Catch ex As Exception
            MessageBox.Show("no se lleno por: " + ex.ToString)
        End Try
        conexion.conexion.Close()

    End Sub


End Class