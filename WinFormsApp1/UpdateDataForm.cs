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

namespace WinFormsApp1
{
    public partial class UpdateDataForm : Form
    {
        public UpdateDataForm()
        {
            InitializeComponent();
        }
        private IConfiguration _configuration;//создаем поле типа IConfiguration для доступа к конфигурационому файлу .json
        private string NameTable { get; set; }
        public UpdateDataForm(string s)
        {
            InitializeComponent();
            comboBox2.Visible = false;
            labelUpdateIn.Text += s;
            NameTable = s;
            SerchEnumTableName(s);
            //создаем переменную для работы с конфигурацией .json
            _configuration = (IConfiguration)ClassEditDB.Building();
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
                    label12.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    label15.Visible = true;
                    label16.Visible = true;
                    label17.Visible = true;
                    label18.Visible = true;
                    label19.Visible = true;
                    label20.Visible = true;
                    textBoxPhone.Visible = true;
                    textBoxNoteUser.Visible = true;
                    textBoxPassword.Visible = true;
                    textBoxMail.Visible = true;
                    textBoxLogin.Visible = true;
                    textBoxFullName.Visible = true;
                    textBoxCodeHeld.Visible = true;
                    textBoxCode.Visible = true;
                    textBoxHeld.Visible = true;
                    break;
                case "[Accounting contracts]":
                    nameTable = EnumTableName.AccountingСontracts;
                    label21.Visible = true;
                    label21.Text = "Примечание";
                    label22.Visible = true;
                    label22.Text = "Статус договора";
                    label23.Visible = true;
                    label23.Text = "Спонсор";
                    label24.Visible = true;
                    label24.Text = "Конец действия контракта";
                    label25.Visible = true;
                    label25.Text = "Начало действия контракта";
                    label26.Visible = true;
                    label26.Text = "Стоимость контракта для нас";
                    label27.Visible = true;
                    label27.Text = "Пункты договора";
                    label28.Visible = true;
                    label28.Text = "Название мероприятия";
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
                    label22.Visible = true;
                    label22.Text = "Примечание";
                    label23.Visible = true;
                    label23.Text = "Место сидения";
                    groupBox1.Visible = true;
                    groupBox1.Location = new System.Drawing.Point(447, 216);
                    groupBox1.Text = "Оценка мероприятия гостем";
                    checkBox2.Visible = true;
                    checkBoxClosedness.Visible = true;
                    checkBoxClosedness.Location = new System.Drawing.Point(167, 225);
                    checkBoxClosedness.Text = "Метка посещения";
                    label27.Visible = true;
                    label27.Text = "ФИО посетителя";
                    label28.Visible = true;
                    label28.Text = "Код мероприя";
                    textBox8.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox7.Visible = true;
                    break;
                case "Участники проводящие мероприятие":
                    nameTable = EnumTableName.ParticipantsHostingEvent;
                    label21.Visible = true;
                    label21.Text = "Примечание";
                    label22.Visible = true;
                    label22.Text = "Краткое описание";
                    label23.Visible = true;
                    label23.Text = "Оклад участника";
                    label24.Visible = true;
                    label24.Text = "Время выступления";
                    label25.Visible = true;
                    label25.Text = "Время начала";
                    label26.Visible = true;
                    label26.Text = "Код мероприятия";
                    label27.Visible = true;
                    label27.Text = "Тема выступления";
                    label28.Visible = true;
                    label28.Text = "ФИО участника";
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
                    label22.Visible = true;
                    label22.Text = "Примечание";
                    label23.Visible = true;
                    label23.Text = "ИНН";
                    label25.Visible = true;
                    label25.Text = "Юридический адрес";
                    label26.Visible = true;
                    label26.Text = "Выделенный бюджет";
                    label27.Visible = true;
                    label27.Text = "Название компании";
                    label28.Visible = true;
                    label28.Text = "Код мероприятия";
                    textBox8.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    groupBox1.Visible = true;
                    groupBox1.Location = new System.Drawing.Point(447, 236);
                    groupBox1.Text = "Оценка сотрудничества с организацией";
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    break;
                case "Дополнительные услуги":
                    nameTable = EnumTableName.AdditionalServices;
                    label23.Visible = true;
                    label23.Text = "Название компании-поставщика";
                    label25.Visible = true;
                    label25.Text = "Примечание";
                    label27.Visible = true;
                    label27.Text = "Номер контракта";
                    label28.Visible = true;
                    label28.Text = "Название услуги";
                    groupBox1.Visible = true;
                    groupBox1.Location = new System.Drawing.Point(447, 156);
                    groupBox1.Text = "Оценка сотрудничества";
                    textBox3.Visible = true;
                    textBox5.Visible = true;
                    textBox8.Visible = true;
                    textBox7.Visible = true;
                    break;
                case "О мероприятие":
                    nameTable = EnumTableName.AboutEvent;
                    label22.Visible = true;
                    label22.Text = "Примечание";
                    label23.Visible = true;
                    label23.Text = "Стоимость посещения мероприятия";
                    label24.Visible = true;
                    label24.Text = "Время перерыва";
                    label25.Visible = true;
                    label25.Text = "ФИО участника";
                    label26.Visible = true;
                    label26.Text = "Время выступления";
                    label27.Visible = true;
                    label27.Text = "Тема выступления";
                    label28.Visible = true;
                    label28.Text = "Код мероприятия";
                    comboBox3.Visible = true;
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

        private void buttonNext_Click(object sender, EventArgs e)
        {
            //Дата для добавления ее в БД
            DateTime dateValue = dateTimePicker1.Value.Date;
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    string checkNewEventTitle = checkBox1.Checked == false ? comboBox3.Text : textBoxTitle.Text;
                    Dictionary<string, object> valuesToUpdate = new Dictionary<string, object>();
                    string[] columnNames = { }; // Массив наименований полей таблицы
                    object[] values = { }; // Массив текстовых значений
                    switch (nameTable)
                    {
                        case EnumTableName.ScheduleEvents:
                            columnNames = new string[] { "[Event title]", "[Event date]", "[Event time]", "[Invited guests]", "[Event sponsor]",
                        "[Contract number]", "[Allocated budget]", "[Closedness event]", "[Number people attending event]", "[Total revenue]",
                        "[Event evaluation]", "Note" };
                            values = new object[] { textBoxTitle.Text, dateValue.ToString("yyyy-MM-dd"), textBoxTime.Text, textBoxGuests.Text,
                        textBoxSponsor.Text, comboBox1.Text, textBoxBudget.Text, checkBoxClosedness.Checked, textBoxCountPeople.Text,
                        textBoxRevenue.Text, GetSelectedRadioValue()==-1? null:GetSelectedRadioValue, textBoxNote.Text };
                            break;
                        case EnumTableName.SystemUser:
                            columnNames = new string[] { "[Full_name employee]", "[Code position held]", "[Position held]", "Login",
                "Password", "[Number phone]", "[Recovery code]", "E_mail", "Note" };
                            values = new object[] { textBoxFullName.Text, textBoxCodeHeld.Text, textBoxHeld.Text, textBoxLogin.Text, textBoxPassword.Text, textBoxPhone.Text, textBoxCode.Text, textBoxMail.Text, textBoxNoteUser.Text };
                            break;
                        case EnumTableName.AccountingСontracts:
                            columnNames = new string[] { "[Event title]", "[Event sponsor]", "[Сost contract for us]",
                "[Agreement status]", "[Contract start time]", "[Contract expiration time]", "[Contract clauses]", "Note" };
                            values = new object[] { textBox8.Text, textBox3.Text, textBox6.Text, textBox2.Text, dateTimePicker3.Value, dateTimePicker2.Value, textBox7.Text, textBox1.Text };
                            break;
                        case EnumTableName.EventAttendanceAccounting:
                            columnNames = new string[] { "Code_event", "[Full_name visitor]", "[Visit mark]",
                "Seat", "[Invited guest]", "[Guest evaluation event]", "Note" };
                            values = new object[] { textBox8.Text, textBox7.Text, checkBoxClosedness.Checked, textBox3.Text, checkBox2.Checked, GetSelectedRadioValue() == -1 ? null : GetSelectedRadioValue(), textBox2.Text };
                            break;
                        case EnumTableName.ParticipantsHostingEvent:
                            columnNames = new string[] { "[Full_name participant]", "Topic", "Code_event",
                "[Start time]", "Duration", "[Participant salary]", "[Short description]", "Note" };
                            values = new object[] { textBox8.Text, textBox7.Text, textBox6.Text, dateTimePicker3.Value, dateTimePicker2.Value, textBox3.Text, textBox2.Text, textBox1.Text };
                            break;
                        case EnumTableName.Sponsors:
                            columnNames = new string[] { "Code_event", "[Name company]", "[Allocated budget]",
                "[Legal address company]", "TIN", "[Assessment cooperation organization]", "Note" };
                            values = new object[] { textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text, textBox3.Text, GetSelectedRadioValue() == -1 ? null : GetSelectedRadioValue(), textBox2.Text };
                            break;
                        case EnumTableName.AdditionalServices:
                            columnNames = new string[] { "[Title service]", "[Contract number]",
                "[Service provider company name]","[Assessment cooperation organization]", "Note" };
                            values = new object[] { textBox8.Text, textBox7.Text, textBox3.Text, GetSelectedRadioValue() == -1 ? null : GetSelectedRadioValue(), textBox5.Text };
                            break;
                        case EnumTableName.AboutEvent:
                            columnNames = new string[] { "Code_event", "[Performance time]", "Topic",
                "[Cost visiting]", "[Full_name participant]", "[Break time]", "Note" };
                            values = new object[] { textBox8.Text, dateTimePicker2.Value, textBox7.Text, textBox3.Text, textBox5.Text, dateTimePicker3.Value, textBox2.Text };
                            break;
                    }
                    ClassEditDB.AddIfNotEmpty(valuesToUpdate, columnNames, values);
                    string collum = "";
                    switch (nameTable)
                    {
                        case EnumTableName.SystemUser:
                            collum = "[Full_name employee]";
                            break;
                        case EnumTableName.AdditionalServices:
                            collum = "[Title service]";
                            break;
                        case EnumTableName.EventAttendanceAccounting:
                            collum = "[Full_name visitor]";
                            break;
                        case EnumTableName.ParticipantsHostingEvent:
                            collum = "[Full_name participant]";
                            break;
                        default:
                            collum = "[Event title]";
                            break;
                    }
                    ClassEditDB.UpdateInTable(nameTable, connection, valuesToUpdate, $"Where {collum} Like ('{comboBox3.Text}')");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка " + ex.Message);
                    MessageBox.Show(ex.StackTrace);
                }
                this.Close();
            }

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxTitle.Enabled = checkBox1.Checked;
            textBox8.Enabled = checkBox1.Checked;
            textBoxFullName.Enabled = checkBox1.Checked;
        }

