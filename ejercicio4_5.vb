Module ejercicio4_5

    Sub Main()
        Dim opc As Byte
        Dim clave, valor As String
        Dim nombrePais As New Collection
        nombrePais.Add("Argentina", "1")
        nombrePais.Add("Alemania", "2")
        nombrePais.Add("Inglaterra", "3")
        
        Do
            Console.Write("Ingrese una opción-> 1-Agregar  2-Editar/Eliminar  3-Mostrar  0-Salir: ")
            opc = Console.ReadLine()
            Select Case opc
                Case 1
                    Console.Write("Ingrese un valor: ")
                    valor = Console.ReadLine()
                    Console.Write("Ingrese una clave: ")
                    clave = Console.ReadLine()
                    nombrePais.Add(valor, clave)
                Case 2
                    Dim x As String = Console.ReadLine()
                    Console.WriteLine("Borrando dominio: " & x & ": " & nombrePais.Item(x))
                    nombrePais.Remove(x)
                    Console.Write("Ingrese nuevo valor: ")
                    valor = Console.ReadLine()
                    Console.Write("Ingrese nueva clave: ")
                    clave = Console.ReadLine()
                    nombrePais.Add(valor, clave)
                Case 3
                    For Each pais In nombrePais
                        Console.WriteLine("Países: " & pais)
                    Next
                    Console.WriteLine("Cantidad de países: " & nombrePais.Count)
            End Select
        Loop Until opc = 0
        Console.WriteLine("Fin del programa...")
        Console.ReadKey()

    End Sub

End Module
