class Solution {
    public int FindDuplicate(int[] nums) {
        int n=nums.Length;
        int[] count=new int[n];
        for(int i=0;i<n;i++){
            count[nums[i]]++;
            if(count[nums[i]]>=2){
                return nums[i];
            }
        }
        return 0;
    }
}