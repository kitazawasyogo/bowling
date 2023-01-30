Public Class Bowling


    ''' <summary>
    ''' 一投で倒したピンの数の記録
    ''' </summary>
    Private scoreList As New List(Of Integer)


    ''' <summary>
    ''' 点数を返す
    ''' </summary>
    ''' <returns>得点の合計値</returns>
    Public Function Score() As Integer

        Return scoreList.Sum()

    End Function


    ''' <summary>
    ''' 一投で倒したピンの数を記録する
    ''' </summary>
    ''' <param name="oneThrow">一投で倒したピンの数</param>
    Public Sub Bowl(oneThrow As Integer)

        scoreList.Add(oneThrow)

    End Sub

End Class
