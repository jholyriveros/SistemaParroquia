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
        Me.PanelClave.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelClave.Location = New System.Drawing.Point(78, 100)
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
        Me.ToolStrip1.Location = New System.Drawing.Point(464, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(69, 362)
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
        Me.dgvListado.Size = New System.Drawing.Size(439, 305)
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
        'FrmUsuarioListado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(533, 362)
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
End Class
