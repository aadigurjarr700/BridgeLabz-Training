namespace ExamProctor.Encapsulation
{
    public class Question
    {
        public int QuestionId { get; }
        public string Text { get; }

        public Question(int id, string text)
        {
            QuestionId = id;
            Text = text;
        }
    }
}
