using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Salary_Detail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            double BS, Alo, EPF, GS, NS;

            BS = double.Parse(txtBSalary.Text);
            Alo = double.Parse(txtAllowance.Text);

            EPF = (BS / 100) * 8;

            lblEPFBasalary.Text = EPF.ToString();

            GS = BS + Alo;
            lblGrossSalary.Text = GS.ToString();

            NS = GS - EPF;
            lblNetSalary.Text = NS.ToString();
        
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAllowance.Clear();
            txtEMPNo.Clear();
            txtEmpname.Clear();
            txtBSalary.Clear();
            lblEPFBasalary.Text = "";
            lblGrossSalary.Text = "";
            lblNetSalary.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
