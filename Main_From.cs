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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        private void button4_Click(object sender, EventArgs e)
        {
            Add_Book _Book = new Add_Book();
            _Book.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vidacha vidacha = new Vidacha();
            vidacha.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Readers vidacha = new Readers();
            vidacha.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                MessageBox.Show("Введите номер экземпляра книги!");
            }
            else
            {
                con.Open();
                string jj;
                SqlCommand sql = new SqlCommand(@"Select On_hands from Books where ID_Book= '"+textBox11.Text+"'",con);
                SqlDataReader reader = sql.ExecuteReader();
                reader.Read();
                jj = reader.IsDBNull(0) ? null : reader.GetString(0);
                reader.Close();
                con.Close();
                if (jj == "yes")
                {
                    con.Open();
                    SqlDataReader read2 = new SqlCommand(@" UPDATE Books set On_hands=(NULL) WHERE ID_Book = '" + textBox11.Text + "'", con).ExecuteReader();
                    read2.Close();
                    SqlDataReader read1 = new SqlCommand(@" DELETE FROM dbo.Accounting WHERE [ID_book] = '" + textBox11.Text + "'", con).ExecuteReader();
                    read1.Close();
                    con.Close();
                    MessageBox.Show("Книга сдана!");
                }
                else
                {
                    MessageBox.Show("Книга не находится на руках!");
                    con.Close();
                }
                
            }
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet8.ЖурналУчёта". При необходимости она может быть перемещена или удалена.
            this.журналУчётаTableAdapter1.Fill(this.libraryDataSet8.ЖурналУчёта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet7.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter1.Fill(this.libraryDataSet7.Книги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet6.Книги". При необходимости она может быть перемещена или удалена.
            this.книгиTableAdapter.Fill(this.libraryDataSet6.Книги);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet5.ЖурналУчёта". При необходимости она может быть перемещена или удалена.
            this.журналУчётаTableAdapter.Fill(this.libraryDataSet5.ЖурналУчёта);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet4.Readers". При необходимости она может быть перемещена или удалена.
            this.readersTableAdapter.Fill(this.libraryDataSet4.Readers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet3.Books". При необходимости она может быть перемещена или удалена.
            this.booksTableAdapter.Fill(this.libraryDataSet3.Books);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "libraryDataSet2.Accounting". При необходимости она может быть перемещена или удалена.
            this.accountingTableAdapter.Fill(this.libraryDataSet2.Accounting);
            dataGridView5.Columns[0].HeaderText = "ФИО читателя";
            dataGridView5.Columns[1].HeaderText = "День рождения";
            dataGridView5.Columns[2].HeaderText = "Номер телефона";
            dataGridView5.Columns[3].HeaderText = "Номер читателя";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Writedowns formf = new Writedowns();
            formf.ShowDialog();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView4.DataSource;
            bs.Filter = string.Format("CONVERT(" + ("[Название книги]") + ", System.String) like '%" + textBox9.Text + "%' and [Автор] like '%"+textBox8.Text+"%'");
            dataGridView4.DataSource = bs;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView3.DataSource;
            bs.Filter = string.Format("CONVERT(" + ("Читатель") + ", System.String) like '%" + textBox4.Text + "%' and [Название книги] like '%" + textBox7.Text + "%'");
            dataGridView3.DataSource = bs;

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView4.DataSource;
            bs.Filter = string.Format("CONVERT(" + ("[Год издания]") + ", System.String) like '%" + textBox12.Text + "'");
            dataGridView4.DataSource = bs;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView5.DataSource;
            bs.Filter = string.Format("CONVERT(" + ("[F_I_O_ Chit]") + ", System.String) like '%" + textBox10.Text + "%'");
            dataGridView5.DataSource = bs;
        }
        //like '%" + textBox9.Text.Replace("'","''") + "%'" + "and [Автор] like '%" + textBox8.Text + "%'" + "and [На руках] like '%" + comboBox3;
    }
}
