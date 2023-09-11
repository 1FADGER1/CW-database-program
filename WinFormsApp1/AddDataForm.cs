using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using System.Xml;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WinFormsApp1.EventsForm;

namespace WinFormsApp1
{
    public partial class AddDataForm : Form
    {
        private IConfiguration _configuration;//создаем поле типа IConfiguration для доступа к конфигурационому файлу .json
        public AddDataForm()
        {
            InitializeComponent();
            //создаем переменную для работы с конфигурацией .json
            _configuration = (IConfiguration)ClassEditDB.Building();
        }

        //метод получения оценки из радиобатон в группе
        private int GetSelectedRadioValue()
        {
            var selectedRadio = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            if (selectedRadio != null)
            {
                return Convert.ToInt32(selectedRadio.Tag);
            }
            return -1; // возврат значения по умолчанию
        }

        public AddDataForm(string s)
        {
            InitializeComponent();
            comboBox2.Visible = false;
            label17.Text += s;
            //создаем переменную для работы с конфигурацией .json
            _configuration = (IConfiguration)ClassEditDB.Building();
            SerchEnumTableName(s);
        }
        EnumTableName nameTable;
        public void SerchEnumTableName(string tableName)
        {
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dateTimePicker3.ShowUpDown = true;
            switch (tableName)
            {
                case "[Schedule events]":
                    nameTable = EnumTableName.ScheduleEvents;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;
                    textBoxBudget.Visible = true;
                    textBoxCountPeople.Visible = true;
                    textBoxGuests.Visible = true;
                    textBoxNote.Visible = true;
                    textBoxRevenue.Visible = true;
                    textBoxSponsor.Visible = true;
                    textBoxTime.Visible = true;
                    textBoxTitle.Visible = true;
                    dateTimePicker1.Visible = true;
                    comboBox1.Visible = true;
                    groupBox1.Visible = true;
                    checkBoxClosedness.Visible = true;
                    break;
                case "[System User]":
                    nameTable = EnumTableName.SystemUser;
                    label17.Visible = true;
                    label18.Visible = true;
                    label19.Visible = true;
                    label20.Visible = true;
                    label21.Visible = true;
                    label22.Visible = true;
                    label23.Visible = true;
                    label24.Visible = true;
                    label25.Visible = true;
                    label26.Visible = true;
                    label27.Visible = true;
                    label28.Visible = true;
                    label29.Visible = true;
                    label30.Visible = true;
                    label31.Visible = true;
                    label32.Visible = true;
                    textBoxCode.Visible = true;
                    textBoxCodeHeld.Visible = true;
                    textBoxFullName.Visible = true;
                    textBoxHeld.Visible = true;
                    textBoxLogin.Visible = true;
                    textBoxMail.Visible = true;
                    textBoxPassword.Visible = true;
                    textBoxPhone.Visible = true;
                    textBoxNoteUser.Visible = true;
                    break;
                case "[Accounting contracts]":
                    nameTable = EnumTableName.AccountingСontracts;
                    label40.Visible = true;
                    label40.Text = "Примечание";
                    label39.Visible = true;
                    label39.Text = "Статус договора";
                    label34.Visible = true;
                    label34.Text = "Спонсор";
                    label38.Visible = true;
                    label38.Text = "Конец действия контракта";
                    label37.Visible = true;
                    label37.Text = "Начало действия контракта";
                    label36.Visible = true;
                    label36.Text = "Стоимость контракта для нас";
                    label35.Visible = true;
                    label35.Text = "Пункты договора";
                    label33.Visible = true;
                    label33.Text = "Название мероприятия";
                    label41.Visible = true;
                    label42.Visible = true;
                    label43.Visible = true;
                    label44.Visible = true;
                    label45.Visible = true;
                    label46.Visible = true;
                    label48.Visible = true;
                    textBox8.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    dateTimePicker3.Visible = true;
                    dateTimePicker2.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    break;
                case "Учет посещения мероприятия":
                    nameTable = EnumTableName.EventAttendanceAccounting;
                    label39.Visible = true;
                    label39.Text = "Примечание";
                    label34.Visible = true;
                    label34.Text = "Место сидения";
                    groupBox1.Visible = true;
                    groupBox1.Location = new System.Drawing.Point(447, 216);
                    groupBox1.Text = "* Оценка мероприятия гостем";
                    checkBox2.Visible = true;
                    checkBoxClosedness.Visible = true;
                    checkBoxClosedness.Location = new System.Drawing.Point(167, 225);
                    checkBoxClosedness.Text = "Метка посещения";
                    label35.Visible = true;
                    label35.Text = "ФИО посетителя";
                    label33.Visible = true;
                    label33.Text = "Код мероприя";
                    label41.Visible = true;
                    label44.Visible = true;
                    textBox8.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox7.Visible = true;
                    break;
                case "Участники проводящие мероприятие":
                    nameTable = EnumTableName.ParticipantsHostingEvent;
                    label40.Visible = true;
                    label40.Text = "Примечание";
                    label39.Visible = true;
                    label39.Text = "Краткое описание";
                    label34.Visible = true;
                    label34.Text = "Оклад участника";
                    label38.Visible = true;
                    label38.Text = "Время выступления";
                    label37.Visible = true;
                    label37.Text = "Время начала";
                    label36.Visible = true;
                    label36.Text = "Код мероприятия";
                    label35.Visible = true;
                    label35.Text = "Тема выступления";
                    label33.Visible = true;
                    label33.Text = "ФИО участника";
                    label41.Visible = true;
                    label44.Visible = true;
                    label45.Visible = true;
                    label46.Visible = true;
                    label42.Visible = true;
                    dateTimePicker2.Visible = true;
                    dateTimePicker3.Visible = true;
                    textBox8.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    break;
                case "Спонсоры":
                    nameTable = EnumTableName.Sponsors;
                    label39.Visible = true;
                    label39.Text = "Примечание";
                    label34.Visible = true;
                    label34.Text = "ИНН";
                    label37.Visible = true;
                    label37.Text = "Юридический адрес";
                    label36.Visible = true;
                    label36.Text = "Выделенный бюджет";
                    label35.Visible = true;
                    label35.Text = "Название компании";
                    label33.Visible = true;
                    label33.Text = "Код мероприятия";
                    label41.Visible = true;
                    label43.Visible = true;
                    label44.Visible = true;
                    label46.Visible = true;
                    label42.Visible = true;
                    textBox8.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    groupBox1.Visible = true;
                    groupBox1.Location = new System.Drawing.Point(447, 236);
                    groupBox1.Text = "* Оценка сотрудничества с организацией";
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    break;
                case "Дополнительные услуги":
                    nameTable = EnumTableName.AdditionalServices;
                    label34.Visible = true;
                    label34.Text = "Название компании-поставщика";
                    label37.Visible = true;
                    label37.Text = "Примечание";
                    label35.Visible = true;
                    label35.Text = "Номер контракта";
                    label33.Visible = true;
                    label33.Text = "Название услуги";
                    label41.Visible = true;
                    label44.Visible = true;
                    groupBox1.Visible = true;
                    groupBox1.Location = new System.Drawing.Point(447, 156);
                    groupBox1.Text = "* Оценка сотрудничества";
                    textBox3.Visible = true;
                    textBox5.Visible = true;
                    textBox8.Visible = true;
                    textBox7.Visible = true;
                    break;
                case "О мероприятие":
                    nameTable = EnumTableName.AboutEvent;
                    label39.Visible = true;
                    label39.Text = "Примечание";
                    label34.Visible = true;
                    label34.Text = "Стоимость посещения мероприятия";
                    label38.Visible = true;
                    label38.Text = "Время перерыва";
                    label37.Visible = true;
                    label37.Text = "ФИО участника";
                    label36.Visible = true;
                    label36.Text = "Время выступления";
                    label35.Visible = true;
                    label35.Text = "Тема выступления";
                    label33.Visible = true;
                    label33.Text = "Код мероприятия";
                    label41.Visible = true;
                    label43.Visible = true;
                    label44.Visible = true;
                    label46.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox5.Visible = true;
                    textBox8.Visible = true;
                    dateTimePicker2.Visible = true;
                    dateTimePicker2.Format = DateTimePickerFormat.Custom;
                    dateTimePicker2.CustomFormat = "HH:mm:ss";
                    dateTimePicker2.Location = new System.Drawing.Point(447, 176);
                    dateTimePicker3.Visible = true;
                    dateTimePicker3.Format = DateTimePickerFormat.Custom;
                    dateTimePicker3.CustomFormat = "HH:mm:ss";
                    dateTimePicker3.Location = new System.Drawing.Point(447, 236);
                    textBox7.Visible = true;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Дата для добавления ее в БД
            DateTime dateValue = dateTimePicker1.Value.Date;
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    string[] chekNull;
                    object[] parametrsValue = { };
                    switch (nameTable)
                    {
                        case EnumTableName.ScheduleEvents:
                            chekNull = new string[] { textBoxTime.Text, textBoxGuests.Text, textBoxRevenue.Text, textBoxNote.Text };
                            if (string.IsNullOrWhiteSpace(textBoxTime.Text))
                                chekNull[0] = "NULL";
                            if (string.IsNullOrWhiteSpace(textBoxGuests.Text))
                                chekNull[1] = "0";
                            if (string.IsNullOrWhiteSpace(textBoxRevenue.Text))
                                chekNull[2] = "0";
                            if (string.IsNullOrWhiteSpace(textBoxNote.Text))
                                chekNull[3] = "NULL";
                            parametrsValue = new object[] { textBoxTitle.Text, dateValue.ToString("yyyy-MM-dd"), chekNull[0], chekNull[1], textBoxSponsor.Text, comboBox1.Text, textBoxBudget.Text, checkBoxClosedness.Checked, 0, chekNull[2], GetSelectedRadioValue(), chekNull[3] };
                            break;
                        case EnumTableName.SystemUser:
                            chekNull = new string[] { textBoxCode.Text, textBoxPhone.Text, textBoxMail.Text, textBoxNoteUser.Text };
                            if (string.IsNullOrWhiteSpace(textBoxCode.Text))
                                chekNull[0] = "NULL";
                            if (string.IsNullOrWhiteSpace(textBoxPhone.Text))
                                chekNull[1] = "NULL";
                            if (string.IsNullOrWhiteSpace(textBoxMail.Text))
                                chekNull[2] = "NULL";
                            if (string.IsNullOrWhiteSpace(textBoxNoteUser.Text))
                                chekNull[3] = "NULL";
                            parametrsValue = new object[] { textBoxFullName.Text, textBoxCodeHeld.Text, textBoxHeld.Text, textBoxLogin.Text, textBoxPassword.Text, chekNull[1], chekNull[0], chekNull[2], chekNull[3] };
                            break;
                        case EnumTableName.AccountingСontracts:
                            chekNull = new string[] { textBox1.Text };
                            if (string.IsNullOrWhiteSpace(textBox1.Text))
                                chekNull[0] = "NULL";
                            parametrsValue = new object[] { textBox8.Text, textBox3.Text, textBox6.Text, chekNull[0], dateTimePicker3.Value, dateTimePicker2.Value, textBox7.Text, chekNull[0] };
                            break;
                        case EnumTableName.EventAttendanceAccounting:
                            chekNull = new string[] { textBox3.Text, textBox2.Text };
                            if (string.IsNullOrWhiteSpace(textBox3.Text))
                                chekNull[0] = "NULL";
                            if (string.IsNullOrWhiteSpace(textBox2.Text))
                                chekNull[1] = "NULL";
                            parametrsValue = new object[] { textBox8.Text, textBox7.Text, checkBoxClosedness.Checked, chekNull[0], checkBox2.Checked, GetSelectedRadioValue() == -1 ? "NULL" : GetSelectedRadioValue(), chekNull[1] };
                            break;
                        case EnumTableName.ParticipantsHostingEvent:
                            chekNull = new string[] { textBox1.Text, textBox2.Text, textBox6.Text };
                            if (string.IsNullOrWhiteSpace(textBox1.Text))
                                chekNull[0] = "NULL";
                            if (string.IsNullOrWhiteSpace(textBox2.Text))
                                chekNull[1] = "NULL";
                            if (string.IsNullOrWhiteSpace(textBox6.Text))
                                chekNull[1] = "NULL";
                            parametrsValue = new object[] { textBox8.Text, textBox7.Text, chekNull[2], dateTimePicker3.Value, dateTimePicker2.Value, textBox3.Text, chekNull[1], chekNull[0] };
                            break;
                        case EnumTableName.Sponsors:
                            chekNull = new string[] { textBox2.Text };
                            if (string.IsNullOrWhiteSpace(textBox2.Text))
                                chekNull[0] = "NULL";
                            parametrsValue = new object[] { textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text, textBox3.Text, GetSelectedRadioValue() == -1 ? "NULL" : GetSelectedRadioValue(), chekNull[0] };
                            break;
                        case EnumTableName.AdditionalServices:
                            chekNull = new string[] { textBox5.Text, textBox3.Text };
                            if (string.IsNullOrWhiteSpace(textBox5.Text))
                                chekNull[0] = "NULL";
                            if (string.IsNullOrWhiteSpace(textBox3.Text))
                                chekNull[1] = "NULL";
                            parametrsValue = new object[] { textBox8.Text, textBox7.Text, chekNull[1], GetSelectedRadioValue() == -1 ? "NULL" : GetSelectedRadioValue(), chekNull[0] };
                            break;
                        case EnumTableName.AboutEvent:
                            chekNull = new string[] { textBox3.Text, textBox2.Text };
                            if (string.IsNullOrWhiteSpace(textBox3.Text))
                                chekNull[0] = "NULL";
                            if (string.IsNullOrWhiteSpace(textBox2.Text))
                                chekNull[1] = "NULL";
                            parametrsValue = new object[] { textBox8.Text, dateTimePicker2.Value, textBox7.Text, chekNull[0], textBox5.Text, dateTimePicker3.Value, chekNull[1] };
                            break;
                    }
                    ClassEditDB.InsertItoTable(nameTable, connection, parametrsValue);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка " + ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddEventsForm_Load(object sender, EventArgs e)
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
                //string sqlQuery = "SELECT [Event title] FROM [Schedule events]";
                // Создаем запрос на получение данных из таблицы
                string sqlQuery2 = "SELECT [Contract number] FROM [Accounting contracts]";

                // Создаем адаптер данных и передаем ему запрос и подключение к БД
                SqlDataAdapter adapter2 = new SqlDataAdapter(sqlQuery2, connection);

                // Создаем объект DataSet для хранения данных
                DataSet dataSet2 = new DataSet();

                // Заполняем DataSet данными из таблицы
                adapter2.Fill(dataSet2, "[Accounting contracts]");

                // Настраиваем свойства ComboBox
                comboBox1.DataSource = dataSet2.Tables["[Accounting contracts]"];
                comboBox1.ValueMember = "Contract number";
                comboBox1.DisplayMember = "[Contract number]";

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
    }
}
