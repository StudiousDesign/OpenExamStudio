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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.txtQuestionText = new DevExpress.XtraEditors.MemoEdit();
            this.lciQuestionText = new DevExpress.XtraLayout.LayoutControlItem();
            this.questionMetadataControl1 = new OpenExamStudio.Designer.Controls.QuestionMetadataControl();
            this.lciQuestionMetadata = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestionText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionMetadata)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtQuestionText);
            this.layoutControl1.Controls.Add(this.questionMetadataControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1469, 888);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciQuestionMetadata,
            this.emptySpaceItem1,
            this.lciQuestionText});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1475, 871);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 255);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1449, 590);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // txtQuestionText
            // 
            this.txtQuestionText.Location = new System.Drawing.Point(104, 82);
            this.txtQuestionText.Name = "txtQuestionText";
            this.txtQuestionText.Size = new System.Drawing.Size(1355, 183);
            this.txtQuestionText.StyleController = this.layoutControl1;
            this.txtQuestionText.TabIndex = 5;
            // 
            // lciQuestionText
            // 
            this.lciQuestionText.Control = this.txtQuestionText;
            this.lciQuestionText.Location = new System.Drawing.Point(0, 66);
            this.lciQuestionText.Name = "lciQuestionText";
            this.lciQuestionText.Size = new System.Drawing.Size(1449, 189);
            this.lciQuestionText.Text = "Question Text:";
            this.lciQuestionText.TextSize = new System.Drawing.Size(72, 13);
            // 
            // questionMetadataControl1
            // 
            this.questionMetadataControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.questionMetadataControl1.Location = new System.Drawing.Point(16, 16);
            this.questionMetadataControl1.MaximumSize = new System.Drawing.Size(1443, 60);
            this.questionMetadataControl1.MinimumSize = new System.Drawing.Size(1443, 60);
            this.questionMetadataControl1.Name = "questionMetadataControl1";
            this.questionMetadataControl1.Size = new System.Drawing.Size(1443, 60);
            this.questionMetadataControl1.TabIndex = 4;
            // 
            // lciQuestionMetadata
            // 
            this.lciQuestionMetadata.Control = this.questionMetadataControl1;
            this.lciQuestionMetadata.Location = new System.Drawing.Point(0, 0);
            this.lciQuestionMetadata.Name = "lciQuestionMetadata";
            this.lciQuestionMetadata.Size = new System.Drawing.Size(1449, 66);
            this.lciQuestionMetadata.Text = "Question Metadata:";
            this.lciQuestionMetadata.TextSize = new System.Drawing.Size(0, 0);
            this.lciQuestionMetadata.TextVisible = false;
            // 
            // MultipleChoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.layoutControl1);
            this.Name = "MultipleChoiceControl";
            this.Size = new System.Drawing.Size(1469, 888);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestionText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionMetadata)).EndInit();
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
    }
}
