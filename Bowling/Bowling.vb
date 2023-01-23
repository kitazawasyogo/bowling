Public Class Bowling

    ''' <summary>
 feat/array-length-check
    ''' 点数を返すメソッド
    ''' </summary>
    ''' <param name="pins">得点の入った配列</param>
    ''' <returns>得点の合計値</returns>
    Public Shared Function Score(pins As Integer()) As Integer

        If pins.Length <> 21 Then
            Throw New ArgumentException
        End If

        Return (pins.Sum())
        
    ''' 点数を返す
    ''' </summary>
    ''' <param name="pins">倒したピンの数の配列</param>
    ''' <returns>得点の合計値</returns>
    Public Shared Function Score(pins As Integer()) As Integer

        Return pins.Sum()
 master

    End Function

End Class
