using DevExpress.Utils.Behaviors.Common;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System.IO;

namespace OpenExamStudio.Designer
{
    public partial class MainView : XtraForm
    {
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
                dynamic exam = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(xtraOpenFileDialog1.FileName));
            }
        }
    }
}