
namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        Solution s = new Solution();
     

        [TestMethod]
        [DataRow(new int[] { 4, -2, 2, -4 })]
        public void test1(int[]arr)
        {
            Assert.AreEqual(true,s.CanReorderDoubled(arr));
        }

        [TestMethod]
        [DataRow(new int[] { 3, 1, 3, 6 })]
        public void test2(int[] arr)
        {
            Assert.AreEqual(false, s.CanReorderDoubled(arr));
        }
        
        [TestMethod]
        [DataRow(new int[] { 2, 4, 0, 0, 8, 1 })]
        public void test3(int[] arr)
        {
            Assert.AreEqual(true, s.CanReorderDoubled(arr));
        }
        
        [TestMethod]
        [DataRow(new int[] { 2, 1, 2, 1, 1, 1, 2, 2 })]
        public void test4(int[] arr)
        {
            Assert.AreEqual(true, s.CanReorderDoubled(arr));
        }
    }



}