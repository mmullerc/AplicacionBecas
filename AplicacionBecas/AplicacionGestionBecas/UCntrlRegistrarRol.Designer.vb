<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCntrlRegistrarRol
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCntrlRegistrarRol))
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblNombre.Location = New System.Drawing.Point(47, 58)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(75, 25)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(146, 63)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 5
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(404, 259)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(110, 47)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.White
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(543, 259)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(110, 47)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'UCntrlRegistrarRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Name = "UCntrlRegistrarRol"
        Me.Size = New System.Drawing.Size(685, 325)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button

End Class
