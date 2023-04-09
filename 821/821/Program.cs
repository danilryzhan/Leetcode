// See https://aka.ms/new-console-template for more information

using System.Globalization;

static void Main()
{

}
public class Solution
{
    public int[] ShortestToChar(string s, char c)
    {
        var result = new int[s.Length];
        var right = new int[s.Length];
        var left = new int[s.Length];

        var idx = -1;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == c)
            {
                idx = i;
            }
            if (idx != -1)
            {
                right[i] = idx - i;
            }
            else
            {
                right[i] = int.MaxValue;
            }
        }
        idx = -1;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == c)
            {
                idx = i;
            }
            if (idx != -1)
            {
                left[i] = i - idx;
            }
            else
            {
                left[i] = int.MaxValue;
            }
        }
        Console.WriteLine(String.Join(" ", left));
        Console.WriteLine("----");
        Console.WriteLine(String.Join(" ", right));

        for (int i = 0; i < s.Length; i++)
        {
            result[i] = Math.Min(left[i], right[i]);
        }
        return result;
    }
}
