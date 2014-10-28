<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlRegistrarBeneficio
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlRegistrarBeneficio))
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.txtAplicacion = New System.Windows.Forms.TextBox()
        Me.txPorcentaje = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblAplicacion = New System.Windows.Forms.Label()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCrear = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.Window
        Me.btnCancelar.Location = New System.Drawing.Point(299, 385)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(132, 41)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAñadir
        '
        Me.btnAñadir.BackgroundImage = CType(resources.GetObject("btnAñadir.BackgroundImage"), System.Drawing.Image)
        Me.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAñadir.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.btnAñadir.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAñadir.Location = New System.Drawing.Point(454, 385)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(132, 41)
        Me.btnAñadir.TabIndex = 20
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'txtAplicacion
        '
        Me.txtAplicacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAplicacion.Location = New System.Drawing.Point(341, 273)
        Me.txtAplicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAplicacion.Multiline = True
        Me.txtAplicacion.Name = "txtAplicacion"
        Me.txtAplicacion.Size = New System.Drawing.Size(121, 26)
        Me.txtAplicacion.TabIndex = 19
        '
        'txPorcentaje
        '
        Me.txPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txPorcentaje.Location = New System.Drawing.Point(341, 182)
        Me.txPorcentaje.Margin = New System.Windows.Forms.Padding(4)
        Me.txPorcentaje.Multiline = True
        Me.txPorcentaje.Name = "txPorcentaje"
        Me.txPorcentaje.Size = New System.Drawing.Size(121, 26)
        Me.txPorcentaje.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(454, 393)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(2, 2)
        Me.TextBox1.TabIndex = 17
        '
        'lblAplicacion
        '
        Me.lblAplicacion.AutoSize = True
        Me.lblAplicacion.BackColor = System.Drawing.Color.Transparent
        Me.lblAplicacion.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.lblAplicacion.Location = New System.Drawing.Point(180, 273)
        Me.lblAplicacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAplicacion.Name = "lblAplicacion"
        Me.lblAplicacion.Size = New System.Drawing.Size(127, 25)
        Me.lblAplicacion.TabIndex = 16
        Me.lblAplicacion.Text = "A que se aplica"
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Location = New System.Drawing.Point(431, 253)
        Me.txtPorcentaje.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPorcentaje.Multiline = True
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(2, 2)
        Me.txtPorcentaje.TabIndex = 15
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.AutoSize = True
        Me.lblPorcentaje.BackColor = System.Drawing.Color.Transparent
        Me.lblPorcentaje.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.lblPorcentaje.Location = New System.Drawing.Point(179, 182)
        Me.lblPorcentaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(91, 25)
        Me.lblPorcentaje.TabIndex = 14
        Me.lblPorcentaje.Text = "Porcentaje"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Location = New System.Drawing.Point(341, 94)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 26)
        Me.txtNombre.TabIndex = 13
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.lblNombre.Location = New System.Drawing.Point(179, 94)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(75, 25)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre"
        '
        'lblCrear
        '
        Me.lblCrear.AutoSize = True
        Me.lblCrear.BackColor = System.Drawing.Color.Transparent
        Me.lblCrear.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.lblCrear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCrear.Location = New System.Drawing.Point(32, 12)
        Me.lblCrear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCrear.Name = "lblCrear"
        Me.lblCrear.Size = New System.Drawing.Size(53, 25)
        Me.lblCrear.TabIndex = 22
        Me.lblCrear.Text = "Crear"
        '
        'uCtrlRegistrarBeneficio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.lblCrear)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.txtAplicacion)
        Me.Controls.Add(Me.txPorcentaje)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblAplicacion)
        Me.Controls.Add(Me.txtPorcentaje)
        Me.Controls.Add(Me.lblPorcentaje)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "uCtrlRegistrarBeneficio"
        Me.Size = New System.Drawing.Size(609, 442)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents txtAplicacion As System.Windows.Forms.TextBox
    Friend WithEvents txPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblAplicacion As System.Windows.Forms.Label
    Friend WithEvents txtPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents lblPorcentaje As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCrear As System.Windows.Forms.Label

End Class
