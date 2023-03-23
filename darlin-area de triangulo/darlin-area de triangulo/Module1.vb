Module Module1

    Sub Main()
        Console.Write("**********************************************buscar area de triangulo************************************************")
       




        'declarar variables'
        Dim base, altura, area As Double

        'Llenar variables'
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
vuelve:
        Try

            Console.WriteLine()
            Console.Write("ingrese la base: ")
            base = Console.ReadLine()
        Catch
            Console.WriteLine()
            Console.Write("ingrese un numero!, toque una tecla e intente otra vez")
            Console.ReadKey()
            Console.Clear()
            Console.Write("**********************************************buscar area de triangulo************************************************")
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            GoTo vuelve
        End Try
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
vuelve2:
        Try
            Console.Write("ingrese la altura: ")
            altura = Console.ReadLine()
        Catch
            Console.WriteLine()
            Console.Write("debe ingresar un numero!, toque cualquier letra e intente otra vez")
            Console.ReadKey()
            Console.Clear()
            Console.Write("**********************************************buscar area de triangulo************************************************")
            Console.WriteLine()
            Console.WriteLine()
            Console.Write("ingrese la base: " & base)
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()
            Console.WriteLine()

            GoTo vuelve2
        End Try
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()

        'calcular area'
        area = (base * altura) / 2
        'mostrar resultado'
        Console.Write("area es igual a: " & area)       
        Console.ReadKey()
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine()
        Console.Write("preocione una tecla para cerrar")
        Console.ReadKey()
        Console.Clear()

    End Sub

End Module
