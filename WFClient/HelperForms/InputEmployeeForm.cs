using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;

namespace WFClient.HelperForms
{
    public partial class InputEmployeeForm : Form
    {
        private IEnumerable<Position> _positions;
        private IEnumerable<Department> _departments;
        internal Employee ResultEmployee;

        public InputEmployeeForm(Employee employee, IEnumerable<Position> positions, IEnumerable<Department> departments)
        {
            _positions = positions;
            _departments = departments;
            InitializeComponent();
            tb_id.Text = employee.Id.ToString();
            tb_id.ReadOnly = true;
            tb_Name.Text = employee.Name;
            tb_LastName.Text = employee.LastName;
            tb_Email.Text = employee.Email;
            if (employee.DateOfBirth == DateTime.MinValue)
            {
                dt_DayBirth.Value = DateTime.Now;
            }
            else
            {
                dt_DayBirth.Value = employee.DateOfBirth.Date;
            }

            cb_Depatments.DataSource = _departments;
            if (employee.Department == null)
            {
                new Department
                {
                    Id = 0,
                    Name = "Добавьте отдел"
                };
            }
            else
            {
                
                cb_Depatments.SelectedIndex = employee.Department.Id;
                cb_Depatments.DisplayMember = "Name";
            }
            cb_Depatments.DisplayMember = "Name";

            cb_Position.DataSource = _positions;
            if (employee.Position == null)
            {
                new Department
                {
                    Id = 0,
                    Name = "Добавьте должность"
                };
            }
            else
            {
                
                cb_Position.SelectedIndex = employee.Position.Id;
            }
            cb_Position.DisplayMember = "Name";

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            ResultEmployee = new Employee
            {
                Id = int.Parse(tb_id.Text),
                Name = tb_Name.Text,
                LastName = tb_LastName.Text,
                Email = tb_Email.Text,
                DateOfBirth = dt_DayBirth.Value,
                Department = (Department)cb_Depatments.SelectedItem,
                Position = (Position)cb_Position.SelectedItem
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
