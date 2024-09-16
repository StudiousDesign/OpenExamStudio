using System.Collections.Generic;

namespace OpenExamStudio.Designer
{
    public class OrderByQuestion : Question
    {
        public new List<OrderByAnswerOption> AnswerOptions { get; }

        public OrderByQuestion(int sectionId, int questionId, string text, int points, List<OrderByAnswerOption> answerOptions, string title)
            : base(sectionId, questionId, text, points, "order-by", title)
        {
            AnswerOptions = answerOptions;
        }

    }
}