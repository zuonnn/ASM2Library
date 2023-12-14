namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_new_student = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_student = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_remove_student = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.student_page = new System.Windows.Forms.TabPage();
            this.admission_page = new System.Windows.Forms.TabPage();
            this.head_of_admission_page = new System.Windows.Forms.TabPage();
            this.accountant_page = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.student_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Page";
            // 
            // btn_add_new_student
            // 
            this.btn_add_new_student.Location = new System.Drawing.Point(0, 528);
            this.btn_add_new_student.Name = "btn_add_new_student";
            this.btn_add_new_student.Size = new System.Drawing.Size(99, 23);
            this.btn_add_new_student.TabIndex = 3;
            this.btn_add_new_student.Text = "Add New Student";
            this.btn_add_new_student.UseVisualStyleBackColor = true;
            this.btn_add_new_student.Click += new System.EventHandler(this.btn_add_new_student_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(267, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 441);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(120, 375);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(373, 20);
            this.textBox6.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(120, 310);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(373, 20);
            this.textBox5.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(120, 243);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(373, 20);
            this.textBox4.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(120, 177);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(373, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(120, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(373, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(826, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 441);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Notification";
            // 
            // list_student
            // 
            this.list_student.AutoScroll = true;
            this.list_student.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.list_student.Location = new System.Drawing.Point(0, 81);
            this.list_student.Name = "list_student";
            this.list_student.Size = new System.Drawing.Size(201, 441);
            this.list_student.TabIndex = 0;
            // 
            // btn_remove_student
            // 
            this.btn_remove_student.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_remove_student.Location = new System.Drawing.Point(105, 528);
            this.btn_remove_student.Name = "btn_remove_student";
            this.btn_remove_student.Size = new System.Drawing.Size(96, 23);
            this.btn_remove_student.TabIndex = 6;
            this.btn_remove_student.Text = "Remove Student";
            this.btn_remove_student.UseVisualStyleBackColor = false;
            this.btn_remove_student.Click += new System.EventHandler(this.btn_remove_student_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.student_page);
            this.tabControl1.Controls.Add(this.admission_page);
            this.tabControl1.Controls.Add(this.head_of_admission_page);
            this.tabControl1.Controls.Add(this.accountant_page);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1108, 615);
            this.tabControl1.TabIndex = 7;
            // 
            // student_page
            // 
            this.student_page.Controls.Add(this.label1);
            this.student_page.Controls.Add(this.btn_remove_student);
            this.student_page.Controls.Add(this.list_student);
            this.student_page.Controls.Add(this.btn_add_new_student);
            this.student_page.Controls.Add(this.groupBox2);
            this.student_page.Controls.Add(this.groupBox1);
            this.student_page.Location = new System.Drawing.Point(4, 22);
            this.student_page.Name = "student_page";
            this.student_page.Padding = new System.Windows.Forms.Padding(3);
            this.student_page.Size = new System.Drawing.Size(1100, 589);
            this.student_page.TabIndex = 0;
            this.student_page.Text = "Student Page";
            this.student_page.UseVisualStyleBackColor = true;
            // 
            // admission_page
            // 
            this.admission_page.Location = new System.Drawing.Point(4, 22);
            this.admission_page.Name = "admission_page";
            this.admission_page.Padding = new System.Windows.Forms.Padding(3);
            this.admission_page.Size = new System.Drawing.Size(1100, 589);
            this.admission_page.TabIndex = 1;
            this.admission_page.Text = "Admission Page";
            this.admission_page.UseVisualStyleBackColor = true;
            // 
            // head_of_admission_page
            // 
            this.head_of_admission_page.Location = new System.Drawing.Point(4, 22);
            this.head_of_admission_page.Name = "head_of_admission_page";
            this.head_of_admission_page.Padding = new System.Windows.Forms.Padding(3);
            this.head_of_admission_page.Size = new System.Drawing.Size(1100, 589);
            this.head_of_admission_page.TabIndex = 2;
            this.head_of_admission_page.Text = "Head Of Admission Page";
            this.head_of_admission_page.UseVisualStyleBackColor = true;
            // 
            // accountant_page
            // 
            this.accountant_page.Location = new System.Drawing.Point(4, 22);
            this.accountant_page.Name = "accountant_page";
            this.accountant_page.Padding = new System.Windows.Forms.Padding(3);
            this.accountant_page.Size = new System.Drawing.Size(1100, 589);
            this.accountant_page.TabIndex = 3;
            this.accountant_page.Text = "AccountantPage";
            this.accountant_page.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 611);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.student_page.ResumeLayout(false);
            this.student_page.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_new_student;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel list_student;
        private System.Windows.Forms.Button btn_remove_student;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage student_page;
        private System.Windows.Forms.TabPage admission_page;
        private System.Windows.Forms.TabPage head_of_admission_page;
        private System.Windows.Forms.TabPage accountant_page;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}

