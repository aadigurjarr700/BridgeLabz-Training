using System;

class SelectionSortScores
{
    // Method to sort exam scores using Selection Sort
    static void SelectionSort(int[] scores){
        int n=scores.Length;

        // Move boundary of unsorted part
        for(int i=0;i<n-1;i++){
            int minIndex=i;

            // Find the smallest score in remaining array
            for(int j=i+1;j<n;j++){
                if(scores[j]<scores[minIndex]){
                    minIndex=j;
                }
            }

            // Swap only if a smaller element is found
            if(minIndex!=i){
                int temp=scores[i];
                scores[i]=scores[minIndex];
                scores[minIndex]=temp;
            }
        }
    }

    static void Main(string[] args){
        // Student exam scores
        int[] examScores={72,89,45,67,91,58};

        Console.WriteLine("Before Sorting:");
        Console.WriteLine(string.Join(",",examScores));

        // Apply selection sort
        SelectionSort(examScores);

        Console.WriteLine("After Sorting:");
        Console.WriteLine(string.Join(",",examScores));
    }
}
