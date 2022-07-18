namespace Problems;

/// <summary>
/// https://leetcode.com/problems/find-pivot-index/
/// </summary>
public class FindPivotIndex
{
    public int LeftAndRight(int[] nums)
    {
        // middle / pivot index is ignored

        // 1,7,3,-6-,5,6  = 3 (0)index
        // 1, 2, 3        = -1 == not found
        // 2 | , 1, -1    = 0
        // 1 1 1 2  = 2

        // If the index is on the left edge of the array,

        int leftSum = 0;
        int rightSum = nums.Sum();

        for (int i = 0; i < nums.Length; i++)
        {
            rightSum -= nums[i];

            if (leftSum == rightSum)
                return i;

            leftSum += nums[i];
        }

        return -1;
    }
}