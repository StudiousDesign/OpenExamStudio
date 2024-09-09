using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Padding = System.Windows.Forms.Padding;
using TextEdit = DevExpress.XtraEditors.TextEdit;

namespace OpenExamStudio.Designer.Controls
{
    public partial class MultipleChoiceControl : BaseExamQuestionControl
    {
        private MultipleChoiceQuestion _multipleChoiceQuestion;
        private List<CheckEdit> checkBoxes = new List<CheckEdit>();
        private List<TextEdit> answerOptions = new List<TextEdit>();

        public MultipleChoiceControl(QuestionUIGenerationArgs args)
            : base(args.SectionId, args.QuestionId)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            _multipleChoiceQuestion = (MultipleChoiceQuestion)QuestionFactory.CreateQuestion(args);
            questionMetadataControl1.SetMetadata(_multipleChoiceQuestion.Title, _multipleChoiceQuestion.Points);
            txtQuestionText.Text = _multipleChoiceQuestion.Text;
            spinEditAllowedSelections.Value = _multipleChoiceQuestion.AllowedSelections;

            CreateControls(_multipleChoiceQuestion.AnswerOptions, args.IsDesignTime);
            // AddAnswerOptionsToLayout(_multipleChoiceQuestion.AnswerOptions, args.IsDesignTime, _multipleChoiceQuestion.AllowedSelections);
        }

        private void CreateControls(List<MultipleChoiceAnswerOption> questionAnswers, bool isDesignTime)
        {
            Root.BeginUpdate();
            RemoveTemporaryItems();
            // Counter for currently selected checkboxes
            int selectedCount = 0;

            foreach (var answer in questionAnswers)
            {
                // Create a new group for each answer
                LayoutControlGroup answerGroup = new LayoutControlGroup
                {
                    GroupStyle = DevExpress.Utils.GroupStyle.Light,
                    LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table, // Set layout mode to table for horizontal alignment
                    Padding = new DevExpress.XtraLayout.Utils.Padding(0), // Remove padding to avoid extra space
                    Spacing = new DevExpress.XtraLayout.Utils.Padding(0), // Remove spacing to avoid extra space
                };

                // Configure table layout to have exactly two columns
                var columnDefinition1 = new ColumnDefinition { SizeType = System.Windows.Forms.SizeType.AutoSize, Width = 0 }; // AutoSize for checkbox
                var columnDefinition2 = new ColumnDefinition { SizeType = System.Windows.Forms.SizeType.Percent, Width = 100 }; // Remaining width for text

                answerGroup.OptionsTableLayoutGroup.ColumnDefinitions.Clear(); // Clear any pre-existing columns
                answerGroup.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new ColumnDefinition[] { columnDefinition1, columnDefinition2 });

                LayoutControlItem lciCheckEdit = new LayoutControlItem
                {
                    TextVisible = false,
                    Padding = new DevExpress.XtraLayout.Utils.Padding(0), // Remove padding for the checkbox item
                    Spacing = new DevExpress.XtraLayout.Utils.Padding(0), // Remove spacing for the checkbox item
                };

                LayoutControlItem lciAnswerDisplay = new LayoutControlItem
                {
                    TextVisible = false,
                    Padding = new DevExpress.XtraLayout.Utils.Padding(0), // Remove padding for the text item
                    Spacing = new DevExpress.XtraLayout.Utils.Padding(0), // Remove spacing for the text item
                };

                // Create a checkbox
                var checkBox = new CheckEdit
                {
                    Text = string.Empty, // No label text
                    AutoSize = true
                };
                checkBoxes.Add(checkBox);

                lciCheckEdit.Control = checkBox;
                lciCheckEdit.OptionsTableLayoutItem.ColumnIndex = 0; // Set the checkbox to the first column

                // Handle the CheckedChanged event
                checkBox.CheckedChanged += (sender, e) =>
                {
                    if (checkBox.Checked)
                    {
                        selectedCount++;
                        if (selectedCount > spinEditAllowedSelections.Value)
                        {
                            checkBox.Checked = false; // Prevent checking if limit exceeded
                        }
                    }
                    else
                    {
                        selectedCount--;
                    }
                };

                // Create either a TextEdit or LabelControl based on isDesignTime
                if (isDesignTime)
                {
                    var textEdit = new TextEdit
                    {
                        Text = answer.DisplayText,
                        Width = 200 // Adjust as needed
                    };
                    lciAnswerDisplay.Control = textEdit;
                }
                else
                {
                    var label = new LabelControl
                    {
                        Text = answer.DisplayText,
                        AutoSizeMode = LabelAutoSizeMode.Default
                    };
                    lciAnswerDisplay.Control = label;
                }

                lciAnswerDisplay.OptionsTableLayoutItem.ColumnIndex = 1; // Set the text edit or label to the second column

                // Add items to the answer group
                answerGroup.AddItem(lciCheckEdit);
                answerGroup.AddItem(lciAnswerDisplay);

                // Add the answer group to the root layout group
                Root.AddItem(answerGroup);
            }
            ReAddTemporaryItems();
            Root.EndUpdate();
        }

        private void RemoveTemporaryItems()
        {
            Root.Remove(emptySpaceItem1);
            Root.Remove(lciSaveButton);
        }

        private void ReAddTemporaryItems()
        {
            Root.Add(emptySpaceItem1);
            Root.Add(lciSaveButton);
        }


        private void btnAddAnswerOption_Click(object sender, EventArgs e)
        {
            CreateControls(new List<MultipleChoiceAnswerOption>() { new MultipleChoiceAnswerOption() { DisplayText = "" } }, true);
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            MultipleChoiceQuestion question = new MultipleChoiceQuestion(base.SectionId, base.QuestionId, txtQuestionText.Text,
                 questionMetadataControl1.Points,
                _multipleChoiceQuestion.AnswerOptions,
                _multipleChoiceQuestion.CorrectAnswer,
                questionMetadataControl1.QuestionName,
                (int)spinEditAllowedSelections.Value);

            base.RaiseOnSave(question);
        }

        private void spinEditAllowedSelections_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            int checkedCount = checkBoxes.Count(c => c.Checked);

            if (int.Parse(e.OldValue.ToString()) > int.Parse(e.NewValue.ToString()))
            {
                if (checkedCount > int.Parse(e.NewValue.ToString()))
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
