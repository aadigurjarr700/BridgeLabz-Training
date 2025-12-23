using System;
class VoteCheck1
{
    static void Main()
    {
        int[] age=new int[10]; //arr to store the age of ten studnts
        for(int i = 0; i < age.Length; i++)
        {
            Console.WriteLine("Enter thr age of studnt " +(i+1)+ ":");
            age[i]=Convert.ToInt32(Console.ReadLine());//rtake input from usr
        }

        for(int i=0;i< age.Length; i++)
        {
            if (age[i] < 0)
            {
                Console.WriteLine("Student" +(i+1)+ ":Invalid age");
            }
            else if (age[i] < 18)
            {
                Console.WriteLine("Student" +(i+1)+ ":Not eligible for voting ");
            }
            else
            {
                Console.WriteLine("Student" +(i+1)+ ":Eligible for voting ");
            }
        }





    }
}