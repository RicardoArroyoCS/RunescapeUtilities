namespace BlastFurnaceGuide.Controls
{
    partial class BlastFurnacePanelControl
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
            this.guideName_lbl = new System.Windows.Forms.Label();
            this.blastFurnaceStepControlStep1_control = new BlastFurnaceGuide.Controls.BlastFurnaceStepControl();
            this.blastFurnaceStepControlStep2_control = new BlastFurnaceGuide.Controls.BlastFurnaceStepControl();
            this.blastFurnaceStepControlStep3_control = new BlastFurnaceGuide.Controls.BlastFurnaceStepControl();
            this.nextStep_btn = new System.Windows.Forms.Button();
            this.previousStep_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guideName_lbl
            // 
            this.guideName_lbl.AutoSize = true;
            this.guideName_lbl.Location = new System.Drawing.Point(3, 12);
            this.guideName_lbl.Name = "guideName_lbl";
            this.guideName_lbl.Size = new System.Drawing.Size(35, 13);
            this.guideName_lbl.TabIndex = 4;
            this.guideName_lbl.Text = "Guide";
            // 
            // blastFurnaceStepControlStep1_control
            // 
            this.blastFurnaceStepControlStep1_control.Location = new System.Drawing.Point(6, 37);
            this.blastFurnaceStepControlStep1_control.Name = "blastFurnaceStepControlStep1_control";
            this.blastFurnaceStepControlStep1_control.Size = new System.Drawing.Size(205, 67);
            this.blastFurnaceStepControlStep1_control.TabIndex = 5;
            // 
            // blastFurnaceStepControlStep2_control
            // 
            this.blastFurnaceStepControlStep2_control.Location = new System.Drawing.Point(6, 110);
            this.blastFurnaceStepControlStep2_control.Name = "blastFurnaceStepControlStep2_control";
            this.blastFurnaceStepControlStep2_control.Size = new System.Drawing.Size(205, 67);
            this.blastFurnaceStepControlStep2_control.TabIndex = 5;
            // 
            // blastFurnaceStepControlStep3_control
            // 
            this.blastFurnaceStepControlStep3_control.Location = new System.Drawing.Point(6, 183);
            this.blastFurnaceStepControlStep3_control.Name = "blastFurnaceStepControlStep3_control";
            this.blastFurnaceStepControlStep3_control.Size = new System.Drawing.Size(205, 67);
            this.blastFurnaceStepControlStep3_control.TabIndex = 5;
            // 
            // nextStep_btn
            // 
            this.nextStep_btn.Location = new System.Drawing.Point(217, 12);
            this.nextStep_btn.Name = "nextStep_btn";
            this.nextStep_btn.Size = new System.Drawing.Size(75, 23);
            this.nextStep_btn.TabIndex = 6;
            this.nextStep_btn.Text = "Next";
            this.nextStep_btn.UseVisualStyleBackColor = true;
            // 
            // previousStep_btn
            // 
            this.previousStep_btn.Location = new System.Drawing.Point(114, 12);
            this.previousStep_btn.Name = "previousStep_btn";
            this.previousStep_btn.Size = new System.Drawing.Size(75, 23);
            this.previousStep_btn.TabIndex = 6;
            this.previousStep_btn.Text = "Previous";
            this.previousStep_btn.UseVisualStyleBackColor = true;
            // 
            // BlastFurnacePanelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.previousStep_btn);
            this.Controls.Add(this.nextStep_btn);
            this.Controls.Add(this.blastFurnaceStepControlStep3_control);
            this.Controls.Add(this.blastFurnaceStepControlStep2_control);
            this.Controls.Add(this.blastFurnaceStepControlStep1_control);
            this.Controls.Add(this.guideName_lbl);
            this.Name = "BlastFurnacePanelControl";
            this.Size = new System.Drawing.Size(319, 338);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label guideName_lbl;
        private BlastFurnaceStepControl blastFurnaceStepControlStep1_control;
        private BlastFurnaceStepControl blastFurnaceStepControlStep2_control;
        private BlastFurnaceStepControl blastFurnaceStepControlStep3_control;
        private System.Windows.Forms.Button nextStep_btn;
        private System.Windows.Forms.Button previousStep_btn;
    }
}
