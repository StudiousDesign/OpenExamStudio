namespace OpenExamStudio.Designer
{
    public abstract class Question
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Text { get; }
        public string Type { get; set; }
        public int Points { get; }

        protected Question(int id, string text, int points, string type, string title)
        {
            Id = Id;
            Text = text;
            Points = points;
            Type = type;
            Title = title;
        }
    }
}