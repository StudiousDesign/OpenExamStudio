namespace OpenExamStudio.Designer.Controls
{
    partial class MultipleChoiceControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSaveQuestion = new DevExpress.XtraEditors.SimpleButton();
            this.spinEditAllowedSelections = new DevExpress.XtraEditors.SpinEdit();
            this.btnAddAnswerOption = new DevExpress.XtraEditors.SimpleButton();
            this.txtQuestionText = new DevExpress.XtraEditors.MemoEdit();
            this.questionMetadataControl1 = new OpenExamStudio.Designer.Controls.QuestionMetadataControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciQuestionMetadata = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciQuestionText = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAllowedSelections = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSaveButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAllowedSelections.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestionText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionMetadata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAllowedSelections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSaveQuestion);
            this.layoutControl1.Controls.Add(this.spinEditAllowedSelections);
            this.layoutControl1.Controls.Add(this.btnAddAnswerOption);
            this.layoutControl1.Controls.Add(this.txtQuestionText);
            this.layoutControl1.Controls.Add(this.questionMetadataControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1318, 888);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.Location = new System.Drawing.Point(1178, 844);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Size = new System.Drawing.Size(124, 28);
            this.btnSaveQuestion.StyleController = this.layoutControl1;
            this.btnSaveQuestion.TabIndex = 8;
            this.btnSaveQuestion.Text = "&Save";
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);
            // 
            // spinEditAllowedSelections
            // 
            this.spinEditAllowedSelections.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditAllowedSelections.Location = new System.Drawing.Point(120, 214);
            this.spinEditAllowedSelections.Name = "spinEditAllowedSelections";
            this.spinEditAllowedSelections.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditAllowedSelections.Properties.IsFloatValue = false;
            this.spinEditAllowedSelections.Properties.MaskSettings.Set("mask", "N00");
            this.spinEditAllowedSelections.Properties.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.spinEditAllowedSelections.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditAllowedSelections.Size = new System.Drawing.Size(1052, 28);
            this.spinEditAllowedSelections.StyleController = this.layoutControl1;
            this.spinEditAllowedSelections.TabIndex = 7;
            this.spinEditAllowedSelections.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.spinEditAllowedSelections_EditValueChanging);
            // 
            // btnAddAnswerOption
            // 
            this.btnAddAnswerOption.Location = new System.Drawing.Point(1178, 214);
            this.btnAddAnswerOption.Name = "btnAddAnswerOption";
            this.btnAddAnswerOption.Size = new System.Drawing.Size(124, 28);
            this.btnAddAnswerOption.StyleController = this.layoutControl1;
            this.btnAddAnswerOption.TabIndex = 6;
            this.btnAddAnswerOption.Text = "&Add Answer Option";
            this.btnAddAnswerOption.Click += new System.EventHandler(this.btnAddAnswerOption_Click);
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.Location = new System.Drawing.Point(16, 122);
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.Size = new System.Drawing.Size(1286, 86);
            this.txtQuestionText.StyleController = this.layoutControl1;
            this.txtQuestionText.TabIndex = 5;
            // 
            // questionMetadataControl1
            // 
            this.questionMetadataControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.questionMetadataControl1.Location = new System.Drawing.Point(16, 16);
            this.questionMetadataControl1.MyProperty = null;
            this.questionMetadataControl1.Name = "questionMetadataControl1";
            this.questionMetadataControl1.Points = 0;
            this.questionMetadataControl1.QuestionName = "";
            this.questionMetadataControl1.Size = new System.Drawing.Size(1286, 81);
            this.questionMetadataControl1.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciQuestionMetadata,
            this.emptySpaceItem1,
            this.lciQuestionText,
            this.layoutControlItem1,
            this.lciAllowedSelections,
            this.lciSaveButton,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1318, 888);
            this.Root.TextVisible = false;
            // 
            // lciQuestionMetadata
            // 
            this.lciQuestionMetadata.Control = this.questionMetadataControl1;
            this.lciQuestionMetadata.Location = new System.Drawing.Point(0, 0);
            this.lciQuestionMetadata.MaxSize = new System.Drawing.Size(0, 87);
            this.lciQuestionMetadata.MinSize = new System.Drawing.Size(106, 87);
            this.lciQuestionMetadata.Name = "lciQuestionMetadata";
            this.lciQuestionMetadata.Size = new System.Drawing.Size(1292, 87);
            this.lciQuestionMetadata.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciQuestionMetadata.Text = "Question Metadata:";
            this.lciQuestionMetadata.TextSize = new System.Drawing.Size(0, 0);
            this.lciQuestionMetadata.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 232);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1292, 596);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciQuestionText
            // 
            this.lciQuestionText.Control = this.txtQuestionText;
            this.lciQuestionText.Location = new System.Drawing.Point(0, 87);
            this.lciQuestionText.MaxSize = new System.Drawing.Size(0, 111);
            this.lciQuestionText.MinSize = new System.Drawing.Size(94, 111);
            this.lciQuestionText.Name = "lciQuestionText";
            this.lciQuestionText.Size = new System.Drawing.Size(1292, 111);
            this.lciQuestionText.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciQuestionText.Text = "Question Text:";
            this.lciQuestionText.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciQuestionText.TextSize = new System.Drawing.Size(88, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAddAnswerOption;
            this.layoutControlItem1.Location = new System.Drawing.Point(1162, 198);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(130, 34);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(130, 34);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(130, 34);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lciAllowedSelections
            // 
            this.lciAllowedSelections.Control = this.spinEditAllowedSelections;
            this.lciAllowedSelections.Location = new System.Drawing.Point(0, 198);
            this.lciAllowedSelections.Name = "lciAllowedSelections";
            this.lciAllowedSelections.Size = new System.Drawing.Size(1162, 34);
            this.lciAllowedSelections.Text = "Allowed Selections";
            this.lciAllowedSelections.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciAllowedSelections.TextSize = new System.Drawing.Size(88, 13);
            // 
            // lciSaveButton
            // 
            this.lciSaveButton.Control = this.btnSaveQuestion;
            this.lciSaveButton.Location = new System.Drawing.Point(1162, 828);
            this.lciSaveButton.MaxSize = new System.Drawing.Size(130, 34);
            this.lciSaveButton.MinSize = new System.Drawing.Size(130, 34);
            this.lciSaveButton.Name = "lciSaveButton";
            this.lciSaveButton.Size = new System.Drawing.Size(130, 34);
            this.lciSaveButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSaveButton.TextSize = new System.Drawing.Size(0, 0);
            this.lciSaveButton.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 828);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(1162, 34);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // MultipleChoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.layoutControl1);
            this.Name = "MultipleChoiceControl";
            this.Size = new System.Drawing.Size(1318, 888);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAllowedSelections.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestionText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionMetadata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAllowedSelections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private QuestionMetadataControl questionMetadataControl1;
        private DevExpress.XtraLayout.LayoutControlItem lciQuestionMetadata;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.MemoEdit txtQuestionText;
        private DevExpress.XtraLayout.LayoutControlItem lciQuestionText;
        private DevExpress.XtraEditors.SimpleButton btnAddAnswerOption;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SpinEdit spinEditAllowedSelections;
        private DevExpress.XtraLayout.LayoutControlItem lciAllowedSelections;
        private DevExpress.XtraEditors.SimpleButton btnSaveQuestion;
        private DevExpress.XtraLayout.LayoutControlItem lciSaveButton;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
    }
}
