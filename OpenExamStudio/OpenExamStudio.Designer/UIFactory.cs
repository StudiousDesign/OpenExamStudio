using OpenExamStudio.Designer.Controls;
using System;
using System.Windows.Forms;

namespace OpenExamStudio.Designer
{
    public static class UIFactory
    {
        public static BaseExamQuestionControl GetQuestionControl(QuestionUIGenerationArgs args)
        {
            string type = args.Question.type;
            switch (type)
            {
                case "multiple-choice":
                    return new MultipleChoiceControl(args);
                // Handle other cases similarly...
                default:
                    throw new InvalidOperationException($"Unknown question type: {type}");
            }
        }
    }
}