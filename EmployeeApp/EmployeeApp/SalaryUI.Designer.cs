namespace EmployeeApp
{
    partial class SalaryUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.basicamounttextBox = new System.Windows.Forms.TextBox();
            this.houserenttextBox = new System.Windows.Forms.TextBox();
            this.medicalallowancetextBox = new System.Windows.Forms.TextBox();
            this.showsalaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medical Allowance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "House Rent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "% of Basic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "% of Basic";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(146, 29);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(100, 20);
            this.nametextBox.TabIndex = 6;
            // 
            // basicamounttextBox
            // 
            this.basicamounttextBox.Location = new System.Drawing.Point(146, 72);
            this.basicamounttextBox.Name = "basicamounttextBox";
            this.basicamounttextBox.Size = new System.Drawing.Size(100, 20);
            this.basicamounttextBox.TabIndex = 7;
            // 
            // houserenttextBox
            // 
            this.houserenttextBox.Location = new System.Drawing.Point(146, 119);
            this.houserenttextBox.Name = "houserenttextBox";
            this.houserenttextBox.Size = new System.Drawing.Size(100, 20);
            this.houserenttextBox.TabIndex = 8;
            // 
            // medicalallowancetextBox
            // 
            this.medicalallowancetextBox.Location = new System.Drawing.Point(146, 150);
            this.medicalallowancetextBox.Name = "medicalallowancetextBox";
            this.medicalallowancetextBox.Size = new System.Drawing.Size(100, 20);
            this.medicalallowancetextBox.TabIndex = 9;
            // 
            // showsalaryButton
            // 
            this.showsalaryButton.Location = new System.Drawing.Point(146, 214);
            this.showsalaryButton.Name = "showsalaryButton";
            this.showsalaryButton.Size = new System.Drawing.Size(75, 23);
            this.showsalaryButton.TabIndex = 10;
            this.showsalaryButton.Text = "show Salary";
            this.showsalaryButton.UseVisualStyleBackColor = true;
            this.showsalaryButton.Click += new System.EventHandler(this.showsalaryButton_Click);
            // 
            // SalaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 261);
            this.Controls.Add(this.showsalaryButton);
            this.Controls.Add(this.medicalallowancetextBox);
            this.Controls.Add(this.houserenttextBox);
            this.Controls.Add(this.basicamounttextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SalaryUI";
            this.Text = "SalaryUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox basicamounttextBox;
        private System.Windows.Forms.TextBox houserenttextBox;
        private System.Windows.Forms.TextBox medicalallowancetextBox;
        private System.Windows.Forms.Button showsalaryButton;
    }
}

