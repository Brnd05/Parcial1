Imports System
Imports System.Net.NetworkInformation
Imports System.Xml

Module Program
    Dim saldo As Integer = 12000 'Se crea una variable que contendra el saldo del usuario

    Public Function Retirardinero(ByRef saldo As Integer) As Integer 'Se agrega saldo como parametro de la funcion para poder modificarlo dentro y fuera de la funcion
        Console.WriteLine("Ingrese la cantidad a retirar, debe ser multiplo de 5")
        Dim retirar As Integer 'Variable que contendra la cantidad a retirar la cual sera ingresada por el usuario 
        retirar = Console.ReadLine()
        If retirar Mod 5 = 0 Then 'Se verifica que la cantidad ingresada de como residuo 0 al dividirla entre 5 por medio el operador Mod
            saldo = saldo - retirar 'En caso de que retirar sea multiplo de 5 se resta la cantidad a retirar al saldo
            Console.WriteLine("Se han retirado: " & retirar) 'Se muestra la cantidad retirada
            Console.WriteLine("Su saldo actual es de: " & saldo) 'Se muestra el saldo nuevo del usuario
        Else
            Console.WriteLine("Usted ingreso: " & retirar)
            Console.WriteLine("Solo se pueden retirar numeros multiplos de 5") 'Si el retirar no dad como residuo 0 al dividirlo entre 5 se muestra este mensaje y no se hace el retiro
            Console.WriteLine("Su saldo actual es de: " & saldo)
        End If
    End Function

    Sub Main(args As String())
        Dim intentos As Integer = 3 'Se crea una variable que contendra el numero de intentos que tiene el usuario para ingresar al cajero
        Dim pass As Boolean = False 'Cree la variable pass para que sea la condicion de salida del primer while (ademas de los 3 intentos) y de entrada del segundo
        Console.WriteLine("Esto es un cajero automatico")
        While pass = False And intentos > 0 'En caso de no cumplirse con cualquiera de las dos condiciones el bucle se rompe

            Console.WriteLine("Tiene " & intentos & " intentos para acceder al cajero") 'se muestra el numero de intentos que le quedan al usuario
            Console.Write("Ingrese su usuario: ")
            Dim usuario = Console.ReadLine() 'El usuario es inge y la contraseña es contra
            Console.Write("Ingrese su pin: ")
            Dim pin = Console.ReadLine()

            If pin <> "contra" Or usuario <> "inge" Then 'Se verifica que el usuario y el pin sean correctos y si no coinciden se resta un intento
                Console.WriteLine("Usuario o contraseña incorrecta")
                intentos -= 1
            ElseIf pin = "contra" And usuario = "inge" Then 'Si el usuario y el pin son correctos se cambia el valor de pass a True para cerrar el primer bucle y abrir el segundo
                pass = True


            End If
        End While
        If intentos = 0 Then
            Console.WriteLine("Usted exedio el limite de intentos, se notificara a las autoridades") 'En caso de que el usuario exceda el limite de intentos se muestra este mensaje
        End If

        While pass = True 'Si la contraseña y usuarios son correctos se cambia el valor de pass y la condicion el segundo bucle se cumple
            Console.WriteLine("Bienvenido")
            Console.WriteLine("1. Consultar saldo") 'Se muestra el menu con diferentes opciones
            Console.WriteLine("2. Retirar dinero (en multiplos de 5)")
            Console.WriteLine("3. Salir")
            Dim opcion = Console.ReadLine() 'Se crea una variale que contendra la opcion que el usuario elija y ejecutara la opcion correspondiente
            If opcion = 1 Then
                Console.WriteLine("Su saldo es de: " & saldo) 'Si es 1 se muestra el saldo del usuario
            ElseIf opcion = 2 Then
                Retirardinero(saldo) ' Si es 2 se ejecuta la funcion Retirardinero con la variable saldo como parametro
            ElseIf opcion = 3 Then
                pass = False 'Opte por crear una tercera opcion para poder salir del bucle y del programa
                Console.WriteLine("Gracias por usar el cajero")
            ElseIf opcion > 3 Then
                Console.WriteLine("Opcion no valida")
            ElseIf opcion < 1 Then 'Si el usuario ingresa una opcion que no esta en el menu se muestra este mensaje
                Console.WriteLine("Opcion no valida")


            End If



        End While

    End Sub
End Module
