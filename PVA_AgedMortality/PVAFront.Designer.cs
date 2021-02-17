
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
            this.lstStartPop = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoRM = new System.Windows.Forms.RadioButton();
            this.rdoLV = new System.Windows.Forms.RadioButton();
            this.rdoBC = new System.Windows.Forms.RadioButton();
            this.btnBeta = new System.Windows.Forms.Button();
            this.txtAmrRate = new System.Windows.Forms.TextBox();
            this.lblAmrRate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // lstStartPop
            // 
            this.lstStartPop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lstStartPop.FormattingEnabled = true;
            this.lstStartPop.ItemHeight = 15;
            this.lstStartPop.Location = new System.Drawing.Point(277, 26);
            this.lstStartPop.Name = "lstStartPop";
            this.lstStartPop.Size = new System.Drawing.Size(218, 304);
            this.lstStartPop.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lstStartPop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 336);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Starting Population Characteristics";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.rdoRM);
            this.groupBox2.Controls.Add(this.rdoLV);
            this.groupBox2.Controls.Add(this.rdoBC);
            this.groupBox2.Location = new System.Drawing.Point(15, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 127);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Default populations";
            // 
            // rdoRM
            // 
            this.rdoRM.AutoSize = true;
            this.rdoRM.Location = new System.Drawing.Point(15, 85);
            this.rdoRM.Name = "rdoRM";
            this.rdoRM.Size = new System.Drawing.Size(205, 24);
            this.rdoRM.TabIndex = 12;
            this.rdoRM.Text = "RM (10 AF / 5 IMM / 3 IF)";
            this.rdoRM.UseVisualStyleBackColor = true;
            this.rdoRM.CheckedChanged += new System.EventHandler(this.rdoDefPops_CheckedChanged);
            // 
            // rdoLV
            // 
            this.rdoLV.AutoSize = true;
            this.rdoLV.Checked = true;
            this.rdoLV.Location = new System.Drawing.Point(15, 55);
            this.rdoLV.Name = "rdoLV";
            this.rdoLV.Size = new System.Drawing.Size(200, 24);
            this.rdoLV.TabIndex = 11;
            this.rdoLV.TabStop = true;
            this.rdoLV.Text = "LV (10 AF / 2 IMM / 1 IF)";
            this.rdoLV.UseVisualStyleBackColor = true;
            this.rdoLV.CheckedChanged += new System.EventHandler(this.rdoDefPops_CheckedChanged);
            // 
            // rdoBC
            // 
            this.rdoBC.AutoSize = true;
            this.rdoBC.Location = new System.Drawing.Point(15, 25);
            this.rdoBC.Name = "rdoBC";
            this.rdoBC.Size = new System.Drawing.Size(193, 24);
            this.rdoBC.TabIndex = 10;
            this.rdoBC.Text = "BC (5 AF / 1 IMM / 1 IF)";
            this.rdoBC.UseVisualStyleBackColor = true;
            this.rdoBC.CheckedChanged += new System.EventHandler(this.rdoDefPops_CheckedChanged);
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
            this.ClientSize = new System.Drawing.Size(554, 497);
            this.Controls.Add(this.lblAmrRate);
            this.Controls.Add(this.txtAmrRate);
            this.Controls.Add(this.btnBeta);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTrials);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.txtTrials);
            this.Controls.Add(this.txtYears);
            this.Name = "frmPvaFront";
            this.Text = "Capuchin Population Viability Analysis";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.TextBox txtTrials;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.Label lblTrials;
        private System.Windows.Forms.ListBox lstStartPop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBeta;
        private System.Windows.Forms.TextBox txtAmrRate;
        private System.Windows.Forms.Label lblAmrRate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoRM;
        private System.Windows.Forms.RadioButton rdoLV;
        private System.Windows.Forms.RadioButton rdoBC;
    }
}

