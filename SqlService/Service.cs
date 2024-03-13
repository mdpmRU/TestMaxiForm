using Contracts;
using Entities;

namespace DataService
{
    public class Service(IEmployeeRepository employeeRepository, IPositionRepository positionRepository, IDepartmentRepository departmentRepository)
    {
        //TODO По хорошему надо развести
        private IEmployeeRepository _employeeRepository = employeeRepository;
        private IPositionRepository _positionRepository = positionRepository;
        private IDepartmentRepository _departmentRepository = departmentRepository;

        #region Positions
        public Position GetPositionById(int id)
        {
            return _positionRepository.GetById(id);
        }

        public IEnumerable<Position> GetAllPosition()
        {
            return _positionRepository.GetAll();
        }

        public void InsertPosition(Position position)
        {

        }

        public void UpdatePosition(Position position)
        {

        }

        public void DeletePositionById(int id)
        {

        }
        #endregion

        #region Departments
        public Department GetDepartmentById(int id)
        {
            return _departmentRepository.GetById(id);
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _departmentRepository.GetAll();
        }

        public void InsertDepartment(Department department)
        {

        }

        public void UpdateDepartment(Department department)
        {

        }

        public void DeleteDepartmentsById(int id)
        {

        }
        #endregion

        #region Employees
        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetById(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }

        public IEnumerable<Employee> GetbyLastNameEmployees(string lastName)
        {
            return _employeeRepository.GetByLastName(lastName);
        }

        public Employee GetByIdOnlyEmployee(int id)
        {
            return _employeeRepository.GetByIdOnlyEmployee(id);
        }

        public void InsertEmployee(Employee employee)
        {

        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.Update(employee);
        }

        public void DeleteEmployeeById(int id)
        {

        }
        #endregion

    }
}
