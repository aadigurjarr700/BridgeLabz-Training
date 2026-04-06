using System;

class MergeSortBooks
{
    // This method divides the array into halves and sorts them recursively
    static void MergeSort(int[] prices,int left,int right){
        // If there is more than one element
        if(left<right){
            // Find middle index
            int mid=(left+right)/2;

            // Sort left half
            MergeSort(prices,left,mid);

            // Sort right half
            MergeSort(prices,mid+1,right);

            // Merge the two sorted halves
            Merge(prices,left,mid,right);
        }
    }

    // This method merges two sorted halves into a single sorted array
    static void Merge(int[] prices,int left,int mid,int right){
        // Size of left and right subarrays
        int n1=mid-left+1;
        int n2=right-mid;

        // Temporary arrays to hold values
        int[] leftArr=new int[n1];
        int[] rightArr=new int[n2];

        // Copy data into left array
        for(int i=0;i<n1;i++){
            leftArr[i]=prices[left+i];
        }

        // Copy data into right array
        for(int j=0;j<n2;j++){
            rightArr[j]=prices[mid+1+j];
        }

        // Initial indexes
        int iIndex=0,jIndex=0,k=left;

        // Compare elements and merge in sorted order
        while(iIndex<n1&&jIndex<n2){
            if(leftArr[iIndex]<=rightArr[jIndex]){
                prices[k]=leftArr[iIndex];
                iIndex++;
            }else{
                prices[k]=rightArr[jIndex];
                jIndex++;
            }
            k++;
        }

        // Copy remaining elements from left array
        while(iIndex<n1){
            prices[k]=leftArr[iIndex];
            iIndex++;
            k++;
        }

        // Copy remaining elements from right array
        while(jIndex<n2){
            prices[k]=rightArr[jIndex];
            jIndex++;
            k++;
        }
    }

    // Main method
    static void Main(string[] args){
        // Book prices array
        int[] bookPrices={450,299,799,199,599,350};

        Console.WriteLine("Before Sorting:");
        Console.WriteLine(string.Join(",",bookPrices));

        // Calling merge sort
        MergeSort(bookPrices,0,bookPrices.Length-1);

        Console.WriteLine("After Sorting:");
        Console.WriteLine(string.Join(",",bookPrices));
    }
}
