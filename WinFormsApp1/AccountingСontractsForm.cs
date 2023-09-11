using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AccountingСontractsForm : Form
    {
        private IConfiguration _configuration;//создаем поле типа IConfiguration для доступа к конфигурационому файлу .json
        MainForm mainForm;
        public AccountingСontractsForm()
        {
            InitializeComponent();
            _configuration = (IConfiguration)ClassEditDB.Building();
        }
        public AccountingСontractsForm(MainForm form)
        {
            InitializeComponent();
            _configuration = (IConfiguration)ClassEditDB.Building();
            mainForm = form;
        }
        public void AddReport(string reportName, DataGridView dataGridView)
        {
            mainForm.AddReport(reportName, dataGridView1);
        }
        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            AddDataForm addDataForm = new AddDataForm("[Accounting contracts]");
            addDataForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    UpdateDataForm updateDataForm = new UpdateDataForm("[Accounting contracts]");
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
                    DeleteDataForm deleteDataForm = new DeleteDataForm("[Accounting contracts]");
                    deleteDataForm.Show();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormNewReport formNewReport = new FormNewReport("[Accounting contracts]", this);
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
                string sqlQuery = "SELECT [Event title] FROM [Accounting contracts]";

                // Создаем адаптер данных и передаем ему запрос и подключение к БД
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);

                // Создаем объект DataSet для хранения данных
                DataSet dataSet = new DataSet();

                // Заполняем DataSet данными из таблицы
                adapter.Fill(dataSet, "[Accounting contracts]");

                // Настраиваем свойства ComboBox
                comboBox1.DataSource = dataSet.Tables["[Accounting contracts]"];
                comboBox1.ValueMember = "Event title";
                comboBox1.DisplayMember = "[Event title]";
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
            string[] columnNames = {"[Contract number]", "[Event title]", "[Event sponsor]", "[Сost contract for us]",
                    "[Agreement status]", "[Contract start time]", "[Contract expiration time]", "[Contract clauses]", "Note" };
            ClassEditDB.CreateDBGrid(columnNames, EnumTableName.AccountingСontracts, connection, dataGridView, serchData);//вызываем метод для постоения грида
                                                                                                                          //изменяем название столбцов в DataGrid
            dataGridView.Columns["Contract number"].HeaderText = "Номер контракта";
            dataGridView.Columns["Event title"].HeaderText = "Название мероприятия";
            dataGridView.Columns["Event sponsor"].HeaderText = "Название компании спонсора";
            dataGridView.Columns["Сost contract for us"].HeaderText = "Стоимость контракта для нас";
            dataGridView.Columns["Agreement status"].HeaderText = "Статус договора";
            dataGridView.Columns["Contract start time"].HeaderText = "Начало действия контракта";
            dataGridView.Columns["Contract expiration time"].HeaderText = "Конец действия контракта";
            dataGridView.Columns["Contract clauses"].HeaderText = "Пункты договора";
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

        private void AccountingСontractsForm_Activated(object sender, EventArgs e)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    if (comboBox1.Visible == true)
                        RefreshDataGridView(dataGridView1, connection, $"Where [Event title] like ('{comboBox1.Text}')");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] columnNames = {"[Contract number]", "[Event title]", "[Event sponsor]", "[Сost contract for us]",
                    "[Agreement status]", "[Contract start time]", "[Contract expiration time]", "[Contract clauses]", "Note" };
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    if(textBox1.Text == "")
                        RefreshDataGridView(dataGridView1, connection, "");
                    RefreshDataGridView(dataGridView1, connection, $"Where [Event title] like '%{textBox1.Text}%' or [Event sponsor] like '%{textBox1.Text}%' or [Сost contract for us] like '%{textBox1.Text}%' OR " +
                        $"[Agreement status] like '%{textBox1.Text}%' OR [Contract start time] like '%{textBox1.Text}%' or [Contract clauses] like '%{textBox1.Text}%' OR " +
                        $"Note like '%{textBox1.Text}%'");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
        }
    }
}
