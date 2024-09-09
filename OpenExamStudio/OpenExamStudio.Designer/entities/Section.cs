using System.Collections.Generic;

namespace OpenExamStudio.Designer
{
    public class Section
    {
        public int SectionId { get; set; }
        public string Title { get; set; }
        public List<dynamic> Questions { get; set; }
    }
}