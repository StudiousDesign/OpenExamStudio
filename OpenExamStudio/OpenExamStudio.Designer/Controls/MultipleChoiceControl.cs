using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using DevExpress.XtraPrinting.Export;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

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

            AddAnswerOptionsToLayoutControlDesignTime(mcq.AnswerOptions);
            // AddAnswerOptionsToLayoutControl(mcq.AnswerOptions, mcq.AllowedSelections); only do this in the exam player
        }

        public void AddAnswerOptionsToLayoutControlExamTime(List<string> answerOptions, int allowedSelections)
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

        public void AddAnswerOptionsToLayoutControlDesignTime(List<string> options)
        {
            Root.BeginUpdate(); // Begin updating to avoid multiple layout recalculations

            // List to store CheckEdit controls for easy management
            List<TextEdit> answerOptions = new List<TextEdit>();

            // Temporarily remove the EmptySpaceItem
            Root.Remove(emptySpaceItem1);
            Root.Remove(lciSaveButton);


            foreach (var option in options)
            {

                // Create a new CheckEdit (checkbox) control
                var textEdit = new TextEdit
                {
                    Text = option, // Set the answer text to the checkbox
                    AutoSize = true, // Automatically size the checkbox to fit the text
                    Margin = new Padding(0)
                };

                LayoutControlItem newItem = new LayoutControlItem
                {
                    Control = textEdit,
                    TextVisible = false // No text label for the layout item
                };



                // Add the CheckEdit to the LayoutControl
                Root.AddItem("", textEdit).TextVisible = false; // Add checkbox without label

                // Store the checkbox in the list
                answerOptions.Add(textEdit);
            }

            // Re-add the EmptySpaceItem after the new controls
            Root.Add(emptySpaceItem1);
            Root.Add(lciSaveButton);


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

        private void btnAddAnswerOption_Click(object sender, EventArgs e)
        {
            Root.BeginUpdate(); // Begin updating to avoid multiple layout recalculations
                                // Temporarily remove the EmptySpaceItem
            Root.Remove(emptySpaceItem1);
            Root.Remove(lciSaveButton);

            TextEdit option = new TextEdit();
            // Add the CheckEdit to the LayoutControl
            Root.AddItem("", option).TextVisible = false; // Add textEdit without label
                                                          // Re-add the EmptySpaceItem after the new controls
            Root.Add(emptySpaceItem1);
            Root.Add(lciSaveButton);

            Root.EndUpdate(); // End updating and apply changes
        }
    }
}
