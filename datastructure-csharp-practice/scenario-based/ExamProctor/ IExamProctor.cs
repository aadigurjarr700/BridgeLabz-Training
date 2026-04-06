namespace ExamProctor.Interface
{
    public interface IExamProctor
    {
        void VisitQuestion(int questionId);
        bool SubmitAnswer(int questionId, string answer);

        void ShowNavigationHistory();

        
        int CalculateScore();
       
    }
}
