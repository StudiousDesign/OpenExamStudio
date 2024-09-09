using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OpenExamStudio.Designer.Controls
{
    public partial class QuestionMetadataControl : UserControl
    {
        public string MyProperty { get; set; }
        public QuestionMetadataControl()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        public int Points { get { return (int)spinEdit1.Value; }  set { spinEdit1.Value = value; } }
        public string QuestionName { get { return txtQuestionName.Text; } set { txtQuestionName.Text = value; } }


        internal void SetMetadata(string title, int points)
        {
            Points = points;
            txtQuestionName.Text = title;
        }

    }
}
