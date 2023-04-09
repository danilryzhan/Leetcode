// See https://aka.ms/new-console-template for more information

static void Main ()
{

}
public class Solution
{
    public class TimeNode
    {
        public TimeNode(int t )
        {
            time= t;
            meetings = new Dictionary<int, List<int>>();
        }
        public int time;
        public Dictionary<int, List<int>> meetings;

        public void AddMeeting(int x1 , int x2 ,Dictionary<int,bool> result)
        {
            var foundkey = -1;
            int valueKey = -1;
                


            foreach (var item in meetings.Keys)
            {
                if (item == (x1))
                {
                    foundkey = item; break;
                }
                if (item == (x1))
                {
                    foundkey = item; break;
                    x2 = x1; break;
                }
                if (meetings[item].Contains(x1))
                {
                    foundkey = item; 
                    valueKey= x1;
                    break;

                }if (meetings[item].Contains(x2))
                {
                    foundkey = item;
                    valueKey = x2;
                    x2 = x1; 
                    break;

                }

            }
            if (foundkey != -1)
            { if (result[x2] == true || result[foundkey] == true)
                {
                    result[x2] = true;
                    if (valueKey == -1) result[foundkey] = true;
                    else { result[valueKey] = true; }

                    var w = meetings.Where(x => x.Key == foundkey);
                    foreach (var item in w)
                    {
                        result[item.Key] = true;
                    }
                }

            }
            else
            {
                if (result[x1] == true || result[x2] == true)
                { 
                   
                    result[x2] = true;
                    result[x1] = true;

                    var w = meetings.Where(x => x.Key == foundkey);
                    foreach (var item in w)
                    {
                        result[item.Key] = true;
                    }

                } 
                meetings.Add(x1, new List<int>(){x2});
                   
            }
           
        }
    }
    

    public IList<int> FindAllPeople(int n, int[][] meetings, int firstPerson)
    {

        Comparer<int> comparer = Comparer<int>.Default;
        Array.Sort<int[]>(meetings, (x, y) => comparer.Compare(x[2], y[2]));
        Dictionary<int, bool> result = new Dictionary<int, bool>();

        for (int i = 0; i < n; i++)
        {
            
            if(i==0||i==firstPerson)
            {
                result.Add(i, true);
                continue;
            }
            result.Add(i, false);
           
        }
        List<TimeNode> nodes = new List<TimeNode>();

        for(int i = 0;i<meetings.Length;i++)
        {
            var r = nodes.FindIndex((x) => x.time == meetings[i][2]);
            if (r == -1)
            {
                var tnode = new TimeNode(meetings[i][2]);
                tnode.AddMeeting(meetings[i][0] ,  meetings[i][1],result);
                nodes.Add(tnode);
            }
            else
            {
                nodes[r].AddMeeting(meetings[i][0], meetings[i][1],result);
            }
            
        }




        return result.Where((x)=>x.Value==true).ToDictionary(x=>x.Key,x=>x.Value).Keys.ToList();

    }
}
