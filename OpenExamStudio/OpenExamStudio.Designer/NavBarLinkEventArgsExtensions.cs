using DevExpress.XtraNavBar;
using System.Linq;

namespace OpenExamStudio.Designer
{
    public static class NavBarLinkEventArgsExtensions
    {
        public static dynamic GetDynamicQuestion(this NavBarLinkEventArgs e, Exam exam)
        {
            string[] nameParts = e.Link.ItemName.Split('|');
            int sectionId = int.Parse(nameParts[0]) -1;
            int questionId = int.Parse(nameParts[1]) -1;

            return exam.Sections[sectionId].Questions[questionId];
        }
    }
}