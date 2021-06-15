Public Class Main
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim table As New DataTable
        table.Columns.Add("ID", Type.GetType("System.String"))
        table.Columns.Add("Nome", Type.GetType("System.String"))
        table.Columns.Add("CPF", Type.GetType("System.String"))
        table.Columns.Add("Data de Nascimento", Type.GetType("System.String"))
        table.Columns.Add("Estado Civil", Type.GetType("System.String"))
        table.Columns.Add("Cor", Type.GetType("System.String"))
        table.Columns.Add("Tipo Sanguineo", Type.GetType("System.String"))
        table.Columns.Add("Alergia", Type.GetType("System.String"))
        table.Columns.Add("Tipo de Alergia", Type.GetType("System.String"))
        table.Columns.Add("Resposável", Type.GetType("System.String"))
        table.Columns.Add("Nome do Responsável", Type.GetType("System.String"))
        table.Columns.Add("CPF Responsável", Type.GetType("System.String"))
        table.Columns.Add("Endereço", Type.GetType("System.String"))
        table.Columns.Add("Complemento", Type.GetType("System.String"))
        table.Columns.Add("Cidade", Type.GetType("System.String"))
        table.Columns.Add("UF", Type.GetType("System.String"))
        table.Columns.Add("CEP", Type.GetType("System.String"))
        table.Columns.Add("Telefone", Type.GetType("System.String"))
        table.Columns.Add("Celular", Type.GetType("System.String"))
        table.Columns.Add("E-mail", Type.GetType("System.String"))
        table.Columns.Add("Observações", Type.GetType("System.String"))
        table.Columns.Add("Status", Type.GetType("System.String"))
        DataGridView1.DataSource = table
        sql = "SELECT MAX(id) from info"
        rs = db.Execute(sql)
        Dim max As Integer = CInt(rs.Fields(0).Value)
        For number As Integer = 0 To max Step 1
            sql = "select * from info where id = '" & number & "'"
            rs = db.Execute(sql)
            table.Rows.Add(rs.Fields(0).Value, rs.Fields(1).Value, rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value, rs.Fields(5).Value, rs.Fields(6).Value, rs.Fields(7).Value, rs.Fields(8).Value, rs.Fields(9).Value, rs.Fields(10).Value, rs.Fields(11).Value, rs.Fields(12).Value, rs.Fields(13).Value, rs.Fields(14).Value, rs.Fields(15).Value, rs.Fields(16).Value, rs.Fields(17).Value, rs.Fields(18).Value, rs.Fields(19).Value, rs.Fields(20).Value, rs.Fields(21).Value)
            If rs.EOF = True Then
                Exit For
            End If
        Next
    End Sub


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        btnDisable.Enabled = True
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        Dim variable As String
        variable = DataGridView1.CurrentRow.Cells(2).Value.ToString
        rowValue = variable
        MsgBox("ID:" + selectedRow.Cells(0).Value.ToString & Environment.NewLine &
               "Nome:" + selectedRow.Cells(1).Value.ToString & Environment.NewLine &
               "CPF:" + selectedRow.Cells(2).Value.ToString & Environment.NewLine &
               "Data de Nascimento:" + selectedRow.Cells(3).Value.ToString & Environment.NewLine &
               "Estado Civil:" + selectedRow.Cells(4).Value.ToString & Environment.NewLine &
               "Cor:" + selectedRow.Cells(5).Value.ToString & Environment.NewLine &
               "Tipo Sanguíneo:" + selectedRow.Cells(6).Value.ToString & Environment.NewLine &
               "Alergia:" + selectedRow.Cells(7).Value.ToString & Environment.NewLine &
               "Tipo de Alergia:" + selectedRow.Cells(8).Value.ToString & Environment.NewLine &
               "Responsável:" + selectedRow.Cells(9).Value.ToString & Environment.NewLine &
               "Nome do Responsável:" + selectedRow.Cells(10).Value.ToString & Environment.NewLine &
               "CPF do Responsável:" + selectedRow.Cells(11).Value.ToString & Environment.NewLine &
               "Endereço:" + selectedRow.Cells(12).Value.ToString & Environment.NewLine &
               "Complemento:" + selectedRow.Cells(13).Value.ToString & Environment.NewLine &
               "Cidade:" + selectedRow.Cells(14).Value.ToString & Environment.NewLine &
               "UF:" + selectedRow.Cells(15).Value.ToString & Environment.NewLine &
               "CEP:" + selectedRow.Cells(16).Value.ToString & Environment.NewLine &
               "Telefone:" + selectedRow.Cells(17).Value.ToString & Environment.NewLine &
               "Celular:" + selectedRow.Cells(18).Value.ToString & Environment.NewLine &
               "Email:" + selectedRow.Cells(19).Value.ToString & Environment.NewLine &
               "Observações:" + selectedRow.Cells(20).Value.ToString & Environment.NewLine &
               "Status:" + selectedRow.Cells(21).Value.ToString, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
    End Sub

    Private Sub Main_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        Try
            sql = "update info set status='desativado' where cpf='" & rowValue & "'"
            rs = db.Execute(sql)
            MsgBox("Desativação de cadastro concluida com sucesso!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
            btnSearch.PerformClick()
        Catch ex As Exception
            MsgBox("Deu ruim", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        Dim recordLoad As New Record
        updateLevel = True
        recordLoad.Show()
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Dim menuLoad As New Menu
        Close()
        menuLoad.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        updateLevel = True
        Dim recordLoad As New Record
        Try
            sql = "select * from info where cpf='" & rowValue & "'"
            rs = db.Execute(sql)
            If rs.EOF = False Then
                With recordLoad
                    .txtName.Text = rs.Fields(1).Value
                    .txtCpf.Text = rs.Fields(2).Value
                    .txtBirthday.Text = rs.Fields(3).Value
                    .cmbCivil.Text = rs.Fields(4).Value
                    .cmbColor.Text = rs.Fields(5).Value
                    .cmbBlood.Text = rs.Fields(6).Value
                    .cmbAlergy.Text = rs.Fields(7).Value
                    .txtAlergy.Text = rs.Fields(8).Value
                    .cmbResp.Text = rs.Fields(9).Value
                    .txtNameResp.Text = rs.Fields(10).Value
                    .txtCpfResp.Text = rs.Fields(11).Value
                    .txtAddress.Text = rs.Fields(12).Value
                    .txtComp.Text = rs.Fields(13).Value
                    .txtCity.Text = rs.Fields(14).Value
                    .txtUf.Text = rs.Fields(15).Value
                    .txtCep.Text = rs.Fields(16).Value
                    .txtTel.Text = rs.Fields(17).Value
                    .txtCel.Text = rs.Fields(18).Value
                    .txtMail.Text = rs.Fields(19).Value
                    .txtObs.Text = rs.Fields(20).Value
                End With
                MsgBox("Busca bem sucessidada", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "AVISO")
            End If
        Catch ex As Exception
            MsgBox("Erro", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "AVISO")
        End Try
        recordLoad.txtCpf.Text = rowValue
        recordLoad.Show()
    End Sub
End Class