using System.ComponentModel;
using DataService;
using Entities;
using RepositoriesSQL;
using System.Data;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using WFClient.HelperForms;
using System.Windows.Forms;

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
                BlockButton(value);
            }
        }

        public MainForm()
        {
            this.service = new(_employeeRepository, _positionRepository, _departmentRepository);
            this.DisplayValueType = DataGridViewHelper.Default;
            InitializeComponent();
        }

        #region Positions
        private void btn_GetAll_Position_Click(object sender, EventArgs e)
        {//TODO Добавить проверку на ввод данных
            var list = service.GetAllPosition();
            DisplayPositions(list);
        }

        private void btn_GetById_Position_Click(object sender, EventArgs e)
        {//TODO Добавить проверку на ввод данных
            var value = Int32.Parse(MainTextBox.Text);
            var value2 = 1;
            var result = service.GetPositionById(value);
        }

        private void btn_Insert_Position_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Position_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Position_Click(object sender, EventArgs e)
        {

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

        }

        private void btn_Insert_Department_Click(object sender, EventArgs e)
        {
        }

        private void btn_Update_Department_Click(object sender, EventArgs e)
        {
            if (displayValueType == DataGridViewHelper.Department)
            {

            }
        }

        private void btn_Delete_Department_Click(object sender, EventArgs e)
        {

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
            var value = Int32.Parse(MainTextBox.Text);
            var item = service.GetEmployeeById(value);
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
            var id = int.Parse(MainDataGridView.CurrentCell.Value.ToString());

            InputEmployeeForm edEmployeeForm = new InputEmployeeForm(service.GetByIdOnlyEmployee(id), service.GetAllPosition(),service.GetAllDepartments());
            DialogResult result = edEmployeeForm.ShowDialog();
            if (result == DialogResult.Cancel)
            {
                return;
            }
            if(result == DialogResult.OK)
            {
                service.UpdateEmployee(edEmployeeForm.ResultEmployee);
            }
            else
            {
                MessageBox.Show("Что-то не так");
            }
        }

        private void btn_Delete_Employee_Click(object sender, EventArgs e)
        {
            var id = int.Parse(MainDataGridView.CurrentCell.Value.ToString());
            service.DeleteEmployeeById(id);
        }
        #endregion

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
                dataTable.Rows.Add(entity.Id, entity.Name, entity.LastName, entity.Email, entity.DateOfBirth, entity.Department.Name, entity.Position.Name);
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
                dataTable.Rows.Add(entity.Id, entity.Name);
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
                dataTable.Rows.Add(entity.Id, entity.Name);
            }
            DisplayValueType = DataGridViewHelper.Position;
            MainDataGridView.DataSource = dataTable;
        }

        private void BlockButton(DataGridViewHelper value)
        {
            //TODO Добавить реализацию на блокирование кнопок
        }
    }
}
