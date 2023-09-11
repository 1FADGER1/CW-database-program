using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.VisualBasic.Logging;

namespace WinFormsApp1
{
    public partial class SignInForm : Form
    {
        private IConfiguration _configuration;//создаем поле типа IConfiguration для доступа к конфигурационому файлу .json
        public static bool admin;//флаг для определения вошел ли админа
        
        public SignInForm()
        {
            InitializeComponent();
            //создаем переменную для работы с конфигурацией .json
            _configuration = (IConfiguration)ClassEditDB.Building();
        }

        private void labelResetPassword_Click(object sender, EventArgs e)
        {
            // этого нет в задании, но это является возможностью дальнейшего развития и базы данных и приложения
            /*FormResetData formResetData = new FormResetData();
            formResetData.Show();*/
        }

        private void labelResetLogin_Click(object sender, EventArgs e)
        {
            labelResetPassword_Click(sender, e);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//завершаем работу программы при нажатии на кнопку
        }

        private void buttonContinue_Click(object sender, EventArgs e)
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
                string sqlExpression = "SELECT Login, Password, [Code position held], [Position held] FROM [System User]";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();//считываем данные из таблицы

                if (reader.HasRows) // если есть данные
                {
                    bool isUserLogin = false;//флаг для определения зашел ли верный пользователь
                    while (reader.Read()) // построчно считываем данные
                    {
                        object Login = reader["Login"];
                        object Password = reader["Password"];
                        object CodePositionHeld = reader["Code position held"];
                        object PositionHeld = reader["Position held"];
                        if (textBoxLogin.Text == Convert.ToString(Login) && textBoxPassword.Text == Convert.ToString(Password)
                            && (textBoxPositionHeld.Text == Convert.ToString(PositionHeld) || textBoxCodePosition.Text == Convert.ToString(CodePositionHeld)))
                        {
                            //инициализируем объект и открываем форму, а текущую скрываем
                            admin = textBoxLogin.Text == "FADGER&FG_365";
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            isUserLogin = true;
                            this.Hide();
                            mainForm.labelUserLogin.Text = Convert.ToString(Login);
                            break;// прерываем цикл, чтобы не искать дальше
                        }
                    }
                    label10.Visible = !isUserLogin;
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                FormError formError = new FormError("Ошибка " + ex.Message + "\nВведены неверные данные");
                formError.Show();
            }
            finally
            {
                // закрываем подключение
                connection.Close();
            }
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            //автоматический вход
            textBoxLogin.Text = "FADGER&FG_365";
            textBoxPassword.Text = "EDJds21DS#$kD&";
            textBoxCodePosition.Text = "1";
            //подключаемся к БД
            /// Примечание: раньше использовали это string connectionString = @"Data Source=FADGER;Initial Catalog=AccEventsAndSeminars;Integrated Security=True";
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            SqlConnection connection = new SqlConnection(myConnectionString);
            //обработка исключений
            try
            {
                // Открываем подключение
                connection.Open();
                labelState.Text = "Подключение: " + Convert.ToString(connection.State);//смотрим состояние подключения
            }
            catch (SqlException ex)
            {
                FormError formError = new FormError("Ошибка " + ex.Message + "\nПерезагрузите приложение и проверте целостность файлов");
                formError.Show();
            }
            finally
            {
                // закрываем подключение
                connection.Close();
            }
        }
    }
}