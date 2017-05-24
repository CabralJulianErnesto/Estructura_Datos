Module Ejercicio_2
    Sub main()
        Dim codigo As Integer
        Dim codigoProducto = New Integer() {1, 2, 3, 4}
        Dim nombreProducto = New String() {"Gabinete", "RAM", "Mouse", "Teclado"}
        Dim precioProducto = New Single() {900, 1200, 200, 500}

        Do
            Console.WriteLine("Ingrese el código de un producto: ")
            codigo = Console.ReadLine()

        Loop Until codigo <= 0

        Console.WriteLine("Fin del programa...")
        Console.ReadKey()
    End Sub

End Module
