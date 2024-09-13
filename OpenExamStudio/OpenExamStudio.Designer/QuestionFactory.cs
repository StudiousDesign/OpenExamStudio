using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace OpenExamStudio.Designer
{
    public static class QuestionFactory
    {
        public static Question CreateQuestion(QuestionUIGenerationArgs generationArgs)
        {
            string type = generationArgs.Question.Type;

            switch (type)
            {
                case "multiple-choice":
                    return new MultipleChoiceQuestion(
                        generationArgs.SectionId,
                        generationArgs.QuestionId,
                        generationArgs.Question.Text,
                        generationArgs.Question.Points,
                        JsonConvert.DeserializeObject<List<MultipleChoiceAnswerOption>>(JsonConvert.SerializeObject(generationArgs.Question.AnswerOptions)),
                        generationArgs.Question.CorrectAnswer,
                        generationArgs.Question.Title,
                        generationArgs.Question.AllowedSelections
                    );
                // Handle other cases similarly...
                default:
                    throw new InvalidOperationException($"Unknown question type: {type}");
            }
        }
    }
}