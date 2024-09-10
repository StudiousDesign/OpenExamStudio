using DevExpress.Utils.Behaviors.Common;
using DevExpress.Utils;
using DevExpress.Utils.Behaviors;
using DevExpress.XtraEditors;

namespace OpenExamStudio.Designer
{
    public class PersistenceManager
    {
        public PersistenceManager(XtraForm form, BehaviorManager behaviorManager)
        {
            behaviorManager.Attach<PersistenceBehavior>(form, behavior =>
            {
                behavior.Properties.StoreChildLayouts = DefaultBoolean.True;
                behavior.Properties.Storage = Storage.File;
                behavior.Properties.Path = "openexamstudio-designer-layout.xml";
            });
        }
    }
}