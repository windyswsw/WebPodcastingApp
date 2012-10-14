namespace Data_Insert
{
    partial class Category_Selection_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category_Selection_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.General = new System.Windows.Forms.CheckBox();
            this.Technology = new System.Windows.Forms.CheckBox();
            this.Entertainment = new System.Windows.Forms.CheckBox();
            this.Business = new System.Windows.Forms.CheckBox();
            this.Global_Issues = new System.Windows.Forms.CheckBox();
            this.Sports = new System.Windows.Forms.CheckBox();
            this.Politics = new System.Windows.Forms.CheckBox();
            this.Religious = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select a category according to your preferences..";
            // 
            // General
            // 
            this.General.AutoSize = true;
            this.General.BackColor = System.Drawing.Color.Transparent;
            this.General.Location = new System.Drawing.Point(203, 119);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(92, 27);
            this.General.TabIndex = 2;
            this.General.Text = "General";
            this.General.UseVisualStyleBackColor = false;
            // 
            // Technology
            // 
            this.Technology.AutoSize = true;
            this.Technology.BackColor = System.Drawing.Color.Transparent;
            this.Technology.Location = new System.Drawing.Point(203, 166);
            this.Technology.Name = "Technology";
            this.Technology.Size = new System.Drawing.Size(117, 27);
            this.Technology.TabIndex = 3;
            this.Technology.Text = "Technology";
            this.Technology.UseVisualStyleBackColor = false;
            // 
            // Entertainment
            // 
            this.Entertainment.AutoSize = true;
            this.Entertainment.BackColor = System.Drawing.Color.Transparent;
            this.Entertainment.Location = new System.Drawing.Point(203, 217);
            this.Entertainment.Name = "Entertainment";
            this.Entertainment.Size = new System.Drawing.Size(145, 27);
            this.Entertainment.TabIndex = 4;
            this.Entertainment.Text = "Entertainment";
            this.Entertainment.UseVisualStyleBackColor = false;
            // 
            // Business
            // 
            this.Business.AutoSize = true;
            this.Business.BackColor = System.Drawing.Color.Transparent;
            this.Business.Location = new System.Drawing.Point(203, 263);
            this.Business.Name = "Business";
            this.Business.Size = new System.Drawing.Size(99, 27);
            this.Business.TabIndex = 5;
            this.Business.Text = "Business";
            this.Business.UseVisualStyleBackColor = false;
            // 
            // Global_Issues
            // 
            this.Global_Issues.AutoSize = true;
            this.Global_Issues.BackColor = System.Drawing.Color.Transparent;
            this.Global_Issues.Location = new System.Drawing.Point(436, 119);
            this.Global_Issues.Name = "Global_Issues";
            this.Global_Issues.Size = new System.Drawing.Size(133, 27);
            this.Global_Issues.TabIndex = 6;
            this.Global_Issues.Text = "Global Issues";
            this.Global_Issues.UseVisualStyleBackColor = false;
            // 
            // Sports
            // 
            this.Sports.AutoSize = true;
            this.Sports.BackColor = System.Drawing.Color.Transparent;
            this.Sports.Location = new System.Drawing.Point(436, 166);
            this.Sports.Name = "Sports";
            this.Sports.Size = new System.Drawing.Size(80, 27);
            this.Sports.TabIndex = 7;
            this.Sports.Text = "Sports";
            this.Sports.UseVisualStyleBackColor = false;
            // 
            // Politics
            // 
            this.Politics.AutoSize = true;
            this.Politics.BackColor = System.Drawing.Color.Transparent;
            this.Politics.Location = new System.Drawing.Point(436, 217);
            this.Politics.Name = "Politics";
            this.Politics.Size = new System.Drawing.Size(86, 27);
            this.Politics.TabIndex = 8;
            this.Politics.Text = "Politics";
            this.Politics.UseVisualStyleBackColor = false;
            // 
            // Religious
            // 
            this.Religious.AutoSize = true;
            this.Religious.BackColor = System.Drawing.Color.Transparent;
            this.Religious.Location = new System.Drawing.Point(436, 263);
            this.Religious.Name = "Religious";
            this.Religious.Size = new System.Drawing.Size(102, 27);
            this.Religious.TabIndex = 9;
            this.Religious.Text = "Religious";
            this.Religious.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(722, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Category_Selection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(847, 509);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Religious);
            this.Controls.Add(this.Politics);
            this.Controls.Add(this.Sports);
            this.Controls.Add(this.Global_Issues);
            this.Controls.Add(this.Business);
            this.Controls.Add(this.Entertainment);
            this.Controls.Add(this.Technology);
            this.Controls.Add(this.General);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Category_Selection_Form";
            this.Text = "Category_Selection_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox General;
        private System.Windows.Forms.CheckBox Technology;
        private System.Windows.Forms.CheckBox Entertainment;
        private System.Windows.Forms.CheckBox Business;
        private System.Windows.Forms.CheckBox Global_Issues;
        private System.Windows.Forms.CheckBox Sports;
        private System.Windows.Forms.CheckBox Politics;
        private System.Windows.Forms.CheckBox Religious;
        private System.Windows.Forms.Button button1;
    }
}