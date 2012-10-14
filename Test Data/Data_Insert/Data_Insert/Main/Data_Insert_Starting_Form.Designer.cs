namespace Data_Insert
{
    partial class Data_Insert_Starting_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Data_Insert_Starting_Form));
            this.Next_btn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Next_btn1
            // 
            this.Next_btn1.BackColor = System.Drawing.Color.SkyBlue;
            this.Next_btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_btn1.Location = new System.Drawing.Point(730, 451);
            this.Next_btn1.Name = "Next_btn1";
            this.Next_btn1.Size = new System.Drawing.Size(94, 33);
            this.Next_btn1.TabIndex = 2;
            this.Next_btn1.Text = "Next";
            this.Next_btn1.UseVisualStyleBackColor = false;
            this.Next_btn1.Click += new System.EventHandler(this.Next_btn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(417, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 71);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(328, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(496, 52);
            this.label2.TabIndex = 4;
            this.label2.Text = "This setup will help Prefetching Agent to understand\r\n your preferences about RSS" +
    " downloads...\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Data_Insert_Starting_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(847, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Next_btn1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Data_Insert_Starting_Form";
            this.Text = "Data Insert Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next_btn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

