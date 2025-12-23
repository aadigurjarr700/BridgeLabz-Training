using System;

class EmpBonus1{
    static void Main()
    {
        double[] salary=new double[10];
        double[] years=new double[10];
        double[] bonus=new double[10];
        double[] newSalary=new double[10];
        double totalBonus=0,totalOldSalary=0,totalNewSalary=0;

        for(int i=0;i<10;i++)
        {
            Console.Write("Enter salary of employee "+(i+1)+":");
            salary[i]=Convert.ToDouble(Console.ReadLine());//take thr inpt form usr
            Console.Write("Enter years of service of employee "+(i+1)+":");
            years[i]=Convert.ToDouble(Console.ReadLine());//takh thr inpot form user
            if(salary[i]<0||years[i]<0){Console.WriteLine("Invalid input");i--;continue;}
        }

        for(int i=0;i<10;i++)
        {
            bonus[i]=years[i]>5?salary[i]*0.05:salary[i]*0.02;
            newSalary[i]=salary[i]+bonus[i];
            totalBonus+=bonus[i];//totl bonus 
            totalOldSalary+=salary[i];
            totalNewSalary+=newSalary[i];
        }

        Console.WriteLine("Total Bonus="+totalBonus);
        Console.WriteLine("Total Old Salary="+totalOldSalary);
        Console.WriteLine("Total New Salary="+totalNewSalary);
    }
}
