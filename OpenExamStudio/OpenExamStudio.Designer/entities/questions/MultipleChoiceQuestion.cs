using System.Collections.Generic;

namespace OpenExamStudio.Designer
{

    public class MultipleChoiceQuestion : Question
    {
        public int AllowedSelections { get; set; }
        public List<MultipleChoiceAnswerOption> AnswerOptions { get; set; }
        public string CorrectAnswer { get; set; }

        public MultipleChoiceQuestion(int sectionId, int questionId, string text, int points, List<MultipleChoiceAnswerOption> answerOptions, string correctAnswer, string title, int allowedSelections)
            : base(sectionId, questionId, text, points, "multiple-choice", title, correctAnswer, allowedSelections)
        {
            AnswerOptions = answerOptions;
            CorrectAnswer = correctAnswer;
            AllowedSelections = allowedSelections;
        }
    }
}