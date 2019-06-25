Imports System.IO
Imports clsNegocio
Public Class FrmLogin
    Dim ruta As String = "D:\SISPAR_NO_ELIMINAR\"

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            pr_PV_Conexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pr_PV_Conexion()
        If Not Directory.Exists(ruta) Then Directory.CreateDirectory(ruta)
        Dim objFSO As Object
        objFSO = CreateObject("Scripting.FileSystemObject")
        Dim objTextStream As Object
        Dim strCadena As String


        Const strFileName = "Config_sp.ini"
        If objFSO.FileExists(ruta & strFileName) Then
            objTextStream = objFSO.OpenTextFile(ruta & strFileName, 1)
            'PryClsVariables.CADENA_CONEXION = "Data Source=10.10.10.11;Initial Catalog=bdParroquia;User ID=u_parroquia;Password=123456"
            strCadena = DesencryptarCnx$(objTextStream.ReadLine, "123456")
            clsEstructuras.CADENA_CN = strCadena
            objTextStream.Close()
            objTextStream = Nothing
        Else
            fraConfiguracion.Visible = True : fraAcceso.Visible = False
        End If
        'Clean up
        objFSO = Nothing
        'objFSO = CreateObject("Scripting.FileSystemObject")
        'objFile = objFSO.CreateTextFile("C:\FSO\ScriptLog.txt")
    End Sub

    Private Sub BtnAceptarBD_Click(sender As Object, e As EventArgs) Handles BtnAceptarBD.Click
        Try
            Dim objFSO As Object
            objFSO = CreateObject("Scripting.FileSystemObject")
            Dim objTextStream As Object
            Dim strCadena As String
            strCadena = "Data Source=" & TxtServidor.Text.Trim & ";Initial Catalog=" & TxtBaseDatos.Text.Trim & ";User ID=" & TxtUsuarioBD.Text.Trim & ";Password=" & TxtClaveBD.Text.Trim & ";Connect Timeout=9000"
            objTextStream = objFSO.CreateTextFile(ruta & "Config_sp.ini", True)
            strCadena = EncryptarCnx$(strCadena, "123456")
            objTextStream.WriteLine(strCadena)

            objTextStream.close()
            objTextStream = Nothing
            fraConfiguracion.Visible = False
            fraAcceso.Visible = True
            pr_PV_Conexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            Dim usu As String = TxtUsuario.Text.Trim.ToUpper
            Dim pass As String = TxtClave.Text.Trim
            Dim objUsu As New UsuarioBL
            Dim perfil As String = objUsu.fun_validar_acceso(usu, pass)

            If perfil <> "" Then
                CODUSU = usu
                NIVPERFIL = perfil
                Me.Visible = False
                mdiPrincipal.ShowDialog()
            Else
                Throw New Exception("Usuario o clave no válidos, verificar.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TxtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtClave.KeyPress
        If Asc(e.KeyChar) = 13 Then Call BtnAceptar_Click(Nothing, Nothing)
    End Sub

    Private Sub BtnCancelarBD_Click(sender As Object, e As EventArgs) Handles BtnCancelarBD.Click
        End
    End Sub
End Class