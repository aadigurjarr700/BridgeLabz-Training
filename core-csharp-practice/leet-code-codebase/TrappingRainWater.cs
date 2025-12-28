class Solution
{
    public int Trap(int[] height)
    {
        int left=0;
        int right=height.Length-1;
        int leftmax=0;
        int rightmax=0;
        int ans=0;
        while(left<right)
        {
            leftmax=Math.Max(leftmax,height[left]);
            rightmax=Math.Max(rightmax,height[right]);
            if(leftmax<rightmax)
            {
                ans+=leftmax-height[left];
                left++;
            }
            else
            {
                ans+=rightmax-height[right];
                right--;
            }
        }
        return ans;
    }
}
