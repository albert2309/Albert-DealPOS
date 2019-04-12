using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;

namespace Albert_DealPOS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //SELECT Person.Full_name, Phone.Phone FROM dbo.Person INNER JOIN dbo.Phone ON dbo.Person.ID = dbo.Phone.PersonID

            string connetionString = null;
            SqlConnection cnn;
            connetionString = "Data Source=.\\SQLExpress;Initial Catalog=DealPOSTest;User id=LoginScott;Password=pwd!23;";
            //connetionString = "Data Source=.\\SQLExpress;Initial Catalog=DealPOSTest;Integrated Security=SSPI;";
            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open using SQL Login! ");
                //For inserting into person;
                //string oString = "SELECT Person.Full_name, Phone.Phone FROM dbo.Person INNER JOIN dbo.Phone ON dbo.Person.ID = dbo.Phone.PersonID";
                SqlCommand oCmd = new SqlCommand("export", cnn);
                oCmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    List<string> row1 = new List<string>();
                    row1.Add(null);
                    row1.Add(null);
                    row1.Add(null);
                    while (oReader.Read())
                    {
                        
                        if (!String.IsNullOrEmpty(row1[0]) && row1[0].CompareTo(oReader["Full_name"].ToString()) == 0)
                        {
                            row1[2] = oReader["Phone"].ToString();
                            dataGridView1.Rows.Add(row1.ToArray());
                            row1 = new List<string>();
                            row1.Add(null);
                            row1.Add(null);
                            row1.Add(null);
                        }
                        else if (String.IsNullOrEmpty(row1[0]))
                        {
                            row1[0] = oReader["Full_name"].ToString();
                            row1[1] = oReader["Phone"].ToString();
                        }
                        else
                        {
                            dataGridView1.Rows.Add(row1.ToArray());
                            row1 = new List<string>();
                            row1.Add(null);
                            row1.Add(null);
                            row1.Add(null);
                            row1[0] = oReader["Full_name"].ToString();
                            row1[1] = oReader["Phone"].ToString();
                        }
                    }

                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error Message");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dealPOSTestDataSet.Phone' table. You can move, or remove it, as needed.
            this.phoneTableAdapter.Fill(this.dealPOSTestDataSet.Phone);
            // TODO: This line of code loads data into the 'dealPOSTestDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.dealPOSTestDataSet.Person);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //            Newtonsoft.Json.Jarr

            string connetionString = null;
            SqlConnection cnn;
            //connetionString = "Data Source=.\\SQLExpress;Initial Catalog=DealPOSTest;User id=LoginScott;Password=pwd!23;";
            connetionString = "Data Source=.\\SQLExpress;Initial Catalog=DealPOSTest;Integrated Security=SSPI;";
            cnn = new SqlConnection(connetionString);
            List<Person> personList = new List<Person>();
            try
            {
                cnn.Open();

                //For inserting into person;
                //string oString = "SELECT Person.Full_name, Phone.Phone FROM dbo.Person INNER JOIN dbo.Phone ON dbo.Person.ID = dbo.Phone.PersonID";
                SqlCommand oCmd = new SqlCommand("export", cnn);
                oCmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader oReader = oCmd.ExecuteReader())
                {
                    List<string> row1 = new List<string>();
                    row1.Add(null);
                    row1.Add(null);
                    row1.Add(null);
                    while (oReader.Read())
                    {
                        if (!String.IsNullOrEmpty(row1[0]) && row1[0].CompareTo(oReader["Full_name"].ToString()) == 0)
                        {
                            row1[2] = oReader["Phone"].ToString();
                            personList = append_Person_Contact(personList, row1);
                            row1 = new List<string>();
                            row1.Add(null);
                            row1.Add(null);
                            row1.Add(null);

                        }
                        else if (String.IsNullOrEmpty(row1[0]))
                        {
                            row1[0] = oReader["Full_name"].ToString();
                            row1[1] = oReader["Phone"].ToString();
                        }
                        else
                        {
                            personList = append_Person_Contact(personList, row1);
                            row1 = new List<string>();
                            row1.Add(null);
                            row1.Add(null);
                            row1.Add(null);
                            row1[0] = oReader["Full_name"].ToString();
                            row1[1] = oReader["Phone"].ToString();
                        }
                    }

                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error Message");
            }

            string json = JsonConvert.SerializeObject(personList, Formatting.Indented);
            MessageBox.Show(json);
        }

        private List<Person> append_Person_Contact(List<Person> personList, List<String> row1)
        {
            Person someone;
            if (String.IsNullOrEmpty(row1[2]))
                someone = new Person(row1[0], new String[] { row1[1] });
            else
                someone = new Person(row1[0], new String[] { row1[1], row1[2] });
            personList.Add(someone);
            return personList;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
