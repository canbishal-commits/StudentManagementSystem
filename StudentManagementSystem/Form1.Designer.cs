namespace StudentManagementSystem
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            cmbDepartment = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lstStudents = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 3);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 41);
            label2.Name = "label2";
            label2.Size = new Size(110, 25);
            label2.TabIndex = 1;
            label2.Text = "Student Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 78);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 2;
            label3.Text = "Department";
            // 
            // txtName
            // 
            txtName.Location = new Point(132, 0);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 3;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(132, 41);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(150, 31);
            txtAge.TabIndex = 4;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "Software Engineering", "Business", "Nursing", "Medicine" });
            cmbDepartment.Location = new Point(132, 78);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(182, 33);
            cmbDepartment.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1, 132);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(1, 172);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(137, 34);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(1, 212);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(1, 252);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(3, 292);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(180, 129);
            lstStudents.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstStudents);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(cmbDepartment);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Student Management System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtAge;
        private ComboBox cmbDepartment;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnClear;
        private Button btnExit;
        private ListBox lstStudents;
    }
}
