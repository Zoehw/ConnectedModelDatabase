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

namespace ConnectedModelDatabase
{
    public partial class Form1 : Form
    {
        private SqlConnection conn = new SqlConnection();

        //ConnectionString is the - Connection that used to open the SQL SERVER connection
        private string conString = "Server=LAPTOP-L4OBTH9P\\SQLEXPRESS; Database=CSharp;"
               + "User=Zoe; Password=Aaron";
        private SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Refreshall();
        }

        private void Refreshall()
        { 

             conn.ConnectionString = conString;

            //creates a command object that will work on the given connection
            //We use use this command object to execute our query
            cmd = conn.CreateCommand();

            try
            {
                string query = "Select * from FlightInfo;";

                //ComamndText is specifying the SQL query to Comamnd Object
                cmd.CommandText = query;

                //To execute the Query first need to Open the connection
                conn.Open();

                SqlDataReader reader=cmd.ExecuteReader();

                //DataTable acts as the bridge between DataReader and DataGridView
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;

                //Close the Data Reader Object
                reader.Close();

            }
            catch(Exception ex)
            {
                string message = ex.Message.ToString();
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string airline = txtAirline.Text;
            string flightNum=txtFlightNum.Text;
            string destination = txtDestination.Text;
            string airplane = cmbAirplane.SelectedItem.ToString();

            try
            {
                conn.ConnectionString = conString;
                cmd=conn.CreateCommand();

               
                string query = " Insert into FlightInfo values('" + airline+"', '" +
                    flightNum+"', '"+ destination +"', '" +airplane+"');";

                cmd.CommandText = query;
                conn.Open();
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                string message = ex.Message.ToString();
                string caption = "Error!";
                MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refreshall();
        }
    }
}
