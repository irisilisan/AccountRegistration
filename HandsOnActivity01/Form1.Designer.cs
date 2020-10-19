namespace HandsOnActivity2
{
    partial class frmRegistration
    {
     
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


       
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMiddleInitial = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.stPrograms = new System.Windows.Forms.ComboBox();          
            this.stGender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
           
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student No";
           
            this.txtStudentNo.Location = new System.Drawing.Point(150, 70);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(200, 30);
            this.txtStudentNo.TabIndex = 1;
           
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Program";
           
         
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
          
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 100);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Name";
           
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "MI";
           
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Age";
           
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Gender";
           
         
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Contact No";
           
            this.btnRegistration.Location = new System.Drawing.Point(307, 317);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(132, 30);
            this.btnRegistration.TabIndex = 11;
            this.btnRegistration.Text = "SUBMIT";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
           
            this.txtLastName.Location = new System.Drawing.Point(150, 126);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 20);
            this.txtLastName.TabIndex = 12;
           
            this.txtFirstName.Location = new System.Drawing.Point(480, 124);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 20);
            this.txtFirstName.TabIndex = 13;
          
            this.txtAge.Location = new System.Drawing.Point(135, 192);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(134, 20);
            this.txtAge.TabIndex = 14;
           
            this.txtMiddleInitial.Location = new System.Drawing.Point(658, 120);
            this.txtMiddleInitial.Name = "txtMiddleInitial";
            this.txtMiddleInitial.Size = new System.Drawing.Size(101, 20);
            this.txtMiddleInitial.TabIndex = 15;
          
            this.txtContactNo.Location = new System.Drawing.Point(478, 255);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(134, 20);
            this.txtContactNo.TabIndex = 10;
           
            this.stPrograms.FormattingEnabled = true;
            this.stPrograms.Location = new System.Drawing.Point(465, 62);
            this.stPrograms.Name = "cbPrograms";
            this.stPrograms.Size = new System.Drawing.Size(157, 21);
            this.stPrograms.TabIndex = 19;
            
          
            this.stGender.FormattingEnabled = true;
            this.stGender.Location = new System.Drawing.Point(465, 192);
            this.stGender.Name = "stGender";
            this.stGender.Size = new System.Drawing.Size(134, 21);
            this.stGender.TabIndex = 21;
           
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bold", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 33);
            this.label10.TabIndex = 22;
            this.label10.Text = "STUDENT SIGN IN:";
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 400);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.stGender);        
            this.Controls.Add(this.stPrograms);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtMiddleInitial);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.label1);
            this.Name = "Organization Profile";
            this.Text = "frmRegistration";
            this.Load += new System.EventHandler(this.frmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtMiddleInitial;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.ComboBox stPrograms;
        private System.Windows.Forms.ComboBox stGender;
        private System.Windows.Forms.Label label10;
    }
}

