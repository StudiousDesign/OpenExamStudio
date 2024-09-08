using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OpenExamStudio.Designer.Controls
{
    public partial class QuestionMetadataControl : UserControl
    {
        public QuestionMetadataControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        internal void SetMetadata(string title, int points)
        {
            spinEdit1.Value = points;
            txtQuestionName.Text = title;
        }
    }
}
