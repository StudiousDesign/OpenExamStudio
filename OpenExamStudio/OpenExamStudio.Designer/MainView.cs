using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraNavBar;
using OpenExamStudio.Designer.Controls;

namespace OpenExamStudio.Designer
{
    public partial class MainView : XtraForm
    {
        private NavigationBarService _navigationBarService;
        private FileHelper _fileHelper;
        private PersistenceManager _persistenceManager;
        private Exam _currentExam;

        public MainView()
        {
            InitializeComponent();
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

        private void OnSaveQuestion(object sender, dynamic question)
        {
            _fileHelper.Save(question);
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
        private void btnGenerateExam_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}