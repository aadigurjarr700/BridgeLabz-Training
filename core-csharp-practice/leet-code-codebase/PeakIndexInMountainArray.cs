class Solution {
    public int PeakIndexInMountainArray(int[] nums) {
        int peak=0;
        for(int i=0;i<nums.Length-1;i++){
            if(nums[i]<nums[i+1]){
                peak=i+1;
            }
        }
        return peak;
    }
}