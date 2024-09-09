using System.Collections.Generic;
using System;

namespace OpenExamStudio.Designer
{
    public static class QuestionFactory
    {
        public static Question CreateQuestion(QuestionUIGenerationArgs generationArgs)
        {
            string type = generationArgs.Question.type;

            switch (type)
            {
                case "multiple-choice":
                    return new MultipleChoiceQuestion(
                        generationArgs.SectionId,
                        generationArgs.QuestionId,
                        generationArgs.Question.text,
                        generationArgs.Question.points,
                        generationArgs.Question.answerOptions.ToObject<List<MultipleChoiceAnswerOption>>(),
                        generationArgs.Question.correctAnswer,
                        generationArgs.Question.title,
                        generationArgs.Question.allowedSelections
                    );
                // Handle other cases similarly...
                default:
                    throw new InvalidOperationException($"Unknown question type: {type}");
            }
        }
    }
}