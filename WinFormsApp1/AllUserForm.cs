using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AllUserForm : Form
    {
        private IConfiguration _configuration;//создаем поле типа IConfiguration для доступа к конфигурационому файлу .json
        MainForm mainForm;
        public AllUserForm()
        {
            InitializeComponent();
            //создаем переменную для работы с конфигурацией .json
            _configuration = (IConfiguration)ClassEditDB.Building();
        }
        public AllUserForm(MainForm form)
        {
            InitializeComponent();
            //создаем переменную для работы с конфигурацией .json
            _configuration = (IConfiguration)ClassEditDB.Building();
            mainForm = form;
        }
        public void AddReport(string reportName, DataGridView dataGridView)
        {
            mainForm.AddReport(reportName, dataGridView1);
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    UpdateDataForm updateDataForm = new UpdateDataForm("[System User]");
                    updateDataForm.Show();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    DeleteDataForm deleteDataForm = new DeleteDataForm("[System User]");
                    deleteDataForm.Show();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            AddDataForm addEventsForm = new AddDataForm("[System User]");
            addEventsForm.Show();

        }

        private void AllUserForm_Activated(object sender, EventArgs e)
        {
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    // Обновляем DataGridView.
                    RefreshDataGridView(dataGridView1, connection, "");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNewReport formNewReport = new FormNewReport("[System User]", formU: this);
            formNewReport.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            toolStripButton1.Visible = true;
            //подключаемся к БД
            /// Примечание: раньше использовали это string connectionString = @"Data Source=FADGER;Initial Catalog=AccEventsAndSeminars;Integrated Security=True";
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            SqlConnection connection = new SqlConnection(myConnectionString);
            //обработка исключений
            try
            {
                // Открываем подключение
                connection.Open();
                //string sqlQuery = "SELECT [Event title] FROM [Schedule events]";
                // Создаем запрос на получение данных из таблицы
                string sqlQuery = "SELECT [Full_name employee] FROM [System User]";

                // Создаем адаптер данных и передаем ему запрос и подключение к БД
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);

                // Создаем объект DataSet для хранения данных
                DataSet dataSet = new DataSet();

                // Заполняем DataSet данными из таблицы
                adapter.Fill(dataSet, "[System User]");

                // Настраиваем свойства ComboBox
                comboBox1.DataSource = dataSet.Tables["[System User]"];
                comboBox1.ValueMember = "Full_name employee";
                comboBox1.DisplayMember = "[Full_name employee]";
                // Получаем выбранный элемент комбо бокса
                // int selectedValue = (int)comboBox.SelectedValue;
                // string selectedText = comboBox.SelectedItem.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
            }
            finally
            {
                // закрываем подключение
                connection.Close();
            }
        }
        public static void RefreshDataGridView(DataGridView dataGridView, SqlConnection connection, string serchData)
        {
            // Здесь вы можете установить источник данных для вашего DataGridView 
            // или перезагрузить данные из источника данных.
            dataGridView.DataSource = null;
            string[] columnNames = {"Code_employee", "[Full_name employee]", "[Code position held]", "[Position held]", "Login",
                    "Password", "[Number phone]", "[Recovery code]", "E_mail", "Note" };
            ClassEditDB.CreateDBGrid(columnNames, EnumTableName.SystemUser, connection, dataGridView, serchData);//вызываем метод для постоения грида
            //изменяем название столбцов в DataGrid
            dataGridView.Columns["Full_name employee"].HeaderText = "ФИО сотрудника";
            dataGridView.Columns["Code position held"].HeaderText = "Код занимаемое должности";
            dataGridView.Columns["Position held"].HeaderText = "Занимаемая должность";
            dataGridView.Columns["Login"].HeaderText = "Логин";
            dataGridView.Columns["Password"].HeaderText = "Пароль";
            dataGridView.Columns["Number phone"].HeaderText = "Номер телефона";
            dataGridView.Columns["Recovery code"].HeaderText = "Код восстановления";
            dataGridView.Columns["E_mail"].HeaderText = "E_mail";
            dataGridView.Columns["Note"].HeaderText = "Примечание";
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            toolStripButton1.Visible = false;
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    RefreshDataGridView(dataGridView1, connection, "");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    if (comboBox1.Visible == true)
                        RefreshDataGridView(dataGridView1, connection, $"Where [Full_name employee] like ('{comboBox1.Text}')");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] columnNames = {"Code_employee", "[Full_name employee]", "[Code position held]", "[Position held]", "Login",
                    "Password", "[Number phone]", "[Recovery code]", "E_mail", "Note" };
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    if (textBox1.Text == "")
                        RefreshDataGridView(dataGridView1, connection, "");
                    RefreshDataGridView(dataGridView1, connection, $"Where [Full_name employee] like '%{textBox1.Text}%' or [Code position held] like '%{textBox1.Text}%' OR" +
                        $"[Position held] like '%{textBox1.Text}%' or Login like '%{textBox1.Text}%' or Password like '%{textBox1.Text}%' or [Number phone] like '%{textBox1.Text}%' or " +
                        $"[Recovery code] like '%{textBox1.Text}%' or E_mail like '%{textBox1.Text}%' or Note like '%{textBox1.Text}%'");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
        }
    }
}
