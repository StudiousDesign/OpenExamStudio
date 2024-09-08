using System.Collections.Generic;

namespace OpenExamStudio.Designer
{

    public class MultipleChoiceQuestion : Question
    {
        public int AllowedSelections { get; set; }
        public List<string> AnswerOptions { get; set; }
        public string CorrectAnswer { get; set; }

        public MultipleChoiceQuestion(int id, string text, int points, List<string> answerOptions, string correctAnswer, string title, int allowedSelections)
            : base(id, text, points, "multiple-choice", title)
        {
            AnswerOptions = answerOptions;
            CorrectAnswer = correctAnswer;
            AllowedSelections = allowedSelections;
        }
    }
}