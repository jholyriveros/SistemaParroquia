Imports clsDatos

Public Class ComboBL
    Dim objCbo As New ComboDAO

    Function fun_listar_perfiles() As DataTable
        Try
            Return objCbo.listar_perfiles()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
