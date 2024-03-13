namespace WFClient
{
    partial class MainForm
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
            gb_Employees = new GroupBox();
            btn_Delete_Employee = new Button();
            btn_Update_Employee = new Button();
            btn_getByLastName_Employee = new Button();
            btn_Insert_Employee = new Button();
            btn_GetByID_Employee = new Button();
            btn_GetAll_Employees = new Button();
            gb_Departments = new GroupBox();
            btn_Delete_Department = new Button();
            btn_Update_Department = new Button();
            btn_Insert_Department = new Button();
            btn_GetById_Department = new Button();
            btn_GetAll_Departments = new Button();
            gb_Positions = new GroupBox();
            btn_Delete_Position = new Button();
            btn_Update_Position = new Button();
            btn_Insert_Position = new Button();
            btn_GetById_Position = new Button();
            btn_GetAll_Position = new Button();
            MainDataGridView = new DataGridView();
            MainTextBox = new TextBox();
            gb_Employees.SuspendLayout();
            gb_Departments.SuspendLayout();
            gb_Positions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).BeginInit();
            SuspendLayout();
            // 
            // gb_Employees
            // 
            gb_Employees.Controls.Add(btn_Delete_Employee);
            gb_Employees.Controls.Add(btn_Update_Employee);
            gb_Employees.Controls.Add(btn_getByLastName_Employee);
            gb_Employees.Controls.Add(btn_Insert_Employee);
            gb_Employees.Controls.Add(btn_GetByID_Employee);
            gb_Employees.Controls.Add(btn_GetAll_Employees);
            gb_Employees.Location = new Point(424, 12);
            gb_Employees.Name = "gb_Employees";
            gb_Employees.Size = new Size(200, 196);
            gb_Employees.TabIndex = 0;
            gb_Employees.TabStop = false;
            gb_Employees.Text = "Сотрудники";
            // 
            // btn_Delete_Employee
            // 
            btn_Delete_Employee.Enabled = false;
            btn_Delete_Employee.Location = new Point(6, 167);
            btn_Delete_Employee.Name = "btn_Delete_Employee";
            btn_Delete_Employee.Size = new Size(188, 23);
            btn_Delete_Employee.TabIndex = 5;
            btn_Delete_Employee.Text = "Удалить сотрудника";
            btn_Delete_Employee.UseVisualStyleBackColor = true;
            btn_Delete_Employee.Click += btn_Delete_Employee_Click;
            // 
            // btn_Update_Employee
            // 
            btn_Update_Employee.Enabled = false;
            btn_Update_Employee.Location = new Point(6, 138);
            btn_Update_Employee.Name = "btn_Update_Employee";
            btn_Update_Employee.Size = new Size(188, 23);
            btn_Update_Employee.TabIndex = 4;
            btn_Update_Employee.Text = "Изменить сотрудника";
            btn_Update_Employee.UseVisualStyleBackColor = true;
            btn_Update_Employee.Click += btn_Update_Employee_Click;
            // 
            // btn_getByLastName_Employee
            // 
            btn_getByLastName_Employee.Enabled = false;
            btn_getByLastName_Employee.Location = new Point(6, 80);
            btn_getByLastName_Employee.Name = "btn_getByLastName_Employee";
            btn_getByLastName_Employee.Size = new Size(188, 23);
            btn_getByLastName_Employee.TabIndex = 3;
            btn_getByLastName_Employee.Text = "Найти по фамилии";
            btn_getByLastName_Employee.UseVisualStyleBackColor = true;
            btn_getByLastName_Employee.Click += btn_getByLastName_Employee_Click;
            // 
            // btn_Insert_Employee
            // 
            btn_Insert_Employee.Enabled = false;
            btn_Insert_Employee.Location = new Point(6, 109);
            btn_Insert_Employee.Name = "btn_Insert_Employee";
            btn_Insert_Employee.Size = new Size(188, 23);
            btn_Insert_Employee.TabIndex = 2;
            btn_Insert_Employee.Text = "Добавить нового сотрудника";
            btn_Insert_Employee.UseVisualStyleBackColor = true;
            btn_Insert_Employee.Click += btn_Insert_Employee_Click;
            // 
            // btn_GetByID_Employee
            // 
            btn_GetByID_Employee.Enabled = false;
            btn_GetByID_Employee.Location = new Point(6, 51);
            btn_GetByID_Employee.Name = "btn_GetByID_Employee";
            btn_GetByID_Employee.Size = new Size(188, 23);
            btn_GetByID_Employee.TabIndex = 1;
            btn_GetByID_Employee.Text = "Найти по ID";
            btn_GetByID_Employee.UseVisualStyleBackColor = true;
            btn_GetByID_Employee.Click += btn_GetByID_Employee_Click;
            // 
            // btn_GetAll_Employees
            // 
            btn_GetAll_Employees.Enabled = false;
            btn_GetAll_Employees.Location = new Point(6, 22);
            btn_GetAll_Employees.Name = "btn_GetAll_Employees";
            btn_GetAll_Employees.Size = new Size(188, 23);
            btn_GetAll_Employees.TabIndex = 0;
            btn_GetAll_Employees.Text = "Вывести всех сотрудников";
            btn_GetAll_Employees.UseVisualStyleBackColor = true;
            btn_GetAll_Employees.Click += btn_GetAll_Employees_Click;
            // 
            // gb_Departments
            // 
            gb_Departments.Controls.Add(btn_Delete_Department);
            gb_Departments.Controls.Add(btn_Update_Department);
            gb_Departments.Controls.Add(btn_Insert_Department);
            gb_Departments.Controls.Add(btn_GetById_Department);
            gb_Departments.Controls.Add(btn_GetAll_Departments);
            gb_Departments.Location = new Point(12, 12);
            gb_Departments.Name = "gb_Departments";
            gb_Departments.Size = new Size(200, 168);
            gb_Departments.TabIndex = 1;
            gb_Departments.TabStop = false;
            gb_Departments.Text = "Отделы";
            // 
            // btn_Delete_Department
            // 
            btn_Delete_Department.Enabled = false;
            btn_Delete_Department.Location = new Point(6, 138);
            btn_Delete_Department.Name = "btn_Delete_Department";
            btn_Delete_Department.Size = new Size(188, 23);
            btn_Delete_Department.TabIndex = 4;
            btn_Delete_Department.Text = "Удалить отдел";
            btn_Delete_Department.UseVisualStyleBackColor = true;
            btn_Delete_Department.Click += btn_Delete_Department_Click;
            // 
            // btn_Update_Department
            // 
            btn_Update_Department.Enabled = false;
            btn_Update_Department.Location = new Point(6, 109);
            btn_Update_Department.Name = "btn_Update_Department";
            btn_Update_Department.Size = new Size(188, 23);
            btn_Update_Department.TabIndex = 3;
            btn_Update_Department.Text = "Изменить отдел";
            btn_Update_Department.UseVisualStyleBackColor = true;
            btn_Update_Department.Click += btn_Update_Department_Click;
            // 
            // btn_Insert_Department
            // 
            btn_Insert_Department.Enabled = false;
            btn_Insert_Department.Location = new Point(6, 80);
            btn_Insert_Department.Name = "btn_Insert_Department";
            btn_Insert_Department.Size = new Size(188, 23);
            btn_Insert_Department.TabIndex = 2;
            btn_Insert_Department.Text = "Добавить новый отдел";
            btn_Insert_Department.UseVisualStyleBackColor = true;
            btn_Insert_Department.Click += btn_Insert_Department_Click;
            // 
            // btn_GetById_Department
            // 
            btn_GetById_Department.Enabled = false;
            btn_GetById_Department.Location = new Point(6, 51);
            btn_GetById_Department.Name = "btn_GetById_Department";
            btn_GetById_Department.Size = new Size(188, 23);
            btn_GetById_Department.TabIndex = 1;
            btn_GetById_Department.Text = "Найти отдел по ID";
            btn_GetById_Department.UseVisualStyleBackColor = true;
            btn_GetById_Department.Click += btn_GetById_Department_Click;
            // 
            // btn_GetAll_Departments
            // 
            btn_GetAll_Departments.Enabled = false;
            btn_GetAll_Departments.Location = new Point(6, 22);
            btn_GetAll_Departments.Name = "btn_GetAll_Departments";
            btn_GetAll_Departments.Size = new Size(188, 23);
            btn_GetAll_Departments.TabIndex = 0;
            btn_GetAll_Departments.Text = "Вывести все отделы";
            btn_GetAll_Departments.UseVisualStyleBackColor = true;
            btn_GetAll_Departments.Click += btn_GetAll_Departments_Click;
            // 
            // gb_Positions
            // 
            gb_Positions.Controls.Add(btn_Delete_Position);
            gb_Positions.Controls.Add(btn_Update_Position);
            gb_Positions.Controls.Add(btn_Insert_Position);
            gb_Positions.Controls.Add(btn_GetById_Position);
            gb_Positions.Controls.Add(btn_GetAll_Position);
            gb_Positions.Location = new Point(218, 12);
            gb_Positions.Name = "gb_Positions";
            gb_Positions.Size = new Size(200, 168);
            gb_Positions.TabIndex = 2;
            gb_Positions.TabStop = false;
            gb_Positions.Text = "Должности";
            // 
            // btn_Delete_Position
            // 
            btn_Delete_Position.Enabled = false;
            btn_Delete_Position.Location = new Point(6, 138);
            btn_Delete_Position.Name = "btn_Delete_Position";
            btn_Delete_Position.Size = new Size(188, 23);
            btn_Delete_Position.TabIndex = 4;
            btn_Delete_Position.Text = "Удалить должность";
            btn_Delete_Position.UseVisualStyleBackColor = true;
            btn_Delete_Position.Click += btn_Delete_Position_Click;
            // 
            // btn_Update_Position
            // 
            btn_Update_Position.Enabled = false;
            btn_Update_Position.Location = new Point(6, 109);
            btn_Update_Position.Name = "btn_Update_Position";
            btn_Update_Position.Size = new Size(188, 23);
            btn_Update_Position.TabIndex = 3;
            btn_Update_Position.Text = "Изменить должность";
            btn_Update_Position.UseVisualStyleBackColor = true;
            btn_Update_Position.Click += btn_Update_Position_Click;
            // 
            // btn_Insert_Position
            // 
            btn_Insert_Position.Enabled = false;
            btn_Insert_Position.Location = new Point(6, 80);
            btn_Insert_Position.Name = "btn_Insert_Position";
            btn_Insert_Position.Size = new Size(188, 23);
            btn_Insert_Position.TabIndex = 2;
            btn_Insert_Position.Text = "Добавить должность";
            btn_Insert_Position.UseVisualStyleBackColor = true;
            btn_Insert_Position.Click += btn_Insert_Position_Click;
            // 
            // btn_GetById_Position
            // 
            btn_GetById_Position.Enabled = false;
            btn_GetById_Position.Location = new Point(6, 51);
            btn_GetById_Position.Name = "btn_GetById_Position";
            btn_GetById_Position.Size = new Size(188, 23);
            btn_GetById_Position.TabIndex = 1;
            btn_GetById_Position.Text = "Найти должность по ID";
            btn_GetById_Position.UseVisualStyleBackColor = true;
            btn_GetById_Position.Click += btn_GetById_Position_Click;
            // 
            // btn_GetAll_Position
            // 
            btn_GetAll_Position.Enabled = false;
            btn_GetAll_Position.Location = new Point(6, 22);
            btn_GetAll_Position.Name = "btn_GetAll_Position";
            btn_GetAll_Position.Size = new Size(188, 23);
            btn_GetAll_Position.TabIndex = 0;
            btn_GetAll_Position.Text = "Вывести все должности";
            btn_GetAll_Position.UseVisualStyleBackColor = true;
            btn_GetAll_Position.Click += btn_GetAll_Position_Click;
            // 
            // MainDataGridView
            // 
            MainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MainDataGridView.Location = new Point(12, 214);
            MainDataGridView.Name = "MainDataGridView";
            MainDataGridView.Size = new Size(671, 224);
            MainDataGridView.TabIndex = 3;
            // 
            // MainTextBox
            // 
            MainTextBox.Location = new Point(12, 185);
            MainTextBox.Name = "MainTextBox";
            MainTextBox.Size = new Size(406, 23);
            MainTextBox.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 450);
            Controls.Add(MainTextBox);
            Controls.Add(MainDataGridView);
            Controls.Add(gb_Positions);
            Controls.Add(gb_Departments);
            Controls.Add(gb_Employees);
            Name = "MainForm";
            Text = "Главное окно";
            gb_Employees.ResumeLayout(false);
            gb_Departments.ResumeLayout(false);
            gb_Positions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb_Employees;
        private GroupBox gb_Departments;
        private GroupBox gb_Positions;
        private Button btn_GetAll_Employees;
        private Button btn_getByLastName_Employee;
        private Button btn_Insert_Employee;
        private Button btn_GetByID_Employee;
        private Button btn_Update_Employee;
        private Button btn_Delete_Employee;
        private Button btn_Delete_Department;
        private Button btn_Update_Department;
        private Button btn_Insert_Department;
        private Button btn_GetById_Department;
        private Button btn_GetAll_Departments;
        private Button btn_GetById_Position;
        private Button btn_GetAll_Position;
        private Button btn_Delete_Position;
        private Button btn_Update_Position;
        private Button btn_Insert_Position;
        private DataGridView MainDataGridView;
        private TextBox MainTextBox;
    }
}
