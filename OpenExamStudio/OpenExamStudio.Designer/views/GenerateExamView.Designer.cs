namespace OpenExamStudio.Designer.views
{
    partial class GenerateExamView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.spinEditSectionCount = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.spinEditQuestionPerSection = new DevExpress.XtraEditors.SpinEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnGenerate = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSectionCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditQuestionPerSection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnGenerate);
            this.layoutControl1.Controls.Add(this.spinEditQuestionPerSection);
            this.layoutControl1.Controls.Add(this.spinEditSectionCount);
            this.layoutControl1.Controls.Add(this.txtTitle);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(473, 130);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(473, 130);
            this.Root.TextVisible = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(141, 16);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(316, 28);
            this.txtTitle.StyleController = this.layoutControl1;
            this.txtTitle.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtTitle;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(447, 34);
            this.layoutControlItem1.Text = "Title:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(109, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 68);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(223, 36);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // spinEditSectionCount
            // 
            this.spinEditSectionCount.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditSectionCount.Location = new System.Drawing.Point(141, 50);
            this.spinEditSectionCount.Name = "spinEditSectionCount";
            this.spinEditSectionCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditSectionCount.Properties.MaxValue = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.spinEditSectionCount.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditSectionCount.Size = new System.Drawing.Size(92, 28);
            this.spinEditSectionCount.StyleController = this.layoutControl1;
            this.spinEditSectionCount.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spinEditSectionCount;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(223, 34);
            this.layoutControlItem2.Text = "Sections";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(109, 13);
            // 
            // spinEditQuestionPerSection
            // 
            this.spinEditQuestionPerSection.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditQuestionPerSection.Location = new System.Drawing.Point(364, 50);
            this.spinEditQuestionPerSection.Name = "spinEditQuestionPerSection";
            this.spinEditQuestionPerSection.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditQuestionPerSection.Properties.MaxValue = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.spinEditQuestionPerSection.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditQuestionPerSection.Size = new System.Drawing.Size(93, 28);
            this.spinEditQuestionPerSection.StyleController = this.layoutControl1;
            this.spinEditQuestionPerSection.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spinEditQuestionPerSection;
            this.layoutControlItem3.Location = new System.Drawing.Point(223, 34);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(224, 34);
            this.layoutControlItem3.Text = "Questions Per Section:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(109, 13);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(239, 84);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(218, 28);
            this.btnGenerate.StyleController = this.layoutControl1;
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnGenerate;
            this.layoutControlItem4.Location = new System.Drawing.Point(223, 68);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(224, 36);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // GenerateExamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 130);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.ShowIcon = false;
            this.Name = "GenerateExamView";
            this.Text = "Generation Settings";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSectionCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditQuestionPerSection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.SimpleButton btnGenerate;
        private DevExpress.XtraEditors.SpinEdit spinEditQuestionPerSection;
        private DevExpress.XtraEditors.SpinEdit spinEditSectionCount;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}