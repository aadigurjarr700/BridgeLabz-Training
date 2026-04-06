using System;

class FootballTeam1
{
    static int[] GenerateHeights(int size)//generate random heights
    {
        Random rand = new Random();
        int[] heights = new int[size];
        for (int i = 0; i < size; i++)
            heights[i] = rand.Next(150, 251);//heights between 150cm and 250cm
        return heights;
    }
    static int Sum(int[] heights)//sum of gheights 
    {
        int sum = 0;
        foreach (int h in heights) sum += h;
        return sum;
    }
    static double Mean(int[] heights)//mean heigth s
    {
        return Sum(heights) / (double)heights.Length;
    }
    static int Shortest(int[] heights)//shortets heigtht s
    {
        int min = heights[0];
        foreach (int h in heights) min = Math.Min(min, h);
        return min;
    }
    static int Tallest(int[] heights)//tallest heights 
    {
        int max = heights[0];
        foreach (int h in heights) max = Math.Max(max, h);
        return max;
    }

    static void Main()
    {
        int[] heights = GenerateHeights(11); // 11 players
        Console.WriteLine("Heights: " + string.Join(", ", heights));
        Console.WriteLine("Shortest: " + Shortest(heights));
        Console.WriteLine("Tallest: " + Tallest(heights));
        Console.WriteLine("Mean: " + Mean(heights).ToString("F2"));
    }
}
