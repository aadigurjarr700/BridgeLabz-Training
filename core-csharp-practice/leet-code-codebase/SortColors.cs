public class Solution
{
    public void SortColors(int[] nums)
    {
        int start=0;
        int end=nums.Length-1;
        int mid=0;
        while(mid<=end)
        {
            if(nums[mid]==0)
            {
                int temp=nums[start];
                nums[start]=nums[mid];
                nums[mid]=temp;
                start++;
                mid++;
            }
            else if(nums[mid]==1)
            {
                mid++;
            }
            else
            {
                int temp=nums[end];
                nums[end]=nums[mid];
                nums[mid]=temp;
                end--;
            }
        }
    }
}
