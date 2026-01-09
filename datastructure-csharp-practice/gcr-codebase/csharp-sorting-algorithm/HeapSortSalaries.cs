using System;

class HeapSortSalaries
{
    // Main method to perform Heap Sort
    static void HeapSort(int[] salaries){
        int n=salaries.Length;

        // Step 1: Build Max Heap
        for(int i=n/2-1;i>=0;i--){
            Heapify(salaries,n,i);
        }

        // Step 2: Extract elements one by one
        for(int i=n-1;i>0;i--){
            // Move current root to end
            int temp=salaries[0];
            salaries[0]=salaries[i];
            salaries[i]=temp;

            // Heapify the reduced heap
            Heapify(salaries,i,0);
        }
    }

    // Heapify subtree rooted at index i
    static void Heapify(int[] salaries,int n,int i){
        int largest=i;
        int left=2*i+1;
        int right=2*i+2;

        // Check if left child is larger
        if(left<n && salaries[left]>salaries[largest]){
            largest=left;
        }

        // Check if right child is larger
        if(right<n && salaries[right]>salaries[largest]){
            largest=right;
        }

        // Swap and continue heapifying if root is not largest
        if(largest!=i){
            int temp=salaries[i];
            salaries[i]=salaries[largest];
            salaries[largest]=temp;

            Heapify(salaries,n,largest);
        }
    }

    static void Main(string[] args){
        // Salary demands from job applicants
        int[] salaryDemands={55000,72000,48000,90000,65000};

        Console.WriteLine("Before Sorting:");
        Console.WriteLine(string.Join(",",salaryDemands));

        // Apply heap sort
        HeapSort(salaryDemands);

        Console.WriteLine("After Sorting:");
        Console.WriteLine(string.Join(",",salaryDemands));
    }
}
