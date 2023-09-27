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
using System.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace WinFormsApp1
{
    public partial class ChooseForm : Form
    {
        private IConfiguration _configuration;//создаем поле типа IConfiguration для доступа к конфигурационому файлу .json
        MainForm mainForm;
        public ChooseForm()
        {
            InitializeComponent();
        }
        public ChooseForm(MainForm form)
        {
            InitializeComponent();
            _configuration = (IConfiguration)ClassEditDB.Building();
            mainForm = form;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 1)
            {
                label2.Visible = true;
                listBox2.Visible = true;
                buttonNext.Visible = false;
                buttonSelect.Visible = true;
                Dictionary<EnumTableName, string> dataTable = new Dictionary<EnumTableName, string>
                {
                    { EnumTableName.ScheduleEvents, "Расписание мероприятий" },
                    { EnumTableName.AboutEvent, "О мероприятие" },
                    { EnumTableName.AccountingСontracts, "Учет договоров"},
                    { EnumTableName.Sponsors, "Спонсоры"},
                    { EnumTableName.AdditionalServices, "Дополнительные услуги"},
                    { EnumTableName.EventAttendanceAccounting, "Учет посещения мероприятия"},
                    { EnumTableName.ParticipantsHostingEvent, "Участники проводящие мероприятие"},
                    { EnumTableName.SystemUser, "Пользователи системы"}
                };
                Dictionary<string, string[]> dataField = new Dictionary<string, string[]>
                {
                    { "Расписание мероприятий", new string[] { "schedule.[Event title]", "schedule.[Event date]", "schedule.[Event time]", "schedule.[Invited guests]",
                        "schedule.[Event sponsor]", "schedule.[Contract number]", "schedule.[Allocated budget]", "schedule.[Closedness event]",
                        "schedule.[Number people attending event]", "schedule.[Total revenue]", "schedule.[Event evaluation]", "schedule.Note" } },
                    { "О мероприятие", new string[] { "about.Code_event", "about.[Performance time]", "about.Topic",
                        "about.[Cost visiting]", "about.[Full_name participant]", "about.[Break time]", "about.Note" }},
                    { "Учет договоров", new string[] { "contract.[Event title]", "contract.[Event sponsor]", "contract.[Сost contract for us]",
                        "contract.[Agreement status]", "contract.[Contract start time]", "contract.[Contract expiration time]", "contract.[Contract clauses]", "contract.Note" }},
                    { "Спонсоры", new string[] { "sponsor.Code_event", "sponsor.[Name company]", "sponsor.[Allocated budget]",
                        "sponsor.[Legal address company]", "sponsor.TIN", "sponsor.[Assessment cooperation organization]", "sponsor.Note" }},
                    { "Дополнительные услуги", new string[] { "service.[Title service]", "service.[Contract number]",
                        "service.[Service provider company name]", "service.[Assessment cooperation organization]", "service.Note" }},
                    { "Учет посещения мероприятия", new string[] { "attendance.Code_event", "attendance.[Full_name visitor]", "attendance.[Visit mark]",
                        "attendance.Seat", "attendance.[Invited guest]", "attendance.[Guest evaluation event]", "attendance.Note" }},
                    { "Участники проводящие мероприятие", new string[] { "participant.[Full_name participant]", "participant.Topic", "participant.Code_event",
                        "participant.[Start time]", "participant.Duration", "participant.[Participant salary]", "participant.[Short description]", "participant.Note" }},
                    { "Пользователи системы", new string[] { "users.[Full_name employee]", "users.[Code position held]", "users.[Position held]", "users.Login",
                        "users.Password", "users.[Number phone]", "users.[Recovery code]", "users.E_mail", "users.Note" }}
                };
                //заполнение дистбокс2 полями из выбранных таблиц
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    string selectedTable = listBox1.SelectedItems[i].ToString();
                    if (dataField.ContainsKey(selectedTable))
                    {
                        listBox2.Items.AddRange(dataField[selectedTable]);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            buttonNext_Click(sender, e);
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            buttonSaveAs.Visible = true;
            groupBoxSort.Visible = true;
            for (int i = 0; i < listBox2.SelectedItems.Count; i++)
                comboBoxField.Items.Add(listBox2.SelectedItems[i]);
            buttonSort_Click(sender, e);
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            string like = "";
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            using (SqlConnection connection = new SqlConnection(myConnectionString))
            {
                try
                {
                    connection.Open();
                    if (!string.IsNullOrWhiteSpace(textBoxText.Text))
                        like = $"and {comboBoxField.Text} like ('{textBoxText.Text}')";
                    ClassEditDB.CreateDBGrid(listBox2.SelectedItems.Cast<string>().ToArray(), listBox1.SelectedItems.Cast<string>().ToArray(), connection, dataGridView1, like);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка" + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxField.Items.Clear();
        }

        private void buttonSaveAs_Click(object sender, EventArgs e)
        {
            SaveAs save = new SaveAs(dataGridView1);
        }

        /*в будущем можно добавить проверку на админа с доступом к пользователям системы
* if(SignInForm.admin)
{
listBox2.Items.Add("Пользователи системы");
} 
*/
    }
}
