Imports System.Data
Imports System.Data.SqlClient
Public Class util
    ' Función para ejecutar un text o sp en SQL Server
    Function fun_ejecutar_script(query As String, tipo As String) As DataTable
        Try
            Using cn As New SqlConnection(clsEstructuras.CADENA_CN)
                cn.Open()
                Dim da As New SqlDataAdapter(query, cn)
                If tipo = "text" Then
                    da.SelectCommand.CommandType = CommandType.Text
                Else
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                End If
                da.SelectCommand.ExecuteNonQuery()
                Dim dt As New DataTable
                dt = New DataTable
                da.Fill(dt)
                Return dt
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Sub pr_ejecutar_script(query As String, tipo As String)
        Try
            Using cn As New SqlConnection(clsEstructuras.CADENA_CN)
                cn.Open()
                Dim cmd As New SqlCommand(query, cn)
                If tipo = "text" Then
                    cmd.CommandType = CommandType.Text
                Else
                    cmd.CommandType = CommandType.StoredProcedure
                End If
                cmd.ExecuteNonQuery()
                cmd.Dispose()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
End Class
