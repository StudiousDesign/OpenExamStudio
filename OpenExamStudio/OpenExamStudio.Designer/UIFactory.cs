using DevExpress.XtraNavBar;
using OpenAI_API.Completions;
using OpenExamStudio.Designer.Controls;
using System;

namespace OpenExamStudio.Designer
{
    public static class UIFactory
    {
        public static BaseExamQuestionControl GetQuestionControl(NavBarLinkEventArgs e, Exam examData)
        {
            var args = e.QuestionUIGenerationArgs(examData);
            string type = args.Question.type;
            switch (type)
            {
                case "multiple-choice":
                    return new MultipleChoiceControl(args);
                default:
                    throw new InvalidOperationException($"Unknown question type: {type}");
            }
        }
    }
}