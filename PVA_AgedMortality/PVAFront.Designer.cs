
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
            this.lblYears = new System.Windows.Forms.Label();
            this.lblTrials = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstStartPop = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(33, 208);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(115, 67);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "&Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtYears
            // 
            this.txtYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtYears.Location = new System.Drawing.Point(33, 112);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(93, 26);
            this.txtYears.TabIndex = 1;
            // 
            // txtTrials
            // 
            this.txtTrials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTrials.Location = new System.Drawing.Point(33, 164);
            this.txtTrials.Name = "txtTrials";
            this.txtTrials.Size = new System.Drawing.Size(93, 26);
            this.txtTrials.TabIndex = 2;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYears.Location = new System.Drawing.Point(132, 118);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(132, 20);
            this.lblYears.TabIndex = 3;
            this.lblYears.Text = "Years to simulate";
            // 
            // lblTrials
            // 
            this.lblTrials.AutoSize = true;
            this.lblTrials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrials.Location = new System.Drawing.Point(132, 170);
            this.lblTrials.Name = "lblTrials";
            this.lblTrials.Size = new System.Drawing.Size(120, 20);
            this.lblTrials.TabIndex = 4;
            this.lblTrials.Text = "Number of trials";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAge.Location = new System.Drawing.Point(319, 112);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(93, 26);
            this.txtAge.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(418, 118);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(94, 20);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age (years) ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(319, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 67);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstStartPop
            // 
            this.lstStartPop.FormattingEnabled = true;
            this.lstStartPop.Location = new System.Drawing.Point(560, 53);
            this.lstStartPop.Name = "lstStartPop";
            this.lstStartPop.Size = new System.Drawing.Size(209, 329);
            this.lstStartPop.TabIndex = 8;
            // 
            // frmPvaFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstStartPop);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblTrials);
            this.Controls.Add(this.lblYears);
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
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblTrials;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstStartPop;
    }
}

