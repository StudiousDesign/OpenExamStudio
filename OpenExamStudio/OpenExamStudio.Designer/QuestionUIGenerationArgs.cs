﻿namespace OpenExamStudio.Designer
{
    public class QuestionUIGenerationArgs
    {
        public int SectionId { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public bool IsDesignTime { get; set; }
    }
}