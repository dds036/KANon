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
using System.Net;

namespace KANon
{
    public partial class Form1 : Form
    {
        //Запросы
        string sqlRead = "SELECT Mails.Texts, Mails.Dates FROM Mails ORDER BY Mails.Dates DESC";
        
        



        //Публичные переменные
        private OleDbDataAdapter adapter = null;
        private DataTable table = null;
        private OleDbDataAdapter adapter2 = null;
        private DataTable table2 = null;
        DateTime localDate = DateTime.Now;
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\dds036\\Desktop\\КАНон\\KANon\\KANon\\KANonDB.accdb");
        int touchrows;



        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip tTip = new ToolTip();
            string host = System.Net.Dns.GetHostName();
            string ip = System.Net.Dns.GetHostByName(host).AddressList[0].ToString();



            //
            readfromBD();
            //



            OleDbCommand commandQ = new OleDbCommand();
            commandQ.Connection = connection;
            commandQ.CommandText = "SELECT Count(*) FROM Users where pc = '" + ip + "' ";
            OleDbDataReader comRead;
            if ((Int32)commandQ.ExecuteScalar()>0)
            {
               // OleDbCommand commandQ1 = new OleDbCommand();
                commandQ.Connection = connection;
                commandQ.CommandText = "SELECT admin FROM Users where pc = '" + ip + "' ";
                comRead = commandQ.ExecuteReader();
                comRead.Read();
                if ((Boolean)comRead[0] == true)
                {
                    администраторToolStripMenuItem.Visible = true;
                };
               
                comRead.Close();

            }
            else
            {
                OleDbCommand command1 = new OleDbCommand();
                command1.Connection = connection;
                command1.CommandText = "insert into Users (PC) values ('"+ ip +"')";
                command1.ExecuteNonQuery();
    
            }

           // touchrows = (int)commandQ.ExecuteScalar(); //Скаляр считает сколько строк было затронуто или нет??
           // MessageBox.Show(Convert.ToString(touchrows));


            



            //OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlRead, connection);
            //DataSet ds = new DataSet();
            //dataAdapter.Fill(ds, "[Miles]");
            //dataGridView1.DataSource = ds.Tables[0].DefaultView;

            tTip.SetToolTip(this.button1, "Отправить сообщение");
            tTip.SetToolTip(this.button2, "Приложить файл (в последующих обновлениях)");
            tTip.SetToolTip(this.textBox1, "Write here...");

            
        }
        public void readfromBD()
        {
            adapter = new OleDbDataAdapter(sqlRead, connection);
            DataTable ds = new DataTable();
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
         
            adapter.Fill(ds);
            dataGridView1.DataSource = ds;

        }
        // public void GetData();



        //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //textBox1.Text = null;
        //textBox1.ForeColor = Color.Black;
        //}

        public void GetDataFromMiles()
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
            string sql = "SELECT Mails.Texts, Mails.Dates FROM Mails ORDER BY Mails.Dates DESC";
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = sql;

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
                command.ExecuteNonQuery();

                //MessageBox.Show("Добавили " + command.ExecuteNonQuery() + " запись");
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            InsertRow();
            readfromBD();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ОчиститьДиалогToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show ("Вы уверены?", "Внимание", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "delete * from mails";
                command.ExecuteNonQuery();
                readfromBD();


            }
            
        }
    }
}
