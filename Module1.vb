Module Module1

    Sub Main()

        Dim opcion As Integer
        Dim num1, num2 As Double

        Do

            Console.WriteLine("Seleccione una del las opciones disponibles del siguiente menu:" &
                 vbCrLf& & vbCrLf & "1.- Sumar." + vbCrLf + "2.- Restar." & vbCrLf &
                              "3.- Multiplicar." & vbCrLf & "4.- Calcular el reto." & vbCrLf & "5.- Salir.")

            While Not (Integer.TryParse(Console.ReadLine(), opcion)) Or (opcion < 1 Or opcion > 5)

                Console.Write("Introduzca una de las opciones disponibles del menu -> ")

            End While

            If opcion <> 5 Then

                Console.Write("Introduzca el primer numero: ")

                While Not (Double.TryParse(Console.ReadLine(), num1))

                    Console.Write("Error, introduzca un numero: ")

                End While

                Console.Write("Introduzca el segundo numero: ")

                While Not (Double.TryParse(Console.ReadLine(), num2))

                    Console.Write("Error, introduzca un numero: ")

                End While

                Select Case opcion

                    Case 1

                        Console.WriteLine("La suma de los numeros introducidos es -> " & num1 + num2)

                    Case 2

                        Console.WriteLine("La resta de los numeros introducidos es -> " & num1 - num2)

                    Case 3

                        Console.WriteLine("La multiplicacion de los numeros introducidos es -> " & num1 * num2)

                    Case 4

                        Console.WriteLine("El resto de los numeros introducidos es -> " & num1 Mod num2)

                    Case Else

                        Console.WriteLine("Error deconocido.")

                End Select

            Else

                Console.WriteLine("Hasta otro momento.")

            End If

            Console.WriteLine()

        Loop While opcion <> 5


        Console.ReadKey()

    End Sub

End Module
