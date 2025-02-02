'Angel Nava
'Spring 2025
'RCET2265
'BetterCalculator
'https://github.com/TheGoldenPorkchop/Better-Calculator/tree/main

Module BetterCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim userInputOperation As String
        Dim secondNumber As Integer
        Dim getOutOfHere As Boolean = False
        Dim quitProgram As Boolean = False
        Dim userInput As String
        Do
            Console.WriteLine($"Please enter two numbers. Enter Q at any time to quit.")
            'First Number
            Do
                Console.Write("Choose a Number: ")
                userInput = Console.ReadLine()

                Try
                    firstNumber = CInt(userInput)
                    getOutOfHere = True
                    Console.WriteLine($"You entered {firstNumber}")
                Catch ex As Exception
                    If userInput = "q" Then
                        Console.WriteLine("Have a nice day")
                        Console.WriteLine("Press enter to close this window")
                        getOutOfHere = True
                        quitProgram = True
                    Else
                        Console.WriteLine($"You entered {userInput}, please enter a whole number.")
                        getOutOfHere = False
                    End If
                End Try
            Loop Until getOutOfHere = True

            'Second Number

            If quitProgram = False Then
                Do
                    Console.Write("Choose a Number: ")
                    userInput = Console.ReadLine()

                    Try
                        secondNumber = CInt(userInput)
                        getOutOfHere = True
                        Console.WriteLine($"You entered {secondNumber}")
                    Catch ex As Exception
                        If userInput = "q" Then
                            Console.WriteLine("Have a nice day")
                            Console.WriteLine("Press enter to close this window")
                            getOutOfHere = True
                            quitProgram = True
                        Else
                            Console.WriteLine($"You entered {userInput}, please enter a whole number.")
                            getOutOfHere = False
                        End If
                    End Try

                Loop Until getOutOfHere = True
            End If

            'Operation

            If quitProgram = False Then
                Do
                    Console.WriteLine("Choose one of the following options: " & vbNewLine _
                      & "1. Add" & vbNewLine _
                      & "2. Subtract" & vbNewLine _
                      & "3. Multiply" & vbNewLine _
                      & "4. Divide")
                    userInputOperation = Console.ReadLine()
                    Console.WriteLine($"You entered {userInputOperation}")
                    If userInputOperation = "q" Then
                        Console.WriteLine("Have a nice day")
                        Console.WriteLine("Press enter to close this window")
                        getOutOfHere = True
                        quitProgram = True
                    Else
                        If userInputOperation = "1" Then
                            userInputOperation = "+"
                            getOutOfHere = True
                        ElseIf userInputOperation = "2" Then
                            userInputOperation = "-"
                            getOutOfHere = True
                        ElseIf userInputOperation = "3" Then
                            userInputOperation = "*"
                            getOutOfHere = True
                        ElseIf userInputOperation = "4" Then
                            userInputOperation = "/"
                            getOutOfHere = True
                        Else
                            getOutOfHere = False
                        End If
                    End If

                Loop Until getOutOfHere = True
            End If

            'calculation

            If quitProgram = False Then
                Console.Write(firstNumber & userInputOperation & secondNumber & "= ")
                If userInputOperation = "+" Then
                    Console.WriteLine(firstNumber + secondNumber)
                ElseIf userInputOperation = "-" Then
                    Console.WriteLine(firstNumber - secondNumber)
                ElseIf userInputOperation = "*" Then
                    Console.WriteLine(firstNumber * secondNumber)
                ElseIf userInputOperation = "/" Then
                    Console.WriteLine(firstNumber / secondNumber)
                Else
                    Console.WriteLine("Whoops. Something went wrong. Restart the program again...")
                End If
            End If

        Loop Until quitProgram = True
    End Sub

End Module
