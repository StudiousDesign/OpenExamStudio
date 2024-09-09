using System;
using System.Windows.Forms;

namespace OpenExamStudio.Designer.Controls
{
    public class BaseExamQuestionControl : UserControl
    {
        public int SectionId { get; }
        public int QuestionId { get; }

        public event EventHandler<dynamic> OnSave;

        public void RaiseOnSave(dynamic question)
        {
            if (OnSave != null) OnSave(this, question);
        }

        public BaseExamQuestionControl()
        {

        }
        public BaseExamQuestionControl(int sectionId, int questionId)
        {
            SectionId = sectionId;
            QuestionId = questionId;
        }
    }
}
