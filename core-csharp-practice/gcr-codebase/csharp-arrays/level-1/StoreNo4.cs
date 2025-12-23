using System;

class StoreNo4{
    static void Main(){
        double[] nums=new double[10]; // arr to stroe numbrs
        double total=0.0; //sum
        int index=0;

        while(true){
            Console.Write("Enter a number (0 or negative to stop): ");
            double value=Convert.ToDouble(Console.ReadLine()); //take inpt from usr

            if(value<=0) break;//stop if 0 or negative
            if(index>=10) break;//stop if array full

            nums[index]=value; //store in array
            index++;
        }

        Console.WriteLine("Numbers entered:");
        for(int i=0;i<index;i++){
            Console.WriteLine(nums[i]); 
            total+=nums[i];
        }

        Console.WriteLine("Total sum is "+total); //disply thr sum
    }
}
