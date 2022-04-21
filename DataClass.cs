using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseElev8
{
    class DataClass
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Elev8Connection"].ConnectionString;

        public int CreateEmployeeRecord(string surName,string otherNames,string gender, string mobileNo, string address)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Insert into [TableName](Properties) Values(content)
                    String query = "INSERT INTO EmployeesDetailsTbl(Surname,OtherNames,Gender, MobileNo,Address) Values(@Surname,@OtherNames,@Gender, @MobileNo,@Address)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Surname", surName);
                        command.Parameters.AddWithValue("@OtherNames", otherNames);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@MobileNo", mobileNo);
                        command.Parameters.AddWithValue("@Address", address);

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
                           
                        }


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
            return 1;
        }


        public DataTable ReturnEmployeesRecord()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String sql = "SELECT * FROM EmployeesDetailsTbl";

                SqlCommand sqlcom = new SqlCommand(sql, connection);
                try
                {
                    sqlcom.Connection.Open();
                    sqlcom.ExecuteNonQuery();
                    SqlDataReader reader = sqlcom.ExecuteReader();
                    
                    dt.Load(reader);
                    //dgView.DataSource = datatable;
                    //MessageBox.Show("LEFT OUTER成功");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }


            return dt;
        }
        public DataTable ReturnEmployeesRecord(string surName)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                String sql = "SELECT * FROM EmployeesDetailsTbl where surName=@surName";
                using (SqlCommand sqlcom = new SqlCommand(sql, connection))
                {
                    
                    try
                    {
                        sqlcom.Parameters.AddWithValue("@surName", surName);
                        sqlcom.Connection.Open();
                        sqlcom.ExecuteNonQuery();
                        SqlDataReader reader = sqlcom.ExecuteReader();

                        dt.Load(reader);
                       
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                  
               
            }


            return dt;
        }

        public int UpdateEmployeeRecord(int Id,string surName, string otherNames, string gender, string mobileNo, string address)
        {
            int result = -1;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    //Update [TableName] set Property=@Value where PK=?
                    String query = "Update EmployeesDetailsTbl set Surname=@Surname, OtherNames=@OtherNames,Gender=@Gender,MobileNo=@MobileNo,Address=@Address where Id=@Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", Id);
                        command.Parameters.AddWithValue("@Surname", surName);
                        command.Parameters.AddWithValue("@OtherNames", otherNames);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@MobileNo", mobileNo);
                        command.Parameters.AddWithValue("@Address", address);

                        connection.Open();
                         result = command.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                        {
                            Console.WriteLine("Error Updating data in Database!");
                        }
                        else
                        {
                            MessageBox.Show("Record Updated Successfully.");
                            
                        }


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            return result;
        }
    }
}
