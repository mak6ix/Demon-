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
    public partial class Add_Book : Form
    {
        public Add_Book()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {

                if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "" || textBox5.Text != "" || textBox6.Text != "" || textBox7.Text != "" || textBox8.Text != "")
                {

                    con.Open();
                    SqlCommand com1 = new SqlCommand(@"INSERT dbo.Map_Book ([ID_Map], [Section], [Number_Cupboard], [Number_Shelf]) VALUES (N'" + textBox5.Text + "',N'" + textBox6.Text + "',N'" + textBox7.Text + "',N'" + textBox8.Text + "')", con);
                    SqlCommand com2 = new SqlCommand(@"INSERT dbo.Books ([Name_Book], [Autor], [Year], [Publication], [ID_Map]) Values (N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "',N'" + textBox4.Text + "',N'" + textBox5.Text + "')", con);
                    SqlDataReader r1 = com1.ExecuteReader();
                    r1.Close();
                    SqlDataReader r2 = com2.ExecuteReader();
                    r2.Close();
                    MessageBox.Show("Книга добавленна!");
                    con.Close();
                }


                con.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

