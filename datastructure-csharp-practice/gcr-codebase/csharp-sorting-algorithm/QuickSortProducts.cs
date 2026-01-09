using System;

class QuickSortProducts
{
    // Main Quick Sort function
    static void QuickSort(int[] prices,int low,int high){
        // Check if array has more than one element
        if(low<high){
            // Find correct position of pivot
            int pivotIndex=Partition(prices,low,high);

            // Sort elements on left of pivot
            QuickSort(prices,low,pivotIndex-1);

            // Sort elements on right of pivot
            QuickSort(prices,pivotIndex+1,high);
        }
    }

    // Partition method places pivot at correct position
    static int Partition(int[] prices,int low,int high){
        // Taking last element as pivot
        int pivot=prices[high];
        int i=low-1;

        // Rearranging elements based on pivot
        for(int j=low;j<high;j++){
            if(prices[j]<pivot){
                i++;
                int temp=prices[i];
                prices[i]=prices[j];
                prices[j]=temp;
            }
        }

        // Place pivot at correct index
        int tempPivot=prices[i+1];
        prices[i+1]=prices[high];
        prices[high]=tempPivot;

        return i+1;
    }

    static void Main(string[] args){
        // Product prices array
        int[] productPrices={1200,450,800,300,1500,650};

        Console.WriteLine("Before Sorting:");
        Console.WriteLine(string.Join(",",productPrices));

        // Apply quick sort
        QuickSort(productPrices,0,productPrices.Length-1);

        Console.WriteLine("After Sorting:");
        Console.WriteLine(string.Join(",",productPrices));
    }
}
