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
using Microsoft.Extensions.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System.Collections;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        private IConfiguration _configuration;//создаем поле типа IConfiguration для доступа к конфигурационому файлу .json
        public MainForm()
        {
            InitializeComponent();
            //создаем переменную для работы с конфигурацией .json
            _configuration = (IConfiguration)ClassEditDB.Building();
            FormNewReport formNewReport = new FormNewReport(this);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//завершаем работу программы при нажатии на кнопку

        }

        private void buttonAboutApp_Click(object sender, EventArgs e)
        {
            //инициализируем объект и открываем форму, текущую оставляем в покое
            AboutAppForm aboutAppForm = new AboutAppForm();
            aboutAppForm.Show();
        }

        private void buttonAllUsers_Click(object sender, EventArgs e)
        {
            //инициализируем объект и открываем форму, текущую оставляем в покое
            AllUserForm allUserForm = new AllUserForm(this);
            allUserForm.Show();
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            //инициализируем объект и открываем форму, текущую оставляем в покое
            EventsForm eventsForm = new EventsForm(this);
            eventsForm.Show();
        }

        private void buttonContracts_Click(object sender, EventArgs e)
        {
            AccountingСontractsForm accountingСontractsForm = new AccountingСontractsForm(this);
            accountingСontractsForm.Show();
        }

        private void labelUserLogin_Click(object sender, EventArgs e)
        {
            //инициализируем объект и открываем форму, ссылку на текущую форму передаем
            ExitForm exitForm = new ExitForm(this);
            exitForm.Show();
            exitForm.label1.Text = $"Выйти из учетной записи {labelUserLogin.Text}?";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    switch (comboBox1.Text)
                    {
                        case "Учет посещения мероприятия":
                            string[] columnNamesEventAttendanceAccounting = { "[Number ticket]", "[Event title]", "[Full_name visitor]", "[Visit mark]",
                                "Seat", "[Invited guest]", "[Guest evaluation event]", "U.Note" };
                            if (checkBox1.Checked == true)
                                ClassEditDB.CreateDBGrid(columnNamesEventAttendanceAccounting, EnumTableName.EventAttendanceAccounting, connection, dataGridView1, $"AND A.[Event title] like('{comboBox2.Text}')");
                            else
                                ClassEditDB.CreateDBGrid(columnNamesEventAttendanceAccounting, EnumTableName.EventAttendanceAccounting, connection, dataGridView1, "");
                            //изменяем название столбцов в DataGrid
                            string[] headersEventAttendanceAccounting = { "Номер билета", "Название мероприятия", "ФИО посетителя", "Метка посещения", "Место сидения",
                                "Приглашенный гость", "Оценка мероприятия гостем", "Примечание" };
                            ClassEditDB.SetColumnHeaders(dataGridView1, columnNamesEventAttendanceAccounting, headersEventAttendanceAccounting);
                            break;
                        case "Участники проводящие мероприятие":
                            string[] columnNamesParticipantsHostingEvent = { "Code_participant", "[Full_name participant]", "Topic", "[Event title]",
                                "[Start time]", "Duration", "[Participant salary]", "[Short description]", "U.Note" };
                            if (checkBox1.Checked == true)
                                ClassEditDB.CreateDBGrid(columnNamesParticipantsHostingEvent, EnumTableName.ParticipantsHostingEvent, connection, dataGridView1, $"AND A.[Event title] like('{comboBox2.Text}')");
                            else
                                ClassEditDB.CreateDBGrid(columnNamesParticipantsHostingEvent, EnumTableName.ParticipantsHostingEvent, connection, dataGridView1, "");
                            //изменяем название столбцов в DataGrid
                            string[] headersParticipantsHostingEvent = { "Код участника", "ФИО участника", "Тема выступления", "Название мероприятия", "Время начала",
                                "Время выступления", "Оклад участника", "Краткое описание", "Примечание" };
                            ClassEditDB.SetColumnHeaders(dataGridView1, columnNamesParticipantsHostingEvent, headersParticipantsHostingEvent);
                            break;
                        case "Спонсоры":
                            string[] columnNamesSponsors = { "U.[Contract number]", "[Event title]", "[Name company]", "U.[Allocated budget]",
                                "[Legal address company]", "TIN", "[Assessment cooperation organization]", "U.Note" };
                            if (checkBox1.Checked == true)
                                ClassEditDB.CreateDBGrid(columnNamesSponsors, EnumTableName.Sponsors, connection, dataGridView1, $"AND A.[Event title] like('{comboBox2.Text}')");
                            else
                                ClassEditDB.CreateDBGrid(columnNamesSponsors, EnumTableName.Sponsors, connection, dataGridView1, "");
                            //изменяем название столбцов в DataGrid
                            string[] headersSponsors = { "Номер контракта", "Название мероприятия", "Название компании", "Выделенный бюджет",
                                "Юридический адрес", "ИНН", "Оценка сотрудничества с организацией", "Примечание" };
                            ClassEditDB.SetColumnHeaders(dataGridView1, columnNamesSponsors, headersSponsors);
                            break;
                        case "Дополнительные услуги":
                            string[] columnNamesAdditionalServices = { "[Service number]", "[Title service]", "[Event title]", "[Service provider company name]",
                                "[Assessment cooperation organization]", "U.Note" };
                            if (checkBox1.Checked == true)
                                ClassEditDB.CreateDBGrid(columnNamesAdditionalServices, EnumTableName.AdditionalServices, connection, dataGridView1, $"AND A.[Event title] like('{comboBox2.Text}')");
                            else
                                ClassEditDB.CreateDBGrid(columnNamesAdditionalServices, EnumTableName.AdditionalServices, connection, dataGridView1, "");
                            //изменяем название столбцов в DataGrid
                            string[] headersAdditionalServices = { "Номер услуги", "Название услуги", "Название контракта", "Название компании-поставщика",
                                "Оценка сотрудничества с организацией", "Примечание" };
                            ClassEditDB.SetColumnHeaders(dataGridView1, columnNamesAdditionalServices, headersAdditionalServices);
                            break;
                        case "О мероприятие":
                            string[] columnNamesAboutEvent = { "Speech_code", "A.[Event title]", "[Performance time]", "Topic",
                                "[Cost visiting]", "[Full_name participant]", "[Break time]", "U.Note" };
                            if (checkBox1.Checked == true)
                                ClassEditDB.CreateDBGrid(columnNamesAboutEvent, EnumTableName.AboutEvent, connection, dataGridView1, $"AND A.[Event title] like('{comboBox2.Text}')");
                            else
                                ClassEditDB.CreateDBGrid(columnNamesAboutEvent, EnumTableName.AboutEvent, connection, dataGridView1, "");
                            //изменяем название столбцов в DataGrid
                            string[] headersAboutEvent = { "Код выступления", "Название мероприятия",
                                "Время выступления", "Тема выступления","Стоимость посещения мероприятия", "ФИО участника", "Время перерыва", "Примечание" };
                            ClassEditDB.SetColumnHeaders(dataGridView1, columnNamesAboutEvent, headersAboutEvent);
                            break;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1_SelectedIndexChanged(sender, e);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = checkBox1.Checked == true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDataForm updateDataForm = new UpdateDataForm(comboBox1.Text);
            updateDataForm.Show();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            //подключаемся к БД
            /// Примечание: раньше использовали это string connectionString = @"Data Source=FADGER;Initial Catalog=AccEventsAndSeminars;Integrated Security=True";
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            SqlConnection connection = new SqlConnection(myConnectionString);
            //обработка исключений
            try
            {
                // Открываем подключение
                connection.Open();
                labelNameDB.Text = "Название базы данных: " + Convert.ToString(connection.Database);//определяем название базы данных
                buttonAllUsers.Visible = SignInForm.admin;
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
                comboBox2.DataSource = dataSet.Tables["[Schedule events]"];
                comboBox2.ValueMember = "Event title";
                comboBox2.DisplayMember = "[Event title]";
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
            checkBox1_CheckedChanged(sender, e);
        }
        Dictionary<string, object> ReportInDataGrid = new Dictionary<string, object>();
        public void AddReport(string reportName, DataGridView dataGridView)
        {
            try
            {
                this.comboBox3.Items.Add(reportName);
                ReportInDataGrid.Add(reportName, dataGridView.DataSource);
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка: " + e.Message + " Такой ключ уже существует");
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                string key = comboBox3.Text;
                if (ReportInDataGrid.ContainsKey(key))
                {
                    dataGridView2.DataSource = ReportInDataGrid[key];
                    // другие свойства дата грида могут быть настроены здесь
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormNewReport formNewReport = new FormNewReport("", this);
            formNewReport.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddDataForm addDataForm = new AddDataForm(comboBox1.Text);
            addDataForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    DeleteDataForm deleteDataForm = new DeleteDataForm(comboBox1.Text);
                    deleteDataForm.Show();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FormNewReport formNewReport = new FormNewReport(this);
            Task.Run(() => SaveAs.SavingXML());
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            ChooseForm chooseForm = new ChooseForm(this);
            chooseForm.Show();
        }
    }
}
