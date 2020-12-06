'----------------------------------------------------------------------------
'INFO
'----------------------------------------------------------------------------
'Program:   Module 4, Exercise 3
'Date:      11/19/2020
'Author:    Morrison, Parker
'Operation: A basic application demonstrating the possibilities
'           of loops.
'-----------------------------------------------------------------------------
'Change Log
' 11/19/2020 @ ~7:15 PM - script created
' 11/19/2020 @ ~8:00 PM - code commented and finalized
' 11/20/2020 @  8:47 PM - adjusted console output text
'-----------------------------------------------------------------------------
'Date Programmer Change
' not applicable
'-----------------------------------------------------------------------------
Module Module1

    Sub Main()
        ' String conversion to Double failed in processing,
        ' so valueEntered is registered as Object.
        Dim valueEntered As Object
        Dim valueTotal As Integer = 0
        Dim countEntered As Integer = 0
        Dim loopCheck As Boolean = True
        Dim valueCalc As Decimal

        Console.WriteLine("The Umpteenth Grade Average Calculator!")
        Console.WriteLine("Enter grade values, between 0 and 100, in the field below.")
        Console.WriteLine("When ready to calculate, enter the '=' symbol.")
        ' Begins a loop that executes while this boolean value is true.
        While loopCheck = True
            valueEntered = Console.ReadLine()
            If valueEntered = "=" Then
                If countEntered = 0 Then
                    ' Prevents calculation if no grades are entered beforehand.
                    Console.WriteLine("You did not provide any grades to calculate. Please try again.")
                Else
                    ' Terminates the loop if all requirements are met.
                    loopCheck = False
                End If
            ElseIf valueEntered = "" Then
                ' Fails if the input is blank.
                Console.WriteLine("That is not a valid input. Please try again.")
            ElseIf valueEntered <> "=" And Not IsNumeric(valueEntered) Then
                ' Fails if a non-numeric input, aside from '=', is entered.
                ' Otherwise, the first 'if' statement is executed.
                Console.WriteLine("That is not a valid input. Please try again.")
            ElseIf valueEntered < 0 Or valueEntered > 100 Then
                ' Fails if the input falls below 0 or exceeding 100.
                Console.WriteLine("You entered a value exceeding the minimum / maximum. Please try again.")
            Else
                ' Successful inputs add to the total value and the number of grades entered.
                valueEntered = CInt(valueEntered)
                valueTotal = valueTotal + valueEntered
                countEntered = countEntered + 1
            End If
        End While
        ' To get the average, the grade total must be divided by the amount of grades entered.
        valueCalc = (valueTotal / countEntered)
        Console.WriteLine($"From a provided total of {countEntered} grade(s) equating to a sum of {valueTotal},")
        Console.WriteLine($"The average is {valueCalc}.")
        Console.WriteLine("Press any key to exit.")
        Console.ReadKey(True)
    End Sub

End Module
