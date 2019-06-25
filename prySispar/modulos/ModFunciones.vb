Module ModFunciones
    Public CODUSU As String
    Public NIVPERFIL As String

    Public Function DesencryptarCnx$(ByVal Strg$, ByVal Password$)
        Dim b, i, j
        Dim A1, A2, A3
        Dim P As String = ""
        Dim s As String = ""
        j = 1
        For i = 1 To Len(Password$)
            P = P & Asc(Mid$(Password$, i, 1))
        Next
        For i = 1 To Len(Strg$) Step 2
            A1 = Asc(Mid$(P, j, 1))
            j = j + 1 : If j > Len(P) Then j = 1
            b = Mid$(Strg$, i, 2)
            A3 = Val("&H" & b)
            A2 = A1 Xor A3
            s = s & ChrW(A2)
        Next
        DesencryptarCnx$ = s
    End Function

    Public Function EncryptarCnx$(ByVal Strg$, ByVal Password$)
        Dim b, i, j
        Dim P As String = ""
        Dim s As String = ""
        Dim A1, A2, A3

        j = 1
        For i = 1 To Len(Password$)
            P = P & Asc(Mid$(Password$, i, 1))
        Next

        For i = 1 To Len(Strg$)
            A1 = Asc(Mid$(P, j, 1))
            j = j + 1 : If j > Len(P) Then j = 1
            A2 = Asc(Mid$(Strg$, i, 1))
            A3 = A1 Xor A2
            b = Hex$(A3)
            If Len(b) < 2 Then b = "0" + b
            s = s + b
        Next
        EncryptarCnx$ = s
    End Function
End Module
