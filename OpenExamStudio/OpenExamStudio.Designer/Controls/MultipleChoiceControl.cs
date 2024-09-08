using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using DevExpress.XtraPrinting.Export;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OpenExamStudio.Designer.Controls
{
    public partial class MultipleChoiceControl : UserControl
    {
        public MultipleChoiceControl(dynamic questionData)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            MultipleChoiceQuestion mcq = QuestionFactory.CreateQuestion(questionData);
            questionMetadataControl1.SetMetadata(mcq.Title, mcq.Points);
            txtQuestionText.Text = mcq.Text;

            AddAnswerOptionsToLayoutControl(mcq.AnswerOptions, mcq.AllowedSelections);
        }

        public void AddAnswerOptionsToLayoutControl(List<string> answerOptions, int allowedSelections)
        {
            Root.BeginUpdate(); // Begin updating to avoid multiple layout recalculations

            // List to store CheckEdit controls for easy management
            List<CheckEdit> checkBoxes = new List<CheckEdit>();

            foreach (var option in answerOptions)
            {
                // Create a new CheckEdit (checkbox) control
                var checkBox = new CheckEdit
                {
                    Text = option, // Set the answer text to the checkbox
                    AutoSize = true, // Automatically size the checkbox to fit the text
                    Margin = new Padding(0)
                };

                // Add CheckedChanged event handler
                checkBox.CheckedChanged += (sender, e) => OnCheckBoxChanged(checkBoxes, allowedSelections);

                // Add the CheckEdit to the LayoutControl
                Root.AddItem("", checkBox).TextVisible = false; // Add checkbox without label

                // Store the checkbox in the list
                checkBoxes.Add(checkBox);
            }

            Root.EndUpdate(); // End updating and apply changes
        }

        // Event handler to enforce the selection limit
        private void OnCheckBoxChanged(List<CheckEdit> checkBoxes, int allowedSelections)
        {
            // Count the number of selected checkboxes
            int selectedCount = checkBoxes.Count(cb => cb.Checked);

            // If the selected count reaches the allowed number, disable remaining unchecked checkboxes
            foreach (var checkBox in checkBoxes)
            {
                if (!checkBox.Checked)
                {
                    checkBox.Enabled = selectedCount < allowedSelections;
                }
            }
        }
    }
}
