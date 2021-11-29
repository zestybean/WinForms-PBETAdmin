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

namespace PBET_Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          
            //Datetime Picker Formats
            dateTimeFrom.Format = DateTimePickerFormat.Custom;
            dateTimeFrom.CustomFormat = "MM/dd/yyyy - HH:mm";

            dateTimeTo.Format = DateTimePickerFormat.Custom;
            dateTimeTo.CustomFormat = "MM/dd/yyyy - HH:mm";
            /*
            //SQL TEST
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=samtah\sqlexpress;Initial Catalog=PBET_DB;Integrated Security=True"))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM tbl_PaintlineCarts", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.Text;

                    using(SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        using(DataTable dt = new DataTable())
                        {
                            sqlAdapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }*/
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(@"Data Source=samtah\sqlexpress;Initial Catalog=PBET_DB;Integrated Security=True"))
            {
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand("getCartsTestTable", sqlConnection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.Add("@MACHINE", SqlDbType.VarChar).Value = machineTxtBox.Text;
                    sqlCommand.Parameters.Add("@TIMEINSTART", SqlDbType.DateTime).Value = dateTimeFrom.Value;
                    sqlCommand.Parameters.Add("@TIMEINEND", SqlDbType.DateTime).Value = dateTimeTo.Value;

                    using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sqlAdapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
