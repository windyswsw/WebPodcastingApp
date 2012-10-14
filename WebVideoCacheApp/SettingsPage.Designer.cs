namespace WebVideoCacheApp
{
    partial class SettingsPage
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpBandWidth = new System.Windows.Forms.TabPage();
            this.trkDuration = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.trkUsage = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbpPodCast = new System.Windows.Forms.TabPage();
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.lblSettingsRSS = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lstRSS = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tbpBandWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkUsage)).BeginInit();
            this.tbpPodCast.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpBandWidth);
            this.tabControl1.Controls.Add(this.tbpPodCast);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(497, 313);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpBandWidth
            // 
            this.tbpBandWidth.BackColor = System.Drawing.SystemColors.Control;
            this.tbpBandWidth.Controls.Add(this.trkDuration);
            this.tbpBandWidth.Controls.Add(this.label5);
            this.tbpBandWidth.Controls.Add(this.txtDuration);
            this.tbpBandWidth.Controls.Add(this.label4);
            this.tbpBandWidth.Controls.Add(this.txtUsage);
            this.tbpBandWidth.Controls.Add(this.trkUsage);
            this.tbpBandWidth.Controls.Add(this.label3);
            this.tbpBandWidth.Controls.Add(this.label2);
            this.tbpBandWidth.Location = new System.Drawing.Point(4, 22);
            this.tbpBandWidth.Name = "tbpBandWidth";
            this.tbpBandWidth.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBandWidth.Size = new System.Drawing.Size(489, 287);
            this.tbpBandWidth.TabIndex = 0;
            this.tbpBandWidth.Text = "Bandwidth Settings";
            // 
            // trkDuration
            // 
            this.trkDuration.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trkDuration.Location = new System.Drawing.Point(9, 112);
            this.trkDuration.Maximum = 120;
            this.trkDuration.Name = "trkDuration";
            this.trkDuration.Size = new System.Drawing.Size(450, 45);
            this.trkDuration.TabIndex = 7;
            this.trkDuration.TickFrequency = 5;
            this.trkDuration.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkDuration.Scroll += new System.EventHandler(this.trkDuration_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "seconds.";
            // 
            // txtDuration
            // 
            this.txtDuration.Enabled = false;
            this.txtDuration.Location = new System.Drawing.Point(88, 86);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(34, 20);
            this.txtDuration.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kb/s";
            // 
            // txtUsage
            // 
            this.txtUsage.Enabled = false;
            this.txtUsage.Location = new System.Drawing.Point(128, 11);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(35, 20);
            this.txtUsage.TabIndex = 3;
            // 
            // trkUsage
            // 
            this.trkUsage.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trkUsage.Location = new System.Drawing.Point(9, 31);
            this.trkUsage.Maximum = 100;
            this.trkUsage.Name = "trkUsage";
            this.trkUsage.Size = new System.Drawing.Size(450, 45);
            this.trkUsage.TabIndex = 2;
            this.trkUsage.TickFrequency = 10;
            this.trkUsage.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trkUsage.Scroll += new System.EventHandler(this.trkUsage_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "And stays so for ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Starts the usage is below";
            // 
            // tbpPodCast
            // 
            this.tbpPodCast.Controls.Add(this.btnEvaluate);
            this.tbpPodCast.Controls.Add(this.lblSettingsRSS);
            this.tbpPodCast.Controls.Add(this.btnInsert);
            this.tbpPodCast.Controls.Add(this.textBox1);
            this.tbpPodCast.Controls.Add(this.lstRSS);
            this.tbpPodCast.Location = new System.Drawing.Point(4, 22);
            this.tbpPodCast.Name = "tbpPodCast";
            this.tbpPodCast.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPodCast.Size = new System.Drawing.Size(489, 287);
            this.tbpPodCast.TabIndex = 1;
            this.tbpPodCast.Text = "PodCast Site List";
            this.tbpPodCast.UseVisualStyleBackColor = true;
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.Location = new System.Drawing.Point(384, 258);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluate.TabIndex = 4;
            this.btnEvaluate.Text = "Evaluate";
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            this.btnEvaluate.MouseLeave += new System.EventHandler(this.resetInformationLabel);
            this.btnEvaluate.MouseHover += new System.EventHandler(this.btnEvaluate_MouseHover);
            // 
            // lblSettingsRSS
            // 
            this.lblSettingsRSS.AutoSize = true;
            this.lblSettingsRSS.Location = new System.Drawing.Point(6, 263);
            this.lblSettingsRSS.Name = "lblSettingsRSS";
            this.lblSettingsRSS.Size = new System.Drawing.Size(209, 13);
            this.lblSettingsRSS.TabIndex = 3;
            this.lblSettingsRSS.Text = "RSS List will be used in download process.";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(371, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(88, 23);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lstRSS
            // 
            this.lstRSS.FormattingEnabled = true;
            this.lstRSS.Location = new System.Drawing.Point(6, 32);
            this.lstRSS.Name = "lstRSS";
            this.lstRSS.Size = new System.Drawing.Size(453, 225);
            this.lstRSS.TabIndex = 0;
            this.lstRSS.DoubleClick += new System.EventHandler(this.lstRSS_DoubleClick);
            this.lstRSS.MouseLeave += new System.EventHandler(this.resetInformationLabel);
            this.lstRSS.MouseHover += new System.EventHandler(this.lstRSS_MouseHover);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 337);
            this.Controls.Add(this.tabControl1);
            this.Name = "SettingsPage";
            this.Text = "SettingsPage";
            this.Load += new System.EventHandler(this.SettingsPage_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpBandWidth.ResumeLayout(false);
            this.tbpBandWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkUsage)).EndInit();
            this.tbpPodCast.ResumeLayout(false);
            this.tbpPodCast.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpBandWidth;
        private System.Windows.Forms.TabPage tbpPodCast;
        private System.Windows.Forms.ListBox lstRSS;
        private System.Windows.Forms.TrackBar trkUsage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSettingsRSS;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TrackBar trkDuration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.Button btnEvaluate;
    }
}