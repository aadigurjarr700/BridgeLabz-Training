using System;

class FriendsCheck8{
    static int FindYoungest(int[] ages)//methdo tot find the youngest frnd 
    {
        int minAge=ages[0];
        int index=0;
        for(int i=1;i<ages.Length;i++)
        {
            if(ages[i]<minAge)
            {
                minAge=ages[i];
                index=i;
            }
        }
        return index;//return index of youngest 
    }
    static int FindTallest(double[] heights)//methdo tot find the tallest frnd 
    {
        double maxHeight=heights[0];
        int index=0;
        for(int i=1;i<heights.Length;i++)
        {
            if(heights[i]>maxHeight)
            {
                maxHeight=heights[i];
                index=i;
            }
        }
        return index;//reutrn teh index  of tlallest 
    }

    static void Main()
    {
        string[] names={"Amar","Akbar","Anthony"};
        int[] ages=new int[3];
        double[] heights=new double[3];

        for(int i=0;i<3;i++)
        {
            Console.Write($"Enter age of {names[i]}: ");
            ages[i]=Convert.ToInt32(Console.ReadLine());//take input from user 

            Console.Write($"Enter height of {names[i]} (in meters): ");
            heights[i]=Convert.ToDouble(Console.ReadLine());//take input from user 
        }

        int youngestIndex=FindYoungest(ages);
        int tallestIndex=FindTallest(heights);

        Console.WriteLine($"Youngest friend: {names[youngestIndex]} with age {ages[youngestIndex]}");
        Console.WriteLine($"Tallest friend: {names[tallestIndex]} with height {heights[tallestIndex]} meters");
    }
}
