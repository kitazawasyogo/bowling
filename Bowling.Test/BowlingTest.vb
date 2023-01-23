Imports NUnit.Framework

Public Class BowlingTest


    <Test()> Public Sub NUnitでのサンプルコード()

        Dim actual As Integer = 2 + 3

        Assert.That(actual, [Is].EqualTo(5))

    End Sub


    <Test()> Public Sub 点数を返すメソッドのテスト()

        Dim pinsArray As Integer() = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21}
        Dim actual As Integer = Bowling.Score(pinsArray)

        Assert.That(actual, [Is].EqualTo(231))

    End Sub

End Class
