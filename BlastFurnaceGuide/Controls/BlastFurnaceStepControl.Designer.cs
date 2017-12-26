namespace BlastFurnaceGuide.Controls
{
    partial class BlastFurnaceStepControl
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
            this.step1_pnl = new System.Windows.Forms.Panel();
            this.stepNumber_lbl = new System.Windows.Forms.Label();
            this.step1_chk = new System.Windows.Forms.CheckBox();
            this.coalBag1_lbl = new System.Windows.Forms.Label();
            this.inventory1_lbl = new System.Windows.Forms.Label();
            this.step1_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // step1_pnl
            // 
            this.step1_pnl.Controls.Add(this.stepNumber_lbl);
            this.step1_pnl.Controls.Add(this.step1_chk);
            this.step1_pnl.Controls.Add(this.coalBag1_lbl);
            this.step1_pnl.Controls.Add(this.inventory1_lbl);
            this.step1_pnl.Location = new System.Drawing.Point(3, 3);
            this.step1_pnl.Name = "step1_pnl";
            this.step1_pnl.Size = new System.Drawing.Size(200, 60);
            this.step1_pnl.TabIndex = 4;
            // 
            // stepNumber_lbl
            // 
            this.stepNumber_lbl.AutoSize = true;
            this.stepNumber_lbl.Location = new System.Drawing.Point(6, 5);
            this.stepNumber_lbl.Name = "stepNumber_lbl";
            this.stepNumber_lbl.Size = new System.Drawing.Size(35, 13);
            this.stepNumber_lbl.TabIndex = 2;
            this.stepNumber_lbl.Text = "label1";
            // 
            // step1_chk
            // 
            this.step1_chk.AutoSize = true;
            this.step1_chk.Location = new System.Drawing.Point(139, 33);
            this.step1_chk.Name = "step1_chk";
            this.step1_chk.Size = new System.Drawing.Size(15, 14);
            this.step1_chk.TabIndex = 1;
            this.step1_chk.UseVisualStyleBackColor = true;
            // 
            // coalBag1_lbl
            // 
            this.coalBag1_lbl.AutoSize = true;
            this.coalBag1_lbl.Location = new System.Drawing.Point(17, 32);
            this.coalBag1_lbl.Name = "coalBag1_lbl";
            this.coalBag1_lbl.Size = new System.Drawing.Size(18, 13);
            this.coalBag1_lbl.TabIndex = 0;
            this.coalBag1_lbl.Text = "txt";
            // 
            // inventory1_lbl
            // 
            this.inventory1_lbl.AutoSize = true;
            this.inventory1_lbl.Location = new System.Drawing.Point(72, 33);
            this.inventory1_lbl.Name = "inventory1_lbl";
            this.inventory1_lbl.Size = new System.Drawing.Size(18, 13);
            this.inventory1_lbl.TabIndex = 0;
            this.inventory1_lbl.Text = "txt";
            // 
            // BlastFurnaceStepControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.step1_pnl);
            this.Name = "BlastFurnaceStepControl";
            this.Size = new System.Drawing.Size(240, 118);
            this.step1_pnl.ResumeLayout(false);
            this.step1_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel step1_pnl;
        private System.Windows.Forms.Label stepNumber_lbl;
        private System.Windows.Forms.CheckBox step1_chk;
        private System.Windows.Forms.Label coalBag1_lbl;
        private System.Windows.Forms.Label inventory1_lbl;
    }
}
