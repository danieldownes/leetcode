using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest;

[TestClass]
public class FirstMissingPositiveTest
{
    [TestMethod]
    public void TestSimple()
    {
        var firstMissingPositive = new FirstMissingPositive();

        int[] nums = { 3, 4, 1, 5, 6 };

        int i = firstMissingPositive.MarkSeen(nums);

        Assert.AreEqual(2, i);
    }

    [TestMethod]
    public void StartMiss4()
    {
        var firstMissingPositive = new FirstMissingPositive();

        int[] nums = { 3, 5, 6, 1, 2 };

        int i = firstMissingPositive.MarkSeen(nums);

        Assert.AreEqual(4, i);
    }

    [TestMethod]
    public void SingleVal()
    {
        var firstMissingPositive = new FirstMissingPositive();

        int[] nums = { 1 };

        int i = firstMissingPositive.MarkSeen(nums);

        Assert.AreEqual(2, i);
    }

    [TestMethod]
    public void SingleValNot1()
    {
        var firstMissingPositive = new FirstMissingPositive();

        int[] nums = { 3 };

        int i = firstMissingPositive.MarkSeen(nums);

        Assert.AreEqual(1, i);
    }

    [TestMethod]
    public void SingleValZero()
    {
        var firstMissingPositive = new FirstMissingPositive();

        int[] nums = { 0 };

        int i = firstMissingPositive.MarkSeen(nums);

        Assert.AreEqual(1, i);
    }

    [TestMethod]
    public void TwoVals()
    {
        var firstMissingPositive = new FirstMissingPositive();

        int[] nums = { 1, 3 };

        int i = firstMissingPositive.MarkSeen(nums);

        Assert.AreEqual(2, i);
    }
    [TestMethod]
    public void TwoValsNotInset()
    {
        var firstMissingPositive = new FirstMissingPositive();

        int[] nums = { 1, 2 };

        int i = firstMissingPositive.MarkSeen(nums);

        Assert.AreEqual(3, i);
    }

    [TestMethod]
    public void NotInSet()
    {
        var firstMissingPositive = new FirstMissingPositive();

        int[] nums = { 3, 5, 2, 4, 1 };

        int i = firstMissingPositive.MarkSeen(nums);

        Assert.AreEqual(6, i);
    }

    [TestMethod]
    public void From7To12()
    {
        var firstMissingPositive = new FirstMissingPositive();

        int[] nums = { 7, 8, 9, 11, 12 };

        int i = firstMissingPositive.MarkSeen(nums);

        Assert.AreEqual(1, i);
    }

    [TestMethod]
    public void DoubleOnesOnly()
    {
        var firstMissingPositive = new FirstMissingPositive();

        int[] nums = { 1, 1 };

        int i = firstMissingPositive.MarkSeen(nums);

        Assert.AreEqual(2, i);
    }

    [TestMethod]
    public void Double1Single2()
    {
        var firstMissingPositive = new FirstMissingPositive();

        int[] nums = { 1, 1, 2};

        int i = firstMissingPositive.MarkSeen(nums);

        Assert.AreEqual(3, i);
    }

    [TestMethod]
    public void Double1Double2()
    {
        var firstMissingPositive = new FirstMissingPositive();

        int[] nums = { 1, 1, 2, 2 };

        int i = firstMissingPositive.MarkSeen(nums);

        Assert.AreEqual(3, i);
    }

    [TestMethod]
    public void ExistingNegative()
    {
        var firstMissingPositive = new FirstMissingPositive();

        int[] nums = { 0, -1, 3, 1 };

        int i = firstMissingPositive.MarkSeen(nums);

        Assert.AreEqual(2, i);
    }
}