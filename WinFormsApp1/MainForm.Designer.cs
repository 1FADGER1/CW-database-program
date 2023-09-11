namespace WinFormsApp1
{
    partial class MainForm
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
            buttonExit = new Button();
            buttonAboutApp = new Button();
            labelNameDB = new Label();
            buttonAllUsers = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            comboBox2 = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            buttonContracts = new Button();
            buttonEvents = new Button();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            comboBox3 = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            labelUserLogin = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(885, 536);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(87, 33);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonAboutApp
            // 
            buttonAboutApp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAboutApp.Location = new Point(744, 536);
            buttonAboutApp.Name = "buttonAboutApp";
            buttonAboutApp.Size = new Size(125, 33);
            buttonAboutApp.TabIndex = 2;
            buttonAboutApp.Text = "О программе";
            buttonAboutApp.UseVisualStyleBackColor = true;
            buttonAboutApp.Click += buttonAboutApp_Click;
            // 
            // labelNameDB
            // 
            labelNameDB.AutoSize = true;
            labelNameDB.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelNameDB.Location = new Point(16, 20);
            labelNameDB.Name = "labelNameDB";
            labelNameDB.Size = new Size(271, 30);
            labelNameDB.TabIndex = 3;
            labelNameDB.Text = "Название базы данных:";
            // 
            // buttonAllUsers
            // 
            buttonAllUsers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAllUsers.Location = new Point(470, 536);
            buttonAllUsers.Name = "buttonAllUsers";
            buttonAllUsers.Size = new Size(258, 33);
            buttonAllUsers.TabIndex = 4;
            buttonAllUsers.Text = "Учетные записи пользователей";
            buttonAllUsers.UseVisualStyleBackColor = true;
            buttonAllUsers.Visible = false;
            buttonAllUsers.Click += buttonAllUsers_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 66);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(960, 448);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(checkBox1);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(buttonContracts);
            tabPage1.Controls.Add(buttonEvents);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(952, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Формы";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(615, 371);
            button4.Name = "button4";
            button4.Size = new Size(115, 34);
            button4.TabIndex = 15;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(454, 371);
            button3.Name = "button3";
            button3.Size = new Size(115, 34);
            button3.TabIndex = 14;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 342);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 7;
            button2.Text = "Сделать отчет";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(773, 371);
            button1.Name = "button1";
            button1.Size = new Size(115, 34);
            button1.TabIndex = 13;
            button1.Text = "Обновить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 150);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 19);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Фильтровать";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(6, 190);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(220, 23);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 172);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 10;
            label2.Text = "Выберите мероприятие";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 86);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 9;
            label1.Text = "Выберите таблицу";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(260, 11);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(679, 354);
            dataGridView1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Учет посещения мероприятия", "Участники проводящие мероприятие", "Спонсоры", "Дополнительные услуги", "О мероприятие" });
            comboBox1.Location = new Point(6, 104);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(220, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // buttonContracts
            // 
            buttonContracts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonContracts.Location = new Point(6, 42);
            buttonContracts.Name = "buttonContracts";
            buttonContracts.Size = new Size(180, 30);
            buttonContracts.TabIndex = 1;
            buttonContracts.Text = "Учет договоров";
            buttonContracts.UseVisualStyleBackColor = true;
            buttonContracts.Click += buttonContracts_Click;
            // 
            // buttonEvents
            // 
            buttonEvents.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEvents.Location = new Point(6, 6);
            buttonEvents.Name = "buttonEvents";
            buttonEvents.Size = new Size(220, 30);
            buttonEvents.TabIndex = 0;
            buttonEvents.Text = "Расписание мероприятий";
            buttonEvents.UseVisualStyleBackColor = true;
            buttonEvents.Click += buttonEvents_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(comboBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(952, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Отчеты";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 65);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(940, 349);
            dataGridView2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(6, 21);
            label3.Name = "label3";
            label3.Size = new Size(124, 21);
            label3.TabIndex = 1;
            label3.Text = "Выберите отчет";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(136, 23);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(196, 23);
            comboBox3.TabIndex = 0;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // labelUserLogin
            // 
            labelUserLogin.AutoSize = true;
            labelUserLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            labelUserLogin.Location = new Point(789, 9);
            labelUserLogin.Name = "labelUserLogin";
            labelUserLogin.Size = new Size(82, 20);
            labelUserLogin.TabIndex = 6;
            labelUserLogin.Text = "User_login";
            labelUserLogin.Click += labelUserLogin_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 581);
            Controls.Add(labelUserLogin);
            Controls.Add(tabControl1);
            Controls.Add(buttonAllUsers);
            Controls.Add(labelNameDB);
            Controls.Add(buttonAboutApp);
            Controls.Add(buttonExit);
            Name = "MainForm";
            Text = "Главное окно";
            Activated += MainForm_Activated;
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonExit;
        private Button buttonAboutApp;
        private Label labelNameDB;
        private Button buttonAllUsers;
        private TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public Label labelUserLogin;
        private TabPage tabPage1;
        private ComboBox comboBox1;
        private Button buttonContracts;
        private Button buttonEvents;
        private Label label2;
        private Label label1;
        private ComboBox comboBox2;
        private CheckBox checkBox1;
        private Button button1;
        private DataGridView dataGridView2;
        private Label label3;
        public ComboBox comboBox3;
        private TabControl tabControl1;
        public DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}