using System.ComponentModel;
using DataService;
using Entities;
using RepositoriesSQL;
using System.Data;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Net.Http.Headers;
using WFClient.HelperForms;
using System.Windows.Forms;
using System.Runtime.Intrinsics.Arm;

namespace WFClient
{
    public partial class MainForm : Form
    {
        private Service service;
        private DepartmentRepository _departmentRepository = new();
        private EmployeeRepository _employeeRepository = new();
        private PositionRepository _positionRepository = new();

        private DataGridViewHelper displayValueType;
        internal DataGridViewHelper DisplayValueType
        {
            get
            {
                return displayValueType;
            }
            set
            {
                displayValueType = value;
                //BlockButtons(value);
            }
        }

        public MainForm()
        {
            service = new(_employeeRepository, _positionRepository, _departmentRepository);
            InitializeComponent();
            DisplayValueType = DataGridViewHelper.Default;
        }

        #region Positions
        private void btn_GetAll_Position_Click(object sender, EventArgs e)
        {//TODO Добавить проверку на ввод данных
            var list = service.GetAllPosition();
            DisplayPositions(list);
        }

        private void btn_GetById_Position_Click(object sender, EventArgs e)
        {//TODO Добавить проверку на ввод данных
            var result = service.GetPositionById(ParseIdTb());
        }

        private void btn_Insert_Position_Click(object sender, EventArgs e)
        {
            Position pos = new Position
            {
                Id = 0,
                Name = "Добавьте имя"
            };
            InputDepartmentOrPosition edEmployeeForm = new InputDepartmentOrPosition(pos.Name);
            DialogResult result = edEmployeeForm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            if (result == DialogResult.OK)
            {
                pos.Name = edEmployeeForm.nameEntity;
                service.InsertPosition(pos);
            }
            else
            {
                MessageBox.Show("Что-то не так");
            }
        }

        private void btn_Update_Position_Click(object sender, EventArgs e)
        {
            ParseIdTb();
            var pos = service.GetPositionById(ParseIdTb());
            if (pos == null)
            {
                MessageBox.Show("Пользователь не найден");
            }
            else
            {
                InputDepartmentOrPosition edEmployeeForm = new InputDepartmentOrPosition(pos.Name);
                DialogResult result = edEmployeeForm.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                if (result == DialogResult.OK)
                {
                    pos.Name = edEmployeeForm.nameEntity;
                    service.UpdatePosition(pos);
                }
                else
                {
                    MessageBox.Show("Что-то не так");
                }
            }
        }

        private void btn_Delete_Position_Click(object sender, EventArgs e)
        {
            service.DeletePositionById(ParseIdTb());
        }
        #endregion

        #region Departments
        private void btn_GetAll_Departments_Click(object sender, EventArgs e)
        {//TODO Добавить проверку на ввод данных
            var list = service.GetAllDepartments();
            DisplayDepartments(list);
        }
        private void btn_GetById_Department_Click(object sender, EventArgs e)
        {//TODO Добавить проверку на ввод данных
            var item = service.GetDepartmentById(ParseIdTb());
            DisplayDepartments(new List<Department> { item });
        }

        private void btn_Insert_Department_Click(object sender, EventArgs e)
        {
            Department dep = new Department
            {
                Id = 0,
                Name = "Добавьте Имя"
            };
            InputDepartmentOrPosition edEmployeeForm = new InputDepartmentOrPosition(dep.Name);
            DialogResult result = edEmployeeForm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            if (result == DialogResult.OK)
            {
                dep.Name = edEmployeeForm.nameEntity;
                service.InsertDepartment(dep);
            }
            else
            {
                MessageBox.Show("Что-то не так");
            }

        }

        private void btn_Update_Department_Click(object sender, EventArgs e)
        {
            ParseIdTb();
            var dep = service.GetDepartmentById(ParseIdTb());
            if (dep == null)
            {
                MessageBox.Show("Пользователь не найден");
            }
            else
            {
                InputDepartmentOrPosition edEmployeeForm = new InputDepartmentOrPosition(dep.Name);
                DialogResult result = edEmployeeForm.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                if (result == DialogResult.OK)
                {
                    dep.Name = edEmployeeForm.nameEntity;
                    service.UpdateDepartment(dep);
                }
                else
                {
                    MessageBox.Show("Что-то не так");
                }
            }
        }

        private void btn_Delete_Department_Click(object sender, EventArgs e)
        {
            service.DeleteDepartmentsById(ParseIdTb());
        }

        #endregion

        #region Employees
        private void btn_GetAll_Employees_Click(object sender, EventArgs e)
        {//TODO Добавить проверку на ввод данных
            var list = service.GetAllEmployees();
            DisplayEmployees(list);
        }

        private void btn_GetByID_Employee_Click(object sender, EventArgs e)
        {//TODO Добавить проверку на ввод данных
            var item = service.GetEmployeeById(ParseIdTb());
            DisplayEmployees(new List<Employee> { item });
        }

        private void btn_getByLastName_Employee_Click(object sender, EventArgs e)
        {//TODO Добавить проверку на ввод данных
            string lastName = MainTextBox.Text;
            var items = service.GetbyLastNameEmployees(lastName);
            DisplayEmployees(items);
        }

