
using System.Collections;

static void Main()
{

} 

public delegate void Del(string message);
public class Solution
{
    public bool CanReorderDoubled(int[] arr)
    {
        Array.Sort(arr);
        Array.Reverse(arr);
        List<int> waiters = new List<int>();
        waiters.Add(arr.First());
        
        for (int i = 1; i < arr.Length; i++)
        {
            if(waiters.Count>arr.Length-i)
                return false;
            
            bool tmp = false;

            bool less = false;
            
             tmp = waiters.Contains(arr[i] * 2);
            if(!tmp && arr[i]%2 == 0)
            {
                less = waiters.Contains(arr[i] / 2);
            }
            

            if (!tmp && !less)
            {
                if (i != arr.Length-1 && arr[i] / 2 > arr[i + 1] && arr[i] > 0) return false;
                waiters.Add(arr[i]);
            }
            else
            {
                if(tmp) waiters.Remove(arr[i] * 2);
                if(less) waiters.Remove(arr[i] / 2);
              
            }

        }
        
        return  waiters.Count==0;
    }
}
