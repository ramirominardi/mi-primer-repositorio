

Public Class Producto
    Public Property Id As Integer
    Public Property Nombre As String
    Public Property Precio As Decimal
    Public Property Categoria As String

    Public Overrides Function ToString() As String
        Return $"{Nombre} - ${Precio}"
    End Function
End Class
