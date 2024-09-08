using System.Collections.Generic;

namespace OpenExamStudio.Designer
{
    public class Exam
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Duration { get; set; }
        public Metadata Metadata { get; set; }
        public List<Section> Sections { get; set; }
        public GradingSchema GradingSchema { get; set; }
        public Settings Settings { get; set; }
    }


}