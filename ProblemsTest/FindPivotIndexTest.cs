using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest;

[TestClass]
public class FindPivotIndexTest
{
    [TestMethod]
    public void TestMethod()
    {
        var o = new FindPivotIndex();
        int[] nums = { 1, 7, 3, 6, 5, 6 };
        int i = o.LeftAndRight(nums);

        Assert.AreEqual(3, i);
    }
}