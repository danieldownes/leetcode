namespace Problems;

/// <summary>
/// Hard! Had a bit of probs with this. Left some notes in code
/// and purposfully didn't optimise things I added after first submit fails
/// Not happy with turn around speed, but a few good learning points
///  - Try solving for 1 array size first.
///  - Think about the inverse of the problem
///  - Leverage hints and constraints to reuse mememory
///    - eg negative numbers are use to 'flag' seen values within
///      the same array, making this the constant size retaint easier
///    - However thinking about using a n^2 size first helped
/// https://leetcode.com/problems/first-missing-positive/
/// </summary>
public class FirstMissingPositive
{
    public int MarkSeen(int[] nums)
    {
        if (nums.Length == 1 && nums[0] <= 0)
            return 1;

        // Find smallest
        int smallest = int.MaxValue;
        int high = 0;
        for (int n = 0; n < nums.Length; n++)
        {
            if (nums[n] > 0 && nums[n] < smallest)
                smallest = nums[n];

            if (nums[n] > high)
                high = nums[n];

            // Preb so that we can use neg numbers
            // in later passes
            // We don't care about them from the data
            if (nums[n] < 0)
                nums[n] = 0;
        }

        if (smallest <= 0)
            return 1;

        // Failed first submission as I had misunderstand that
        // we need to return 1 if the smallest > 1!!!
        if (smallest != 1)
            return 1;

        // ... yes could merge both if statements, but this was 
        // a learning exercise, and I am learning!!

        // 3, 4, 6, 2
        // smallest 2
        // 0  1  2  3  +4+
        // 3, 4, 6, 2 
        //    0
        //       0
        //              0 (take highest)
        // 0  
        //    0
        //          !
        // Therefore index 3 has no 'seen' and should be
        // a posative number
        // Missing number is 3 + smallest
        // If all seen, then its highest number + 1
        // index = 0 - -1 = 0

        // Use smallest - smallest as 0-index
        // for nums to store each seen value

        // Duplicates

        int index;

        // First pass, go through each element,
        // For each elements value, mark the index as seen.
        // do this with distroying the data by negating the index value
        for (int n = 0; n < nums.Length; n++)
        {
            index = Math.Abs(nums[n]) - smallest;
            if (index < 0)
                continue;

            if (index >= nums.Length)
                continue;

            // Flip. Abs here as we might have repeating numbers
            nums[index] = -Math.Abs(nums[index]);
            // Consider this could have been a 0 previously
            // In that case we need to force a minus number to flip it
            if (nums[index] == 0)
                nums[index] = -1;
        }

        // Now lets find the first  missing number, by looking for
        // the index that wasn't negated
        for (int n = 0; n < nums.Length; n++)
        {
            if (nums[n] >= 0)
                return n + smallest;
        }

        // If all numbers were negated, then the first missing highest will
        // the next highest
        return high + 1;
    }
}