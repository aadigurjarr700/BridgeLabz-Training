using System;
using ExamProctor.Utility;

namespace ExamProctor.Menu
{
    public class ExamMenu
    {
        private readonly ExamProctorUtility exam = new(); 

        public void Show()
        {
            while (true)
            {
                PrintMenu();
                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        VisitQuestion();
                        break;

                    case "2":
                        SubmitAnswer();
                        break;

                    case "3":
                        exam.ShowNavigationHistory();
                        break;

                    case "4":
                        int score = exam.CalculateScore();
                        Console.WriteLine($"Final Score: {score}");
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        private void PrintMenu()
        {
            Console.WriteLine("\n--- Exam Proctor Menu ---");
            Console.WriteLine("1. Visit Question");
            Console.WriteLine("2. Submit Answer");
            Console.WriteLine("3. View Navigation History");
            Console.WriteLine("4. Submit Exam");
            Console.Write("Choice: ");
        }

        private void VisitQuestion()
        {
            Console.Write("Enter Question ID: ");
            if (int.TryParse(Console.ReadLine(), out int qId))
            {
                exam.VisitQuestion(qId);
                Console.WriteLine($"Visited Question {qId}");
            }
            else
            {
                Console.WriteLine("Invalid Question ID.");
            }
        }

        private void SubmitAnswer()
        {
            Console.Write("Enter Question ID: ");
            if (!int.TryParse(Console.ReadLine(), out int qId))
            {
                Console.WriteLine("Invalid ID.");
                return;
            }

            Console.Write("Enter Answer (A/B/C/D): ");
            string answer = Console.ReadLine() ?? "";

            bool success = exam.SubmitAnswer(qId, answer);
            Console.WriteLine(success ? "Answer saved." : "Invalid answer.");
        }
    }
}
