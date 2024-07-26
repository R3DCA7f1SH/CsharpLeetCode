namespace CsharpLeetCode.Main.Easy;
public class HappyNumberSolution
{
    public bool IsHappy(int n)
    {
        if (n == 1 || n == 7) return true;
        var current = n;
        var count = 0;
        while (true)
        {
            var sumQuad = 0;
            while (current > 0 )
            {
                var number = current % 10;
                sumQuad += number*number;
                current /= 10;
            }
            if(sumQuad<10) count++;
            current = sumQuad;
            if (current == 1 || current == 7) return true;
            if (count > 1) return false;
        }
    }
}

