<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Telefono
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGtelefono = New System.Windows.Forms.DataGridView()
        Me.btnEntregar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGtelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 122)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Identidad Solicitada"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(98, 36)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 28)
        Me.txtCodigo.TabIndex = 40
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.Image = Global.Clase_II_Parcial.My.Resources.Resources.buscar
        Me.btnBuscar.Location = New System.Drawing.Point(98, 70)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(51, 45)
        Me.btnBuscar.TabIndex = 39
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Codigo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DGtelefono)
        Me.GroupBox2.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.Location = New System.Drawing.Point(250, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(574, 237)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion de Ingreso"
        '
        'DGtelefono
        '
        Me.DGtelefono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGtelefono.Location = New System.Drawing.Point(16, 27)
        Me.DGtelefono.Name = "DGtelefono"
        Me.DGtelefono.Size = New System.Drawing.Size(540, 191)
        Me.DGtelefono.TabIndex = 3
        '
        'btnEntregar
        '
        Me.btnEntregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btnEntregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntregar.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntregar.Location = New System.Drawing.Point(46, 140)
        Me.btnEntregar.Name = "btnEntregar"
        Me.btnEntregar.Size = New System.Drawing.Size(157, 58)
        Me.btnEntregar.TabIndex = 4
        Me.btnEntregar.Text = "Asignar Telefono  Celular"
        Me.btnEntregar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(68, 250)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(68, 276)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(68, 302)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(68, 328)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(68, 354)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 9
        '
        'Telefono
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(847, 434)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnEntregar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Telefono"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DGtelefono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGtelefono As DataGridView
    Friend WithEvents btnEntregar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
End Class
