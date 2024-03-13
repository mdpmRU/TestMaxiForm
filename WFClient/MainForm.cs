using System.ComponentModel;
using DataService;
using Entities;
using RepositoriesSQL;
using System.Data;
using System.Runtime.CompilerServices;

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
                BlockButton();
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
            //var value = Int32.Parse(MainTextBox.Text);
            var value2 = 1;
            var result = service.GetPositionById(value2);
        }

        private void btn_Insert_Position_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Position_Click(object sender, EventArgs e)
        {
            if (displayValueType == DataGridViewHelper.Position)
            {
                
            }
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
            var item = service.GetEmployeeById(1);
        }

        private void btn_getByLastName_Employee_Click(object sender, EventArgs e)
        {//TODO Добавить проверку на ввод данных
            string lastName= "FirstLastName";
            var items = service.GetbyLastNameEmployees(lastName);
        }

        private void btn_Insert_Employee_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Employee_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Employee_Click(object sender, EventArgs e)
        {
        }
        #endregion

        private void DisplayEmployees(IEnumerable<Employee> list)
        {
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
        {
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
        {
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

        }
    }
}
