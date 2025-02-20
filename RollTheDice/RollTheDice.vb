Module RollTheDice

    Sub Main()
        Dim myLuckyNumber As Integer = 1
        Randomize(DateAndTime.Now.Millisecond)
        For i = 1 To 10
            Console.Write($"{RandomNumber.PadLeft(8)}|")
        Next
    End Sub

    Function RandomNumber() As String
        Dim myRandomNumber As Single
        Randomize()

        myRandomNumber = Rnd() * 10
        myRandomNumber = Int(myRandomNumber) + 1
        Return CInt(myRandomNumber)
    End Function
End Module