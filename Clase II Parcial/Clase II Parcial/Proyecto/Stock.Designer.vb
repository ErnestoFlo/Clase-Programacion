<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stock
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPack3 = New System.Windows.Forms.TextBox()
        Me.txtPack2 = New System.Windows.Forms.TextBox()
        Me.txtPack1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGCelulares = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ddd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Puest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Paquete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGCelulares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPack3)
        Me.GroupBox1.Controls.Add(Me.txtPack2)
        Me.GroupBox1.Controls.Add(Me.txtPack1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DGCelulares)
        Me.GroupBox1.Font = New System.Drawing.Font("Bebas Neue", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 296)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Telefonos Registrados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Inventario Pack 3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Inventario Pack 2"
        '
        'txtPack3
        '
        Me.txtPack3.Location = New System.Drawing.Point(113, 254)
        Me.txtPack3.Name = "txtPack3"
        Me.txtPack3.Size = New System.Drawing.Size(62, 28)
        Me.txtPack3.TabIndex = 7
        '
        'txtPack2
        '
        Me.txtPack2.Location = New System.Drawing.Point(113, 220)
        Me.txtPack2.Name = "txtPack2"
        Me.txtPack2.Size = New System.Drawing.Size(62, 28)
        Me.txtPack2.TabIndex = 6
        '
        'txtPack1
        '
        Me.txtPack1.Location = New System.Drawing.Point(113, 186)
        Me.txtPack1.Name = "txtPack1"
        Me.txtPack1.Size = New System.Drawing.Size(62, 28)
        Me.txtPack1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Inventario Pack 1"
        '
        'DGCelulares
        '
        Me.DGCelulares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCelulares.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.ddd, Me.Puest, Me.Paquete, Me.Estado})
        Me.DGCelulares.Location = New System.Drawing.Point(6, 27)
        Me.DGCelulares.Name = "DGCelulares"
        Me.DGCelulares.Size = New System.Drawing.Size(545, 150)
        Me.DGCelulares.TabIndex = 1
        '
        'Id
        '
        Me.Id.HeaderText = "Identidad"
        Me.Id.Name = "Id"
        '
        'ddd
        '
        Me.ddd.HeaderText = "Nombre"
        Me.ddd.Name = "ddd"
        '
        'Puest
        '
        Me.Puest.HeaderText = "Puesto"
        Me.Puest.Name = "Puest"
        '
        'Paquete
        '
        Me.Paquete.HeaderText = "Paquete"
        Me.Paquete.Name = "Paquete"
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(600, 324)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Stock"
        Me.Text = "Stock"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGCelulares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPack3 As TextBox
    Friend WithEvents txtPack2 As TextBox
    Friend WithEvents txtPack1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGCelulares As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents ddd As DataGridViewTextBoxColumn
    Friend WithEvents Puest As DataGridViewTextBoxColumn
    Friend WithEvents Paquete As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
End Class
