﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UctrlCrearUsuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UctrlCrearUsuario))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSegundoNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rbtMasculino = New System.Windows.Forms.RadioButton()
        Me.rbtFemenino = New System.Windows.Forms.RadioButton()
        Me.rbtOtro = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbRoles = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtConfirmacionContraseña = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Crear"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(27, 80)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(123, 25)
        Me.lblNombre.TabIndex = 8
        Me.lblNombre.Text = "Primer nombre"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImage = CType(resources.GetObject("btnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(461, 441)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(132, 41)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.BackgroundImage = CType(resources.GetObject("btnAceptar.BackgroundImage"), System.Drawing.Image)
        Me.btnAceptar.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(599, 441)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(132, 41)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(171, 80)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(144, 20)
        Me.txtNombre.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Segundo nombre"
        '
        'txtSegundoNombre
        '
        Me.txtSegundoNombre.Location = New System.Drawing.Point(171, 132)
        Me.txtSegundoNombre.Name = "txtSegundoNombre"
        Me.txtSegundoNombre.Size = New System.Drawing.Size(144, 20)
        Me.txtSegundoNombre.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Primer apellido"
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Location = New System.Drawing.Point(171, 179)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(144, 20)
        Me.txtPrimerApellido.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Segundo apellido"
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(171, 224)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(144, 20)
        Me.txtSegundoApellido.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Identificación"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(171, 273)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(144, 20)
        Me.txtIdentificacion.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 321)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 25)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Teléfono"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(171, 321)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(144, 20)
        Me.txtTelefono.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(407, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 25)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Fecha de nacimiento"
        '
        'DtpFechaNacimiento
        '
        Me.DtpFechaNacimiento.Location = New System.Drawing.Point(587, 85)
        Me.DtpFechaNacimiento.Name = "DtpFechaNacimiento"
        Me.DtpFechaNacimiento.Size = New System.Drawing.Size(144, 20)
        Me.DtpFechaNacimiento.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(407, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 25)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Género"
        '
        'rbtMasculino
        '
        Me.rbtMasculino.AutoSize = True
        Me.rbtMasculino.BackColor = System.Drawing.Color.Transparent
        Me.rbtMasculino.Location = New System.Drawing.Point(500, 138)
        Me.rbtMasculino.Name = "rbtMasculino"
        Me.rbtMasculino.Size = New System.Drawing.Size(34, 17)
        Me.rbtMasculino.TabIndex = 25
        Me.rbtMasculino.TabStop = True
        Me.rbtMasculino.Text = "M"
        Me.rbtMasculino.UseVisualStyleBackColor = False
        '
        'rbtFemenino
        '
        Me.rbtFemenino.AutoSize = True
        Me.rbtFemenino.BackColor = System.Drawing.Color.Transparent
        Me.rbtFemenino.Location = New System.Drawing.Point(596, 136)
        Me.rbtFemenino.Name = "rbtFemenino"
        Me.rbtFemenino.Size = New System.Drawing.Size(31, 17)
        Me.rbtFemenino.TabIndex = 26
        Me.rbtFemenino.TabStop = True
        Me.rbtFemenino.Text = "F"
        Me.rbtFemenino.UseVisualStyleBackColor = False
        '
        'rbtOtro
        '
        Me.rbtOtro.AutoSize = True
        Me.rbtOtro.BackColor = System.Drawing.Color.Transparent
        Me.rbtOtro.Location = New System.Drawing.Point(682, 136)
        Me.rbtOtro.Name = "rbtOtro"
        Me.rbtOtro.Size = New System.Drawing.Size(45, 17)
        Me.rbtOtro.TabIndex = 27
        Me.rbtOtro.TabStop = True
        Me.rbtOtro.Text = "Otro"
        Me.rbtOtro.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(407, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 25)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Rol"
        '
        'cmbRoles
        '
        Me.cmbRoles.FormattingEnabled = True
        Me.cmbRoles.Location = New System.Drawing.Point(587, 175)
        Me.cmbRoles.Name = "cmbRoles"
        Me.cmbRoles.Size = New System.Drawing.Size(140, 21)
        Me.cmbRoles.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(407, 211)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 25)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Correo electrónico"
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(587, 225)
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(144, 20)
        Me.txtCorreoElectronico.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(407, 273)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 25)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Contraseña"
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(587, 278)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(144, 20)
        Me.txtContraseña.TabIndex = 33
        Me.txtContraseña.UseSystemPasswordChar = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Light", 13.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(407, 338)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(176, 25)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Confirmar Contraseña"
        '
        'txtConfirmacionContraseña
        '
        Me.txtConfirmacionContraseña.Location = New System.Drawing.Point(587, 342)
        Me.txtConfirmacionContraseña.Name = "txtConfirmacionContraseña"
        Me.txtConfirmacionContraseña.Size = New System.Drawing.Size(144, 20)
        Me.txtConfirmacionContraseña.TabIndex = 35
        Me.txtConfirmacionContraseña.UseSystemPasswordChar = True
        '
        'UctrlCrearUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.txtConfirmacionContraseña)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCorreoElectronico)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbRoles)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rbtOtro)
        Me.Controls.Add(Me.rbtFemenino)
        Me.Controls.Add(Me.rbtMasculino)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DtpFechaNacimiento)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIdentificacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSegundoApellido)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPrimerApellido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSegundoNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UctrlCrearUsuario"
        Me.Size = New System.Drawing.Size(774, 512)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSegundoNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrimerApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSegundoApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtIdentificacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DtpFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rbtMasculino As System.Windows.Forms.RadioButton
    Friend WithEvents rbtFemenino As System.Windows.Forms.RadioButton
    Friend WithEvents rbtOtro As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbRoles As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCorreoElectronico As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmacionContraseña As System.Windows.Forms.TextBox

End Class
