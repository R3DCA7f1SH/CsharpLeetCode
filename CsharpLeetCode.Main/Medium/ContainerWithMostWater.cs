namespace CsharpLeetCode.Main.Medium;
public class ContainerWithMostWater
{
    public int MaxArea(int[] height)
    {
        int amount = 0;
        int leftIndex = 0;
        int rightIndex = height.Length - 1;
        int leftH;
        int rightH;
        int current;
        while (rightIndex > leftIndex)
        {
            leftH = height[leftIndex];
            rightH = height[rightIndex];

            if (leftH > rightH)
            {
                current = rightH * (rightIndex - leftIndex);
                rightIndex--;
            }
            else
            {
                current = leftH * (rightIndex - leftIndex);
                leftIndex++;
            }
            if (current > amount) amount = current;
        }
        return amount;
    }
}
