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

namespace Программа_библиотека
{
    public partial class Join : Form
    {
        public Join()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nick = textBox1.Text;
            string pass = textBox2.Text;
            string myConnectionString = @"Data Source=DESKTOP-J15L8AS\SQLEXPRESS; Initial Catalog=Library; Integrated Security=SSPI";
            string mySelectQuery = "SELECT * FROM [Personnel] WHERE [Login_Pers] = '" + nick + "'and [Password_Pers]='" + pass + "'";
            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(mySelectQuery, myConnectionString))
            {
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Такого пользователя не существует");
                }
                else
                { 
                    
                    this.Hide();
                    Form2 typ = new Form2();
                    typ.Closed += (s, args) => this.Close();
                    typ.Show();
                }
            }
        }
    }
}
