using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
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
using System.ComponentModel;

namespace OpenExamStudio.Designer.Controls
{
    public partial class OrderByControl : BaseExamQuestionControl
    {
        private OrderByQuestion _orderByQuestion;
        //private List<CheckEdit> checkBoxes = new List<CheckEdit>();
        //private List<TextEdit> answerOptions = new List<TextEdit>();

        public OrderByControl(QuestionUIGenerationArgs args)
            : base(args.SectionId, args.QuestionId)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;

            _orderByQuestion = (OrderByQuestion)QuestionFactory.CreateQuestion(args);
            questionMetadataControl1.SetMetadata(_orderByQuestion.Title, _orderByQuestion.Points);
            txtQuestionText.Text = _orderByQuestion.Text;

            gridControlAnswers.DataSource = _orderByQuestion.AnswerOptions;

        }
        private void RemoveTemporaryItems()
        {
            // Root.Remove(emptySpaceItem1);
            Root.Remove(lciSaveButton);
        }

        private void ReAddTemporaryItems()
        {
            // Root.Add(emptySpaceItem1);
            Root.Add(lciSaveButton);
        }


        private void btnAddAnswerOption_Click(object sender, EventArgs e)
        {
            gridControlAnswers.BeginUpdate();
            _orderByQuestion.AnswerOptions.Add(new OrderByAnswerOption() { AnswerId = _orderByQuestion.AnswerOptions.Count + 1 });
            gridControlAnswers.DataSource = _orderByQuestion.AnswerOptions;
            gridControlAnswers.EndUpdate();
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            OrderByQuestion question = new OrderByQuestion(base.SectionId, base.QuestionId, txtQuestionText.Text,
                 questionMetadataControl1.Points,
                _orderByQuestion.AnswerOptions,
                questionMetadataControl1.QuestionName);

            base.RaiseOnSave(question);
        }


        private void DeleteRow_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            gridControlAnswers.BeginUpdate();
            // Get the selected row handle
            int rowHandle = gridView1.FocusedRowHandle;

            // Check if the row handle is valid
            if (rowHandle >= 0)
            {
                // Remove the row
                gridView1.DeleteRow(rowHandle);
            }
            gridControlAnswers.EndUpdate();

        }

        
    }
}
