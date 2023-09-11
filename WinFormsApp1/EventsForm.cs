using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
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
using System.Xml;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class EventsForm : Form
    {
        private IConfiguration _configuration;//создаем поле типа IConfiguration для доступа к конфигурационому файлу .json
        MainForm mainForm;
        public EventsForm()
        {
            InitializeComponent();
            //создаем переменную для работы с конфигурацией .json
            _configuration = (IConfiguration)ClassEditDB.Building();
        }
        public EventsForm(MainForm form)
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
        //класс для обновления грида
        public static void RefreshDataGridView(DataGridView dataGridView, SqlConnection connection, string serchData)
        {
            // Здесь вы можете установить источник данных для вашего DataGridView 
            // или перезагрузить данные из источника данных.
            dataGridView.DataSource = null;
            string[] columnNames = { "Code_Event", "[Event title]", "[Event date]", "[Event time]", "[Invited guests]",
                    "[Event sponsor]", "[Contract number]", "[Allocated budget]", "[Closedness event]",
                    "[Number people attending event]", "[Total revenue]", "[Event evaluation]", "Note" };
            ClassEditDB.CreateDBGrid(columnNames, EnumTableName.ScheduleEvents, connection, dataGridView, $"{serchData}");//вызываем метод для постоения грида

            //изменяем название столбцов в DataGrid
            dataGridView.Columns["Event title"].HeaderText = "Название мероприятия";
            dataGridView.Columns["Event date"].HeaderText = "Дата проведения";
            dataGridView.Columns["Event time"].HeaderText = "Время проведения";
            dataGridView.Columns["Invited guests"].HeaderText = "Приглашенные гости";
            dataGridView.Columns["Event sponsor"].HeaderText = "Спонсор мероприятия";
            dataGridView.Columns["Contract number"].HeaderText = "Номер договора с клиентом";
            dataGridView.Columns["Allocated budget"].HeaderText = "Выделенный бюджет";
            dataGridView.Columns["Closedness event"].HeaderText = "Закрытость мероприятия";
            dataGridView.Columns["Number people attending event"].HeaderText = "Колличество людей посетивших мероприятие";
            dataGridView.Columns["Total revenue"].HeaderText = "Итоговая выручка";
            dataGridView.Columns["Event evaluation"].HeaderText = "Оценка мероприятия";
            dataGridView.Columns["Note"].HeaderText = "Примечание";
        }
        private void EventsForm_Activated(object sender, EventArgs e)
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
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // если клик правой кнопкой мыши
            {
                var row = dataGridView1.Rows[e.RowIndex]; // выбранная строка
                dataGridView1.ClearSelection(); // снимаем выделение со всех ячеек
                row.Selected = true; // выделяем всю строку
                contextMenuStrip1.Show(MousePosition); // выводим контекстное меню в месте, где был сделан клик
            }
        }

        private void EventsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            AddDataForm addEventsForm = new AddDataForm("[Schedule events]");
            addEventsForm.Show();
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    DeleteDataForm deleteDataForm = new DeleteDataForm("[[Schedule events]]");
                    deleteDataForm.Show();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    UpdateDataForm updateDataForm = new UpdateDataForm("[Schedule events]");
                    updateDataForm.Show();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
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
                string sqlQuery = "SELECT [Event title] FROM [Schedule events]";

                // Создаем адаптер данных и передаем ему запрос и подключение к БД
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);

                // Создаем объект DataSet для хранения данных
                DataSet dataSet = new DataSet();

                // Заполняем DataSet данными из таблицы
                adapter.Fill(dataSet, "[Schedule events]");

                // Настраиваем свойства ComboBox
                comboBox1.DataSource = dataSet.Tables["[Schedule events]"];
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

        private void button1_Click(object sender, EventArgs e)
        {
            FormNewReport formNewReport = new FormNewReport("[Schedule events]", this);
            formNewReport.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] columnNames = { "Code_Event", "[Event title]", "[Event date]", "[Event time]", "[Invited guests]",
                    "[Event sponsor]", "[Contract number]", "[Allocated budget]", "[Closedness event]",
                    "[Number people attending event]", "[Total revenue]", "[Event evaluation]", "Note" };
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    if (textBox1.Text == "")
                        RefreshDataGridView(dataGridView1, connection, "");
                    RefreshDataGridView(dataGridView1, connection, $"Where [Event title] like '%{textBox1.Text}%' OR [Event date] like '%{textBox1.Text}%' OR [Event time] like '%{textBox1.Text}%' OR " +
                        $"[Invited guests] like '%{textBox1.Text}%' OR [Event sponsor] like ('{textBox1.Text}') OR [Contract number] like '%{textBox1.Text}%' OR [Allocated budget] like '%{textBox1.Text}%' OR [Closedness event] like '%{textBox1.Text}%' OR [Number people attending event] like '%{textBox1.Text}%' OR " +
                        $"[Total revenue] like '%{textBox1.Text}%' OR [Event evaluation] like '%{textBox1.Text}%' OR Note like '%{textBox1.Text}%'");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
        }
    }
}
