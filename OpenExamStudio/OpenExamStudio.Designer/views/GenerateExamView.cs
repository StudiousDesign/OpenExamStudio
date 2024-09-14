using DevExpress.XtraEditors;

namespace OpenExamStudio.Designer.views
{
    public partial class GenerateExamView : XtraForm
    {
        public ExamGenerationArgs ExamGenerationArgs
        {
            get
            {
                return new ExamGenerationArgs()
                {
                    Title = txtTitle.Text,
                    SectionCount = (int)spinEditSectionCount.Value,
                    QuestionPerSectionCount = (int)spinEditQuestionPerSection.Value
                };
            }
        }

        public GenerateExamView()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}