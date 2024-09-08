using OpenExamStudio.Designer.Controls;
using System;
using System.Windows.Forms;

namespace OpenExamStudio.Designer
{
    public static class UIFactory
    {
        public static UserControl GetQuestionControl(dynamic questionData)
        {
            string type = questionData.type;

            switch (type)
            {
                case "multiple-choice":
                    return new MultipleChoiceControl(questionData);
                // Handle other cases similarly...
                default:
                    throw new InvalidOperationException($"Unknown question type: {type}");
            }
        }
    }
}