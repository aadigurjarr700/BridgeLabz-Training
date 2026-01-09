using System;

class CountingSortAges
{
    // Method to sort student ages using Counting Sort
    static void CountingSort(int[] ages){
        int minAge=10;
        int maxAge=18;
        int range=maxAge-minAge+1;

        // Step 1: Create count array
        int[] count=new int[range];

        // Count frequency of each age
        for(int i=0;i<ages.Length;i++){
            count[ages[i]-minAge]++;
        }

        // Step 2: Rebuild sorted array
        int index=0;
        for(int i=0;i<range;i++){
            while(count[i]>0){
                ages[index]=i+minAge;
                index++;
                count[i]--;
            }
        }
    }

    static void Main(string[] args){
        // Student ages array
        int[] studentAges={12,15,11,14,18,10,13,15};

        Console.WriteLine("Before Sorting:");
        Console.WriteLine(string.Join(",",studentAges));

        // Apply counting sort
        CountingSort(studentAges);

        Console.WriteLine("After Sorting:");
        Console.WriteLine(string.Join(",",studentAges));
    }
}
