namespace NetworkArithmeticGame
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.comboBoxOperator = new System.Windows.Forms.ComboBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnlHeader2 = new System.Windows.Forms.Panel();
            this.lblList = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBinaryTree = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPreOrder = new System.Windows.Forms.Label();
            this.btnPreDisplay = new System.Windows.Forms.Button();
            this.btnPreSave = new System.Windows.Forms.Button();
            this.btnInSave = new System.Windows.Forms.Button();
            this.btnInDisplay = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInOrder = new System.Windows.Forms.Label();
            this.btnPostSave = new System.Windows.Forms.Button();
            this.btnPostDisplay = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblPostOrder = new System.Windows.Forms.Label();
            this.lstBinaryTree = new System.Windows.Forms.RichTextBox();
            this.lstLinkedList = new System.Windows.Forms.RichTextBox();
            this.dgdArrayQuestions = new System.Windows.Forms.DataGridView();
            this.lblArray = new System.Windows.Forms.Label();
            this.btnSort1 = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.btnSort2 = new System.Windows.Forms.Button();
            this.btnSort3 = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlHeader2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdArrayQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.pnlHeader.Controls.Add(this.panel5);
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.lblInstructor);
            this.pnlHeader.Controls.Add(this.btnMinimize);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(954, 45);
            this.pnlHeader.TabIndex = 1;
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlHeader_MouseUp);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.panel5.Location = new System.Drawing.Point(1, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(953, 10);
            this.panel5.TabIndex = 24;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(853, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 45);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInstructor.Location = new System.Drawing.Point(11, 7);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(118, 28);
            this.lblInstructor.TabIndex = 0;
            this.lblInstructor.Text = "Instructor";
            this.lblInstructor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(752, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(101, 45);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "-";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.pnlInput.Controls.Add(this.comboBoxOperator);
            this.pnlInput.Controls.Add(this.lblEnter);
            this.pnlInput.Controls.Add(this.lblAnswer);
            this.pnlInput.Controls.Add(this.lblSecondNumber);
            this.pnlInput.Controls.Add(this.lblOperator);
            this.pnlInput.Controls.Add(this.lblFirstNumber);
            this.pnlInput.Controls.Add(this.txtAnswer);
            this.pnlInput.Controls.Add(this.txtSecondNumber);
            this.pnlInput.Controls.Add(this.txtFirstNumber);
            this.pnlInput.Location = new System.Drawing.Point(0, 45);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(414, 260);
            this.pnlInput.TabIndex = 3;
            // 
            // comboBoxOperator
            // 
            this.comboBoxOperator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.comboBoxOperator.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxOperator.ForeColor = System.Drawing.Color.White;
            this.comboBoxOperator.FormattingEnabled = true;
            this.comboBoxOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "/"});
            this.comboBoxOperator.Location = new System.Drawing.Point(191, 98);
            this.comboBoxOperator.Name = "comboBoxOperator";
            this.comboBoxOperator.Size = new System.Drawing.Size(191, 33);
            this.comboBoxOperator.TabIndex = 24;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEnter.Location = new System.Drawing.Point(12, 10);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(289, 22);
            this.lblEnter.TabIndex = 9;
            this.lblEnter.Text = "Enter question, then click Send";
            this.lblEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAnswer.Location = new System.Drawing.Point(12, 207);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(83, 22);
            this.lblAnswer.TabIndex = 8;
            this.lblAnswer.Text = "Answer:";
            this.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSecondNumber.Location = new System.Drawing.Point(12, 155);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(164, 22);
            this.lblSecondNumber.TabIndex = 7;
            this.lblSecondNumber.Text = "Second Number:";
            this.lblSecondNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.SystemColors.Control;
            this.lblOperator.Location = new System.Drawing.Point(12, 103);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(101, 22);
            this.lblOperator.TabIndex = 6;
            this.lblOperator.Text = "Operator:";
            this.lblOperator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFirstNumber.Location = new System.Drawing.Point(12, 53);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(126, 22);
            this.lblFirstNumber.TabIndex = 5;
            this.lblFirstNumber.Text = "First Number:";
            this.lblFirstNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAnswer.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.ForeColor = System.Drawing.Color.White;
            this.txtAnswer.Location = new System.Drawing.Point(191, 203);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(191, 33);
            this.txtAnswer.TabIndex = 3;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.txtSecondNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSecondNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondNumber.ForeColor = System.Drawing.Color.White;
            this.txtSecondNumber.Location = new System.Drawing.Point(191, 151);
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(191, 33);
            this.txtSecondNumber.TabIndex = 2;
            this.txtSecondNumber.TextChanged += new System.EventHandler(this.txtSecondNumber_TextChanged);
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.txtFirstNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstNumber.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNumber.ForeColor = System.Drawing.Color.White;
            this.txtFirstNumber.Location = new System.Drawing.Point(191, 49);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(191, 33);
            this.txtFirstNumber.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSend.Location = new System.Drawing.Point(0, 305);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(414, 40);
            this.btnSend.TabIndex = 11;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pnlHeader2
            // 
            this.pnlHeader2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.pnlHeader2.Controls.Add(this.lblList);
            this.pnlHeader2.Location = new System.Drawing.Point(0, 345);
            this.pnlHeader2.Name = "pnlHeader2";
            this.pnlHeader2.Size = new System.Drawing.Size(954, 45);
            this.pnlHeader2.TabIndex = 12;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.ForeColor = System.Drawing.SystemColors.Control;
            this.lblList.Location = new System.Drawing.Point(1, 10);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(509, 25);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "Linked List (of all incorrectly answered exercises):";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.lblBinaryTree);
            this.panel1.Location = new System.Drawing.Point(0, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 45);
            this.panel1.TabIndex = 13;
            // 
            // lblBinaryTree
            // 
            this.lblBinaryTree.AutoSize = true;
            this.lblBinaryTree.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBinaryTree.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBinaryTree.Location = new System.Drawing.Point(1, 10);
            this.lblBinaryTree.Name = "lblBinaryTree";
            this.lblBinaryTree.Size = new System.Drawing.Size(694, 25);
            this.lblBinaryTree.TabIndex = 0;
            this.lblBinaryTree.Text = "Binary Tree (of all questions - added in order that they were asked):";
            this.lblBinaryTree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.lblPreOrder);
            this.panel2.Location = new System.Drawing.Point(6, 614);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(148, 34);
            this.panel2.TabIndex = 16;
            // 
            // lblPreOrder
            // 
            this.lblPreOrder.AutoSize = true;
            this.lblPreOrder.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPreOrder.Location = new System.Drawing.Point(23, 5);
            this.lblPreOrder.Name = "lblPreOrder";
            this.lblPreOrder.Size = new System.Drawing.Size(100, 23);
            this.lblPreOrder.TabIndex = 0;
            this.lblPreOrder.Text = "Pre-Order";
            this.lblPreOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreDisplay
            // 
            this.btnPreDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnPreDisplay.FlatAppearance.BorderSize = 0;
            this.btnPreDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreDisplay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPreDisplay.Location = new System.Drawing.Point(6, 648);
            this.btnPreDisplay.Name = "btnPreDisplay";
            this.btnPreDisplay.Size = new System.Drawing.Size(74, 32);
            this.btnPreDisplay.TabIndex = 16;
            this.btnPreDisplay.Text = "Display";
            this.btnPreDisplay.UseVisualStyleBackColor = false;
            this.btnPreDisplay.Click += new System.EventHandler(this.btnPreDisplay_Click);
            // 
            // btnPreSave
            // 
            this.btnPreSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnPreSave.FlatAppearance.BorderSize = 0;
            this.btnPreSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPreSave.Location = new System.Drawing.Point(80, 648);
            this.btnPreSave.Name = "btnPreSave";
            this.btnPreSave.Size = new System.Drawing.Size(74, 32);
            this.btnPreSave.TabIndex = 17;
            this.btnPreSave.Text = "Save";
            this.btnPreSave.UseVisualStyleBackColor = false;
            this.btnPreSave.Click += new System.EventHandler(this.btnPreSave_Click);
            // 
            // btnInSave
            // 
            this.btnInSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnInSave.FlatAppearance.BorderSize = 0;
            this.btnInSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInSave.Location = new System.Drawing.Point(470, 648);
            this.btnInSave.Name = "btnInSave";
            this.btnInSave.Size = new System.Drawing.Size(74, 32);
            this.btnInSave.TabIndex = 20;
            this.btnInSave.Text = "Save";
            this.btnInSave.UseVisualStyleBackColor = false;
            this.btnInSave.Click += new System.EventHandler(this.btnInSave_Click);
            // 
            // btnInDisplay
            // 
            this.btnInDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnInDisplay.FlatAppearance.BorderSize = 0;
            this.btnInDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInDisplay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInDisplay.Location = new System.Drawing.Point(396, 648);
            this.btnInDisplay.Name = "btnInDisplay";
            this.btnInDisplay.Size = new System.Drawing.Size(74, 32);
            this.btnInDisplay.TabIndex = 18;
            this.btnInDisplay.Text = "Display";
            this.btnInDisplay.UseVisualStyleBackColor = false;
            this.btnInDisplay.Click += new System.EventHandler(this.btnInDisplay_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.panel3.Controls.Add(this.lblInOrder);
            this.panel3.Location = new System.Drawing.Point(396, 614);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(148, 34);
            this.panel3.TabIndex = 19;
            // 
            // lblInOrder
            // 
            this.lblInOrder.AutoSize = true;
            this.lblInOrder.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInOrder.Location = new System.Drawing.Point(30, 5);
            this.lblInOrder.Name = "lblInOrder";
            this.lblInOrder.Size = new System.Drawing.Size(87, 23);
            this.lblInOrder.TabIndex = 0;
            this.lblInOrder.Text = "In-Order";
            this.lblInOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPostSave
            // 
            this.btnPostSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnPostSave.FlatAppearance.BorderSize = 0;
            this.btnPostSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPostSave.Location = new System.Drawing.Point(875, 648);
            this.btnPostSave.Name = "btnPostSave";
            this.btnPostSave.Size = new System.Drawing.Size(74, 32);
            this.btnPostSave.TabIndex = 23;
            this.btnPostSave.Text = "Save";
            this.btnPostSave.UseVisualStyleBackColor = false;
            this.btnPostSave.Click += new System.EventHandler(this.btnPostSave_Click);
            // 
            // btnPostDisplay
            // 
            this.btnPostDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnPostDisplay.FlatAppearance.BorderSize = 0;
            this.btnPostDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostDisplay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPostDisplay.Location = new System.Drawing.Point(801, 648);
            this.btnPostDisplay.Name = "btnPostDisplay";
            this.btnPostDisplay.Size = new System.Drawing.Size(74, 32);
            this.btnPostDisplay.TabIndex = 21;
            this.btnPostDisplay.Text = "Display";
            this.btnPostDisplay.UseVisualStyleBackColor = false;
            this.btnPostDisplay.Click += new System.EventHandler(this.btnPostDisplay_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(35)))), ((int)(((byte)(43)))));
            this.panel4.Controls.Add(this.lblPostOrder);
            this.panel4.Location = new System.Drawing.Point(801, 614);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 34);
            this.panel4.TabIndex = 22;
            // 
            // lblPostOrder
            // 
            this.lblPostOrder.AutoSize = true;
            this.lblPostOrder.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostOrder.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPostOrder.Location = new System.Drawing.Point(21, 5);
            this.lblPostOrder.Name = "lblPostOrder";
            this.lblPostOrder.Size = new System.Drawing.Size(108, 23);
            this.lblPostOrder.TabIndex = 0;
            this.lblPostOrder.Text = "Post-Order";
            this.lblPostOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstBinaryTree
            // 
            this.lstBinaryTree.Location = new System.Drawing.Point(6, 539);
            this.lstBinaryTree.Name = "lstBinaryTree";
            this.lstBinaryTree.ReadOnly = true;
            this.lstBinaryTree.Size = new System.Drawing.Size(942, 61);
            this.lstBinaryTree.TabIndex = 24;
            this.lstBinaryTree.Text = "";
            // 
            // lstLinkedList
            // 
            this.lstLinkedList.Location = new System.Drawing.Point(6, 403);
            this.lstLinkedList.Name = "lstLinkedList";
            this.lstLinkedList.ReadOnly = true;
            this.lstLinkedList.Size = new System.Drawing.Size(942, 64);
            this.lstLinkedList.TabIndex = 25;
            this.lstLinkedList.Text = "";
            // 
            // dgdArrayQuestions
            // 
            this.dgdArrayQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdArrayQuestions.Location = new System.Drawing.Point(424, 83);
            this.dgdArrayQuestions.Name = "dgdArrayQuestions";
            this.dgdArrayQuestions.Size = new System.Drawing.Size(522, 222);
            this.dgdArrayQuestions.TabIndex = 26;
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArray.ForeColor = System.Drawing.SystemColors.Control;
            this.lblArray.Location = new System.Drawing.Point(420, 55);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(239, 22);
            this.lblArray.TabIndex = 25;
            this.lblArray.Text = "Array of questions asked:";
            this.lblArray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSort1
            // 
            this.btnSort1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSort1.FlatAppearance.BorderSize = 0;
            this.btnSort1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSort1.Location = new System.Drawing.Point(500, 304);
            this.btnSort1.Name = "btnSort1";
            this.btnSort1.Size = new System.Drawing.Size(149, 41);
            this.btnSort1.TabIndex = 32;
            this.btnSort1.Text = "1";
            this.btnSort1.UseVisualStyleBackColor = false;
            this.btnSort1.Click += new System.EventHandler(this.btnSort1_Click);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSort.Location = new System.Drawing.Point(426, 314);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(49, 22);
            this.lblSort.TabIndex = 25;
            this.lblSort.Text = "Sort:";
            this.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSort2
            // 
            this.btnSort2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSort2.FlatAppearance.BorderSize = 0;
            this.btnSort2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSort2.Location = new System.Drawing.Point(649, 304);
            this.btnSort2.Name = "btnSort2";
            this.btnSort2.Size = new System.Drawing.Size(149, 41);
            this.btnSort2.TabIndex = 33;
            this.btnSort2.Text = "2";
            this.btnSort2.UseVisualStyleBackColor = false;
            this.btnSort2.Click += new System.EventHandler(this.btnSort2_Click);
            // 
            // btnSort3
            // 
            this.btnSort3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.btnSort3.FlatAppearance.BorderSize = 0;
            this.btnSort3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort3.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSort3.Location = new System.Drawing.Point(796, 304);
            this.btnSort3.Name = "btnSort3";
            this.btnSort3.Size = new System.Drawing.Size(149, 41);
            this.btnSort3.TabIndex = 34;
            this.btnSort3.Text = "3";
            this.btnSort3.UseVisualStyleBackColor = false;
            this.btnSort3.Click += new System.EventHandler(this.btnSort3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(954, 684);
            this.Controls.Add(this.btnSort3);
            this.Controls.Add(this.btnSort2);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.btnSort1);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.dgdArrayQuestions);
            this.Controls.Add(this.lstLinkedList);
            this.Controls.Add(this.lstBinaryTree);
            this.Controls.Add(this.btnPostSave);
            this.Controls.Add(this.btnPostDisplay);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnInSave);
            this.Controls.Add(this.btnInDisplay);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnPreSave);
            this.Controls.Add(this.btnPreDisplay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlHeader2.ResumeLayout(false);
            this.pnlHeader2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdArrayQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInstructor;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel pnlHeader2;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBinaryTree;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPreOrder;
        private System.Windows.Forms.Button btnPreDisplay;
        private System.Windows.Forms.Button btnPreSave;
        private System.Windows.Forms.Button btnInSave;
        private System.Windows.Forms.Button btnInDisplay;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblInOrder;
        private System.Windows.Forms.Button btnPostSave;
        private System.Windows.Forms.Button btnPostDisplay;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblPostOrder;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox comboBoxOperator;
        private System.Windows.Forms.RichTextBox lstBinaryTree;
        private System.Windows.Forms.RichTextBox lstLinkedList;
        private System.Windows.Forms.DataGridView dgdArrayQuestions;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Button btnSort1;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Button btnSort2;
        private System.Windows.Forms.Button btnSort3;
    }
}

