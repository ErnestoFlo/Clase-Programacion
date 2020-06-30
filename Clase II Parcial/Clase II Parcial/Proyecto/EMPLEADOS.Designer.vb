<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPLEADOS
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGListado = New System.Windows.Forms.DataGridView()
        Me.Identidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Puesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.cmbmunicipio = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbDepto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtIdentidad = New System.Windows.Forms.MaskedTextBox()
        Me.chkM = New System.Windows.Forms.CheckBox()
        Me.chkF = New System.Windows.Forms.CheckBox()
        Me.cmbPuesto = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtcantidad)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DGListado)
        Me.GroupBox2.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(461, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 403)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingreso De informacion"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(150, 366)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(62, 28)
        Me.txtcantidad.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 369)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 21)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "cantidad empleados:"
        '
        'DGListado
        '
        Me.DGListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identidad, Me.Nombre, Me.Direccion, Me.Puesto, Me.Sexo})
        Me.DGListado.Location = New System.Drawing.Point(6, 24)
        Me.DGListado.Name = "DGListado"
        Me.DGListado.Size = New System.Drawing.Size(542, 329)
        Me.DGListado.TabIndex = 18
        '
        'Identidad
        '
        Me.Identidad.HeaderText = "Identidad"
        Me.Identidad.Name = "Identidad"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Direccion
        '
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        '
        'Puesto
        '
        Me.Puesto.HeaderText = "Puesto"
        Me.Puesto.Name = "Puesto"
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSolicitar)
        Me.GroupBox1.Controls.Add(Me.cmbmunicipio)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cmbDepto)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtIdentidad)
        Me.GroupBox1.Controls.Add(Me.chkM)
        Me.GroupBox1.Controls.Add(Me.chkF)
        Me.GroupBox1.Controls.Add(Me.cmbPuesto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtBarrio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtId)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnIngresar)
        Me.GroupBox1.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 217)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso De informacion"
        '
        'btnSolicitar
        '
        Me.btnSolicitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnSolicitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnSolicitar.Location = New System.Drawing.Point(276, 93)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(75, 34)
        Me.btnSolicitar.TabIndex = 21
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'cmbmunicipio
        '
        Me.cmbmunicipio.FormattingEnabled = True
        Me.cmbmunicipio.Location = New System.Drawing.Point(97, 93)
        Me.cmbmunicipio.Name = "cmbmunicipio"
        Me.cmbmunicipio.Size = New System.Drawing.Size(100, 29)
        Me.cmbmunicipio.TabIndex = 35
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 21)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Municipio"
        '
        'cmbDepto
        '
        Me.cmbDepto.FormattingEnabled = True
        Me.cmbDepto.Items.AddRange(New Object() {"Atlantida", "Colón", "Comayagua", "Copán ", "Cortés", "Choluteca", "El Paraiso", "Francisco Morazan", "Gracias aDios", "Intibuca", "Islas de la Bahía", "La Paz", "Lempira", "Ocotepeque", "Olancho ", "Santa Bárbara", "Valle", "Yoro"})
        Me.cmbDepto.Location = New System.Drawing.Point(97, 58)
        Me.cmbDepto.Name = "cmbDepto"
        Me.cmbDepto.Size = New System.Drawing.Size(100, 29)
        Me.cmbDepto.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 21)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Departamento"
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(97, 24)
        Me.txtIdentidad.Mask = "9999-9999-99999"
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(100, 28)
        Me.txtIdentidad.TabIndex = 31
        '
        'chkM
        '
        Me.chkM.AutoSize = True
        Me.chkM.Location = New System.Drawing.Point(314, 62)
        Me.chkM.Name = "chkM"
        Me.chkM.Size = New System.Drawing.Size(38, 25)
        Me.chkM.TabIndex = 30
        Me.chkM.Text = "M"
        Me.chkM.UseVisualStyleBackColor = True
        '
        'chkF
        '
        Me.chkF.AutoSize = True
        Me.chkF.Location = New System.Drawing.Point(276, 63)
        Me.chkF.Name = "chkF"
        Me.chkF.Size = New System.Drawing.Size(35, 25)
        Me.chkF.TabIndex = 29
        Me.chkF.Text = "F"
        Me.chkF.UseVisualStyleBackColor = True
        '
        'cmbPuesto
        '
        Me.cmbPuesto.FormattingEnabled = True
        Me.cmbPuesto.Items.AddRange(New Object() {"Gerente", "Jefes de Calidad"})
        Me.cmbPuesto.Location = New System.Drawing.Point(97, 163)
        Me.cmbPuesto.Name = "cmbPuesto"
        Me.cmbPuesto.Size = New System.Drawing.Size(121, 29)
        Me.cmbPuesto.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(222, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 21)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Sexo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 21)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Puesto"
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(97, 128)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(100, 28)
        Me.txtBarrio.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 21)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Direccion"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(277, 24)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(151, 28)
        Me.txtNombre.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 21)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nombre:"
        '
        'txtId
        '
        Me.txtId.AutoSize = True
        Me.txtId.Location = New System.Drawing.Point(12, 27)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(62, 21)
        Me.txtId.TabIndex = 21
        Me.txtId.Text = "Identidad"
        '
        'Button1
        '
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.Location = New System.Drawing.Point(277, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Limpiar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnIngresar.Location = New System.Drawing.Point(277, 133)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(75, 34)
        Me.btnIngresar.TabIndex = 2
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'EMPLEADOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1027, 434)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EMPLEADOS"
        Me.Text = "EMPLEADOS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DGListado As DataGridView
    Friend WithEvents Identidad As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Puesto As DataGridViewTextBoxColumn
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents cmbmunicipio As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbDepto As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIdentidad As MaskedTextBox
    Friend WithEvents chkM As CheckBox
    Friend WithEvents chkF As CheckBox
    Friend WithEvents cmbPuesto As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBarrio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtId As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnIngresar As Button
End Class
