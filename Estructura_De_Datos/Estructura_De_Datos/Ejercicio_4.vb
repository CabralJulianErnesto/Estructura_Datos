Module Ejercicio_4
    Sub main()
        Dim dominio, valor As String
        Dim nombrePais As New Collection
        nombrePais.Add("Argentina", "AR")
        nombrePais.Add("Germany", "GE")
        nombrePais.Add("England", "EN")
        nombrePais.Add("Netherlands", "NE")
        nombrePais.Add("Czech Republic", "CR")
        nombrePais.Add("Finland", "FI")
        Console.WriteLine("Cantidad de países: " & nombrePais.Count & vbCrLf)
        Do
            Console.WriteLine("Ingrese el dominio del país a consultar")
            dominio = Console.ReadLine()
            Console.WriteLine("país: " & nombrePais.Item(dominio))
        Loop Until dominio = ""

        Console.ReadKey()
    End Sub

End Module
