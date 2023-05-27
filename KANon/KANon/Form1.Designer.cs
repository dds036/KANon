namespace KANon
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчиститьОкноЧатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.убратьБордерОкнаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьЦветФонаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.черныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.белыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.желтыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.цветШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.черныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.белыйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зеленыйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.желтыйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.звукToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключитьМузыкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьАнимацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПредприятииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.kaNonDBDataSet1 = new KANon.KANonDBDataSet();
            this.сообщенияTableAdapter1 = new KANon.KANonDBDataSetTableAdapters.СообщенияTableAdapter();
            this.tableAdapterManager1 = new KANon.KANonDBDataSetTableAdapters.TableAdapterManager();
            this.kANonDBDataSet11 = new KANon.KANonDBDataSet1();
            this.mailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mailsTableAdapter = new KANon.KANonDBDataSet1TableAdapters.MailsTableAdapter();
            this.tableAdapterManager = new KANon.KANonDBDataSet1TableAdapters.TableAdapterManager();
            this.сообщенияTableAdapter2 = new KANon.KANonDBDataSetTableAdapters.СообщенияTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.администраторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьДиалогToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaNonDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANonDBDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.звукToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.администраторToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пользовательToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.выходToolStripMenuItem1});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.выходToolStripMenuItem.Text = "Лог";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(151, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчиститьОкноЧатаToolStripMenuItem,
            this.убратьБордерОкнаToolStripMenuItem,
            this.сменитьЦветФонаToolStripMenuItem,
            this.цветШрифтаToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // отчиститьОкноЧатаToolStripMenuItem
            // 
            this.отчиститьОкноЧатаToolStripMenuItem.Name = "отчиститьОкноЧатаToolStripMenuItem";
            this.отчиститьОкноЧатаToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.отчиститьОкноЧатаToolStripMenuItem.Text = "Отчистить окно чата";
            // 
            // убратьБордерОкнаToolStripMenuItem
            // 
            this.убратьБордерОкнаToolStripMenuItem.Name = "убратьБордерОкнаToolStripMenuItem";
            this.убратьБордерОкнаToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.убратьБордерОкнаToolStripMenuItem.Text = "Убрать бордер окна";
            // 
            // сменитьЦветФонаToolStripMenuItem
            // 
            this.сменитьЦветФонаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.черныйToolStripMenuItem,
            this.белыйToolStripMenuItem,
            this.зеленыйToolStripMenuItem,
            this.желтыйToolStripMenuItem});
            this.сменитьЦветФонаToolStripMenuItem.Name = "сменитьЦветФонаToolStripMenuItem";
            this.сменитьЦветФонаToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.сменитьЦветФонаToolStripMenuItem.Text = "Цвет фона";
            // 
            // черныйToolStripMenuItem
            // 
            this.черныйToolStripMenuItem.Name = "черныйToolStripMenuItem";
            this.черныйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.черныйToolStripMenuItem.Text = "Черный";
            // 
            // белыйToolStripMenuItem
            // 
            this.белыйToolStripMenuItem.Name = "белыйToolStripMenuItem";
            this.белыйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.белыйToolStripMenuItem.Text = "Белый";
            // 
            // зеленыйToolStripMenuItem
            // 
            this.зеленыйToolStripMenuItem.Name = "зеленыйToolStripMenuItem";
            this.зеленыйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.зеленыйToolStripMenuItem.Text = "Зеленый";
            // 
            // желтыйToolStripMenuItem
            // 
            this.желтыйToolStripMenuItem.Name = "желтыйToolStripMenuItem";
            this.желтыйToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.желтыйToolStripMenuItem.Text = "Желтый";
            // 
            // цветШрифтаToolStripMenuItem
            // 
            this.цветШрифтаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.черныйToolStripMenuItem1,
            this.белыйToolStripMenuItem1,
            this.зеленыйToolStripMenuItem1,
            this.желтыйToolStripMenuItem1});
            this.цветШрифтаToolStripMenuItem.Name = "цветШрифтаToolStripMenuItem";
            this.цветШрифтаToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.цветШрифтаToolStripMenuItem.Text = "Цвет шрифта";
            // 
            // черныйToolStripMenuItem1
            // 
            this.черныйToolStripMenuItem1.Name = "черныйToolStripMenuItem1";
            this.черныйToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.черныйToolStripMenuItem1.Text = "Черный";
            // 
            // белыйToolStripMenuItem1
            // 
            this.белыйToolStripMenuItem1.Name = "белыйToolStripMenuItem1";
            this.белыйToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.белыйToolStripMenuItem1.Text = "Белый";
            // 
            // зеленыйToolStripMenuItem1
            // 
            this.зеленыйToolStripMenuItem1.Name = "зеленыйToolStripMenuItem1";
            this.зеленыйToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.зеленыйToolStripMenuItem1.Text = "Зеленый";
            // 
            // желтыйToolStripMenuItem1
            // 
            this.желтыйToolStripMenuItem1.Name = "желтыйToolStripMenuItem1";
            this.желтыйToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.желтыйToolStripMenuItem1.Text = "Желтый";
            this.желтыйToolStripMenuItem1.Click += new System.EventHandler(this.ЖелтыйToolStripMenuItem1_Click);
            // 
            // звукToolStripMenuItem
            // 
            this.звукToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выключитьМузыкуToolStripMenuItem,
            this.остановитьАнимацииToolStripMenuItem});
            this.звукToolStripMenuItem.Name = "звукToolStripMenuItem";
            this.звукToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.звукToolStripMenuItem.Text = "Окно";
            this.звукToolStripMenuItem.Click += new System.EventHandler(this.ЗвукToolStripMenuItem_Click);
            // 
            // выключитьМузыкуToolStripMenuItem
            // 
            this.выключитьМузыкуToolStripMenuItem.Name = "выключитьМузыкуToolStripMenuItem";
            this.выключитьМузыкуToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.выключитьМузыкуToolStripMenuItem.Text = "Выключить музыку";
            // 
            // остановитьАнимацииToolStripMenuItem
            // 
            this.остановитьАнимацииToolStripMenuItem.Name = "остановитьАнимацииToolStripMenuItem";
            this.остановитьАнимацииToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.остановитьАнимацииToolStripMenuItem.Text = "Остановить анимации";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.оПредприятииToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.ОПрограммеToolStripMenuItem_Click);
            // 
            // оПредприятииToolStripMenuItem
            // 
            this.оПредприятииToolStripMenuItem.Name = "оПредприятииToolStripMenuItem";
            this.оПредприятииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.оПредприятииToolStripMenuItem.Text = "О предприятии";
            this.оПредприятииToolStripMenuItem.Click += new System.EventHandler(this.ОПредприятииToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(875, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(12, 610);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(857, 63);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(875, 645);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Attach";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(637, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "KANon (Анонимный чат КАИ)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(949, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(933, 645);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(933, 610);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // kaNonDBDataSet1
            // 
            this.kaNonDBDataSet1.DataSetName = "KANonDBDataSet";
            this.kaNonDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сообщенияTableAdapter1
            // 
            this.сообщенияTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = KANon.KANonDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.ПользователиTableAdapter = null;
            this.tableAdapterManager1.СообщенияTableAdapter = this.сообщенияTableAdapter1;
            // 
            // kANonDBDataSet11
            // 
            this.kANonDBDataSet11.DataSetName = "KANonDBDataSet1";
            this.kANonDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mailsBindingSource
            // 
            this.mailsBindingSource.DataMember = "Mails";
            this.mailsBindingSource.DataSource = this.kANonDBDataSet11;
            // 
            // mailsTableAdapter
            // 
            this.mailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MailsTableAdapter = this.mailsTableAdapter;
            this.tableAdapterManager.UpdateOrder = KANon.KANonDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // сообщенияTableAdapter2
            // 
            this.сообщенияTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(976, 504);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // администраторToolStripMenuItem
            // 
            this.администраторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьДиалогToolStripMenuItem});
            this.администраторToolStripMenuItem.Name = "администраторToolStripMenuItem";
            this.администраторToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.администраторToolStripMenuItem.Text = "Администратор";
            this.администраторToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.администраторToolStripMenuItem.Visible = false;
            // 
            // очиститьДиалогToolStripMenuItem
            // 
            this.очиститьДиалогToolStripMenuItem.Name = "очиститьДиалогToolStripMenuItem";
            this.очиститьДиалогToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.очиститьДиалогToolStripMenuItem.Text = "Очистить диалог";
            this.очиститьДиалогToolStripMenuItem.Click += new System.EventHandler(this.ОчиститьДиалогToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1029, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KANon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaNonDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kANonDBDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчиститьОкноЧатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem убратьБордерОкнаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьЦветФонаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem черныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem белыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem желтыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem цветШрифтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem черныйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem белыйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зеленыйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem желтыйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem звукToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выключитьМузыкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПредприятииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьАнимацииToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private KANonDBDataSet kaNonDBDataSet1;
        private KANonDBDataSetTableAdapters.СообщенияTableAdapter сообщенияTableAdapter1;
        private KANonDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private KANonDBDataSet1 kANonDBDataSet11;
        private System.Windows.Forms.BindingSource mailsBindingSource;
        private KANonDBDataSet1TableAdapters.MailsTableAdapter mailsTableAdapter;
        private KANonDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private KANonDBDataSetTableAdapters.СообщенияTableAdapter сообщенияTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem администраторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьДиалогToolStripMenuItem;
    }
}

