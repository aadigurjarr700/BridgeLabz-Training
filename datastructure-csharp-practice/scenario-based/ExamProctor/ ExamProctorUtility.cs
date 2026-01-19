using System;
using System.Collections.Generic;
using ExamProctor.Interface;

namespace ExamProctor.Utility
{
    public class ExamProctorUtility : IExamProctor
    {
        private readonly Stack<int> navigationStack = new();
        private readonly Dictionary<int, string> studentAnswers = new();
        private readonly Dictionary<int, string> answerKey = new();

        public ExamProctorUtility()
        {
            LoadAnswerKey();
        }

        private void LoadAnswerKey()
        {
            answerKey[1] = "B";
            answerKey[2] = "D";
            answerKey[3] = "B";
            answerKey[4] = "A";
        }

        public void VisitQuestion(int questionId)
        {
            navigationStack.Push(questionId);
        }

        public bool SubmitAnswer(int questionId, string answer)
        {
            if (string.IsNullOrWhiteSpace(answer))
                return false;

            studentAnswers[questionId] = answer.ToUpper();
            return true;
        }

        public int CalculateScore()
        {
            int score = 0;

            foreach (var entry in answerKey)
            {
                if (studentAnswers.TryGetValue(entry.Key, out string? studentAnswer))
                {
                    if (studentAnswer == entry.Value)
                        score++;
                }
            }
            return score;
        }

        public void ShowNavigationHistory()
        {
            if (navigationStack.Count == 0)
            {
                Console.WriteLine("No navigation recorded.");
                return;
            }

            Console.WriteLine("Question Navigation (Last Visited First):");
            foreach (int q in navigationStack)
            {
                Console.WriteLine($"Question {q}");
            }
        }
    }
}