        private void UpdateDataForm_Load(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
            //подключаемся к БД
            /// Примечание: раньше использовали это string connectionString = @"Data Source=FADGER;Initial Catalog=AccEventsAndSeminars;Integrated Security=True";
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            SqlConnection connection = new SqlConnection(myConnectionString);
            //обработка исключений
            try
            {
                // Открываем подключение
                connection.Open();

                string table = "";
                string collum = "";
                switch (nameTable)
                {
                    case EnumTableName.SystemUser:
                        table = "[System User]";
                        collum = "[Full_name employee]";
                        break;
                    case EnumTableName.AdditionalServices:
                        table = "[Additional services]";
                        collum = "[Title service]";
                        break;
                    case EnumTableName.EventAttendanceAccounting:
                        table = "[Event attendance accounting]";
                        collum = "[Full_name visitor]";
                        break;
                    case EnumTableName.ParticipantsHostingEvent:
                        table = "[Participants hosting event]";
                        collum = "[Full_name participant]";
                        break;
                    default:
                        table = "[Schedule events]";
                        collum = "[Event title]";
                        break;
                }
                // Создаем запрос на получение данных из таблицы
                string sqlQuery = $"SELECT {collum} FROM {table}";
                // Создаем адаптер данных и передаем ему запрос и подключение к БД
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);

                // Создаем объект DataSet для хранения данных
                DataSet dataSet = new DataSet();

                // Заполняем DataSet данными из таблицы
                adapter.Fill(dataSet, table);

                // Настраиваем свойства ComboBox
                comboBox3.DataSource = dataSet.Tables[table];
                comboBox3.ValueMember = collum.Replace("[", "").Replace("]", "");
                comboBox3.DisplayMember = collum;

                string sqlQuery2 = "SELECT [Contract number] FROM [Accounting contracts]";
                SqlDataAdapter adapter2 = new SqlDataAdapter(sqlQuery2, connection);
                DataSet dataSet2 = new DataSet();
                adapter2.Fill(dataSet2, "[Accounting contracts]");
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

        private void button1_Click(object sender, EventArgs e)
        {
            buttonNext_Click(sender, e);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBoxFullName_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
