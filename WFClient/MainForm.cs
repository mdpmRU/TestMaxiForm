using DataService;
using RepositoriesSQL;

namespace WFClient
{
    public partial class MainForm : Form
    {
        private Service service;
        private DepartmentRepository _departmentRepository = new();
        private EmployeeRepository _employeeRepository = new();
        private PositionRepository _positionRepository = new();

        public MainForm()
        {
            this.service = new(_employeeRepository, _positionRepository, _departmentRepository);
            InitializeComponent();
        }

        #region Positions
        private void btn_GetAll_Position_Click(object sender, EventArgs e)
        {
            service.GetAllPosition();
        }

        private void btn_GetById_Position_Click(object sender, EventArgs e)
        {
            //var value = Int32.Parse(MainTextBox.Text);
            var value2 = 1;
            var result = service.GetPositionById(value2);
        }

        private void btn_Insert_Position_Click(object sender, EventArgs e)
        {
            //service.InsertPosition();
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
        {
            service.GetAllDepartments();
        }
        private void btn_GetById_Department_Click(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Department_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Department_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Department_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Employees
        private void btn_GetAll_Employees_Click(object sender, EventArgs e)
        {

        }

        private void btn_GetByID_Employee_Click(object sender, EventArgs e)
        {

        }

        private void btn_getByLastName_Employee_Click(object sender, EventArgs e)
        {

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
    }
}
