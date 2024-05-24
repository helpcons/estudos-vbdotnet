Imports System

Module Program
    ' explorando a biblioteca DateTime
    Sub Main()
        ' ' obtendo a data do dia
        ' Dim dataDeHoje As Date = DateTime.Today
        ' Console.WriteLine(dataDeHoje.ToString("dd/MMMM/yyyy"))

        ' obtendo o horário atual
        Dim horaAgora As Date = DateTime.Now
        Console.WriteLine(horaAgora.ToString("HH")) ' formato para imprimir a hora "HH:mm:ss"
    End Sub
End Module

' Imports System
' Imports System.Threading

' Module Module1
'     Sub Main()
'         Dim condicao As Boolean = False
'         Dim horaAgora As Date = DateTime.Now
'         Dim minuto As Integer
'         Dim nada As Integer = 40

'         ' Loop para verificar a condição
'         While Not condicao
'             ' Verificar a condição
'             condicao = VerificarCondicao()

'             If Not condicao Then
'                 ' Condição é falsa, aguardar 1 minuto (60000 milissegundos)
'                 ' 1 hora (3600000 milisegundos)
'                 minuto = Cint(horaAgora.ToString("mm"))
'                 If minuto > nada Then
'                     Console.WriteLine("Condição falsa. Aguardando 1 minuto...")
'                     Console.WriteLine(minuto)
'                     Console.WriteLine(minuto.GetType())
'                     Thread.Sleep(60000) ' Aguardar 60000 milissegundos (1 minuto)
'                 End If
'             End If
'         End While

'         Console.WriteLine("Condição verdadeira. Loop encerrado.")
'         ' Manter o console aberto até que uma tecla seja pressionada
'         Console.ReadLine()
'     End Sub

'     ' Função de exemplo para verificar uma condição
'     Function VerificarCondicao() As Boolean
'         ' Aqui você deve implementar sua lógica para verificar a condição
'         ' Retorna True ou False com base na sua verificação
'         ' Para este exemplo, vamos simplesmente retornar False
'         Return False
'     End Function
' End Module

