using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Albert_DealPOS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            String name = name_field.Text;
            String phone1 = phone1_field.Text;
            String phone2 = phone2_field.Text;
            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(phone1))
            {
                if (String.IsNullOrEmpty(name))
                    error1_label.Visible = true;
                if (String.IsNullOrEmpty(phone1))
                {
                    error2_label.Text = "Phone 1 must be filled";
                    error2_label.Visible = true;
                }

            }
            else
            {
                if (!String.IsNullOrEmpty(name))
                    error1_label.Visible = false;
                if (!String.IsNullOrEmpty(phone1) && !Regex.IsMatch(phone1, @"[\D]."))
                {
                    error2_label.Visible = false;
                }
                if (String.IsNullOrEmpty(phone2) || !Regex.IsMatch(phone2, @"[\D]."))
                    error3_label.Visible = false;
                if (Regex.IsMatch(phone1, @"[\D].") || Regex.IsMatch(phone2, @"[\D]."))
                {
                    if (Regex.IsMatch(phone1, @"[\D]."))
                    {
                        error2_label.Text = "Phone number must contain numbers only";
                        error2_label.Visible = true;
                    }

                    if (Regex.IsMatch(phone2, @"[\D].") && !String.IsNullOrEmpty(phone2))
                    {
                        error3_label.Text = "Phone number must contain numbers only";
                        error3_label.Visible = true;
                    }
                }
                else
                {
                    error1_label.Visible = false;
                    error2_label.Visible = false;
                    error3_label.Visible = false;
                    string connetionString = null;
                    SqlConnection cnn;
                    //connetionString = "Data Source=.\\SQLExpress;Initial Catalog=DealPOSTest;User id=LoginScott;Password=pwd!23;";
                    connetionString = "Data Source=.\\SQLExpress;Initial Catalog=DealPOSTest;Integrated Security=SSPI;";
                    cnn = new SqlConnection(connetionString);
                    try
                    {
                        cnn.Open();
                        MessageBox.Show("Connection Open ! ");
                        //For inserting into person;
                        using (SqlCommand command = new SqlCommand())
                        {
                            command.Connection = cnn;
                            command.CommandType = CommandType.Text;
                            command.CommandText = @"INSERT INTO Person (Full_name) VALUES (@param1)";
                            command.Parameters.AddWithValue("@param1", name);
                            command.ExecuteNonQuery();
                            command.CommandText = @"SELECT ID from Person where Full_name =@param1";
                            Int32 id = Convert.ToInt32(command.ExecuteScalar());
                            command.CommandText = @"INSERT INTO Phone (PersonID, Phone) VALUES (@personIDParam,@phone1param)";
                            command.Parameters.AddWithValue("@personIDParam", id);
                            command.Parameters.AddWithValue("@phone1param", phone1);
                            command.ExecuteNonQuery();
                            if (!String.IsNullOrEmpty(phone2))
                            {
                                command.CommandText = @"INSERT INTO Phone (PersonID, Phone) VALUES (@personIDParam,@phone2param)";
                                command.Parameters.AddWithValue("@phone2param", phone2);
                                command.ExecuteNonQuery();
                            }
                        }
                       
                        cnn.Close();
                        MessageBox.Show("Filled!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error Message");
                    }
                }

            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void view_button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.Activate();
        }
    }
}
