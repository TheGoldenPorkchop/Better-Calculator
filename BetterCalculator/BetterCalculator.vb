'Angel Nava
'Spring 2025
'RCET2265
'BetterCalculator
'

Module BetterCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim userInputOperation As String
        Dim secondNumber As Integer
        Dim getOutOfHere As Boolean = False
        Dim quitProgram As Boolean = False
        Dim userInput As String
        Do
            Do
                Console.WriteLine("Enter your first number")
                Console.WriteLine("Enter Q to Quit")
                userInput = Console.ReadLine()
                Console.WriteLine()

                Try
                    firstNumber = CInt(userInput)
                    getOutOfHere = True
                    Console.WriteLine($"First Number = {firstNumber}")
                Catch ex As Exception
                    If userInput = "q" Then
                        Console.WriteLine("You have Quit the program")
                        getOutOfHere = True
                        quitProgram = True
                    Else
                        Console.WriteLine($"{userInput} is not a valid number")
                        Console.WriteLine($"Please enter a valid number")
                        getOutOfHere = False
                    End If
                End Try

            Loop Until getOutOfHere = True

            Console.WriteLine()

            If quitProgram = False Then
                Do
                    Console.WriteLine("Please make a selection: " & vbNewLine _
                      & "[1. Add]" & vbNewLine _
                      & "[2. Subtract]" & vbNewLine _
                      & "[3. Multiply]")
                    Console.WriteLine("Enter Q to Quit")
                    userInputOperation = Console.ReadLine()
                    If userInputOperation = "q" Then
                        Console.WriteLine("You have Quit the program")
                        getOutOfHere = True
                        quitProgram = True
                    Else
                        If userInputOperation = "1" Then
                            Console.WriteLine("Adding")
                            userInputOperation = "+"
                            getOutOfHere = True
                        ElseIf userInputOperation = "2" Then
                            Console.WriteLine("Subtracting")
                            userInputOperation = "-"
                            getOutOfHere = True
                        ElseIf userInputOperation = "3" Then
                            Console.WriteLine("Multiplying")
                            userInputOperation = "*"
                            getOutOfHere = True
                        Else
                            Console.WriteLine("Invalid Option")
                            getOutOfHere = False
                        End If
                    End If
                    Console.WriteLine()

                Loop Until getOutOfHere = True
            End If

            Console.WriteLine()

            If quitProgram = False Then
                Do
                    Console.WriteLine("Enter your second number")
                    Console.WriteLine("Enter Q to Quit")
                    userInput = Console.ReadLine()
                    Console.WriteLine()

                    Try
                        secondNumber = CInt(userInput)
                        getOutOfHere = True
                        Console.WriteLine($"Second Number = {secondNumber}")
                    Catch ex As Exception
                        If userInput = "q" Then
                            Console.WriteLine("You have Quit the program")
                            getOutOfHere = True
                            quitProgram = True
                        Else
                            Console.WriteLine($"{userInput} is not a valid number")
                            Console.WriteLine($"Please enter a valid number")
                            getOutOfHere = False
                        End If
                    End Try

                Loop Until getOutOfHere = True
            End If

            Console.WriteLine()

            If quitProgram = False Then
                Console.WriteLine("Your Calculation")
                Console.WriteLine(firstNumber & userInputOperation & secondNumber & "=")
                If userInputOperation = "+" Then
                    Console.WriteLine(firstNumber + secondNumber)
                ElseIf userInputOperation = "-" Then
                    Console.WriteLine(firstNumber - secondNumber)
                ElseIf userInputOperation = "*" Then
                    Console.WriteLine(firstNumber * secondNumber)
                Else
                    Console.WriteLine("Whoops. Something went wrong. Restart the program again...")
                End If
            End If

            If quitProgram = False Then
                Console.WriteLine()
                Console.WriteLine(StrDup(80, "*"))
                Console.WriteLine("NEW CALCULATION")
                Console.WriteLine()
            End If

        Loop Until quitProgram = True
    End Sub

End Module
