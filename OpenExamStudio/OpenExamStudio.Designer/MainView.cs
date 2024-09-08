using DevExpress.Utils.Behaviors.Common;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System.IO;
using DevExpress.XtraLayout.Utils;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraNavBar;
using DevExpress.Mvvm.Native;

namespace OpenExamStudio.Designer
{
    public partial class MainView : XtraForm
    {
        private Exam _examData;
        public MainView()
        {
            InitializeComponent();
            // EnableUIPersistence();
        }

        private void EnableUIPersistence()
        {
            behaviorManager1.Attach<PersistenceBehavior>(this, behavior =>
            {
                behavior.Properties.StoreChildLayouts = DefaultBoolean.True;
                behavior.Properties.Storage = Storage.File;
                behavior.Properties.Path = "openexamstudio-designer-layout.xml";
            });
        }

        private void btnLoadExam_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (xtraOpenFileDialog1.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                _examData = JsonConvert.DeserializeObject<Exam>(File.ReadAllText(xtraOpenFileDialog1.FileName));
                lciExamMetadata.Visibility = LayoutVisibility.Always;

                txtExamTitle.Bind(_examData, "Title");
                txtExamDescription.Bind(_examData, "Description");
                txtExamAuthor.Bind(_examData, "Metadata.CreatedBy");
                spinEditExamDuration.Bind(_examData, "Duration");

                AddToNavigation(_examData.Sections);
            }
        }

        private void AddToNavigation(List<Section> sections)
        {
            foreach (Section section in sections)
            {
                NavBarGroup group = new NavBarGroup();
                group.Name = section.Id.ToString();
                group.Caption = section.Title;
                group.Expanded = true;

                foreach (dynamic question in section.Questions)
                {
                    NavBarItem item = new NavBarItem();
                    item.Caption = $"{question.id} - {question.type}";
                    item.Name = $"{section.Id}|{question.id}";

                    navBarControl1.Items.Add(item);
                    group.ItemLinks.Add(item);
                }

                navBarControl1.Groups.Add(group);
            }
        }

        private void navBarControl1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            dynamic question = e.GetDynamicQuestion(_examData);
            pnlQuestion.Controls.Add(UIFactory.GetQuestionControl(question));
        }
    }
}