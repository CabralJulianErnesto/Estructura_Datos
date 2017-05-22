Module Ejercicio_1

    Sub main()

        Dim cargarArreglo = New Integer() {2, 4, 6, 8, 10, 12}
        Dim Media As Single = calcularMedia(cargarArreglo)
        Console.WriteLine("Media: {0}", Media)
        calcularDesviacion(cargarArreglo, Media)


        Console.ReadKey()
    End Sub
    Private Function calcularDesviacion(Arreglo() As Integer, media As Integer) As Integer
        For x = 0 To Arreglo.Length - 1
            Console.WriteLine("Elemento -> {0} su desviación -> {1}", Arreglo(x), Arreglo(x) - media)
        Next

    End Function

    Private Function calcularMedia(Arreglo() As Integer) As Integer
        Dim sum As Integer = 0
        For x = 0 To Arreglo.Length - 1
            sum += Arreglo(x)
        Next
        Return sum / Arreglo.Length()
    End Function

End Module
