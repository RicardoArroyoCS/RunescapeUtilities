namespace BlastFurnaceGuide
{
    partial class BlastFurnaceGuideForm
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
            this.blastFurnace_tabcntrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.steelGuidePanelControl_control = new BlastFurnaceGuide.Controls.BlastFurnacePanelControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mithrilGuidePanelControl_control = new BlastFurnaceGuide.Controls.BlastFurnacePanelControl();
            this.blastFurnace_tabcntrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // blastFurnace_tabcntrl
            // 
            this.blastFurnace_tabcntrl.Controls.Add(this.tabPage1);
            this.blastFurnace_tabcntrl.Controls.Add(this.tabPage2);
            this.blastFurnace_tabcntrl.Location = new System.Drawing.Point(13, 13);
            this.blastFurnace_tabcntrl.Name = "blastFurnace_tabcntrl";
            this.blastFurnace_tabcntrl.SelectedIndex = 0;
            this.blastFurnace_tabcntrl.Size = new System.Drawing.Size(308, 291);
            this.blastFurnace_tabcntrl.TabIndex = 0;
            this.blastFurnace_tabcntrl.SelectedIndexChanged += new System.EventHandler(this.blastFurnace_tab_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.steelGuidePanelControl_control);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(300, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Steel";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // steelGuidePanelControl_control
            // 
            this.steelGuidePanelControl_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.steelGuidePanelControl_control.GuideName = "Guide";
            this.steelGuidePanelControl_control.Location = new System.Drawing.Point(3, 3);
            this.steelGuidePanelControl_control.Name = "steelGuidePanelControl_control";
            this.steelGuidePanelControl_control.Size = new System.Drawing.Size(294, 259);
            this.steelGuidePanelControl_control.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mithrilGuidePanelControl_control);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(300, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mithril";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // mithrilGuidePanelControl_control
            // 
            this.mithrilGuidePanelControl_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mithrilGuidePanelControl_control.GuideName = "Guide";
            this.mithrilGuidePanelControl_control.Location = new System.Drawing.Point(3, 3);
            this.mithrilGuidePanelControl_control.Name = "mithrilGuidePanelControl_control";
            this.mithrilGuidePanelControl_control.Size = new System.Drawing.Size(294, 259);
            this.mithrilGuidePanelControl_control.TabIndex = 0;
            // 
            // BlastFurnaceGuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 316);
            this.Controls.Add(this.blastFurnace_tabcntrl);
            this.KeyPreview = true;
            this.Name = "BlastFurnaceGuideForm";
            this.Text = "BlastFurnace Interactive Guide";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BlastFurnaceGuideForm_KeyDown);
            this.blastFurnace_tabcntrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl blastFurnace_tabcntrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public Controls.BlastFurnacePanelControl steelGuidePanelControl_control;
        private Controls.BlastFurnacePanelControl mithrilGuidePanelControl_control;
    }
}

