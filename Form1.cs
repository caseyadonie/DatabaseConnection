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
        string connectionString = ConfigurationManager.ConnectionStrings["Elev8Connection"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Insert into [TableName](Properties) Values(content)
                    String query = "INSERT INTO EmployeesDetailsTbl(Surname,OtherNames,Gender, MobileNo,Address) Values(@Surname,@OtherNames,@Gender, @MobileNo,@Address)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Surname", txtSurname.Text);
                        command.Parameters.AddWithValue("@OtherNames", txtOtherNames.Text);
                        command.Parameters.AddWithValue("@Gender", cmbGender.Text);
                        command.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text);
                        command.Parameters.AddWithValue("@Address", txtAddress.Text);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                        {
                            Console.WriteLine("Error inserting data into Database!");
                        }
                        else
                        {
                            MessageBox.Show("Record Added Successfully.");
                            clear();
                        }


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
               
            }
        }
        void clear()
        {
            txtAddress.Text = String.Empty;
            txtMobileNo.Text = String.Empty;
            txtOtherNames.Text = String.Empty;
            txtSurname.Text = String.Empty;
            cmbGender.Text = String.Empty;
        }
        private void bttnRead_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String sql = "SELECT * FROM EmployeesDetailsTbl";

                SqlCommand sqlcom = new SqlCommand(sql, connection);
                try
                {
                    sqlcom.Connection.Open();
                    sqlcom.ExecuteNonQuery();
                    SqlDataReader reader = sqlcom.ExecuteReader();
                    DataTable datatable = new DataTable();
                    datatable.Load(reader);
                    dgView.DataSource = datatable;
                    //MessageBox.Show("LEFT OUTER成功");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
                
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Update [TableName] set Property=@Value where PK=?
                    String query = "Update EmployeesDetailsTbl set Surname=@Surname, OtherNames=@OtherNames where Id=1";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Surname", txtSurname.Text);
                        command.Parameters.AddWithValue("@OtherNames", txtOtherNames.Text);

                        connection.Open();
                        int result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                        {
                            Console.WriteLine("Error Updating data in Database!");
                        }
                        else
                        {
                            MessageBox.Show("Record Updated Successfully.");
                            clear();
                        }


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
