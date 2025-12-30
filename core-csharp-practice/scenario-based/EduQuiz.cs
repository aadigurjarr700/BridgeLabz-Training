// SUMMARY:
//Uses two string arrays to store correct answers and student answers.
//Compares answers case-insensitively, prints correct/incorrect feedback for each question, and calculates the score.
//Calculates percentage and displays a pass/fail result.
using System;
class EduQuiz
{
    //method to calculate score
    static int CalculateScore(string[] correct, string[] student)
    {
        int score = 0;

        for (int i = 0; i < correct.Length; i++)
        {
            if (student[i].Equals(correct[i], StringComparison.OrdinalIgnoreCase))
            {
                score++;
            }
        }
        return score;
    }

    static void Main()
    {
        // Correct answers
        string[] correctAnswers =
        {
            "A", "B", "C", "D", "A","C", "B", "D", "A", "C"
        };

        //student answers
        string[] studentAnswers = new string[10];

        //take input student answers
        Console.WriteLine("Enter answers for 10 questions:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Question " + (i + 1) + ": ");
            studentAnswers[i] = Console.ReadLine()?? "";
        }

        // Feedback
        Console.WriteLine("\n--- Quiz Feedback ---");
        for (int i = 0; i < 10; i++)
        {
            if (studentAnswers[i].Equals(correctAnswers[i], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Question " + (i + 1) + ": Correct");
            }
            else
            {
                Console.WriteLine("Question " + (i + 1) + ": Incorrect");
            }
        }

        //calculate score
        int score = CalculateScore(correctAnswers, studentAnswers);
        double percentage = (score / 10.0) * 100;

        //final result
        Console.WriteLine("\nTotal Score: " + score + "/10");
        Console.WriteLine("Percentage: " + percentage + "%");

        if (percentage >= 50){
		Console.WriteLine("Result: PASS");}
        else{
		Console.WriteLine("Result: FAIL");}
    }
}