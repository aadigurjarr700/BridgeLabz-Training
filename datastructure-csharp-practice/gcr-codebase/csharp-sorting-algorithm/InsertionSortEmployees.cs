using System;

class InsertionSortEmployees
{
    // Method to sort employee IDs using Insertion Sort
    static void InsertionSort(int[] employeeIds){
        int n=employeeIds.Length;

        // Start from second element
        for(int i=1;i<n;i++){
            int currentId=employeeIds[i];
            int j=i-1;

            // Shift elements that are greater than currentId
            while(j>=0 && employeeIds[j]>currentId){
                employeeIds[j+1]=employeeIds[j];
                j--;
            }

            // Place currentId at its correct position
            employeeIds[j+1]=currentId;
        }
    }

    static void Main(string[] args){
        // Unsorted employee IDs
        int[] employeeIds={105,102,110,101,108};

        Console.WriteLine("Before Sorting:");
        Console.WriteLine(string.Join(",",employeeIds));

        // Apply insertion sort
        InsertionSort(employeeIds);

        Console.WriteLine("After Sorting:");
        Console.WriteLine(string.Join(",",employeeIds));
    }
}

