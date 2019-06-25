Imports clsNegocio

Public Class FrmUsuarioListado
    Dim objUsu As New UsuarioBL

    Private Sub FrmUsuarioListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim objCbo As New ComboBL()
            cboPerfil.DataSource = objCbo.fun_listar_perfiles()
            cboPerfil.ValueMember = "idPerfil"
            cboPerfil.DisplayMember = "descripcion"

            dgvListado.DataSource = objUsu.fun_listar_usuarios()
            dgvListado.Columns(0).Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        panelNuevo.Visible = True
        txtNombre.Focus()
    End Sub

    Private Sub btnCancelarNuevo_Click(sender As Object, e As EventArgs) Handles btnCancelarNuevo.Click
        panelNuevo.Visible = False
        txtNombre.Clear()
        txtUsuario.Clear()
        txtClave.Clear()
        cboPerfil.SelectedIndex = 0
        rdbActivo.Checked = True
        rdbInactivo.Checked = False
    End Sub

    Private Sub btnGuardarNuevo_Click(sender As Object, e As EventArgs) Handles btnGuardarNuevo.Click

    End Sub
End Class