public class Solution
{
    // Given an integer array nums and an integer val,
    // remove all occurrences of val in nums in-place. 
    public static int RemoveElement(int[] nums, int val)
    {
        int k = 0;

        foreach (var i in nums)
        {
            if (i != val)
            {
                nums[k++] = i; // equal to nums[k] = i; k++
            }
        }
        return k;
    }

    static void Main()
    {
        int[] nums =  {3, 2, 2, 3, 8, 1 };
        int val = 3;
        int k = RemoveElement(nums, val);
        for(int i = 0; i < k; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }
}