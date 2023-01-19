Imports NUnit.Framework

Public Class BowlingTest

    <Test()> Public Sub NUnitでのサンプルコード()
        Dim actual As Integer = 2 + 3

        Assert.That(actual, [Is].EqualTo(5))
    End Sub

End Class
