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


namespace KANon
{
    public partial class Form1 : Form
    {
        
       public Form1()
       {
            
            InitializeComponent();
       }

       private void Form1_Load(object sender, EventArgs e)
       {
            
            //textBox1.Text = "Write here...";
            //textBox1.ForeColor = Color.Gray;
            ToolTip tTip = new ToolTip();

            tTip.SetToolTip(this.button1, "Отправить сообщение");
            tTip.SetToolTip(this.button2, "Приложить файл (в последующих обновлениях)");
            tTip.SetToolTip(this.textBox1, "Write here...");
       }
       //private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
       //{
           //textBox1.Text = null;
           //textBox1.ForeColor = Color.Black;
       //}



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

        private void Button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            //int kod;
           // kaNonDBDataSetTableAdapters.сообщенияTableAdapter1 сообщенияTableAdapter1 = new kaNonDBDataSetTableAdapters.сообщенияTableAdapter1();
            KANonDBDataSet.СообщенияRow newСообщенияRow;
            newСообщенияRow = kaNonDBDataSet1.Сообщения.NewСообщенияRow();
         //   newСообщенияRow.Код = kod = 1;
            newСообщенияRow.Текст_сообщения = textBox1.Text;
            MessageBox.Show(textBox1.Text);
            this.kaNonDBDataSet1.Сообщения.Rows.Add(newСообщенияRow);
            this.сообщенияTableAdapter1.Update(this.kaNonDBDataSet1.Сообщения);
            this.сообщенияTableAdapter1.Insert(textBox1.Text, dateTime);
           // kod++;
        }
    }
}
