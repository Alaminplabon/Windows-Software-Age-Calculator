namespace Age_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.lblAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(113, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Of Birth";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MM-yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(201, 133);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(270, 23);
            this.dtpDOB.TabIndex = 1;
            this.dtpDOB.ValueChanged += new System.EventHandler(this.dtpDOB_ValueChanged);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalculate.Location = new System.Drawing.Point(329, 218);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(133, 40);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current date";
            // 
            // dtpCurrentDate
            // 
            this.dtpCurrentDate.CustomFormat = "dd-MM-yyyy";
            this.dtpCurrentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCurrentDate.Location = new System.Drawing.Point(201, 182);
            this.dtpCurrentDate.Name = "dtpCurrentDate";
            this.dtpCurrentDate.Size = new System.Drawing.Size(270, 23);
            this.dtpCurrentDate.TabIndex = 4;
            this.dtpCurrentDate.ValueChanged += new System.EventHandler(this.dtpCurrentDate_ValueChanged);
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblAge.Location = new System.Drawing.Point(127, 292);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(205, 47);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Your Age : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Age_Calculator.Properties.Resources.age_jpg;
            this.ClientSize = new System.Drawing.Size(605, 426);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.dtpCurrentDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Age Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDOB;
        private Button buttonCalculate;
        private Label label2;
        private DateTimePicker dtpCurrentDate;
        private Label lblAge;
    }
}