using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseElev8
{
    public partial class Form1 : Form
    {
        DataClass dataClass = new DataClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnInsert_Click(object sender, EventArgs e)
        {

            dataClass.CreateEmployeeRecord(txtSurname.Text, txtOtherNames.Text, cmbGender.Text, txtMobileNo.Text, txtAddress.Text);
            clear();
            bttnRead.PerformClick();
        }
        void clear()
        {
            txtAddress.Text = String.Empty;
            txtMobileNo.Text = String.Empty;
            txtOtherNames.Text = String.Empty;
            txtSurname.Text = String.Empty;
            cmbGender.Text = String.Empty;
            dtpDOB.Value = DateTime.Today;
        }
        private void bttnRead_Click(object sender, EventArgs e)
        {
           //DataTable dt= dataClass.ReturnEmployeesRecord();
            dgView.DataSource= dataClass.ReturnEmployeesRecord();
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {

            dataClass.UpdateEmployeeRecord(Convert.ToInt32(lblId.Text), txtSurname.Text, txtOtherNames.Text, cmbGender.Text, txtMobileNo.Text, txtAddress.Text);
            bttnRead.PerformClick();
        }

        private void dgView_SelectionChanged(object sender, EventArgs e)
        {
            int row = dgView.CurrentCell.RowIndex;
            lblId.Text= dgView.Rows[row].Cells[0].Value.ToString();
            txtSurname.Text = dgView.Rows[row].Cells[1].Value.ToString();
            txtOtherNames.Text = dgView.Rows[row].Cells[2].Value.ToString();
            cmbGender.Text= dgView.Rows[row].Cells[3].Value.ToString();
            txtMobileNo.Text = dgView.Rows[row].Cells[4].Value.ToString();
            txtAddress.Text = dgView.Rows[row].Cells[6].Value.ToString();
        }

        private void bttnRead1_Click(object sender, EventArgs e)
        {
            dgView.DataSource = dataClass.ReturnEmployeesRecord(txtSurname.Text);
        }
    }
}
