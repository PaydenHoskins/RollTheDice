'Payden Hoskins
'RCET2265
'Spring 2025
'https://github.com/PaydenHoskins/RollTheDice.git

Option Compare Text
Option Explicit On
Option Strict On

Module RollTheDice

    Sub Main()
        'Call the sub to display the count of the dice
        DiceCounter()
    End Sub

    Sub DiceCounter()
        'Test the randomness of the dice rolls
        Dim RollCounter(12) As Integer
        For i = 1 To 1000
            RollCounter(RandomNumber(1, 12)) += 1
        Next
        Console.WriteLine("Roll of the Dice".PadLeft(45))
        Console.WriteLine(StrDup(80, "-"))
        For i = 2 To UBound(RollCounter)
            Console.Write($"{CStr(i).PadLeft(4)}  |")
        Next
        Console.WriteLine()
        For i = 2 To UBound(RollCounter)
            Console.Write($"{CStr(RollCounter(i)).PadLeft(4)}  |")
        Next
        Console.WriteLine()
    End Sub

    Function RandomNumber(Min As Integer, Max As Integer) As Integer
        'Math.
        Dim Dice As Single
        Randomize()
        Dice = Rnd()
        Dice *= Max - Min
        Dice += Min
        Return CInt(Math.Ceiling(Dice))
    End Function

End Module