Imports System



Namespace VBConsole
	Module Program
		<STAThread> Sub Main()
			Using game As New Game1()
            	game.Run()
        	End Using
    	End Sub
	End Module
End Namespace
