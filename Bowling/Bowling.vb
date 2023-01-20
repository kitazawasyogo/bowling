Public Class Bowling

    ''' <summary>
    ''' 点数を返すメソッド
    ''' </summary>
    ''' <param name="pins">得点の入った配列</param>
    ''' <returns>得点の合計値</returns>
    Public Shared Function Score(pins As Integer()) As Integer

        If pins.Length <> 21 Then
            Throw New ArgumentException
        End If

        Return (pins.Sum())

    End Function

End Class
