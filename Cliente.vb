
Public Class Cliente
    Inherits Persona

    Public Property Id As Integer
    Public Property Telefono As String
    Public Property Correo As String

    Public Overrides Sub MostrarDatos()
        MyBase.MostrarDatos()
        Console.WriteLine("Teléfono: " & Telefono)
        Console.WriteLine("Correo: " & Correo)
    End Sub
End Class



