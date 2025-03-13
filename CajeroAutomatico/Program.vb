Imports System
Imports System.Net.NetworkInformation
Imports System.Xml

Module Program
    Dim saldo As Integer = 12000
    Dim intentos As Integer = 3
    Public Function Retirardinero(ByRef saldo As Integer) As Integer
        Console.WriteLine("Ingrese la cantidad a retirar, debe ser multiplo de 5")
        Dim retirar As Integer
        retirar = Console.ReadLine()
        If retirar Mod 5 = 0 Then
            saldo = saldo - retirar
            Console.WriteLine("Su saldo actual es de: " & saldo)
        Else
            Console.WriteLine("Solo se pueden retirar multiplos de 5")
            Console.WriteLine("Su saldo actual es de: " & saldo)
        End If
    End Function

    Sub Main(args As String())
        Dim intentos As Integer = 3
        Dim pass As Boolean = False
        Console.WriteLine("Esto es un cajero automatico")
        While pass = False And intentos > 0

            Console.WriteLine("Tien " & intentos & " intentos para acceder al cajero")
            Console.Write("Ingrese su usuario: ")
            Dim usuario = Console.ReadLine()
            Console.Write("Ingrese su pin: ")
            Dim pin = Console.ReadLine()

            If pin <> "contra" Or usuario <> "inge" Then
                Console.WriteLine("Usuario o contraseña incorrecta")
                intentos -= 1
            ElseIf pin = "contra" And usuario = "inge" Then
                pass = True


            End If
        End While
        If intentos = 0 Then
            Console.WriteLine("Usted exedio el limite de intentos, se notificara a las autoridades")
        End If

        While pass = True
            Console.WriteLine("Bienvenido")
            Console.WriteLine("1. Consultar saldo")
            Console.WriteLine("2. Retirar dinero (en multiplos de 5)")
            Console.WriteLine("3. Salir")
            Dim opcion = Console.ReadLine()
            If opcion = 1 Then
                Console.WriteLine("Su saldo es de: " & saldo)
            ElseIf opcion = 2 Then
                Retirardinero(saldo)
            ElseIf opcion = 3 Then
                pass = False
                Console.WriteLine("Gracias por usar el cajero")
            ElseIf opcion > 3 Then
                Console.WriteLine("Opcion no valida")
            ElseIf opcion < 1 Then
                Console.WriteLine("Opcion no valida")


            End If



        End While

    End Sub
End Module
