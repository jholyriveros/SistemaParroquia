<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.fraAcceso = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtClave = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.fraConfiguracion = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnCancelarBD = New System.Windows.Forms.Button()
        Me.BtnAceptarBD = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtClaveBD = New System.Windows.Forms.TextBox()
        Me.TxtUsuarioBD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtBaseDatos = New System.Windows.Forms.TextBox()
        Me.TxtServidor = New System.Windows.Forms.TextBox()
        Me.fraAcceso.SuspendLayout()
        Me.fraConfiguracion.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraAcceso
        '
        Me.fraAcceso.BackColor = System.Drawing.SystemColors.Control
        Me.fraAcceso.Controls.Add(Me.Label4)
        Me.fraAcceso.Controls.Add(Me.Label3)
        Me.fraAcceso.Controls.Add(Me.Label2)
        Me.fraAcceso.Controls.Add(Me.Label1)
        Me.fraAcceso.Controls.Add(Me.TxtClave)
        Me.fraAcceso.Controls.Add(Me.TxtUsuario)
        Me.fraAcceso.Controls.Add(Me.BtnAceptar)
        Me.fraAcceso.Location = New System.Drawing.Point(12, 12)
        Me.fraAcceso.Name = "fraAcceso"
        Me.fraAcceso.Size = New System.Drawing.Size(492, 226)
        Me.fraAcceso.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(49, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(413, 35)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "PARROQUIA SAN JOSÉ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(66, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(380, 34)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Sistema documentario"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "CLAVE:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "USUARIO:"
        '
        'TxtClave
        '
        Me.TxtClave.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClave.Location = New System.Drawing.Point(203, 123)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClave.Size = New System.Drawing.Size(169, 25)
        Me.TxtClave.TabIndex = 1
        Me.TxtClave.Text = "111"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(203, 89)
        Me.TxtUsuario.MaxLength = 10
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(169, 25)
        Me.TxtUsuario.TabIndex = 0
        Me.TxtUsuario.Text = "jriveros"
        '
        'BtnAceptar
        '
        Me.BtnAceptar.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.ForeColor = System.Drawing.Color.White
        Me.BtnAceptar.Location = New System.Drawing.Point(212, 168)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(100, 38)
        Me.BtnAceptar.TabIndex = 17
        Me.BtnAceptar.Text = "ACEPTAR"
        Me.BtnAceptar.UseVisualStyleBackColor = False
        '
        'fraConfiguracion
        '
        Me.fraConfiguracion.BackColor = System.Drawing.Color.LightGreen
        Me.fraConfiguracion.Controls.Add(Me.Label10)
        Me.fraConfiguracion.Controls.Add(Me.BtnCancelarBD)
        Me.fraConfiguracion.Controls.Add(Me.BtnAceptarBD)
        Me.fraConfiguracion.Controls.Add(Me.Label7)
        Me.fraConfiguracion.Controls.Add(Me.Label8)
        Me.fraConfiguracion.Controls.Add(Me.TxtClaveBD)
        Me.fraConfiguracion.Controls.Add(Me.TxtUsuarioBD)
        Me.fraConfiguracion.Controls.Add(Me.Label5)
        Me.fraConfiguracion.Controls.Add(Me.Label6)
        Me.fraConfiguracion.Controls.Add(Me.TxtBaseDatos)
        Me.fraConfiguracion.Controls.Add(Me.TxtServidor)
        Me.fraConfiguracion.Location = New System.Drawing.Point(127, 37)
        Me.fraConfiguracion.Name = "fraConfiguracion"
        Me.fraConfiguracion.Size = New System.Drawing.Size(254, 171)
        Me.fraConfiguracion.TabIndex = 19
        Me.fraConfiguracion.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Configuración de BD."
        '
        'BtnCancelarBD
        '
        Me.BtnCancelarBD.Location = New System.Drawing.Point(128, 132)
        Me.BtnCancelarBD.Name = "BtnCancelarBD"
        Me.BtnCancelarBD.Size = New System.Drawing.Size(61, 24)
        Me.BtnCancelarBD.TabIndex = 33
        Me.BtnCancelarBD.Text = "Cancelar"
        Me.BtnCancelarBD.UseVisualStyleBackColor = True
        '
        'BtnAceptarBD
        '
        Me.BtnAceptarBD.Location = New System.Drawing.Point(61, 132)
        Me.BtnAceptarBD.Name = "BtnAceptarBD"
        Me.BtnAceptarBD.Size = New System.Drawing.Size(61, 24)
        Me.BtnAceptarBD.TabIndex = 32
        Me.BtnAceptarBD.Text = "Aceptar"
        Me.BtnAceptarBD.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Clave"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Usuario"
        '
        'TxtClaveBD
        '
        Me.TxtClaveBD.Location = New System.Drawing.Point(97, 97)
        Me.TxtClaveBD.Name = "TxtClaveBD"
        Me.TxtClaveBD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClaveBD.Size = New System.Drawing.Size(140, 20)
        Me.TxtClaveBD.TabIndex = 29
        '
        'TxtUsuarioBD
        '
        Me.TxtUsuarioBD.Location = New System.Drawing.Point(97, 70)
        Me.TxtUsuarioBD.Name = "TxtUsuarioBD"
        Me.TxtUsuarioBD.Size = New System.Drawing.Size(140, 20)
        Me.TxtUsuarioBD.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Base de Datos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Servidor"
        '
        'TxtBaseDatos
        '
        Me.TxtBaseDatos.Location = New System.Drawing.Point(97, 45)
        Me.TxtBaseDatos.Name = "TxtBaseDatos"
        Me.TxtBaseDatos.Size = New System.Drawing.Size(140, 20)
        Me.TxtBaseDatos.TabIndex = 25
        '
        'TxtServidor
        '
        Me.TxtServidor.Location = New System.Drawing.Point(97, 18)
        Me.TxtServidor.Name = "TxtServidor"
        Me.TxtServidor.Size = New System.Drawing.Size(140, 20)
        Me.TxtServidor.TabIndex = 24
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(518, 251)
        Me.Controls.Add(Me.fraAcceso)
        Me.Controls.Add(Me.fraConfiguracion)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(534, 290)
        Me.MinimumSize = New System.Drawing.Size(534, 290)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Acceso"
        Me.fraAcceso.ResumeLayout(False)
        Me.fraAcceso.PerformLayout()
        Me.fraConfiguracion.ResumeLayout(False)
        Me.fraConfiguracion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fraAcceso As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtClave As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents BtnAceptar As Button
    Friend WithEvents fraConfiguracion As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents BtnCancelarBD As Button
    Friend WithEvents BtnAceptarBD As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtClaveBD As TextBox
    Friend WithEvents TxtUsuarioBD As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtBaseDatos As TextBox
    Friend WithEvents TxtServidor As TextBox
End Class
