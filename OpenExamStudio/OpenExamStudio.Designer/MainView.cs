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
using System.Windows.Forms;
using OpenExamStudio.Designer.Controls;
using System;
using Newtonsoft.Json.Serialization;

namespace OpenExamStudio.Designer
{
    public partial class MainView : XtraForm
    {
        private string _examPath;
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
                _examPath = xtraOpenFileDialog1.FileName;

                ReloadExam();
            }
        }

        private void AddToNavigation(List<Section> sections)
        {
            navBarControl1.Groups.Clear();

            foreach (Section section in sections)
            {
                NavBarGroup group = new NavBarGroup();
                group.Name = section.SectionId.ToString();
                group.Caption = section.Title;
                group.Expanded = true;

                foreach (dynamic question in section.Questions)
                {
                    NavBarItem item = new NavBarItem();
                    item.Caption = $"{question.questionId} - {question.type}";
                    item.Name = $"{section.SectionId}|{question.questionId}";

                    navBarControl1.Items.Add(item);
                    group.ItemLinks.Add(item);
                }

                navBarControl1.Groups.Add(group);
            }
        }

        private void navBarControl1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            QuestionUIGenerationArgs questionUIGenerationArgs = e.QuestionUIGenerationArgs(_examData);
            BaseExamQuestionControl control = UIFactory.GetQuestionControl(questionUIGenerationArgs);
            control.OnSave += Question_onSave;
            pnlQuestion.Controls.Add(control);
        }

        private void Question_onSave(object sender, dynamic question)
        {
            var section = _examData.Sections.First(s => s.SectionId == question.SectionId);
            var index = section.Questions.FindIndex(q => q.questionId == question.QuestionId);
            if (index != -1)
            {
                section.Questions[index] = question;

                var settings = new JsonSerializerSettings
                {
                    ContractResolver = new DefaultContractResolver
                    {
                        NamingStrategy = new CamelCaseNamingStrategy
                        {
                            ProcessDictionaryKeys = true,
                            OverrideSpecifiedNames = true
                        }
                    }
                };

                // Specify the Formatting.Indented along with the settings
                File.WriteAllText(_examPath, JsonConvert.SerializeObject(_examData, Formatting.Indented, settings));
                ReloadExam();
            }
        }

        private void ReloadExam()
        {
            _examData = JsonConvert.DeserializeObject<Exam>(File.ReadAllText(_examPath));
            lciExamMetadata.Visibility = LayoutVisibility.Always;

            txtExamTitle.Bind(_examData, "Title");
            txtExamDescription.Bind(_examData, "Description");
            txtExamAuthor.Bind(_examData, "Metadata.CreatedBy");
            spinEditExamDuration.Bind(_examData, "Duration");

            AddToNavigation(_examData.Sections);
        }
    }
}