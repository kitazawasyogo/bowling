Imports NUnit.Framework

Public Class BowlingTest


    <Test()> Public Sub 二投目に九ピン倒した段階のスコアを計算()

        Dim bowlingScore As New Bowling
        bowlingScore.Bowl(10)
        bowlingScore.Bowl(9)

        Dim actual As Integer = bowlingScore.Score()
        Assert.That(actual, [Is].EqualTo(19))

    End Sub


    <Test()> Public Sub 十一投目に一ピン倒した段階のスコアを計算()

        Dim bowlingScore As New Bowling
        bowlingScore.Bowl(10)
        bowlingScore.Bowl(9)
        bowlingScore.Bowl(9)
        bowlingScore.Bowl(9)
        bowlingScore.Bowl(9)
        bowlingScore.Bowl(9)
        bowlingScore.Bowl(9)
        bowlingScore.Bowl(9)
        bowlingScore.Bowl(9)
        bowlingScore.Bowl(9)
        bowlingScore.Bowl(1)

        Dim actual As Integer = bowlingScore.Score()
        Assert.That(actual, [Is].EqualTo(92))

    End Sub

End Class
