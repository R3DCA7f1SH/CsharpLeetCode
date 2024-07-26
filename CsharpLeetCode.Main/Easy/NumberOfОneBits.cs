namespace CsharpLeetCode.Main.Easy;
public class NumberOfОneBits
{
    public int HammingWeight(int n)
    {
        int weight = 0;
        while (n > 0)
        {
            weight += (n & 1); // Побитовое умножение на 1 равняется взятию остатка от деления на 2
            n >>= 1; // Сдвиг влево равняется делению на 2
        }
        return weight;
    }
}
