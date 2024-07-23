namespace CsharpLeetCode.Main.Medium;
public class GenerateParentheses
{
    public IList<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();
        GenerateParenthesis(result,n,"",0,0);
        return result;
    }

    private static void GenerateParenthesis(List<string> list,int n,string str,int left,int right)
    {
        if (str.Length == n * 2) // Если длина строки равна числу пар
        {
            list.Add(str);
            return;
        }
        if (left < n) GenerateParenthesis(list, n, str + "(", left + 1, right);
        if (right < left) GenerateParenthesis(list, n, str + ")",left,right+1);
    }
}

