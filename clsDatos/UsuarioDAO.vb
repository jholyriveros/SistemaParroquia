Imports System.Data
Imports System.Data.SqlClient

Public Class UsuarioDAO
    Dim sql As String
    Dim objUtil As New util

    Function validar_acceso(usuario As String, clave As String) As String
        Try
            sql = "select idPerfil from tbUsuario where usuario = '" + usuario + "' and clave = '" + clave + "' and estado = 'A'"
            Dim perfil As String = ""

            Using cn As New SqlConnection(clsEstructuras.CADENA_CN)
                cn.Open()
                Dim cmd As New SqlCommand(sql, cn)
                cmd.CommandType = CommandType.Text
                perfil = cmd.ExecuteScalar()
            End Using
            Return perfil
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function listar_usuarios() As DataTable
        Try
            Return objUtil.fun_ejecutar_script("usp_tbUsuario_listar", "sp")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
