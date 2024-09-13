using DevExpress.XtraNavBar;
using System;
using System.Linq;

namespace OpenExamStudio.Designer
{
    public static class NavBarLinkEventArgsExtensions
    {
        public static dynamic QuestionUIGenerationArgs(this NavBarLinkEventArgs e, Exam exam)
        {
            string[] nameParts = e.Link.ItemName.Split('|');
            int sectionId = int.Parse(nameParts[0]);
            int questionId = int.Parse(nameParts[1]);

            QuestionUIGenerationArgs args = new QuestionUIGenerationArgs();
            args.SectionId = sectionId;
            args.QuestionId = questionId;
            args.Question = exam.Sections[sectionId - 1].Questions[questionId - 1];
            args.IsDesignTime = true;
            return args;
        }

    }
}