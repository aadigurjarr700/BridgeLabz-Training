class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int maxsum = int.MinValue;
        int currmax = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            currmax += nums[i];
            maxsum = Math.Max(maxsum, currmax);

            if (currmax < 0)
            {
                currmax = 0;
            }
        }

        return maxsum;
    }
}
