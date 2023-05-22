using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace KANon
{
    public partial class Form1 : Form
    {
        DateTime localDate = DateTime.Now;
        string connectionString = ConfigurationManager.ConnectionStrings["MS_Access_DatabaseConnectionString"].ConnectionString;
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Denis\\Desktop\\Проект\\КАНон\\KANon\\KANon\\KANonDB.accdb");
        public Form1()

        {
            
            InitializeComponent();

        }

       private void Form1_Load(object sender, EventArgs e)
       {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kANonDBDataSet11.Mails". При необходимости она может быть перемещена или удалена.
            //this.mailsTableAdapter.Fill(this.kANonDBDataSet11.Mails);

            //textBox1.Text = "Write here...";
            //textBox1.ForeColor = Color.Gray;
            ToolTip tTip = new ToolTip();

            tTip.SetToolTip(this.button1, "Отправить сообщение");
            tTip.SetToolTip(this.button2, "Приложить файл (в последующих обновлениях)");
            tTip.SetToolTip(this.textBox1, "Write here...");
            mailsBindingSource.DataSource = GetData("Select * From Mails order by id DESC");
            dataGridView1.DataSource = mailsBindingSource;


        }
        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //textBox1.Text = null;
        //textBox1.ForeColor = Color.Black;
        //}

        public DataTable GetData(string sqlCommand) 
        {

            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            SqlConnection northwindConnection = new SqlConnection(connectionString);

            SqlCommand command = new SqlCommand(sqlCommand, northwindConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            return table;
        }

        private void ЖелтыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ЗвукToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 examp = new Form2();
            examp.Show();
        }

        private void ОПредприятииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 examp = new Form3();
            examp.Show();
        }

        public void InsertRow()
        {
            
           // using (OleDbConnection connection = new OleDbConnection(connectionString))
            {

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                }
                catch
                {
                    MessageBox.Show("Ошибка соединения с базой");
                }
                string sql = "insert into mails (Texts) values (@Texts)";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = sql;
                command.Parameters.AddWithValue("@Texts", textBox1.Text);
                
                
                MessageBox.Show("Добавили " + command.ExecuteNonQuery() + " запись");
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            InsertRow();
            //DateTime localDate = DateTime.Now;
            //using (OleDbConnection connection = new OleDbConnection(connectionString))
            //{

            //    try
            //    {
            //        if (connection.State == ConnectionState.Closed)
            //        {
            //            connection.Open();
            //        }

            //    }
            //    catch
            //    {
            //        MessageBox.Show("Ошибка соединения с базой");
            //    }
            //    string sql = "insert into mails (Texts, Dates) values (@Texts, @Dates)";
            //    OleDbCommand command = new OleDbCommand();
            //    command.Connection = connection;
            //    command.CommandText = sql;
            //    command.Parameters.AddWithValue("@Texts", textBox1.Text);
            //    command.Parameters.AddWithValue("@Dates", localDate);
            //    int rows = command.ExecuteNonQuery();
            //    //MessageBox.Show("Добавили " + rows.ToString() + " запись");
            //}
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
