using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraNavBar;
using Newtonsoft.Json;
using OpenExamStudio.Designer.Controls;
using System.Linq;
using System.Windows.Forms;

namespace OpenExamStudio.Designer
{
    public partial class MainView : XtraForm
    {
        private ExamElementGeneratorFactory _examElementGeneratorFactory;
        private NavigationBarService _navigationBarService;
        private FileHelper _fileHelper;
        private PersistenceManager _persistenceManager;
        private Exam _currentExam;

        public MainView()
        {
            InitializeComponent();
            _examElementGeneratorFactory = new ExamElementGeneratorFactory();
            _persistenceManager = new PersistenceManager(this, behaviorManager1);
            _navigationBarService = new NavigationBarService(navBarControl1);
            _fileHelper = new FileHelper(this);
            _fileHelper.ActiveExamChanged += OnActiveExamChanged;
        }

        private void navBarControl1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            pnlQuestion.Controls.Clear();
            _navigationBarService.StyleNavLink(e.Link);
            BaseExamQuestionControl control = UIFactory.GetQuestionControl(e, _currentExam);
            control.OnSaveQuestion += OnSaveQuestion;
            pnlQuestion.Controls.Add(control);
        }

        private void OnLoadButtonClicked(object sender, ItemClickEventArgs e)
        {
            _fileHelper.Load();
        }

        private void btnSaveAs_ItemClick(object sender, ItemClickEventArgs e)
        {
            _fileHelper.SaveAs();
        }

        private void OnSaveQuestion(object sender, Question question)
        {
            _fileHelper.Save(question);
        }

        private void ClearUI()
        {
            pnlQuestion.Controls.Clear();
            _navigationBarService.Clear();
            lciExamMetadata.Visibility = LayoutVisibility.Never;
        }

        private void OnActiveExamChanged(object sender, Exam exam)
        {
            _currentExam = exam;
            lciExamMetadata.Visibility = LayoutVisibility.Always;
            txtExamTitle.Bind(exam, "Title");
            txtExamDescription.Bind(exam, "Description");
            txtExamAuthor.Bind(exam, "Metadata.CreatedBy");
            spinEditExamDuration.Bind(exam, "Duration");
            _navigationBarService.RebuildNavigation(exam);
        }
        private async void btnGenerateExam_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClearUI();
            var generator = _examElementGeneratorFactory.GetExamElementGenerator();
            var result = await generator.GenerateExamAsync();
            Exam exam = JsonConvert.DeserializeObject<Exam>(result);
            _fileHelper.SaveGeneratedExam(exam);
        }

        private void navBarControl1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Check if the right mouse button is clicked
            if (e.Button == MouseButtons.Right)
            {
                // Get the NavBarGroup under the mouse cursor
                NavBarHitInfo hitInfo = navBarControl1.CalcHitInfo(e.Location);
                if (hitInfo.InGroupCaption)
                {
                    _currentSelctedSection = hitInfo.Group.Caption;
                    popupMenu1.ShowPopup(Control.MousePosition);
                }
                else if (hitInfo.InLink)
                {
                    _currentSelctedSection = hitInfo.Link.Caption;
                    _selectedLinkInfo = hitInfo.Link.ItemName;
                    popupMenu1.ShowPopup(Control.MousePosition);
                }
            }
        }

        private string _currentSelctedSection = "";
        private string _selectedLinkInfo = "";
        private async void PopupMenuItemClicked(object sender, ItemClickEventArgs e)
        {
            if (e.Item.Equals(bbiGenQuestion))
            {
                var generator = _examElementGeneratorFactory.GetExamElementGenerator();
                var result = await generator.GenerateExamQuestionAsync(_currentExam.Title, _currentExam.Sections.First(s => s.Title == _currentSelctedSection));
                Question question = JsonConvert.DeserializeObject<Question>(result);
                OnSaveQuestion(this, question);
            }
            else if (e.Item.Equals(bbiDeleteQuestion))
            {
                _fileHelper.DeleteQuestion(_selectedLinkInfo);
            }
        }
    }
}