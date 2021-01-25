
namespace PVA_AgedMortality
{
    partial class frmPvaFront
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
            this.btnRun = new System.Windows.Forms.Button();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.txtTrials = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(12, 12);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(115, 67);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "&Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(33, 138);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(93, 20);
            this.txtYears.TabIndex = 1;
            // 
            // txtTrials
            // 
            this.txtTrials.Location = new System.Drawing.Point(33, 164);
            this.txtTrials.Name = "txtTrials";
            this.txtTrials.Size = new System.Drawing.Size(93, 20);
            this.txtTrials.TabIndex = 2;
            // 
            // frmPvaFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTrials);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.btnRun);
            this.Name = "frmPvaFront";
            this.Text = "Capuchin Population Viability Analysis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtTrials;
    }
}

