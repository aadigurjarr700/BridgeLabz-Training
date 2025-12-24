class Solution{
public int MaxArea(int[] height){
    int water=0;
    int left=0;
    int right=height.Length-1;
    while(left<right){
        water=Math.Max(water,Math.Min(height[left],height[right])*(right-left));
         if(height[left]<height[right]){
            left++;
            }
            else{
                right--;
                }
            }
         return water;
    }
}
