namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(6,1)]
        public void TestMethod1(int n,  int firstPerson)
        {
            int[][] array2D = new int[][] { new int []{ 1, 2, 5 }, new int[] { 2, 3, 8 }, new int[] { 1, 5, 10 }, };
            var res = new Solution().FindAllPeople(n,array2D,firstPerson);
            CollectionAssert.AreEqual(new List<int>{ 0, 1, 2, 3, 5 }, res.ToList());
        }
        
        [TestMethod]
        [DataRow(6,3)]
        public void TestMethod2(int n,  int firstPerson)
        {
            int[][] array2D = new int[][] { new int []{ 0, 3, 3 }, new int[] { 3, 1, 3 }, new int[] { 1, 2, 2 }, };
            var res = new Solution().FindAllPeople(n,array2D,firstPerson);
            CollectionAssert.AreEqual(new List<int>{ 0, 1, 3 }, res.ToList());
        } 
        
        [TestMethod]
        [DataRow(5,1)]
        public void TestMethod3(int n,  int firstPerson)
        {
            int[][] array2D = new int[][] { new int []{ 3, 4, 2 }, new int[] { 1, 2, 1 }, new int[] { 2, 3, 1 }, };
            var res = new Solution().FindAllPeople(n,array2D,firstPerson);
            CollectionAssert.AreEqual(new List<int>{ 0, 1, 2, 3, 4 }, res.ToList());
        }
    }
}