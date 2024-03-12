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
            gb_Departments = new GroupBox();
            gb_Positions = new GroupBox();
            btn_GetAll_Employee = new Button();
            btn_GetByID_Employee = new Button();
            btn_Insert_Employee = new Button();
            btn_getByLastName_Employee = new Button();
            btn_Update_Employee = new Button();
            btn_Delete_Employee = new Button();
            btn_GetAll_Departments = new Button();
            btn_GetById_Depatment = new Button();
            btn_Insert_Depatment = new Button();
            btn_Update_Depatment = new Button();
            btn_Delete_Depatment = new Button();
            btn_GetAll_Position = new Button();
            btn_GetById_Position = new Button();
            btn_Insert_Position = new Button();
            btn_Update_Position = new Button();
            btn_Delete_Position = new Button();
            dataGridView1 = new DataGridView();
            gb_Employees.SuspendLayout();
            gb_Departments.SuspendLayout();
            gb_Positions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // gb_Employees
            // 
            gb_Employees.Controls.Add(btn_Delete_Employee);
            gb_Employees.Controls.Add(btn_Update_Employee);
            gb_Employees.Controls.Add(btn_getByLastName_Employee);
            gb_Employees.Controls.Add(btn_Insert_Employee);
            gb_Employees.Controls.Add(btn_GetByID_Employee);
            gb_Employees.Controls.Add(btn_GetAll_Employee);
            gb_Employees.Location = new Point(424, 12);
            gb_Employees.Name = "gb_Employees";
            gb_Employees.Size = new Size(200, 196);
            gb_Employees.TabIndex = 0;
            gb_Employees.TabStop = false;
            gb_Employees.Text = "Сотрудники";
            // 
            // gb_Departments
            // 
            gb_Departments.Controls.Add(btn_Delete_Depatment);
            gb_Departments.Controls.Add(btn_Update_Depatment);
            gb_Departments.Controls.Add(btn_Insert_Depatment);
            gb_Departments.Controls.Add(btn_GetById_Depatment);
            gb_Departments.Controls.Add(btn_GetAll_Departments);
            gb_Departments.Location = new Point(12, 12);
            gb_Departments.Name = "gb_Departments";
            gb_Departments.Size = new Size(200, 168);
            gb_Departments.TabIndex = 1;
            gb_Departments.TabStop = false;
            gb_Departments.Text = "Отделы";
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
            // btn_GetAll_Employee
            // 
            btn_GetAll_Employee.Location = new Point(6, 22);
            btn_GetAll_Employee.Name = "btn_GetAll_Employee";
            btn_GetAll_Employee.Size = new Size(188, 23);
            btn_GetAll_Employee.TabIndex = 0;
            btn_GetAll_Employee.Text = "Вывести всех сотрудников";
            btn_GetAll_Employee.UseVisualStyleBackColor = true;
            // 
            // btn_GetByID_Employee
            // 
            btn_GetByID_Employee.Location = new Point(6, 51);
            btn_GetByID_Employee.Name = "btn_GetByID_Employee";
            btn_GetByID_Employee.Size = new Size(188, 23);
            btn_GetByID_Employee.TabIndex = 1;
            btn_GetByID_Employee.Text = "Найти по ID";
            btn_GetByID_Employee.UseVisualStyleBackColor = true;
            // 
            // btn_Insert_Employee
            // 
            btn_Insert_Employee.Location = new Point(6, 109);
            btn_Insert_Employee.Name = "btn_Insert_Employee";
            btn_Insert_Employee.Size = new Size(188, 23);
            btn_Insert_Employee.TabIndex = 2;
            btn_Insert_Employee.Text = "Добавить нового сотрудника";
            btn_Insert_Employee.UseVisualStyleBackColor = true;
            // 
            // btn_getByLastName_Employee
            // 
            btn_getByLastName_Employee.Location = new Point(6, 80);
            btn_getByLastName_Employee.Name = "btn_getByLastName_Employee";
            btn_getByLastName_Employee.Size = new Size(188, 23);
            btn_getByLastName_Employee.TabIndex = 3;
            btn_getByLastName_Employee.Text = "Найти по фамилии";
            btn_getByLastName_Employee.UseVisualStyleBackColor = true;
            // 
            // btn_Update_Employee
            // 
            btn_Update_Employee.Location = new Point(6, 138);
            btn_Update_Employee.Name = "btn_Update_Employee";
            btn_Update_Employee.Size = new Size(188, 23);
            btn_Update_Employee.TabIndex = 4;
            btn_Update_Employee.Text = "Изменить сотрудника";
            btn_Update_Employee.UseVisualStyleBackColor = true;
            // 
            // btn_Delete_Employee
            // 
            btn_Delete_Employee.Location = new Point(6, 167);
            btn_Delete_Employee.Name = "btn_Delete_Employee";
            btn_Delete_Employee.Size = new Size(188, 23);
            btn_Delete_Employee.TabIndex = 5;
            btn_Delete_Employee.Text = "Удалить сотрудника";
            btn_Delete_Employee.UseVisualStyleBackColor = true;
            // 
            // btn_GetAll_Departments
            // 
            btn_GetAll_Departments.Location = new Point(6, 22);
            btn_GetAll_Departments.Name = "btn_GetAll_Departments";
            btn_GetAll_Departments.Size = new Size(188, 23);
            btn_GetAll_Departments.TabIndex = 0;
            btn_GetAll_Departments.Text = "Вывести все отделы";
            btn_GetAll_Departments.UseVisualStyleBackColor = true;
            // 
            // btn_GetById_Depatment
            // 
            btn_GetById_Depatment.Location = new Point(6, 51);
            btn_GetById_Depatment.Name = "btn_GetById_Depatment";
            btn_GetById_Depatment.Size = new Size(188, 23);
            btn_GetById_Depatment.TabIndex = 1;
            btn_GetById_Depatment.Text = "Найти отдел по ID";
            btn_GetById_Depatment.UseVisualStyleBackColor = true;
            // 
            // btn_Insert_Depatment
            // 
            btn_Insert_Depatment.Location = new Point(6, 80);
            btn_Insert_Depatment.Name = "btn_Insert_Depatment";
            btn_Insert_Depatment.Size = new Size(188, 23);
            btn_Insert_Depatment.TabIndex = 2;
            btn_Insert_Depatment.Text = "Добавить новый отдел";
            btn_Insert_Depatment.UseVisualStyleBackColor = true;
            // 
            // btn_Update_Depatment
            // 
            btn_Update_Depatment.Location = new Point(6, 109);
            btn_Update_Depatment.Name = "btn_Update_Depatment";
            btn_Update_Depatment.Size = new Size(188, 23);
            btn_Update_Depatment.TabIndex = 3;
            btn_Update_Depatment.Text = "Изменить отдел";
            btn_Update_Depatment.UseVisualStyleBackColor = true;
            // 
            // btn_Delete_Depatment
            // 
            btn_Delete_Depatment.Location = new Point(6, 138);
            btn_Delete_Depatment.Name = "btn_Delete_Depatment";
            btn_Delete_Depatment.Size = new Size(188, 23);
            btn_Delete_Depatment.TabIndex = 4;
            btn_Delete_Depatment.Text = "Удалить отдел";
            btn_Delete_Depatment.UseVisualStyleBackColor = true;
            // 
            // btn_GetAll_Position
            // 
            btn_GetAll_Position.Location = new Point(6, 22);
            btn_GetAll_Position.Name = "btn_GetAll_Position";
            btn_GetAll_Position.Size = new Size(188, 23);
            btn_GetAll_Position.TabIndex = 0;
            btn_GetAll_Position.Text = "Вывести все должности";
            btn_GetAll_Position.UseVisualStyleBackColor = true;
            // 
            // btn_GetById_Position
            // 
            btn_GetById_Position.Location = new Point(6, 51);
            btn_GetById_Position.Name = "btn_GetById_Position";
            btn_GetById_Position.Size = new Size(188, 23);
            btn_GetById_Position.TabIndex = 1;
            btn_GetById_Position.Text = "Найти должность по ID";
            btn_GetById_Position.UseVisualStyleBackColor = true;
            // 
            // btn_Insert_Position
            // 
            btn_Insert_Position.Location = new Point(6, 80);
            btn_Insert_Position.Name = "btn_Insert_Position";
            btn_Insert_Position.Size = new Size(188, 23);
            btn_Insert_Position.TabIndex = 2;
            btn_Insert_Position.Text = "Добавить должность";
            btn_Insert_Position.UseVisualStyleBackColor = true;
            // 
            // btn_Update_Position
            // 
            btn_Update_Position.Location = new Point(6, 109);
            btn_Update_Position.Name = "btn_Update_Position";
            btn_Update_Position.Size = new Size(188, 23);
            btn_Update_Position.TabIndex = 3;
            btn_Update_Position.Text = "Изменить должность";
            btn_Update_Position.UseVisualStyleBackColor = true;
            // 
            // btn_Delete_Position
            // 
            btn_Delete_Position.Location = new Point(6, 138);
            btn_Delete_Position.Name = "btn_Delete_Position";
            btn_Delete_Position.Size = new Size(188, 23);
            btn_Delete_Position.TabIndex = 4;
            btn_Delete_Position.Text = "Удалить должность";
            btn_Delete_Position.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(612, 230);
            dataGridView1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 450);
            Controls.Add(dataGridView1);
            Controls.Add(gb_Positions);
            Controls.Add(gb_Departments);
            Controls.Add(gb_Employees);
            Name = "MainForm";
            Text = "Главное окно";
            gb_Employees.ResumeLayout(false);
            gb_Departments.ResumeLayout(false);
            gb_Positions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_Employees;
        private GroupBox gb_Departments;
        private GroupBox gb_Positions;
        private Button btn_GetAll_Employee;
        private Button btn_getByLastName_Employee;
        private Button btn_Insert_Employee;
        private Button btn_GetByID_Employee;
        private Button btn_Update_Employee;
        private Button btn_Delete_Employee;
        private Button btn_Delete_Depatment;
        private Button btn_Update_Depatment;
        private Button btn_Insert_Depatment;
        private Button btn_GetById_Depatment;
        private Button btn_GetAll_Departments;
        private Button btn_GetById_Position;
        private Button btn_GetAll_Position;
        private Button btn_Delete_Position;
        private Button btn_Update_Position;
        private Button btn_Insert_Position;
        private DataGridView dataGridView1;
    }
}
