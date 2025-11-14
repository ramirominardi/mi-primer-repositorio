
Public Class Persona
    Private _nombre As String
    Private _apellido As String
    Private _documento As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property Documento As String
        Get
            Return _documento
        End Get
        Set(value As String)
            _documento = value
        End Set
    End Property

    Public Overridable Sub MostrarDatos()
        Console.WriteLine("Nombre: " & Nombre & " " & Apellido & " - DNI: " & Documento)
    End Sub
End Class




