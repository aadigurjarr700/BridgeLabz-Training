using System;

class ArrayIndexOutOfRangeDemo8
{
    //array index  thr error demo
    static void ShowArrayIndexError()
    {
        try
        {
            int[] nums={1,2,3,4};//array for sample use 
            Console.WriteLine(nums[6]);//thr wronmg index
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("Exception:"+e.GetType().Name);//handleed 
        }
    }

    static void Main()
    {
        ShowArrayIndexError();//call thr method 
    }
}
