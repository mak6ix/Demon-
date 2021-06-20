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
using System.Configuration;

namespace Программа_библиотека
{
    public partial class Readers : Form
    {
        public Readers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || maskedTextBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                if (textBox1.Text != "" || maskedTextBox1.Text != "" || textBox3.Text != "")
                {

                    con.Open();
                    SqlCommand com2 = new SqlCommand(@"INSERT dbo.[Readers] ([F.I.O. Chit], [Birthday], [Number Phone Chit]) Values (N'" + textBox1.Text + "',N'" + maskedTextBox1.Text + "',N'" + textBox3.Text + "')", con);
                    SqlDataReader r = com2.ExecuteReader();
                    r.Close();
                    MessageBox.Show("Читетль добавлен!");
                    con.Close();
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
