Module Ejercicio_5
    Sub main()
        Dim opc As Byte
        Console.WriteLine("Ingrese una opc: ")
        opc = Console.ReadLine()
        Dim clave, valor As String
        Dim nombrePaises As New Collection
        nombrePaises.Add("Jamaica", "JA")
        nombrePaises.Add("España", "ES")

        Select Case opc
            Case 1
                Dim salir As Byte = Console.ReadLine()
                Console.Write("Ingresa una clave: ")
                clave = Console.ReadLine()
                Console.Write("Ingresa un valor: ")
                valor = Console.ReadLine()
                nombrePaises.Add(valor, clave)

            Case 2
                Dim x As String = Console.ReadLine()
                Console.WriteLine("Borrando dominio: " & x & ": " & nombrePaises.Item(x))
                nombrePaises.Remove(x)
            Case 3
                For Each paises In nombrePaises
                    Console.WriteLine(paises)
                Next
        End Select
        Console.ReadKey()
    End Sub
End Module
