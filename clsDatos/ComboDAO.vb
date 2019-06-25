Imports System.Data.SqlClient

Public Class ComboDAO
    Dim objUtil As New util
    Dim sql As String

    Function listar_perfiles() As DataTable
        Try
            Return objUtil.fun_ejecutar_script("select * from tbPerfil order by 1 desc", "text")
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
