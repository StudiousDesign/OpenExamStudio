using System;
using System.Windows.Forms;

namespace OpenExamStudio.Designer.Controls
{
    public class BaseExamQuestionControl : UserControl
    {
        public int SectionId { get; }
        public int QuestionId { get; }

        public event EventHandler<Question> OnSaveQuestion;

        public void RaiseOnSave(Question question)
        {
            if (OnSaveQuestion != null) OnSaveQuestion(this, question);
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
