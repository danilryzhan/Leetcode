namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("loveleetcode", 'e',new int[] { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 })]
        
        public void TestMethod1(string s, char c, int[]inspectData)
        {
           var testres =  new Solution().ShortestToChar(s, c);


            CollectionAssert.AreEqual(inspectData, testres);    
        }

        [TestMethod]
        [DataRow("aaba", 'b', new int[] { 2, 1, 0, 1 })]

        public void TestMethod2(string s, char c, int[] inspectData)
        {
            var testres = new Solution().ShortestToChar(s, c);


            CollectionAssert.AreEqual(inspectData, testres);
        }

    }

   
    
}