using System;

class RandomNumbers12{
    static int[] Generate4DigitRandomArray(int size)//generate random 4 digit numbers
    {
        Random rand=new Random();
        int[] arr=new int[size];
        for(int i=0;i<size;i++)
            arr[i]=rand.Next(1000,10000); // 4-digit number
        return arr;
    }

    //find thr  average, min, and max
    static double[] FindAverageMinMax(int[] numbers)
    {
        int min=numbers[0], max=numbers[0], sum=0;
        for(int i=0;i<numbers.Length;i++)
        {
            sum+=numbers[i];
            min=Math.Min(min,numbers[i]);
            max=Math.Max(max,numbers[i]);
        }
        double avg=sum/(double)numbers.Length;
        return new double[]{avg,min,max};
    }

    static void Main()
    {
        int[] nums=Generate4DigitRandomArray(5);

        Console.WriteLine("Generated numbers: "+string.Join(", ",nums));

        double[] result=FindAverageMinMax(nums);

        Console.WriteLine($"Average: {result[0]:F2}, Min: {result[1]}, Max: {result[2]}");
    }
}
