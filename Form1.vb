' Program.vb
Imports System
Imports System.Windows.Forms

Module Program
    <STAThread()>
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New FrmClientes()) ' Cambiá por FrmPrincipal si lo tenés
    End Sub
End Module


