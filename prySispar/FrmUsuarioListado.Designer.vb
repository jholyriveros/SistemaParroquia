<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarioListado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarioListado))
        Me.btnCancelarClave = New System.Windows.Forms.Button()
        Me.btnGrabarClave = New System.Windows.Forms.Button()
        Me.txtOldClave = New System.Windows.Forms.TextBox()
        Me.txtNewClave = New System.Windows.Forms.TextBox()
        Me.txtConfirClave = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelClave = New System.Windows.Forms.Panel()
        Me.btnModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnModificarClave = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panelNuevo = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboPerfil = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.groupEstado = New System.Windows.Forms.GroupBox()
        Me.rdbInactivo = New System.Windows.Forms.RadioButton()
        Me.rdbActivo = New System.Windows.Forms.RadioButton()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnGuardarNuevo = New System.Windows.Forms.Button()
        Me.btnCancelarNuevo = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PanelClave.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNuevo.SuspendLayout()
        Me.groupEstado.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelarClave
        '
        Me.btnCancelarClave.Location = New System.Drawing.Point(155, 143)
        Me.btnCancelarClave.Name = "btnCancelarClave"
        Me.btnCancelarClave.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarClave.TabIndex = 3
        Me.btnCancelarClave.Text = "CANCELAR"
        Me.btnCancelarClave.UseVisualStyleBackColor = True
        '
        'btnGrabarClave
        '
        Me.btnGrabarClave.Location = New System.Drawing.Point(74, 143)
        Me.btnGrabarClave.Name = "btnGrabarClave"
        Me.btnGrabarClave.Size = New System.Drawing.Size(75, 23)
        Me.btnGrabarClave.TabIndex = 3
        Me.btnGrabarClave.Text = "GRABAR"
        Me.btnGrabarClave.UseVisualStyleBackColor = True
        '
        'txtOldClave
        '
        Me.txtOldClave.Location = New System.Drawing.Point(136, 56)
        Me.txtOldClave.MaxLength = 15
        Me.txtOldClave.Name = "txtOldClave"
        Me.txtOldClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldClave.Size = New System.Drawing.Size(142, 20)
        Me.txtOldClave.TabIndex = 2
        '
        'txtNewClave
        '
        Me.txtNewClave.Location = New System.Drawing.Point(136, 82)
        Me.txtNewClave.MaxLength = 15
        Me.txtNewClave.Name = "txtNewClave"
        Me.txtNewClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewClave.Size = New System.Drawing.Size(142, 20)
        Me.txtNewClave.TabIndex = 2
        '
        'txtConfirClave
        '
        Me.txtConfirClave.Location = New System.Drawing.Point(136, 107)
        Me.txtConfirClave.MaxLength = 15
        Me.txtConfirClave.Name = "txtConfirClave"
        Me.txtConfirClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirClave.Size = New System.Drawing.Size(142, 20)
        Me.txtConfirClave.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Confirmar clave:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nueva anterior:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Clave anterior:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CAMBIAR CLAVE"
        '
        'PanelClave
        '
        Me.PanelClave.Controls.Add(Me.btnCancelarClave)
        Me.PanelClave.Controls.Add(Me.btnGrabarClave)
        Me.PanelClave.Controls.Add(Me.txtOldClave)
        Me.PanelClave.Controls.Add(Me.txtNewClave)
        Me.PanelClave.Controls.Add(Me.txtConfirClave)
        Me.PanelClave.Controls.Add(Me.Label5)
        Me.PanelClave.Controls.Add(Me.Label4)
        Me.PanelClave.Controls.Add(Me.Label3)
        Me.PanelClave.Controls.Add(Me.Label1)
        Me.PanelClave.Location = New System.Drawing.Point(170, 110)
        Me.PanelClave.Name = "PanelClave"
        Me.PanelClave.Size = New System.Drawing.Size(306, 178)
        Me.PanelClave.TabIndex = 153
        Me.PanelClave.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(66, 35)
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnModificar, Me.btnModificarClave, Me.btnEliminar, Me.ToolStripSeparator3, Me.btnCancelar})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(635, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(69, 370)
        Me.ToolStrip1.TabIndex = 150
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(66, 35)
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnModificarClave
        '
        Me.btnModificarClave.Image = CType(resources.GetObject("btnModificarClave.Image"), System.Drawing.Image)
        Me.btnModificarClave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificarClave.Name = "btnModificarClave"
        Me.btnModificarClave.Size = New System.Drawing.Size(66, 35)
        Me.btnModificarClave.Text = "Mod Clave"
        Me.btnModificarClave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(66, 35)
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(66, 6)
        '
        'btnCancelar
        '
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(66, 35)
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = False
        Me.dgvListado.AllowUserToDeleteRows = False
        Me.dgvListado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Location = New System.Drawing.Point(8, 45)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.ReadOnly = True
        Me.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListado.Size = New System.Drawing.Size(610, 313)
        Me.dgvListado.TabIndex = 151
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 18)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "USUARIOS DEL SISTEMA"
        '
        'panelNuevo
        '
        Me.panelNuevo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelNuevo.Controls.Add(Me.btnCancelarNuevo)
        Me.panelNuevo.Controls.Add(Me.btnGuardarNuevo)
        Me.panelNuevo.Controls.Add(Me.cboPerfil)
        Me.panelNuevo.Controls.Add(Me.Label7)
        Me.panelNuevo.Controls.Add(Me.groupEstado)
        Me.panelNuevo.Controls.Add(Me.lblClave)
        Me.panelNuevo.Controls.Add(Me.txtClave)
        Me.panelNuevo.Controls.Add(Me.Label9)
        Me.panelNuevo.Controls.Add(Me.txtNombre)
        Me.panelNuevo.Controls.Add(Me.Label8)
        Me.panelNuevo.Controls.Add(Me.txtUsuario)
        Me.panelNuevo.Controls.Add(Me.Label6)
        Me.panelNuevo.Location = New System.Drawing.Point(130, 101)
        Me.panelNuevo.Name = "panelNuevo"
        Me.panelNuevo.Size = New System.Drawing.Size(391, 219)
        Me.panelNuevo.TabIndex = 154
        Me.panelNuevo.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(20, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "NUEVO USUARIO"
        '
        'cboPerfil
        '
        Me.cboPerfil.Enabled = False
        Me.cboPerfil.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cboPerfil.FormattingEnabled = True
        Me.cboPerfil.Location = New System.Drawing.Point(94, 134)
        Me.cboPerfil.Name = "cboPerfil"
        Me.cboPerfil.Size = New System.Drawing.Size(160, 24)
        Me.cboPerfil.TabIndex = 173
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 175
        Me.Label7.Text = "PERFIL:"
        '
        'groupEstado
        '
        Me.groupEstado.Controls.Add(Me.rdbInactivo)
        Me.groupEstado.Controls.Add(Me.rdbActivo)
        Me.groupEstado.Enabled = False
        Me.groupEstado.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.groupEstado.Location = New System.Drawing.Point(274, 83)
        Me.groupEstado.Name = "groupEstado"
        Me.groupEstado.Size = New System.Drawing.Size(100, 68)
        Me.groupEstado.TabIndex = 174
        Me.groupEstado.TabStop = False
        Me.groupEstado.Text = "Estado"
        '
        'rdbInactivo
        '
        Me.rdbInactivo.AutoSize = True
        Me.rdbInactivo.Location = New System.Drawing.Point(10, 42)
        Me.rdbInactivo.Name = "rdbInactivo"
        Me.rdbInactivo.Size = New System.Drawing.Size(69, 20)
        Me.rdbInactivo.TabIndex = 1
        Me.rdbInactivo.Text = "Inactivo"
        Me.rdbInactivo.UseVisualStyleBackColor = True
        '
        'rdbActivo
        '
        Me.rdbActivo.AutoSize = True
        Me.rdbActivo.Checked = True
        Me.rdbActivo.Location = New System.Drawing.Point(10, 19)
        Me.rdbActivo.Name = "rdbActivo"
        Me.rdbActivo.Size = New System.Drawing.Size(61, 20)
        Me.rdbActivo.TabIndex = 0
        Me.rdbActivo.TabStop = True
        Me.rdbActivo.Text = "Activo"
        Me.rdbActivo.UseVisualStyleBackColor = True
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Location = New System.Drawing.Point(29, 108)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(44, 13)
        Me.lblClave.TabIndex = 173
        Me.lblClave.Text = "CLAVE:"
        '
        'txtClave
        '
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtClave.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txtClave.Location = New System.Drawing.Point(94, 105)
        Me.txtClave.MaxLength = 15
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(160, 22)
        Me.txtClave.TabIndex = 172
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 171
        Me.Label8.Text = "USUARIO:"
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(94, 76)
        Me.txtUsuario.MaxLength = 30
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(160, 22)
        Me.txtUsuario.TabIndex = 171
        '
        'btnGuardarNuevo
        '
        Me.btnGuardarNuevo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnGuardarNuevo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarNuevo.ForeColor = System.Drawing.Color.White
        Me.btnGuardarNuevo.Location = New System.Drawing.Point(94, 169)
        Me.btnGuardarNuevo.Name = "btnGuardarNuevo"
        Me.btnGuardarNuevo.Size = New System.Drawing.Size(84, 33)
        Me.btnGuardarNuevo.TabIndex = 174
        Me.btnGuardarNuevo.Text = "Guardar"
        Me.btnGuardarNuevo.UseVisualStyleBackColor = False
        '
        'btnCancelarNuevo
        '
        Me.btnCancelarNuevo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCancelarNuevo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarNuevo.ForeColor = System.Drawing.Color.White
        Me.btnCancelarNuevo.Location = New System.Drawing.Point(193, 169)
        Me.btnCancelarNuevo.Name = "btnCancelarNuevo"
        Me.btnCancelarNuevo.Size = New System.Drawing.Size(84, 33)
        Me.btnCancelarNuevo.TabIndex = 175
        Me.btnCancelarNuevo.Text = "Cancelar"
        Me.btnCancelarNuevo.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(94, 46)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(280, 22)
        Me.txtNombre.TabIndex = 170
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 171
        Me.Label9.Text = "NOMBRE:"
        '
        'FrmUsuarioListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(704, 370)
        Me.Controls.Add(Me.panelNuevo)
        Me.Controls.Add(Me.PanelClave)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvListado)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FrmUsuarioListado"
        Me.Text = "Usuarios del sistema"
        Me.PanelClave.ResumeLayout(False)
        Me.PanelClave.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNuevo.ResumeLayout(False)
        Me.panelNuevo.PerformLayout()
        Me.groupEstado.ResumeLayout(False)
        Me.groupEstado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarClave As Button
    Friend WithEvents btnGrabarClave As Button
    Friend WithEvents txtOldClave As TextBox
    Friend WithEvents txtNewClave As TextBox
    Friend WithEvents txtConfirClave As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelClave As Panel
    Friend WithEvents btnModificar As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents btnModificarClave As ToolStripButton
    Friend WithEvents btnEliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btnCancelar As ToolStripButton
    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents panelNuevo As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCancelarNuevo As Button
    Friend WithEvents btnGuardarNuevo As Button
    Friend WithEvents cboPerfil As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents groupEstado As GroupBox
    Friend WithEvents rdbInactivo As RadioButton
    Friend WithEvents rdbActivo As RadioButton
    Friend WithEvents lblClave As Label
    Friend WithEvents txtClave As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNombre As TextBox
End Class
