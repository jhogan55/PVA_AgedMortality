
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
            this.btnDefault = new System.Windows.Forms.Button();
            this.lstTrialResults = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBeta = new System.Windows.Forms.Button();
            this.txtAmrRate = new System.Windows.Forms.TextBox();
            this.lblAmrRate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(271, 413);
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
            this.txtYears.Location = new System.Drawing.Point(15, 401);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(93, 26);
            this.txtYears.TabIndex = 1;
            // 
            // txtTrials
            // 
            this.txtTrials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTrials.Location = new System.Drawing.Point(15, 453);
            this.txtTrials.Name = "txtTrials";
            this.txtTrials.Size = new System.Drawing.Size(93, 26);
            this.txtTrials.TabIndex = 2;
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYears.Location = new System.Drawing.Point(114, 407);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(132, 20);
            this.lblYears.TabIndex = 3;
            this.lblYears.Text = "Years to simulate";
            // 
            // lblTrials
            // 
            this.lblTrials.AutoSize = true;
            this.lblTrials.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrials.Location = new System.Drawing.Point(114, 459);
            this.lblTrials.Name = "lblTrials";
            this.lblTrials.Size = new System.Drawing.Size(120, 20);
            this.lblTrials.TabIndex = 4;
            this.lblTrials.Text = "Number of trials";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAge.Location = new System.Drawing.Point(112, 119);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(49, 26);
            this.txtAge.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(12, 122);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(94, 20);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age (years) ";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(27, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 67);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "&Add Ind";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstStartPop
            // 
            this.lstStartPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lstStartPop.FormattingEnabled = true;
            this.lstStartPop.ItemHeight = 15;
            this.lstStartPop.Location = new System.Drawing.Point(178, 37);
            this.lstStartPop.Name = "lstStartPop";
            this.lstStartPop.Size = new System.Drawing.Size(248, 244);
            this.lstStartPop.TabIndex = 8;
            // 
            // btnDefault
            // 
            this.btnDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefault.Location = new System.Drawing.Point(16, 37);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(145, 67);
            this.btnDefault.TabIndex = 9;
            this.btnDefault.Text = "&Default Pop";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // lstTrialResults
            // 
            this.lstTrialResults.FormattingEnabled = true;
            this.lstTrialResults.Location = new System.Drawing.Point(517, 13);
            this.lstTrialResults.Name = "lstTrialResults";
            this.lstTrialResults.Size = new System.Drawing.Size(288, 472);
            this.lstTrialResults.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnDefault);
            this.groupBox1.Controls.Add(this.lstStartPop);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 287);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Starting Population Characteristics";
            // 
            // btnBeta
            // 
            this.btnBeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeta.Location = new System.Drawing.Point(392, 413);
            this.btnBeta.Name = "btnBeta";
            this.btnBeta.Size = new System.Drawing.Size(115, 67);
            this.btnBeta.TabIndex = 12;
            this.btnBeta.Text = "&Sample Beta";
            this.btnBeta.UseVisualStyleBackColor = true;
            this.btnBeta.Click += new System.EventHandler(this.btnBeta_Click);
            // 
            // txtAmrRate
            // 
            this.txtAmrRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAmrRate.Location = new System.Drawing.Point(15, 354);
            this.txtAmrRate.Name = "txtAmrRate";
            this.txtAmrRate.Size = new System.Drawing.Size(93, 26);
            this.txtAmrRate.TabIndex = 13;
            // 
            // lblAmrRate
            // 
            this.lblAmrRate.AutoSize = true;
            this.lblAmrRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmrRate.Location = new System.Drawing.Point(114, 360);
            this.lblAmrRate.Name = "lblAmrRate";
            this.lblAmrRate.Size = new System.Drawing.Size(77, 20);
            this.lblAmrRate.TabIndex = 14;
            this.lblAmrRate.Text = "AMR rate";
            // 
            // frmPvaFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 497);
            this.Controls.Add(this.lblAmrRate);
            this.Controls.Add(this.txtAmrRate);
            this.Controls.Add(this.btnBeta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstTrialResults);
            this.Controls.Add(this.lblTrials);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.txtTrials);
            this.Controls.Add(this.txtYears);
            this.Name = "frmPvaFront";
            this.Text = "Capuchin Population Viability Analysis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.ListBox lstTrialResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBeta;
        private System.Windows.Forms.TextBox txtAmrRate;
        private System.Windows.Forms.Label lblAmrRate;
    }
}

