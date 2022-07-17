using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problems;

namespace ProblemsTest;

[TestClass]
public class AddTwoNumbersTest
{
    [TestMethod]
    public void TestMethod()
    {
        var l1 = new ListNode(2);
        l1.next = new ListNode(4);
        l1.next.next = new ListNode(3);

        var l2 = new ListNode(5);
        l2.next = new ListNode(6);
        l2.next.next = new ListNode(4);

        var o = AddTwoNumbers.WithCarryMethod(l1, l2);

        Assert.AreEqual(7, o.val);
        Assert.AreEqual(0, o.next.val);
        Assert.AreEqual(8, o.next.next.val);
    }
}