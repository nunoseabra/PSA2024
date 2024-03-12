Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub VerificarCredenciais()
        ' Acessando a variável RFID_CartaoAtual do módulo
        Dim cartaoAtual As String = Module1.credencial
        ' Faça a verificação das credenciais com base no valor de cartaoAtual
        ' Verificação das credenciais com base no valor do cartão atual
        Select Case cartaoAtual
            Case "0307546191"
                ' Se o cartão for "1111", verifica as credenciais de Joao
                If txtID.Text = "Joao" AndAlso txtPass.Text = "0000" Then
                    MessageBox.Show("Credenciais válidas para Joao.")
                    Me.Close()
                    ' Exibe novamente o Form1
                    Dim form1 As Form1 = DirectCast(Application.OpenForms("Form1"), Form1)
                    form1.ShowForm1Again()
                Else
                    MessageBox.Show("Credenciais inválidas.")
                    ' Limpa os campos de ID e senha para nova entrada
                    If txtID.Text = "Joao" Then
                        txtPass.Clear()
                    ElseIf txtPass.Text = "0000" Then
                        txtID.Clear()
                    End If
                End If
            Case "0307598534"
                ' Se o cartão for "2222", verifica as credenciais de Antonio
                If txtID.Text = "Antonio" AndAlso txtPass.Text = "1234" Then
                    MessageBox.Show("Credenciais válidas para Antonio.")
                    Me.Close()
                    ' Exibe novamente o Form1
                    Dim form1 As Form1 = DirectCast(Application.OpenForms("Form1"), Form1)
                    form1.ShowForm1Again()
                Else
                    MessageBox.Show("Credenciais inválidas para Antonio.")
                    ' Limpa os campos de ID e senha para nova entrada
                    If txtID.Text = "Antonio" Then
                        txtPass.Clear()
                    ElseIf txtPass.Text = "1234" Then
                        
                    End If
                End If
            Case Else
                ' Cartão não reconhecido
                MessageBox.Show("Cartão não reconhecido.")
                ' Limpa os campos de ID e senha para nova entrada
                txtID.Clear()
                txtPass.Clear()
        End Select

    End Sub
    Private Sub btnVerificar_Click(sender As Object, e As EventArgs) Handles btnVerificar.Click
        VerificarCredenciais()

    End Sub
End Class
