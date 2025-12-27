class Solution
{
    public int FindFirst(int[] nums,int target)
    {
        int index=-1;
        int start=0;
        int end=nums.Length-1;
        while(start<=end)
        {
            int mid=start+(end-start)/2;
            if(nums[mid]==target)
            {
                index=mid;
            }
            if(nums[mid]>=target)
            {
                end=mid-1;
            }
            else
            {
                start=mid+1;
            }
        }
        return index;
    }

    public int FindLast(int[] nums,int target)
    {
        int index=-1;
        int start=0;
        int end=nums.Length-1;
        while(start<=end)
        {
            int mid=start+(end-start)/2;
            if(nums[mid]==target)
            {
                index=mid;
            }
            if(nums[mid]<=target)
            {
                start=mid+1;
            }
            else
            {
                end=mid-1;
            }
        }
        return index;
    }

    public int[] SearchRange(int[] nums,int target)
    {
        int[] arr=new int[2];
        arr[0]=FindFirst(nums,target);
        arr[1]=FindLast(nums,target);
        return arr;
    }
}