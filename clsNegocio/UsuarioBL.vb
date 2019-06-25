Imports clsDatos
Public Class UsuarioBL
    Dim objUsu As New UsuarioDAO

    Function fun_validar_acceso(usuario As String, clave As String) As String
        Try
            Dim perfil As String = objUsu.validar_acceso(usuario, clave)
            If IsDBNull(perfil) Then perfil = ""
            Return perfil
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
