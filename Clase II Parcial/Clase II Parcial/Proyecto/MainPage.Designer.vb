<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnStock = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnAsignacionTelefonos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelCentral = New System.Windows.Forms.Panel()
        Me.PanelSuperior.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.Aqua
        Me.PanelSuperior.Controls.Add(Me.btnRestaurar)
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.btnMaximizar)
        Me.PanelSuperior.Controls.Add(Me.btnCerrar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(1223, 32)
        Me.PanelSuperior.TabIndex = 1
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.Clase_II_Parcial.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(1157, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(30, 33)
        Me.btnRestaurar.TabIndex = 2
        Me.btnRestaurar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Clase_II_Parcial.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(1121, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(30, 33)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = Global.Clase_II_Parcial.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(1157, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(30, 33)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Clase_II_Parcial.My.Resources.Resources.Icono_cerrar_FN
        Me.btnCerrar.Location = New System.Drawing.Point(1193, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 33)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.btnStock)
        Me.Panel1.Controls.Add(Me.btnEmpleados)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnAsignacionTelefonos)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 454)
        Me.Panel1.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Cyan
        Me.Panel6.Location = New System.Drawing.Point(3, 284)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(18, 42)
        Me.Panel6.TabIndex = 10
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Bebas Neue", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnSalir.Image = Global.Clase_II_Parcial.My.Resources.Resources._exit
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(27, 284)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(152, 42)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Cyan
        Me.Panel5.Location = New System.Drawing.Point(3, 236)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(18, 42)
        Me.Panel5.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Cyan
        Me.Panel4.Location = New System.Drawing.Point(3, 188)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(18, 42)
        Me.Panel4.TabIndex = 7
        '
        'btnStock
        '
        Me.btnStock.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStock.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
        Me.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStock.Font = New System.Drawing.Font("Bebas Neue", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStock.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnStock.Image = Global.Clase_II_Parcial.My.Resources.Resources.pallet__1_
        Me.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStock.Location = New System.Drawing.Point(27, 236)
        Me.btnStock.Name = "btnStock"
        Me.btnStock.Size = New System.Drawing.Size(152, 42)
        Me.btnStock.TabIndex = 6
        Me.btnStock.Text = "Stock"
        Me.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStock.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpleados.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEmpleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
        Me.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleados.Font = New System.Drawing.Font("Bebas Neue", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnEmpleados.Image = Global.Clase_II_Parcial.My.Resources.Resources.employee__1_
        Me.btnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpleados.Location = New System.Drawing.Point(27, 188)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(152, 42)
        Me.btnEmpleados.TabIndex = 6
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Cyan
        Me.Panel3.Location = New System.Drawing.Point(3, 140)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(18, 42)
        Me.Panel3.TabIndex = 6
        '
        'btnAsignacionTelefonos
        '
        Me.btnAsignacionTelefonos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAsignacionTelefonos.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAsignacionTelefonos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
        Me.btnAsignacionTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsignacionTelefonos.Font = New System.Drawing.Font("Bebas Neue", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignacionTelefonos.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnAsignacionTelefonos.Image = Global.Clase_II_Parcial.My.Resources.Resources.telephone__1_
        Me.btnAsignacionTelefonos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAsignacionTelefonos.Location = New System.Drawing.Point(27, 140)
        Me.btnAsignacionTelefonos.Name = "btnAsignacionTelefonos"
        Me.btnAsignacionTelefonos.Size = New System.Drawing.Size(152, 42)
        Me.btnAsignacionTelefonos.TabIndex = 5
        Me.btnAsignacionTelefonos.Text = "Telefonos"
        Me.btnAsignacionTelefonos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAsignacionTelefonos.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Clase_II_Parcial.My.Resources.Resources.LOGO_EMPRESA
        Me.PictureBox1.Location = New System.Drawing.Point(42, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(102, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'panelCentral
        '
        Me.panelCentral.BackColor = System.Drawing.SystemColors.Window
        Me.panelCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelCentral.Location = New System.Drawing.Point(180, 32)
        Me.panelCentral.Name = "panelCentral"
        Me.panelCentral.Size = New System.Drawing.Size(1043, 454)
        Me.panelCentral.TabIndex = 8
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1223, 486)
        Me.Controls.Add(Me.panelCentral)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainPage"
        Me.Text = "MainPage"
        Me.PanelSuperior.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAsignacionTelefonos As Button
    Friend WithEvents btnStock As Button
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents panelCentral As Panel
End Class
