using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using System;

namespace OpenExamStudio.Designer
{
    public class FileHelper
    {
        public event EventHandler<Exam> ActiveExamChanged;
        private readonly Control _owner;
        private string _path;
        private Exam _examData;

        public FileHelper(Control owner)
        {
            _owner = owner;
        }

        public void Load()
        {
            using (XtraOpenFileDialog dlg = new XtraOpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json",
                DefaultExt = "json"
            })
            {
                if (dlg.ShowDialog(_owner) == DialogResult.OK)
                {
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


                    _path = dlg.FileName;
                    _examData = JsonConvert.DeserializeObject<Exam>(File.ReadAllText(_path), settings);
                    RaiseActiveExamChanged(_examData);
                }
            }
        }

        public void Save(dynamic question, string path = "")
        {
            var section = _examData.Sections.First(s => s.SectionId == question.SectionId);
            var index = section.Questions.FindIndex(q => q.questionId == question.QuestionId);
            if (index != -1)
            {
                section.Questions[index] = question;
                SaveToFile(!string.IsNullOrWhiteSpace(path) ? path : _path);
            }
        }

        public void SaveAs(string filename = "")
        {
            using (XtraSaveFileDialog dlg = new XtraSaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json",
                DefaultExt = "json",
                FileName = !string.IsNullOrWhiteSpace(filename) ? filename : string.Empty,
            })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _path = dlg.FileName;
                    SaveToFile(_path);
                }
            }
        }

        public void SaveGeneratedExam(Exam exam)
        {
            _examData = exam;
            SaveAs(_examData.Title);
        }

        private void SaveToFile(string path)
        {
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

            string fileContents = JsonConvert.SerializeObject(_examData, Formatting.Indented, settings);
            File.WriteAllText(path, fileContents);
            _examData = JsonConvert.DeserializeObject<Exam>(File.ReadAllText(path), settings);
            RaiseActiveExamChanged(_examData);
        }

        private void RaiseActiveExamChanged(Exam exam)
        {
            ActiveExamChanged?.Invoke(this, exam);
        }
    }
}
