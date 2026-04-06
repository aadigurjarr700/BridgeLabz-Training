using System;

class HeightFoot6{
    static void Main(){
        double[] heights=new double[11];//arr to stre elevn playrs' height
        double sum=0.0;//sum of heigts

        for(int i=0;i<11;i++){
            Console.Write("Enter height of player "+(i+1)+": ");
            heights[i]=Convert.ToDouble(Console.ReadLine());//take inpt of ech playr
            sum+=heights[i]; //add to sum
        }

        double mean=sum/11;//calculate mean
        Console.WriteLine("Mean height of the football team is: "+mean);
    }
}
