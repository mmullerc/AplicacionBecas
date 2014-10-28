<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarRol
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListarRol))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvRoles = New System.Windows.Forms.DataGridView()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PbRoles = New System.Windows.Forms.PictureBox()
        Me.btnCrearRol = New System.Windows.Forms.Button()
        Me.ComboBox = New System.Windows.Forms.ComboBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCrearRoles = New System.Windows.Forms.Button()
        Me.DGVRol = New System.Windows.Forms.DataGridView()
        Me.dtNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PBRol = New System.Windows.Forms.PictureBox()
        Me.Combo = New System.Windows.Forms.ComboBox()
        Me.lblBuscarRol = New System.Windows.Forms.Label()
        Me.txtBuscarRol = New System.Windows.Forms.TextBox()
        Me.btnBuscarRol = New System.Windows.Forms.Button()
        CType(Me.dgvRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbRoles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVRol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBRol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRoles
        '
        Me.dgvRoles.BackgroundColor = System.Drawing.Color.White
        Me.dgvRoles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRoles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaNombre})
        Me.dgvRoles.GridColor = System.Drawing.Color.White
        Me.dgvRoles.Location = New System.Drawing.Point(43, 197)
        Me.dgvRoles.Name = "dgvRoles"
        Me.dgvRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRoles.RowHeadersVisible = False
        Me.dgvRoles.Size = New System.Drawing.Size(778, 208)
        Me.dgvRoles.TabIndex = 12
        '
        'dtaNombre
        '
        Me.dtaNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dtaNombre.HeaderText = "Nombre"
        Me.dtaNombre.Name = "dtaNombre"
        Me.dtaNombre.ReadOnly = True
        Me.dtaNombre.Width = 200
        '
        'PbRoles
        '
        Me.PbRoles.Image = CType(resources.GetObject("PbRoles.Image"), System.Drawing.Image)
        Me.PbRoles.Location = New System.Drawing.Point(43, 167)
        Me.PbRoles.Name = "PbRoles"
        Me.PbRoles.Size = New System.Drawing.Size(778, 238)
        Me.PbRoles.TabIndex = 11
        Me.PbRoles.TabStop = False
        '
        'btnCrearRol
        '
        Me.btnCrearRol.BackgroundImage = CType(resources.GetObject("btnCrearRol.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearRol.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearRol.ForeColor = System.Drawing.Color.White
        Me.btnCrearRol.Location = New System.Drawing.Point(599, 65)
        Me.btnCrearRol.Name = "btnCrearRol"
        Me.btnCrearRol.Size = New System.Drawing.Size(222, 79)
        Me.btnCrearRol.TabIndex = 5
        Me.btnCrearRol.Text = "Crear Rol"
        Me.btnCrearRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearRol.UseVisualStyleBackColor = True
        '
        'ComboBox
        '
        Me.ComboBox.FormattingEnabled = True
        Me.ComboBox.Items.AddRange(New Object() {"Ver", "Editar", "Eliminar"})
        Me.ComboBox.Location = New System.Drawing.Point(360, 232)
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox.TabIndex = 14
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(130, 65)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscar.TabIndex = 15
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(49, 63)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(50, 20)
        Me.lblBuscar.TabIndex = 16
        Me.lblBuscar.Text = "Buscar"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(270, 55)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(102, 34)
        Me.btnBuscar.TabIndex = 17
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnCrearRoles
        '
        Me.btnCrearRoles.BackgroundImage = CType(resources.GetObject("btnCrearRoles.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearRoles.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearRoles.ForeColor = System.Drawing.Color.White
        Me.btnCrearRoles.Location = New System.Drawing.Point(661, 83)
        Me.btnCrearRoles.Name = "btnCrearRoles"
        Me.btnCrearRoles.Size = New System.Drawing.Size(222, 79)
        Me.btnCrearRoles.TabIndex = 5
        Me.btnCrearRoles.Text = "Crear Rol"
        Me.btnCrearRoles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearRoles.UseVisualStyleBackColor = True
        '
        'DGVRol
        '
        Me.DGVRol.BackgroundColor = System.Drawing.Color.White
        Me.DGVRol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVRol.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVRol.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVRol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtNombre})
        Me.DGVRol.GridColor = System.Drawing.Color.White
        Me.DGVRol.Location = New System.Drawing.Point(48, 257)
        Me.DGVRol.Name = "DGVRol"
        Me.DGVRol.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVRol.RowHeadersVisible = False
        Me.DGVRol.Size = New System.Drawing.Size(665, 224)
        Me.DGVRol.TabIndex = 11
        '
        'dtNombre
        '
        Me.dtNombre.HeaderText = "Nombre"
        Me.dtNombre.Name = "dtNombre"
        Me.dtNombre.Width = 200
        '
        'PBRol
        '
        Me.PBRol.Image = CType(resources.GetObject("PBRol.Image"), System.Drawing.Image)
        Me.PBRol.Location = New System.Drawing.Point(45, 217)
        Me.PBRol.Name = "PBRol"
        Me.PBRol.Size = New System.Drawing.Size(682, 276)
        Me.PBRol.TabIndex = 12
        Me.PBRol.TabStop = False
        '
        'Combo
        '
        Me.Combo.FormattingEnabled = True
        Me.Combo.Items.AddRange(New Object() {"Editar", "Eliminar", "Ver"})
        Me.Combo.Location = New System.Drawing.Point(477, 190)
        Me.Combo.Name = "Combo"
        Me.Combo.Size = New System.Drawing.Size(121, 21)
        Me.Combo.TabIndex = 13
        '
        'lblBuscarRol
        '
        Me.lblBuscarRol.AutoSize = True
        Me.lblBuscarRol.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarRol.Location = New System.Drawing.Point(118, 113)
        Me.lblBuscarRol.Name = "lblBuscarRol"
        Me.lblBuscarRol.Size = New System.Drawing.Size(50, 20)
        Me.lblBuscarRol.TabIndex = 14
        Me.lblBuscarRol.Text = "Buscar"
        '
        'txtBuscarRol
        '
        Me.txtBuscarRol.Location = New System.Drawing.Point(205, 115)
        Me.txtBuscarRol.Name = "txtBuscarRol"
        Me.txtBuscarRol.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscarRol.TabIndex = 15
        '
        'btnBuscarRol
        '
        Me.btnBuscarRol.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBuscarRol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscarRol.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarRol.ForeColor = System.Drawing.Color.White
        Me.btnBuscarRol.Location = New System.Drawing.Point(311, 107)
        Me.btnBuscarRol.Name = "btnBuscarRol"
        Me.btnBuscarRol.Size = New System.Drawing.Size(70, 30)
        Me.btnBuscarRol.TabIndex = 18
        Me.btnBuscarRol.Text = "Buscar"
        Me.btnBuscarRol.UseVisualStyleBackColor = False
        '
        'ListarRol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnBuscarRol)
        Me.Controls.Add(Me.txtBuscarRol)
        Me.Controls.Add(Me.lblBuscarRol)
        Me.Controls.Add(Me.Combo)
        Me.Controls.Add(Me.DGVRol)
        Me.Controls.Add(Me.PBRol)
        Me.Controls.Add(Me.btnCrearRoles)
        Me.Name = "ListarRol"
        Me.Size = New System.Drawing.Size(947, 530)
        CType(Me.dgvRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbRoles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVRol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBRol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCrearRol As System.Windows.Forms.Button
    Friend WithEvents PbRoles As System.Windows.Forms.PictureBox
    Friend WithEvents dgvRoles As System.Windows.Forms.DataGridView
    Public WithEvents ventana As AplicacionGestionBecas.UCntrlRegistrarRol
    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UCntrlRegistrarRol1 As AplicacionGestionBecas.UCntrlRegistrarRol
    Friend WithEvents ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCrearRoles As System.Windows.Forms.Button
    Friend WithEvents DGVRol As System.Windows.Forms.DataGridView
    Friend WithEvents dtNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PBRol As System.Windows.Forms.PictureBox
    Friend WithEvents Combo As System.Windows.Forms.ComboBox
    Friend WithEvents lblBuscarRol As System.Windows.Forms.Label
    Friend WithEvents txtBuscarRol As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarRol As System.Windows.Forms.Button

End Class
