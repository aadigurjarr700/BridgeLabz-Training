using System;


class VotingProgram7
{
    public class StudentVoteChecker{
    public bool CanStudentVote(int age)///method to check the votinf eleiginbilty 
    {
        if(age<0)return false;//invalid age 
        return age>=18;//eleigibkle 
    }
}
    static void Main()
    {
        int[] ages=new int[10];//arr of ten studnets 
        StudentVoteChecker checker=new StudentVoteChecker();

        for(int i=0;i<10;i++)
        {
            Console.Write($"Enter age of student {i+1}: ");
            ages[i]=Convert.ToInt32(Console.ReadLine());

            if(checker.CanStudentVote(ages[i]))
                Console.WriteLine("Student can vote");
            else
                Console.WriteLine("Student cannot vote");
        }
    }
}
