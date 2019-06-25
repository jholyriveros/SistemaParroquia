Imports System.Windows.Forms
Imports System.Deployment.Application


Public Class mdiPrincipal
    Private m_ChildFormNumber As Integer = 0

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub

    Private Sub mdiPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ToolStripStatusLabel.Text = "Usuario: " & CODUSU & "   Nombre de PC: " & System.Environment.MachineName
        If ApplicationDeployment.IsNetworkDeployed Then
            lblVersion.Text = "Versión " & ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
        Else
            lblVersion.Text = "Versión " & My.Application.Info.Version.ToString
        End If
        Permisos()
    End Sub

    Sub Permisos()
        If NIVPERFIL = "1" Then ' ADMIN
            TarfiasGuíasTCToolStripMenuItem.Visible = True
            GastosTourToolStripMenuItem.Visible = True
            UsuariosDelSistemaToolStripMenuItem.Visible = True
            FacturacionToolStripMenuItem.Visible = True
            ReportesToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub UsuariosDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosDelSistemaToolStripMenuItem.Click
        With FrmUsuarioListado
            .MdiParent = Me
            .Show()
        End With
    End Sub
End Class
