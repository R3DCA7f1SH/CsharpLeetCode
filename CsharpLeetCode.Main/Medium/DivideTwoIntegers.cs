namespace CsharpLeetCode.Main.Medium;
public class DivideTwoIntegers
{
    public int Divide(int dividend, int divisor)
    {
        if (divisor == 0) throw new ArithmeticException("Divisor cannot be zero");
        if (divisor == dividend) return 1;
        if (divisor == 1) return dividend;
        if (divisor == -1)
        {
            if (dividend == int.MinValue) return int.MaxValue;
            if (dividend == int.MaxValue) return -1 * int.MaxValue;
            return -dividend;
        }

        var sign = (dividend < 0) == (divisor < 0) ? 1 : -1;

        var newDividend = Math.Abs((long)dividend);
        var newDivisor = Math.Abs((long)divisor);

        int result = 0;
        while (newDividend >= newDivisor)
        {
            int pow = 0;
            while (newDividend >= (newDivisor << (pow + 1))) pow++;

            newDividend -= (newDivisor << pow);
            result += (1 << pow);
        }

        return sign * result;
    }
}
