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
    public partial class DeleteDataForm : Form
    {
        private string NameTable { get; set; }
        public string ParameterValue { get { return this.textBox1.Text; } }
        private IConfiguration _configuration;//создаем поле типа IConfiguration для доступа к конфигурационому файлу .json
        public DeleteDataForm()
        {
            InitializeComponent();
        }

        public DeleteDataForm(string nameTable)
        {
            InitializeComponent();
            //создаем переменную для работы с конфигурацией .json
            _configuration = (IConfiguration)ClassEditDB.Building();
            NameTable = nameTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    EnumTableName tableName = EnumTableName.ScheduleEvents;
                    switch (NameTable)
                    {
                        case "[Schedule events]":
                            tableName = EnumTableName.ScheduleEvents;
                            break;
                        case "[System User]":
                            tableName = EnumTableName.SystemUser;
                            break;
                        case "[Accounting contracts]":
                            tableName = EnumTableName.AccountingСontracts;
                            break;
                        case "Учет посещения мероприятия":
                            tableName = EnumTableName.EventAttendanceAccounting;
                            break;
                        case "Участники проводящие мероприятие":
                            tableName = EnumTableName.ParticipantsHostingEvent;
                            break;
                        case "Спонсоры":
                            tableName = EnumTableName.Sponsors;
                            break;
                        case "Дополнительные услуги":
                            tableName = EnumTableName.AdditionalServices;
                            break;
                        case "О мероприятие":
                            tableName = EnumTableName.AboutEvent;
                            break;
                    }
                    ClassEditDB.DeleteToTable(tableName, connection, textBox1.Text);
                    this.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
            this.Close();
        }

        private void DeleteDataForm_Load(object sender, EventArgs e)
        {
            if (NameTable == "[Additional services]")
                label1.Text = "Укажите название услуги";
            else if (NameTable == "[System User]")
                label1.Text = "Укажите ФИО сотрудника";
            else if (NameTable == "Дополнительные услуги")
                label1.Text = "Укажите название услуги";
        }
    }
}
