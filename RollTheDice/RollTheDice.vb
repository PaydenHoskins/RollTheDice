Module RollTheDice

    Sub Main()
        Dim myLuckyNumber As Integer = 1
        Randomize(DateAndTime.Now.Millisecond)
        For i = 2 To 12
            TestRandomness()
        Next
    End Sub

    Sub TestRandomness()
        Dim BeanCounter(20) As Integer
        For i = 1 To 10000
            BeanCounter(RandomNumber(12, 2)) += 1

        Next

        For i = LBound(BeanCounter) To UBound(BeanCounter)
            Console.WriteLine($"{CStr(i).PadLeft(4)} Hit {CStr(BeanCounter(i)).PadLeft(4)} Many times!")
        Next
        Console.WriteLine()
    End Sub

    Function RandomNumber(Max As Integer, min As Integer) As Integer
        Dim temp As Single
        Randomize()
        temp = Rnd()
        temp *= Max 
        temp += min
        'Math.
        Return CInt(Math.Floor(temp))
    End Function

End Module