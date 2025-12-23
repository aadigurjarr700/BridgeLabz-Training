public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] mergedarray=new int[nums1.Length+nums2.Length];//create the new array for merging the both arrays
        
        int idx=0;
        for(int i=0;i<nums1.Length;i++){
            mergedarray[idx++]=nums1[i];
        }
        for(int i=0;i<nums2.Length;i++){
            mergedarray[idx++]=nums2[i];
        }
        Array.Sort(mergedarray);
        int n=mergedarray.Length;
        if(n%2==0){
            return (mergedarray[n/2]+mergedarray[n/2-1])/2.0; //for even size of array 
        }
        else{
            return mergedarray[n/2];//median for odd size of array
        }

    }
}