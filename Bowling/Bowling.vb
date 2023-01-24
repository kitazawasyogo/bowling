Public Class Bowling

    ''' <summary>
    ''' 点数を返す
    ''' </summary>
    ''' <param name="pins">倒したピンの数の配列</param>
    ''' <returns>得点の合計値</returns>
    Public Shared Function Score(pins As Integer()) As Integer

        If pins.Length <> 21 Then
            Throw New ArgumentException
        End If

        Return pins.Sum()

    End Function

End Class
