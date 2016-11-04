' La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub button1_Click(sender As Object, e As RoutedEventArgs) Handles button1.Click
        genNombre.Text = GeneraNombre(5, 12)
        genApellidos.Text = GeneraNombre(5, 12) + " " + GeneraNombre(3, 15)
        genPais.Text = GeneraPais()
    End Sub


    Private Function GeneraNombre(min As Integer, max As Integer) As String
        Dim res As String = ""
        Dim ran As Random = New Random

        'Crear arrays
        Dim vocales() As Char = "aeiou".ToCharArray
        Dim consonantes() As Char = "bcdfhjlmnprstvz".ToCharArray
        Dim vocal As Boolean = True

        'Empiezo a meter letras
        res += Char.ToUpper(consonantes.GetValue(ran.Next(0, consonantes.GetLength(0))))

        For index = 1 To ran.Next(min, max)
            If vocal Then
                res += vocales.GetValue(ran.Next(0, 5))
                vocal = False
            Else
                res += consonantes.GetValue(ran.Next(0, consonantes.GetLength(0)))
                vocal = True

            End If
        Next

        Return res
    End Function

    Private Function GeneraPais() As String
        Dim res As String = GeneraNombre(5, 5)
        Dim ran As Random = New Random

        If (ran.Next(1, 2) = 1) Then
            res += "nia"
        Else
            res += "cia"
        End If

        Return res
    End Function

End Class
