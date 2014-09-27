using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class SalaryUI : Form
    {
        public SalaryUI()
        {
            InitializeComponent();
        }
        Employee anEmployee=new Employee();
        private void showsalaryButton_Click(object sender, EventArgs e)
        {
            anEmployee.name = nametextBox.Text;
            anEmployee.basicAmount = Convert.ToDouble(basicamounttextBox.Text);
            anEmployee.houseRent = Convert.ToDouble(houserenttextBox.Text);
            anEmployee.medicalAllowance = Convert.ToDouble(medicalallowancetextBox.Text);


           anEmployee.Calculate();
            
            string msg = anEmployee.name+" " +"your salary is " + anEmployee.Calculate();
            MessageBox.Show(msg);
        }
    }
}
