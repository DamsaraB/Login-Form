using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hasitha
{
    public partial class Form1 : Form
    {
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pwd, repwd, password, userrole, username;
            pwd = textBox2.Text;
            repwd = textBox3.Text;
            username = textBox1.Text;
            userrole = comboBox1.Text;


            if (pwd == repwd)
            {
                password = pwd;
            }
            else
            {
                string message = ("Password Do Not Match");
                string title = "Error";
                MessageBox.Show(message, title);

            }

            Class1.open_connection();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO login VALUES ('" + username + "' ,'" + userrole + "','" + pwd + "')", Class1
                .con);

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@userrole", userrole);
            cmd.Parameters.AddWithValue("@password", pwd);

            MySqlDataReader myreader;
            myreader = cmd.ExecuteReader();
            MessageBox.Show("Save Data");

            // form 2 linking code

            {
                SetValueForText1 = textBox1.Text;
                SetValueForText2 = textBox2.Text;
                SetValueForText3 = textBox3.Text;

                Form2 frm2 = new Form2();
                frm2.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            {
                if (MessageBox.Show("Are you sure you want to delete this data?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Write code to delete data here
                    {
                        try
                        {
                            string query = "delete From Login Where username='" + this.textBox1.Text + "';'";

                            MySqlCommand Mycommand = new MySqlCommand(query, Class1.con);
                            MySqlDataReader Myreader2;
                           Class1.open_connection();

                            Myreader2 = Mycommand.ExecuteReader();
                            MessageBox.Show("Data Deleted");

                            Class1.close_connection();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
        }
    }
}




        
    

