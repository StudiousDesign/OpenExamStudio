using DevExpress.XtraNavBar;
using System;
using static System.Collections.Specialized.BitVector32;

namespace OpenExamStudio.Designer
{
    public class NavigationBarService
    {
        private NavLinkStyler _navLinkStyler;
        private readonly NavBarControl _navBar;

        public NavigationBarService(NavBarControl navBar)
        {
            _navBar = navBar;
            _navLinkStyler = new NavLinkStyler(navBar);
        }

        public void RebuildNavigation(Exam exam)
        {
            _navBar.Groups.Clear();

            foreach (Section section in exam.Sections)
            {
                NavBarGroup group = new NavBarGroup();
                group.Name = section.SectionId.ToString();
                group.Caption = section.Title;
                group.Expanded = true;

                foreach (Question question in section.Questions)
                {
                    NavBarItem item = new NavBarItem();
                    item.Caption = $"{question.QuestionId} - {question.Type}";
                    item.Name = $"{section.SectionId}|{question.QuestionId}";

                    _navBar.Items.Add(item);
                    group.ItemLinks.Add(item);
                }

                _navBar.Groups.Add(group);
            }
        }


        public void StyleNavLink(NavBarItemLink link)
        {
            _navLinkStyler.StyleNavLink(link);
        }

        internal void Clear()
        {
            _navBar.Groups.Clear();
        }
    }
}