namespace OpenExamStudio.Designer
{
    public abstract class Question
    {
        public int SectionId { get; }
        public int QuestionId { get; }

        public string Title { get; set; }
        public string Text { get; }
        public string Type { get; set; }
        public int Points { get; }

        protected Question(int sectionId, int questionId, string text, int points, string type, string title)
        {
            SectionId = sectionId;
            QuestionId = questionId;
            Text = text;
            Points = points;
            Type = type;
            Title = title;
        }
    }
}