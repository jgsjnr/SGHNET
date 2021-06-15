Module ModuleGeneral
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String
    Public compName = Environment.MachineName
    Public session As Boolean
    Public sessionUser As String
    Public sessionLevel As String
    Public updateLevel As Boolean
    Public rowValue As String
    Public diretorio As String
    Public pesquisa As String

    Sub conBanco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=SQLOLEDB;Data Source='" & Environment.MachineName & "';Initial Catalog=sgh;trusted_connection=yes;")
            MsgBox("Conectado com sucesso!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        Catch ex As Exception
            MsgBox("Conexão mal sucedida", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub
    Function numGen()
        Dim num As Integer
        Dim result As Integer
        sql = "select * from info"
        rs = db.Execute(sql)
        If rs.EOF And rs.BOF Then
            If rs.RecordCount <= 0 Then
                result = 0
            Else
                num = CInt(rs.Fields(0).Value)
                If num = 0 Then
                    result = 1
                Else
                    result = num + 1
                End If
            End If
        Else
            sql = "SELECT MAX(id) from info"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                num = CInt(rs.Fields(0).Value)
                If num = 0 Then
                    result = 1
                Else
                    result = num + 1
                End If
            End If
        End If
        Return result
    End Function
End Module
