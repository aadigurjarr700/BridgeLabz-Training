using System;

class Friend2{
    static void Main()
    {
        string[] names={"Amar","Akbar","Anthony"}; //arr of string
        int[] age=new int[3];//arr to stre the age
        double[] height=new double[3];//arr to stre the height

        for(int i=0;i<3;i++)
        {
            Console.Write("Enter age of "+names[i]+":");
            age[i]=Convert.ToInt32(Console.ReadLine());//tak input from usr
            Console.Write("Enter height of "+names[i]+":");
            height[i]=Convert.ToDouble(Console.ReadLine());//tak inrput form user
        }

        int minAgeIndex=0;
        double maxHeight=height[0];int maxHeightIndex=0;
        for(int i=1;i<3;i++)
        {
            if(age[i]<age[minAgeIndex]) minAgeIndex=i;
            if(height[i]>maxHeight){maxHeight=height[i];maxHeightIndex=i;}
        }

        Console.WriteLine("Youngest:"+names[minAgeIndex]);
        Console.WriteLine("Tallest:"+names[maxHeightIndex]);
    }
}
