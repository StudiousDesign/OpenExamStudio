using System.Windows.Forms;

namespace OpenExamStudio.Designer
{
    public static class DataBindingExtension
    {
        public static void Bind(this Control control, object dataDource, string propertyName)
        {
            control.DataBindings.Add("EditValue", dataDource, propertyName, true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}