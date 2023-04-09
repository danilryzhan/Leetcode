// See https://aka.ms/new-console-template for more information

using System.Globalization;

static void Main()
{

}
public class Solution
{
    public int[] ShortestToChar(string s, char c)
    {
        int[] res = new int[s.Length];
        int cindex = int.MaxValue;
        int lastint = 0;
        for(int i = 0; i < s.Length;i++)
        {
            if (s[i]== c)
            {

                
                for (int k = lastint;  k <= i ; k++)
                {
                    if (i - k > Math.Abs(cindex - k)) res[k] = Math.Abs(cindex - k);
                    else res[k] = Math.Abs( i - k);
                    lastint= k;
                        
                    
                }
                    cindex = i;
               
            }else if(i == s.Length-1)
            {
                for (int k = lastint; k <= i; k++)
                {
                    res[k] = Math.Abs(cindex - k);
                   
                    lastint = k;


                }
            }
        }

        return res;
    }
}
