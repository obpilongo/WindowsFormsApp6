namespace WindowsFormsApp6
{
    partial class Form1
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
            this.label6 = new System.Windows.Forms.Label();
            this.deptNoTB = new System.Windows.Forms.TextBox();
            this.deptNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mgrNotb = new System.Windows.Forms.TextBox();
            this.mgrNo = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Department No.";
            // 
            // deptNoTB
            // 
            this.deptNoTB.Location = new System.Drawing.Point(197, 77);
            this.deptNoTB.Name = "deptNoTB";
            this.deptNoTB.Size = new System.Drawing.Size(154, 20);
            this.deptNoTB.TabIndex = 1;
            // 
            // deptNameTB
            // 
            this.deptNameTB.Location = new System.Drawing.Point(206, 129);
            this.deptNameTB.Name = "deptNameTB";
            this.deptNameTB.Size = new System.Drawing.Size(154, 20);
            this.deptNameTB.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Department Name.";
            // 
            // mgrNotb
            // 
            this.mgrNotb.Location = new System.Drawing.Point(221, 178);
            this.mgrNotb.Name = "mgrNotb";
            this.mgrNotb.Size = new System.Drawing.Size(154, 20);
            this.mgrNotb.TabIndex = 5;
            // 
            // mgrNo
            // 
            this.mgrNo.AutoSize = true;
            this.mgrNo.Location = new System.Drawing.Point(73, 178);
            this.mgrNo.Name = "mgrNo";
            this.mgrNo.Size = new System.Drawing.Size(82, 13);
            this.mgrNo.TabIndex = 4;
            this.mgrNo.Text = "Department No.";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(76, 255);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(185, 54);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(267, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(722, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.mgrNotb);
            this.Controls.Add(this.mgrNo);
            this.Controls.Add(this.deptNameTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.deptNoTB);
            this.Controls.Add(this.label6);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empIDtb;
        private System.Windows.Forms.TextBox lnTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fnTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deptIdtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salaryTB;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.TextBox mgrAllowTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox deptNoTB;
        private System.Windows.Forms.TextBox deptNameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mgrNotb;
        private System.Windows.Forms.Label mgrNo;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button1;
    }
}

