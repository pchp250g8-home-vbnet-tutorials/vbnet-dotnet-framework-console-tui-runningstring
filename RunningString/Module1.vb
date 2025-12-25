Imports System.Threading

Module Module1

	Sub Main()
		Console.Clear()
		Console.CursorVisible = False
		Dim strSpaces = New String(" "c, 80)
		Dim strLine = "Hello World!!! Running String!!! Press Any Key To Exit!!!"
		strLine = strSpaces & strLine & strSpaces
		Dim nCounter = 0
		Dim nStrLen = strLine.Length - 80
		Do
			strSpaces = strLine.Substring(nCounter, 80)
			Console.SetCursorPosition(10, 10)
			Console.Write(strSpaces)
			Thread.Sleep(140)
			nCounter += 1
			If nCounter >= nStrLen Then
				nCounter = 0
			End If
		Loop While Not Console.KeyAvailable
	End Sub

End Module
