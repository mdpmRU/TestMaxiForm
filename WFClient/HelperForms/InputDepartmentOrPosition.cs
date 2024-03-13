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
    public partial class InputDepartmentOrPosition : Form
    {
        internal string nameEntity;
        public InputDepartmentOrPosition(string nameEntity)
        {
            InitializeComponent();
            tb_Name.Text = nameEntity;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            nameEntity = tb_Name.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
