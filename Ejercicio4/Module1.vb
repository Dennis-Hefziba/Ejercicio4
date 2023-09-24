Module Module1
    'Calcule la suma de los números naturales desde 1 hasta n. Ejemplo: 1+2+3+4+5=15
    Sub Main()


        Dim cantidad As Integer
        Dim retorno As Boolean

        Console.WriteLine("Suma de numeros naturales de 1 a N")

        Do
            Console.WriteLine("Por favor ingresa un numero N")
            cantidad = Console.ReadLine()

            'declaramos el arreglo del tamano que el usuario ingreso.

            Dim arreglo(cantidad - 1) As Integer
            Dim suma As Integer = 0

            For i As Integer = 1 To cantidad
                'suma = suma + i
                suma += i
            Next

            Console.WriteLine("La suma de los numeros es: " + suma.ToString)



        Loop While retorno = True

        Console.ReadLine()
    End Sub

End Module
