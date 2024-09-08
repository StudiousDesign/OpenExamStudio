namespace OpenExamStudio.Designer.Controls
{
    partial class QuestionMetadataControl
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
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.txtQuestionName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciQuestionName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciQuestionPoints = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spinEdit1);
            this.layoutControl1.Controls.Add(this.txtQuestionName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1443, 60);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(819, 16);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Size = new System.Drawing.Size(608, 28);
            this.spinEdit1.StyleController = this.layoutControl1;
            this.spinEdit1.TabIndex = 5;
            // 
            // txtQuestionName
            // 
            this.txtQuestionName.Location = new System.Drawing.Point(111, 16);
            this.txtQuestionName.Name = "txtQuestionName";
            this.txtQuestionName.Size = new System.Drawing.Size(607, 28);
            this.txtQuestionName.StyleController = this.layoutControl1;
            this.txtQuestionName.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciQuestionName,
            this.lciQuestionPoints});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1443, 60);
            this.Root.TextVisible = false;
            // 
            // lciQuestionName
            // 
            this.lciQuestionName.Control = this.txtQuestionName;
            this.lciQuestionName.Location = new System.Drawing.Point(0, 0);
            this.lciQuestionName.MaxSize = new System.Drawing.Size(0, 34);
            this.lciQuestionName.MinSize = new System.Drawing.Size(151, 34);
            this.lciQuestionName.Name = "lciQuestionName";
            this.lciQuestionName.Size = new System.Drawing.Size(708, 34);
            this.lciQuestionName.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciQuestionName.Text = "Question Name:";
            this.lciQuestionName.TextSize = new System.Drawing.Size(79, 13);
            // 
            // lciQuestionPoints
            // 
            this.lciQuestionPoints.Control = this.spinEdit1;
            this.lciQuestionPoints.Location = new System.Drawing.Point(708, 0);
            this.lciQuestionPoints.MaxSize = new System.Drawing.Size(0, 34);
            this.lciQuestionPoints.MinSize = new System.Drawing.Size(166, 34);
            this.lciQuestionPoints.Name = "lciQuestionPoints";
            this.lciQuestionPoints.Size = new System.Drawing.Size(709, 34);
            this.lciQuestionPoints.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciQuestionPoints.Text = "Question Points:";
            this.lciQuestionPoints.TextSize = new System.Drawing.Size(79, 13);
            // 
            // QuestionMetadataControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.layoutControl1);
            this.Name = "QuestionMetadataControl";
            this.Size = new System.Drawing.Size(1443, 60);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuestionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciQuestionPoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtQuestionName;
        private DevExpress.XtraLayout.LayoutControlItem lciQuestionName;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraLayout.LayoutControlItem lciQuestionPoints;
    }
}
