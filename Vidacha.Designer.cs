namespace Программа_библиотека
{
    partial class Vidacha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fIOChitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDChitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new Программа_библиотека.LibraryDataSet();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onhandsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet1 = new Программа_библиотека.LibraryDataSet1();
            this.readersTableAdapter = new Программа_библиотека.LibraryDataSetTableAdapters.ReadersTableAdapter();
            this.booksTableAdapter = new Программа_библиотека.LibraryDataSet1TableAdapters.BooksTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(150, 59);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 16;
            this.textBox5.Click += new System.EventHandler(this.textBox5_Click);
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ЛОГИН БИБЛИОТЕКАРЯ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "НОМЕР ЭКЗЕМПЛЯРА";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "НОМЕР ЧИТАТЕЛЯ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Выдать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fIOChitDataGridViewTextBoxColumn,
            this.iDChitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.readersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 131);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(236, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.Visible = false;
            // 
            // fIOChitDataGridViewTextBoxColumn
            // 
            this.fIOChitDataGridViewTextBoxColumn.DataPropertyName = "F_I_O_ Chit";
            this.fIOChitDataGridViewTextBoxColumn.HeaderText = "F_I_O_ Chit";
            this.fIOChitDataGridViewTextBoxColumn.Name = "fIOChitDataGridViewTextBoxColumn";
            // 
            // iDChitDataGridViewTextBoxColumn
            // 
            this.iDChitDataGridViewTextBoxColumn.DataPropertyName = "ID_Chit";
            this.iDChitDataGridViewTextBoxColumn.HeaderText = "ID_Chit";
            this.iDChitDataGridViewTextBoxColumn.Name = "iDChitDataGridViewTextBoxColumn";
            this.iDChitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // readersBindingSource
            // 
            this.readersBindingSource.DataMember = "Readers";
            this.readersBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(113, 20);
            this.textBox3.TabIndex = 19;
            this.textBox3.Visible = false;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(113, 20);
            this.textBox4.TabIndex = 20;
            this.textBox4.Visible = false;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDBookDataGridViewTextBoxColumn,
            this.nameBookDataGridViewTextBoxColumn,
            this.onhandsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.booksBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(10, 131);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 150);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.Visible = false;
            // 
            // iDBookDataGridViewTextBoxColumn
            // 
            this.iDBookDataGridViewTextBoxColumn.DataPropertyName = "ID_Book";
            this.iDBookDataGridViewTextBoxColumn.HeaderText = "ID_Book";
            this.iDBookDataGridViewTextBoxColumn.Name = "iDBookDataGridViewTextBoxColumn";
            this.iDBookDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameBookDataGridViewTextBoxColumn
            // 
            this.nameBookDataGridViewTextBoxColumn.DataPropertyName = "Name_Book";
            this.nameBookDataGridViewTextBoxColumn.HeaderText = "Name_Book";
            this.nameBookDataGridViewTextBoxColumn.Name = "nameBookDataGridViewTextBoxColumn";
            // 
            // onhandsDataGridViewTextBoxColumn
            // 
            this.onhandsDataGridViewTextBoxColumn.DataPropertyName = "On_hands";
            this.onhandsDataGridViewTextBoxColumn.HeaderText = "On_hands";
            this.onhandsDataGridViewTextBoxColumn.Name = "onhandsDataGridViewTextBoxColumn";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDataSet1;
            // 
            // libraryDataSet1
            // 
            this.libraryDataSet1.DataSetName = "LibraryDataSet1";
            this.libraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // readersTableAdapter
            // 
            this.readersTableAdapter.ClearBeforeFill = true;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(256, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Показать читателей";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(256, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Показать книги";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "ФИО ЧИТАТЕЛЯ";
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "НАЗВАНИЕ КНИГИ";
            this.label5.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(379, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Назад";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Vidacha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 322);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vidacha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vidacha";
            this.Load += new System.EventHandler(this.Vidacha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource readersBindingSource;
        private LibraryDataSetTableAdapters.ReadersTableAdapter readersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOChitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDChitDataGridViewTextBoxColumn;
        private LibraryDataSet1 libraryDataSet1;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDataSet1TableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn onhandsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
    }
}