using System;

class BubbleSortMarks
{
    // Method to sort student marks using Bubble Sort
    static void BubbleSort(int[] marks){
        int n=marks.Length;
        bool swapped;

        // Run passes over the array
        for(int i=0;i<n-1;i++){
            swapped=false;

            // Compare adjacent elements
            for(int j=0;j<n-i-1;j++){
                if(marks[j]>marks[j+1]){
                    int temp=marks[j];
                    marks[j]=marks[j+1];
                    marks[j+1]=temp;
                    swapped=true;
                }
            }

            // Stop early if no swaps happened
            if(!swapped){
                break;
            }
        }
    }

    static void Main(string[] args){
        // Student marks array
        int[] studentMarks={78,45,89,60,72};

        Console.WriteLine("Before Sorting:");
        Console.WriteLine(string.Join(",",studentMarks));

        // Apply bubble sort
        BubbleSort(studentMarks);

        Console.WriteLine("After Sorting:");
        Console.WriteLine(string.Join(",",studentMarks));
    }
}
