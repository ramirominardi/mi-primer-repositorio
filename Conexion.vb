Imports System.IO

Public Class Conexion
    Public Shared Function ObtenerCadena() As String
        Return File.ReadAllText("conexion.txt")
    End Function
End Class

