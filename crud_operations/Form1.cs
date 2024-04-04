using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionString = "Data Source=MSCCS24;Initial Catalog=master;User ID=sa;Password=sql2024";
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                int dno = Convert.ToInt32(textBox1.Text);
                String dname = textBox2.Text;
                int budget = Convert.ToInt32(textBox3.Text);

                String query = "insert into department values(" + dno + ",'" + dname + "'," + budget + ")";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data inserted successfully");
            

                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Enter valid data "+ex);
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Please provide department name!");
            }

            try
            {
                String connectionString = "Data Source=MSCCS24;Initial Catalog=master;User ID=sa;Password=sql2024";
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                int dno = Convert.ToInt32(textBox5.Text);
                String dname = textBox6.Text;
                // int budget = Convert.ToInt32(textBox3.Text);

                String query = "update department set dno = " + dno + " where dname = '" + textBox6.Text + "'";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully!");


                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please enter valid data"+ex);
            }


        }

        private void onLoad(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.masterDataSet.department);
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1.Visible = false;
            groupBox3.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                String connectionString = "Data Source=MSCCS24;Initial Catalog=master;User ID=sa;Password=sql2024";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                String dname = textBox4.Text;
                String query = "DELETE FROM department WHERE dname = '" + dname + "'";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted succefully!");
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something wrong"+ex);
            }
            
                
            
                     
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Please provide department id!");
            }

            try
            {
                String connectionString = "Data Source=MSCCS24;Initial Catalog=master;User ID=sa;Password=sql2024";
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                int dno = Convert.ToInt32(textBox6.Text);
                String dname = textBox7.Text;
                //int budget = Convert.ToInt32(textBox3.Text);

                String query = "update department set dname = '" + dname + "' where dno = " + dno + "";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully!");


                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Someting wrong." + ex);
            }

            
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                MessageBox.Show("Please provide department name!");
            }

            
                String connectionString = "Data Source=MSCCS24;Initial Catalog=master;User ID=sa;Password=sql2024";
                SqlConnection con = new SqlConnection(connectionString);

                con.Open();
                //int dno = Convert.ToInt32(textBox6.Text);
                String dname = textBox6.Text;
                int budget = Convert.ToInt32(textBox8.Text);

                String query = "update department set budget = " + budget + " where dname = '" + dname + "'";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully!");


                con.Close();
            
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.departmentTableAdapter.FillBy(this.masterDataSet.department);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.departmentTableAdapter.FillBy1(this.masterDataSet.department);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.departmentTableAdapter.Fill(this.masterDataSet.department);
        }
    }
}
