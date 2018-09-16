namespace StudentForm
{
    partial class Form2
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
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lstQuestion = new System.Windows.Forms.ListView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEnter2 = new System.Windows.Forms.Label();
            this.lblStudentAnswer = new System.Windows.Forms.Label();
            this.lblStudentQuestion = new System.Windows.Forms.Label();
            this.txtStudentAnswer = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnExitStudent = new System.Windows.Forms.Button();
            this.btnMinimizeStudent = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStudent = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pnlInput.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.pnlInput.Controls.Add(this.lstQuestion);
            this.pnlInput.Controls.Add(this.btnSubmit);
            this.pnlInput.Controls.Add(this.lblEnter2);
            this.pnlInput.Controls.Add(this.lblStudentAnswer);
            this.pnlInput.Controls.Add(this.lblStudentQuestion);
            this.pnlInput.Controls.Add(this.txtStudentAnswer);
            this.pnlInput.Location = new System.Drawing.Point(0, 45);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(424, 200);
            this.pnlInput.TabIndex = 29;
            // 
            // lstQuestion
            // 
            this.lstQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.lstQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstQuestion.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lstQuestion.ForeColor = System.Drawing.Color.White;
            this.lstQuestion.Location = new System.Drawing.Point(191, 52);
            this.lstQuestion.Name = "lstQuestion";
            this.lstQuestion.Size = new System.Drawing.Size(191, 33);
            this.lstQuestion.TabIndex = 27;
            this.lstQuestion.UseCompatibleStateImageBehavior = false;
            this.lstQuestion.View = System.Windows.Forms.View.SmallIcon;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSubmit.Location = new System.Drawing.Point(-1, 158);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(425, 40);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEnter2
            // 
            this.lblEnter2.AutoSize = true;
            this.lblEnter2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter2.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnter2.Location = new System.Drawing.Point(12, 10);
            this.lblEnter2.Name = "lblEnter2";
            this.lblEnter2.Size = new System.Drawing.Size(328, 22);
            this.lblEnter2.TabIndex = 9;
            this.lblEnter2.Text = "Enter your answer and click Submit";
            this.lblEnter2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentAnswer
            // 
            this.lblStudentAnswer.AutoSize = true;
            this.lblStudentAnswer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentAnswer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStudentAnswer.Location = new System.Drawing.Point(12, 105);
            this.lblStudentAnswer.Name = "lblStudentAnswer";
            this.lblStudentAnswer.Size = new System.Drawing.Size(129, 22);
            this.lblStudentAnswer.TabIndex = 8;
            this.lblStudentAnswer.Text = "Your Answer:";
            this.lblStudentAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStudentQuestion
            // 
            this.lblStudentQuestion.AutoSize = true;
            this.lblStudentQuestion.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStudentQuestion.Location = new System.Drawing.Point(12, 52);
            this.lblStudentQuestion.Name = "lblStudentQuestion";
            this.lblStudentQuestion.Size = new System.Drawing.Size(102, 22);
            this.lblStudentQuestion.TabIndex = 5;
            this.lblStudentQuestion.Text = "Question: ";
            this.lblStudentQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStudentAnswer
            // 
            this.txtStudentAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.txtStudentAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentAnswer.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentAnswer.ForeColor = System.Drawing.Color.White;
            this.txtStudentAnswer.Location = new System.Drawing.Point(191, 101);
            this.txtStudentAnswer.Name = "txtStudentAnswer";
            this.txtStudentAnswer.Size = new System.Drawing.Size(191, 33);
            this.txtStudentAnswer.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panel6.Controls.Add(this.btnExitStudent);
            this.panel6.Controls.Add(this.btnMinimizeStudent);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.button1);
            this.panel6.Controls.Add(this.lblStudent);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Location = new System.Drawing.Point(-1, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(425, 45);
            this.panel6.TabIndex = 28;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDown);
            this.panel6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseMove);
            this.panel6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseUp);
            // 
            // btnExitStudent
            // 
            this.btnExitStudent.BackColor = System.Drawing.Color.Maroon;
            this.btnExitStudent.FlatAppearance.BorderSize = 0;
            this.btnExitStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitStudent.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitStudent.ForeColor = System.Drawing.Color.White;
            this.btnExitStudent.Location = new System.Drawing.Point(355, 0);
            this.btnExitStudent.Name = "btnExitStudent";
            this.btnExitStudent.Size = new System.Drawing.Size(70, 40);
            this.btnExitStudent.TabIndex = 28;
            this.btnExitStudent.Text = "X";
            this.btnExitStudent.UseVisualStyleBackColor = false;
            this.btnExitStudent.Click += new System.EventHandler(this.btnExitStudent_Click);
            // 
            // btnMinimizeStudent
            // 
            this.btnMinimizeStudent.BackColor = System.Drawing.Color.Gray;
            this.btnMinimizeStudent.FlatAppearance.BorderSize = 0;
            this.btnMinimizeStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeStudent.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeStudent.ForeColor = System.Drawing.Color.White;
            this.btnMinimizeStudent.Location = new System.Drawing.Point(285, 0);
            this.btnMinimizeStudent.Name = "btnMinimizeStudent";
            this.btnMinimizeStudent.Size = new System.Drawing.Size(70, 40);
            this.btnMinimizeStudent.TabIndex = 27;
            this.btnMinimizeStudent.Text = "-";
            this.btnMinimizeStudent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizeStudent.UseVisualStyleBackColor = false;
            this.btnMinimizeStudent.Click += new System.EventHandler(this.btnMinimizeStudent_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.panel7.Location = new System.Drawing.Point(1, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(424, 10);
            this.panel7.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(853, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStudent.Location = new System.Drawing.Point(11, 7);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(97, 28);
            this.lblStudent.TabIndex = 0;
            this.lblStudent.Text = "Student";
            this.lblStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(752, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "-";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 243);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblEnter2;
        private System.Windows.Forms.Label lblStudentAnswer;
        private System.Windows.Forms.Label lblStudentQuestion;
        private System.Windows.Forms.TextBox txtStudentAnswer;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExitStudent;
        private System.Windows.Forms.Button btnMinimizeStudent;
        private System.Windows.Forms.ListView lstQuestion;
    }
}

