using System;

class Trigonometry12{
    public static double[] calculateTrigonometricFunctions(double angle)//method to calculate teh trigonometry 
    {
        double radians=angle*Math.PI/180;
        double sine=Math.Sin(radians);
        double cosine=Math.Cos(radians);
        double tangent=Math.Tan(radians);
        return new double[]{sine,cosine,tangent};
    }
    static void Main()
    {
        Console.Write("Enter angle in degrees: ");
        double angle=Convert.ToDouble(Console.ReadLine());//take the inptu from usr 

        double[] result=calculateTrigonometricFunctions(angle);//call the metyhdos 

        Console.WriteLine("Sine: "+result[0]);
        Console.WriteLine("Cosine: "+result[1]);
        Console.WriteLine("Tangent: "+result[2]);
    }
}
