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
    public partial class Writedowns : Form
    {
        public Writedowns()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand sql = new SqlCommand(@"Select [F.I.O. Pers] from Personnel where Login_Pers = '" + textBox4.Text + "'", con);
            SqlDataReader reader = sql.ExecuteReader();
            reader.Read();
            string fio = reader.GetString(0);
            reader.Close();
            con.Close();
            con.Open();
            SqlCommand nameBook1 = new SqlCommand(@"Select Name_Book from Books where ID_Book = '" + textBox1.Text + "'", con);
            SqlDataReader dataReader = nameBook1.ExecuteReader();
            dataReader.Read();
            string nameBook = dataReader.GetString(0);
            dataReader.Close();
            string date;
            date = DateTime.Now.ToShortDateString();
            if (textBox3.Text == "")
            {
                var helper = new ClassWriteDown("Списание_книги.docx");
                var items = new Dictionary<string, string>
                {
                    {"<biba>", fio  },
                    {"<book>", nameBook },
                    {"<id_book>", textBox1.Text },
                    {"<prichina>", textBox2.Text },
                    {"<date>", date },
                };
                helper.Process(items);
                con.Close();
                con.Open();
                SqlCommand oo = new SqlCommand(@"delete from Accounting where ID_Book = '" + textBox1.Text + "'", con);
                SqlCommand pp = new SqlCommand(@"Delete from Bookks where Id_book = '" + textBox1.Text + "'", con);
                SqlCommand sql11 = new SqlCommand(@"delete from Map_Book where ID_Map in (select ID_Map from Books where ID_Book = '" + textBox1.Text + "'", con);
                SqlDataReader ll = oo.ExecuteReader();
                ll.Read();
                ll.Close();
                con.Close();
                con.Open();
                SqlDataReader tt = sql11.ExecuteReader();
                tt.Read();
                tt.Close();
                con.Close();
                con.Open();
                SqlDataReader rr = pp.ExecuteReader();
                rr.Read();
                rr.Close();
                con.Close();
                
            }

            else
            {
                SqlCommand readerBook = new SqlCommand(@"Select [F.I.O. Chit] from Readers where [ID_Chit] = '"+textBox3.Text+"'",con);
                SqlDataReader sqlDataReader = readerBook.ExecuteReader();
                sqlDataReader.Read();
                string chit = sqlDataReader.GetString(0);

                var helper = new ClassWriteDownReader("Списание_книги_штраф.docx");
                var items = new Dictionary<string, string>
                {
                    {"<bibliotekar>", fio },
                    {"<fio_chit>", chit },
                    {"<prihina>", textBox2.Text },
                    {"<book>", nameBook },
                    {"<id_book>", textBox1.Text },
                    {"<date>", date }
                };
                con.Close();
                helper.Process(items);
                con.Open();
                SqlCommand oo = new SqlCommand(@"delete from Accounting where ID_Book = '"+textBox1.Text+"'",con);
                SqlCommand pp = new SqlCommand(@"Delete from Books where Id_book = '"+textBox1.Text+"'",con);
                SqlCommand sql11 = new SqlCommand(@"delete from Map_Book where ID_Map in (select ID_Map from Books where ID_Book = '" + textBox1.Text + "')",con);
                SqlDataReader ll = oo.ExecuteReader();
                ll.Read();
                ll.Close();
                con.Close();
                con.Open();
                SqlDataReader tt = sql11.ExecuteReader();
                tt.Read();
                tt.Close();
                con.Close();
                con.Open();
                SqlDataReader rr = pp.ExecuteReader();
                rr.Read();
                rr.Close();
                con.Close();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
