using System.Collections.Generic;
using System.Security.Permissions;

namespace OpenExamStudio.Designer
{
    public class Question
    {
        public int SectionId { get; set; }
        public int QuestionId { get; set; }
        public string CorrectAnswer { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public int Points { get; set; }
        public int AllowedSelections { get; set; }
        public List<dynamic> AnswerOptions { get; set; }
        public Question()
        {

        }
        protected Question(int sectionId, int questionId, string text, int points, string type, string title, string correctAnswer, int allowedSelections)
        {
            SectionId = sectionId;
            QuestionId = questionId;
            Text = text;
            Points = points;
            Type = type;
            Title = title;
            CorrectAnswer = correctAnswer;
            AllowedSelections = allowedSelections;
        }
    }
}