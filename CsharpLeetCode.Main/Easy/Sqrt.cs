using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace CsharpLeetCode.Main.Easy;

public class Sqrt
{

    private static float FastInvSqrt(float x)
    {
        float xhalf = 0.5f * x;
        int i = BitConverter.SingleToInt32Bits(x);
        i = 0x5f3759df - (i >> 1); // magic
        x = BitConverter.Int32BitsToSingle(i);
        for (int j = 0; j < 10; j++) x *= (1.5f - (xhalf * x * x));// for accuracy
        return x;
    }
    // Красивое решение, не проходящее в литкоде из-за отдельных случаев
    private static int MagicSqrt(int x)
    {
        if (x == 0) return 0;
        if (x < 0) throw new ArgumentException("Must be non negative");
        var invert = FastInvSqrt(x);
        var result = Math.Truncate(1 / invert);
        return (int)result;
    }

    private static int IterationSqrt(int x)
    {
        if (x < 0) throw new ArgumentException("Must be non negative");
        if (x == 0) return 0;
        if (x == 1) return x;
        for (int i = 0; i <= x / 2 + 1; i++)
        {
            uint checkSqrt = (uint)(i * i);
            if (checkSqrt == x) return i;
            if (checkSqrt > x) return i - 1;
        }
        return 0;
    }

    private static int BinarySearchSqrt(int x)
    {
        if (x < 0) throw new ArgumentException("Must be non negative");
        if (x == 0 || x == 1) return x;

        int left = 1;
        int right = x/2+1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int check = x / mid;

            if (check == mid) return mid;
            if (check < mid) right = mid - 1;
            else left = mid + 1;
        }
        return right;
    }

    public int MySqrt(int x)
        => BinarySearchSqrt(x);
    //=> IterationSqrt(x);
}
