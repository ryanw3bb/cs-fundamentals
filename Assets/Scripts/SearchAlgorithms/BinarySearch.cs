public static class BinarySearch
{
    public static int[] SearchArray(int[] sortedArray, int target)
    {
        int[] targetRange = { -1, -1 };

        int leftIdx = ExtremeInsertionIndex(sortedArray, target, true);

        // assert that 'leftIdx' is within the array bounds and that `target`
        // is actually in 'nums'.
        if(leftIdx == sortedArray.Length || sortedArray[leftIdx] != target)
        {
            return targetRange;
        }

        targetRange[0] = leftIdx;
        targetRange[1] = ExtremeInsertionIndex(sortedArray, target, false) - 1;

        return targetRange;
    }

    // returns leftmost (or rightmost) index at which target should be
    // inserted in sorted array nums via binary search.
    private static int ExtremeInsertionIndex(int[] nums, int target, bool left)
    {
        int lo = 0;
        int hi = nums.Length;

        while(lo < hi)
        {
            int mid = (lo + hi) / 2;

            if(nums[mid] > target || (left && nums[mid] == target))
            {
                hi = mid;
            }
            else
            {
                lo = mid + 1;
            }
        }

        return lo;
    }

    // returning the index of the first occurence we come to of given target
    public static int IndexFind(int[] nums, int target)
    {
        int lo = 0;
        int hi = nums.Length;

        while(lo < hi)
        {
            int mid = (lo + hi) / 2;

            if(nums[mid] == target)
            {
                return mid;
            }
            if(nums[mid] > target)
            {
                hi = mid;
            }
            else
            {
                lo = mid + 1;
            }
        }

        return -1;
    }
}