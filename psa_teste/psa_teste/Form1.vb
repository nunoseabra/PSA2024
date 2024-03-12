Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Private credenciais As New Dictionary(Of String, (String, String)) ' Dicionário para armazenar as credenciais associadas aos cartões RFID

    ' Adicionar credenciais de exemplo ao dicionário
    Private Sub AdicionarCredenciaisDeExemplo()
        credenciais.Add("0307546191", ("José", "0000"))
        ' Adicionar mais credenciais conforme necessário
    End Sub



    Private Sub btnLer_Click(sender As Object, e As EventArgs) Handles btnLer.Click
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        If e.KeyCode = Keys.Enter Then ' Verificar se a tecla Enter foi pressionada
            credencial = TextBox1.Text.Trim()
            'Validação da credencial do cartão
            If credenciaisValidas.Contains(credencial) Then
                Dim form2 As New Form2()
                Me.Hide()
                form2.ShowDialog()

            Else
                MessageBox.Show("CARTÃO NÃO AUTORIZADO")
            End If

            'TextBox1.Clear() ' Limpar o conteúdo da TextBox invisível
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Centralizar a Label
        Label1.Left = (Me.ClientSize.Width - Label1.Width) / 2
        Label1.Top = (Me.ClientSize.Height - Label1.Height) / 2

        ' Centralizar o Button
        btnLer.Left = (Me.ClientSize.Width - btnLer.Width) / 2
        btnLer.Top = Label1.Bottom + 20 ' Espaçamento de 20 pixels abaixo da Label
    End Sub
    Public Sub ShowForm1Again()
        Me.Show() ' Exibe o Form1 novamente
        btnLer.Focus()
        TextBox1.Clear()
    End Sub


End Class
