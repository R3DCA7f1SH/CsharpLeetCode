using CsharpLeetCode.Main.Easy;

namespace CsharpLeetCode.Tests.Easy;
public class SqrtTests
{
    private readonly Sqrt _sqrt = new();
    [Fact]
    public void CaseN1()
    {
        var x = 4;
        var expected = 2;
        var result = _sqrt.MySqrt(x);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CaseN2()
    {
        var x = 8;
        var expected = 2;
        var result = _sqrt.MySqrt(x);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CaseN3()
    {
        var x = 16;
        var expected = 4;
        var result = _sqrt.MySqrt(x);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CaseN4()
    {
        var x = 37;
        var expected = 6;
        var result = _sqrt.MySqrt(x);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CaseN5()
    {
        var x = 2147395599;
        var expected = 46339;
        var result = _sqrt.MySqrt(x);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CaseN6()
    {
        var x = 807810077;
        var expected = 28421;
        var result = _sqrt.MySqrt(x);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CaseN7()
    {
        var x = 1464898982;
        var expected = 38273;
        var result = _sqrt.MySqrt(x);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CaseN8()
    {
        var x = 2147395600;
        var expected = 46340;
        var result = _sqrt.MySqrt(x);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void CaseN9()
    {
        var kek = 2147488281;
        var x = 2147483647;
        var expected = 46340;
        var result = _sqrt.MySqrt(x);
        Assert.Equal(expected, result);
    }
}
