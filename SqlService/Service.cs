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
            return id <= 0 ? null : _positionRepository.GetById(id);
        }

        public IEnumerable<Position> GetAllPosition()
        {
            return _positionRepository.GetAll();
        }

        public void InsertPosition(Position position)
        {
            _positionRepository.Insert(position);
        }

        public void UpdatePosition(Position position)
        {
            _positionRepository.Update(position);
        }

        public void DeletePositionById(int id)
        {
            _positionRepository.DeleteById(id);
        }
        #endregion

        #region Departments
        public Department GetDepartmentById(int id)
        {
            return id <= 0 ? null : _departmentRepository.GetById(id);
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _departmentRepository.GetAll();
        }

        public void InsertDepartment(Department department)
        {
            _departmentRepository.Insert(department);
        }

        public void UpdateDepartment(Department department)
        {
            _departmentRepository.Update(department);
        }

        public void DeleteDepartmentsById(int id)
        {
            _departmentRepository.DeleteById(id);
        }
        #endregion

        #region Employees
        public Employee GetEmployeeById(int id)
        {
            return id <= 0 ? null : _employeeRepository.GetById(id);
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
            return id <= 0 ? null : _employeeRepository.GetByIdOnlyEmployee(id);
        }

        public void InsertEmployee(Employee employee)
        {
            _employeeRepository.Insert(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.Update(employee);
        }

        public void DeleteEmployeeById(int id)
        {
            if(id<= 0) return;
            _employeeRepository.DeleteById(id);
        }
        #endregion

    }
}
