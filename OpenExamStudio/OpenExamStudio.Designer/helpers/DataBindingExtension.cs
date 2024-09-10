using System.Windows.Forms;

namespace OpenExamStudio.Designer
{
    public static class DataBindingExtension
    {
        public static void Bind(this Control control, object dataDource, string propertyName)
        {
            // Check if a binding exists for "EditValue" and remove it
            foreach (Binding binding in control.DataBindings)
            {
                if (binding.PropertyName == "EditValue")
                {
                    control.DataBindings.Remove(binding);
                    break;
                }
            }
            control.DataBindings.Add("EditValue", dataDource, propertyName, true, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}