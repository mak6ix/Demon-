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
    public partial class Vidacha : Form
    {
        public Vidacha()
        {
            InitializeComponent();
        }
        

        private void Vidacha_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet1.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.libraryDataSet1.Books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet.Readers". При необходимости она может быть перемещена или удалена.
            this.readersTableAdapter.Fill(this.libraryDataSet.Readers);
            dataGridView1.Columns[0].HeaderText = "ФИО Читателя";
            dataGridView1.Columns[1].HeaderText = "Номер читателя";
            dataGridView2.Columns[0].HeaderText = "Номер экземпляра";
            dataGridView2.Columns[1].HeaderText = "Название книги";
            dataGridView2.Columns[2].HeaderText = "На руках";
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            else
            {

                if (textBox1.Text != "" || textBox2.Text != "")
                {
                    string gg = "еу";
                    con.Open();
                    SqlCommand sql = new SqlCommand(@"select On_hands from Books where ID_Book = '" + textBox2.Text + "'", con);
                    SqlDataReader sqlData = sql.ExecuteReader();
                    sqlData.Read();
                    gg = sqlData.IsDBNull(0) ? null : sqlData.GetString(0);
                    sqlData.Close();
                    con.Close();
                    
                    if (gg == "yes")
                    {
                        MessageBox.Show("Книга уже находится на руках!");
                        con.Close();
                    }
                    else
                    {
                        con.Open();
                        SqlCommand com2 = new SqlCommand(@"INSERT dbo.[Accounting] ([ID_Chit], [ID_Book], [Login_Pers]) Values (N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox5.Text + "')", con);
                        SqlDataReader r = com2.ExecuteReader();
                        r.Close();
                        DialogResult result = MessageBox.Show(
                        "Напечатать памятку читателя?",
                        "Сообщение",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                        con.Close();
                        if (result == DialogResult.Yes)
                        {
                            string fio;
                            string fio_pers;
                            con.Open();
                            SqlCommand typo = new SqlCommand(@"Select [F.I.O. Chit] from Readers where [ID_Chit] = '"+textBox1.Text+"'",con);
                            SqlDataReader tt = typo.ExecuteReader();
                            tt.Read();
                            fio = tt.GetString(0);
                            tt.Close();
                            con.Close();
                            con.Open();
                            SqlCommand command = new SqlCommand(@"Select [F.I.O. Pers] from Personnel where [Login_Pers] = '"+textBox5.Text+"'",con);
                            SqlDataReader reader = command.ExecuteReader();
                            reader.Read();
                            fio_pers = reader.GetString(0);
                            con.Close();
                            string date;
                            date = DateTime.Now.ToShortDateString();
                            var helper = new Memo("Памятка.docx");
                            var items = new Dictionary<string, string>
                            {
                                { "<bib>", fio_pers },
                                { "<chi>", fio  },
                                { "<date>", date  },
                            };
                            helper.Process(items);

                        }
                        MessageBox.Show("Книга выданна!");
                        con.Close();
                    
                    }
                    
                }


                
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            readersBindingSource.Filter = $"[F_I_O_ Chit] like '%{textBox3.Text}%'";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            booksBindingSource.Filter = $"Name_Book like '%{textBox4.Text}%'";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
            dataGridView1.Visible = true;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            label3.Visible = true;
            label5.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
            dataGridView2.Visible = true;
            textBox3.Visible = false;
            dataGridView1.Visible = false;
            label3.Visible = false;
            label5.Visible = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            dataGridView1.Visible = false;
            label3.Visible = false;
            textBox4.Visible = false;
            dataGridView2.Visible = false;
            label5.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