        private void btn_Insert_Employee_Click(object sender, EventArgs e)
        {
            InputEmployeeForm edEmployeeForm = new InputEmployeeForm(new Employee(), service.GetAllPosition(), service.GetAllDepartments());
            DialogResult result = edEmployeeForm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            if (result == DialogResult.OK)
            {
                service.InsertEmployee(edEmployeeForm.ResultEmployee);
            }
            else
            {
                MessageBox.Show("Что-то не так");
            }
        }

        private void btn_Update_Employee_Click(object sender, EventArgs e)
        {
            //TODO Добавить выбор по строке
            var employee = service.GetByIdOnlyEmployee(ParseIdTb());
            if (employee == null)
            {
                MessageBox.Show("Пользователь не найден");
            }
            else
            {
                InputEmployeeForm edEmployeeForm = new InputEmployeeForm(employee, service.GetAllPosition(), service.GetAllDepartments());
                DialogResult result = edEmployeeForm.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                if (result == DialogResult.OK)
                {
                    service.UpdateEmployee(edEmployeeForm.ResultEmployee);
                }
                else
                {
                    MessageBox.Show("Что-то не так");
                }
            }

        }

        private void btn_Delete_Employee_Click(object sender, EventArgs e)
        {
            var id = int.Parse(MainDataGridView.CurrentCell.Value.ToString());
            service.DeleteEmployeeById(id);
        }
        #endregion

        #region MyRegion
        private void DisplayEmployees(IEnumerable<Employee> list)
        {
            //TODO Добавить блокировку на изменения
            DataTable dataTable = new();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("DateOfBirth", typeof(DateTime));
            dataTable.Columns.Add("Department", typeof(string));
            dataTable.Columns.Add("Position", typeof(string));

            foreach (var entity in list)
            {
                if (entity != null)
                {
                    dataTable.Rows.Add(entity.Id, entity.Name, entity.LastName, entity.Email, entity.DateOfBirth, entity.Department.Name, entity.Position.Name);
                }
                else
                {
                    MessageBox.Show("Данные не найдены");
                }
            }

            DisplayValueType = DataGridViewHelper.Employee;
            MainDataGridView.DataSource = dataTable;
        }

        private void DisplayPositions(IEnumerable<Position> list)
        {//TODO Добавить блокировку на изменения
            DataTable dataTable = new();

            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));

            foreach (var entity in list)
            {
                if (entity != null)
                {
                    dataTable.Rows.Add(entity.Id, entity.Name);
                }
                else
                {
                    MessageBox.Show("Данные не найдены");
                }
            }
            DisplayValueType = DataGridViewHelper.Position;
            MainDataGridView.DataSource = dataTable;
        }

        private void DisplayDepartments(IEnumerable<Department> list)
        {//TODO Добавить блокировку на изменения
            DataTable dataTable = new();

            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Name", typeof(string));

            foreach (var entity in list)
            {
                if (entity != null)
                {
                    dataTable.Rows.Add(entity.Id, entity.Name);
                }
                else
                {
                    MessageBox.Show("Данные не найдены");
                }
            }
            DisplayValueType = DataGridViewHelper.Department;
            MainDataGridView.DataSource = dataTable;
        }

        //private void BlockButtons(DataGridViewHelper value)
        //{
        //    if (value == DataGridViewHelper.Default)
        //    {
        //        btn_GetAll_Departments.Enabled = true;
        //        btn_GetAll_Position.Enabled = true;
        //        btn_GetAll_Employees.Enabled = true;

        //        btn_GetById_Department.Enabled = true;
        //        btn_GetById_Position.Enabled = true;
        //        btn_GetByID_Employee.Enabled = true;
        //        btn_getByLastName_Employee.Enabled = true;

        //        btn_Insert_Employee.Enabled = true;
        //        btn_Insert_Position.Enabled = true;
        //        btn_Insert_Department.Enabled = true;

        //        btn_Update_Employee.Enabled = false;
        //        btn_Delete_Employee.Enabled = false;
        //        btn_Update_Position.Enabled = false;
        //        btn_Delete_Position.Enabled = false;
        //        btn_Update_Department.Enabled = false;
        //        btn_Delete_Department.Enabled = false;
        //    }
        //    if (value == DataGridViewHelper.Employee)
        //    {
        //        btn_Update_Employee.Enabled = true;
        //        btn_Update_Position.Enabled = false;
        //        btn_Update_Department.Enabled = false;

        //        btn_Delete_Employee.Enabled = true;
        //        btn_Delete_Position.Enabled = false;
        //        btn_Delete_Department.Enabled = false;
        //    }
        //    if (value == DataGridViewHelper.Department)
        //    {
        //        btn_Update_Employee.Enabled = false;
        //        btn_Update_Position.Enabled = false;
        //        btn_Update_Department.Enabled = true;

        //        btn_Delete_Employee.Enabled = false;
        //        btn_Delete_Position.Enabled = false;
        //        btn_Delete_Department.Enabled = true;
        //    }

        //    if (value == DataGridViewHelper.Position)
        //    {
        //        btn_Update_Employee.Enabled = false;
        //        btn_Update_Position.Enabled = true;
        //        btn_Update_Department.Enabled = false;

        //        btn_Delete_Employee.Enabled = false;
        //        btn_Delete_Position.Enabled = true;
        //        btn_Delete_Department.Enabled = false;
        //    }
        //}

        private int ParseIdTb()
        {
            int value;
            if (!Int32.TryParse(MainTextBox.Text, out value) || value <= 0)
            {
                MessageBox.Show("Введенный id неккоректен");
                return -1;
            }
            else
            {
                return value;
            }
        }
        #endregion

    }
}
