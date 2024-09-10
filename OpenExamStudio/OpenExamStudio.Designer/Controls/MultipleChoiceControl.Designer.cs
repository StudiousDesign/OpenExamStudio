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
            this.gridControlAnswers = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcAnswerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDisplayText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcExplanation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcIsCorrect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDelete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.btnSaveQuestion = new DevExpress.XtraEditors.SimpleButton();
            this.spinEditAllowedSelections = new DevExpress.XtraEditors.SpinEdit();
            this.btnAddAnswerOption = new DevExpress.XtraEditors.SimpleButton();
            this.txtQuestionText = new DevExpress.XtraEditors.MemoEdit();
            this.questionMetadataControl1 = new OpenExamStudio.Designer.Controls.QuestionMetadataControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciQuestionMetadata = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciQuestionText = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAllowedSelections = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSaveButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAnswers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAllowedSelections.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestionText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionMetadata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAllowedSelections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlAnswers);
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
            // gridControlAnswers
            // 
            this.gridControlAnswers.Location = new System.Drawing.Point(16, 267);
            this.gridControlAnswers.MainView = this.gridView1;
            this.gridControlAnswers.Name = "gridControlAnswers";
            this.gridControlAnswers.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemCheckEdit1});
            this.gridControlAnswers.Size = new System.Drawing.Size(1286, 571);
            this.gridControlAnswers.TabIndex = 9;
            this.gridControlAnswers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcAnswerId,
            this.gcDisplayText,
            this.gcExplanation,
            this.gcIsCorrect,
            this.gcDelete});
            this.gridView1.GridControl = this.gridControlAnswers;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            // 
            // gcAnswerId
            // 
            this.gcAnswerId.AppearanceHeader.Options.UseTextOptions = true;
            this.gcAnswerId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcAnswerId.Caption = "Id";
            this.gcAnswerId.FieldName = "AnswerId";
            this.gcAnswerId.Name = "gcAnswerId";
            this.gcAnswerId.OptionsColumn.AllowEdit = false;
            this.gcAnswerId.Visible = true;
            this.gcAnswerId.VisibleIndex = 0;
            this.gcAnswerId.Width = 60;
            // 
            // gcDisplayText
            // 
            this.gcDisplayText.AppearanceHeader.Options.UseTextOptions = true;
            this.gcDisplayText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcDisplayText.Caption = "Display Text";
            this.gcDisplayText.FieldName = "DisplayText";
            this.gcDisplayText.Name = "gcDisplayText";
            this.gcDisplayText.Visible = true;
            this.gcDisplayText.VisibleIndex = 1;
            this.gcDisplayText.Width = 350;
            // 
            // gcExplanation
            // 
            this.gcExplanation.AppearanceHeader.Options.UseTextOptions = true;
            this.gcExplanation.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcExplanation.Caption = "Explanation";
            this.gcExplanation.FieldName = "Explanation";
            this.gcExplanation.Name = "gcExplanation";
            this.gcExplanation.Visible = true;
            this.gcExplanation.VisibleIndex = 2;
            this.gcExplanation.Width = 754;
            // 
            // gcIsCorrect
            // 
            this.gcIsCorrect.AppearanceHeader.Options.UseTextOptions = true;
            this.gcIsCorrect.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcIsCorrect.Caption = "Correct";
            this.gcIsCorrect.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gcIsCorrect.FieldName = "IsCorrect";
            this.gcIsCorrect.Name = "gcIsCorrect";
            this.gcIsCorrect.Visible = true;
            this.gcIsCorrect.VisibleIndex = 3;
            this.gcIsCorrect.Width = 60;
            // 
            // gcDelete
            // 
            this.gcDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.gcDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gcDelete.ColumnEdit = this.repositoryItemButtonEdit1;
            this.gcDelete.FieldName = "gcDelete";
            this.gcDelete.Name = "gcDelete";
            this.gcDelete.OptionsColumn.ShowCaption = false;
            this.gcDelete.UnboundDataType = typeof(object);
            this.gcDelete.Visible = true;
            this.gcDelete.VisibleIndex = 4;
            this.gcDelete.Width = 60;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.DeleteRow_ButtonClick);
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
            this.spinEditAllowedSelections.Location = new System.Drawing.Point(1042, 214);
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
            this.spinEditAllowedSelections.Size = new System.Drawing.Size(130, 28);
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
            this.lciQuestionText,
            this.layoutControlItem1,
            this.lciAllowedSelections,
            this.lciSaveButton,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.emptySpaceItem1});
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
            this.lciAllowedSelections.Location = new System.Drawing.Point(922, 198);
            this.lciAllowedSelections.MaxSize = new System.Drawing.Size(240, 34);
            this.lciAllowedSelections.MinSize = new System.Drawing.Size(240, 34);
            this.lciAllowedSelections.Name = "lciAllowedSelections";
            this.lciAllowedSelections.Size = new System.Drawing.Size(240, 34);
            this.lciAllowedSelections.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
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
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlAnswers;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 232);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1292, 596);
            this.layoutControlItem2.Text = "Answer Options";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(88, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 198);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(922, 34);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.repositoryItemCheckEdit1_EditValueChanging);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAnswers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAllowedSelections.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestionText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionMetadata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAllowedSelections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSaveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private QuestionMetadataControl questionMetadataControl1;
        private DevExpress.XtraLayout.LayoutControlItem lciQuestionMetadata;
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
        private DevExpress.XtraGrid.GridControl gridControlAnswers;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn gcAnswerId;
        private DevExpress.XtraGrid.Columns.GridColumn gcDisplayText;
        private DevExpress.XtraGrid.Columns.GridColumn gcExplanation;
        private DevExpress.XtraGrid.Columns.GridColumn gcIsCorrect;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcDelete;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}
