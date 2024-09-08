using System.Collections.Generic;
using System;

namespace OpenExamStudio.Designer
{
    public static class QuestionFactory
    {
        public static Question CreateQuestion(dynamic questionData)
        {
            string type = questionData.type;

            switch (type)
            {
                case "multiple-choice":
                    return new MultipleChoiceQuestion(
                        questionData.id,
                        questionData.text,
                        questionData.points,
                        questionData.options.ToObject<List<string>>(),
                        questionData.correctAnswer,
                        questionData.title,
                        questionData.allowedSelections
                    );
                // Handle other cases similarly...
                default:
                    throw new InvalidOperationException($"Unknown question type: {type}");
            }
        }
    }

}