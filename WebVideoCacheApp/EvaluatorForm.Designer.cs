namespace WebVideoCacheApp
{
    partial class EvaluatorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAllURLs = new System.Windows.Forms.Label();
            this.lblAllArticles = new System.Windows.Forms.Label();
            this.lblFailed = new System.Windows.Forms.Label();
            this.lblPassed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblPrgrssBar = new System.Windows.Forms.Label();
            this.txtEvalLog = new System.Windows.Forms.TextBox();
            this.btnPassed = new System.Windows.Forms.Button();
            this.btnFailed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "All URLs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "All Articles";
            // 
            // lblAllURLs
            // 
            this.lblAllURLs.AutoSize = true;
            this.lblAllURLs.Location = new System.Drawing.Point(76, 13);
            this.lblAllURLs.Name = "lblAllURLs";
            this.lblAllURLs.Size = new System.Drawing.Size(13, 13);
            this.lblAllURLs.TabIndex = 2;
            this.lblAllURLs.Text = "0";
            // 
            // lblAllArticles
            // 
            this.lblAllArticles.AutoSize = true;
            this.lblAllArticles.Location = new System.Drawing.Point(76, 38);
            this.lblAllArticles.Name = "lblAllArticles";
            this.lblAllArticles.Size = new System.Drawing.Size(13, 13);
            this.lblAllArticles.TabIndex = 3;
            this.lblAllArticles.Text = "0";
            // 
            // lblFailed
            // 
            this.lblFailed.AutoSize = true;
            this.lblFailed.Location = new System.Drawing.Point(220, 38);
            this.lblFailed.Name = "lblFailed";
            this.lblFailed.Size = new System.Drawing.Size(13, 13);
            this.lblFailed.TabIndex = 7;
            this.lblFailed.Text = "0";
            // 
            // lblPassed
            // 
            this.lblPassed.AutoSize = true;
            this.lblPassed.Location = new System.Drawing.Point(220, 13);
            this.lblPassed.Name = "lblPassed";
            this.lblPassed.Size = new System.Drawing.Size(13, 13);
            this.lblPassed.TabIndex = 6;
            this.lblPassed.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(134, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Failed Articles";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Passed Articles";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 65);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(391, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // lblPrgrssBar
            // 
            this.lblPrgrssBar.AutoSize = true;
            this.lblPrgrssBar.Location = new System.Drawing.Point(12, 95);
            this.lblPrgrssBar.Name = "lblPrgrssBar";
            this.lblPrgrssBar.Size = new System.Drawing.Size(66, 13);
            this.lblPrgrssBar.TabIndex = 9;
            this.lblPrgrssBar.Text = "Evaluating...";
            // 
            // txtEvalLog
            // 
            this.txtEvalLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEvalLog.Location = new System.Drawing.Point(12, 112);
            this.txtEvalLog.Multiline = true;
            this.txtEvalLog.Name = "txtEvalLog";
            this.txtEvalLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEvalLog.Size = new System.Drawing.Size(391, 96);
            this.txtEvalLog.TabIndex = 10;
            this.txtEvalLog.WordWrap = false;
            // 
            // btnPassed
            // 
            this.btnPassed.Location = new System.Drawing.Point(268, 8);
            this.btnPassed.Name = "btnPassed";
            this.btnPassed.Size = new System.Drawing.Size(135, 23);
            this.btnPassed.TabIndex = 11;
            this.btnPassed.Text = "Passed List";
            this.btnPassed.UseVisualStyleBackColor = true;
            this.btnPassed.Click += new System.EventHandler(this.btnPassed_Click);
            // 
            // btnFailed
            // 
            this.btnFailed.Location = new System.Drawing.Point(268, 33);
            this.btnFailed.Name = "btnFailed";
            this.btnFailed.Size = new System.Drawing.Size(135, 23);
            this.btnFailed.TabIndex = 12;
            this.btnFailed.Text = "Falied List";
            this.btnFailed.UseVisualStyleBackColor = true;
            this.btnFailed.Click += new System.EventHandler(this.btnFailed_Click);
            // 
            // EvaluatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 220);
            this.Controls.Add(this.btnFailed);
            this.Controls.Add(this.btnPassed);
            this.Controls.Add(this.txtEvalLog);
            this.Controls.Add(this.lblPrgrssBar);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblFailed);
            this.Controls.Add(this.lblPassed);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAllArticles);
            this.Controls.Add(this.lblAllURLs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EvaluatorForm";
            this.Text = "EvaluatorForm";
            this.Load += new System.EventHandler(this.EvaluatorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAllURLs;
        private System.Windows.Forms.Label lblAllArticles;
        private System.Windows.Forms.Label lblFailed;
        private System.Windows.Forms.Label lblPassed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblPrgrssBar;
        private System.Windows.Forms.TextBox txtEvalLog;
        private System.Windows.Forms.Button btnPassed;
        private System.Windows.Forms.Button btnFailed;
    }
}