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
        private IConfiguration _configuration;//������� ���� ���� IConfiguration ��� ������� � ���������������� ����� .json
        public static bool admin;//���� ��� ����������� ����� �� ������
        
        public SignInForm()
        {
            InitializeComponent();
            //������� ���������� ��� ������ � ������������� .json
            _configuration = (IConfiguration)ClassEditDB.Building();
        }

        private void labelResetPassword_Click(object sender, EventArgs e)
        {
            // ����� ��� � �������, �� ��� �������� ������������ ����������� �������� � ���� ������ � ����������
            /*FormResetData formResetData = new FormResetData();
            formResetData.Show();*/
        }

        private void labelResetLogin_Click(object sender, EventArgs e)
        {
            labelResetPassword_Click(sender, e);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//��������� ������ ��������� ��� ������� �� ������
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            //������������ � ��
            /// ����������: ������ ������������ ��� string connectionString = @"Data Source=FADGER;Initial Catalog=AccEventsAndSeminars;Integrated Security=True";
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            SqlConnection connection = new SqlConnection(myConnectionString);
            //��������� ����������
            try
            {
                // ��������� �����������
                connection.Open();
                string sqlExpression = "SELECT Login, Password, [Code position held], [Position held] FROM [System User]";
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();//��������� ������ �� �������

                if (reader.HasRows) // ���� ���� ������
                {
                    bool isUserLogin = false;//���� ��� ����������� ����� �� ������ ������������
                    while (reader.Read()) // ��������� ��������� ������
                    {
                        object Login = reader["Login"];
                        object Password = reader["Password"];
                        object CodePositionHeld = reader["Code position held"];
                        object PositionHeld = reader["Position held"];
                        if (textBoxLogin.Text == Convert.ToString(Login) && textBoxPassword.Text == Convert.ToString(Password)
                            && (textBoxPositionHeld.Text == Convert.ToString(PositionHeld) || textBoxCodePosition.Text == Convert.ToString(CodePositionHeld)))
                        {
                            //�������������� ������ � ��������� �����, � ������� ��������
                            admin = textBoxLogin.Text == "FADGER&FG_365";
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            isUserLogin = true;
                            this.Hide();
                            mainForm.labelUserLogin.Text = Convert.ToString(Login);
                            break;// ��������� ����, ����� �� ������ ������
                        }
                    }
                    label10.Visible = !isUserLogin;
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                FormError formError = new FormError("������ " + ex.Message + "\n������� �������� ������");
                formError.Show();
            }
            finally
            {
                // ��������� �����������
                connection.Close();
            }
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            //�������������� ����
            textBoxLogin.Text = "FADGER&FG_365";
            textBoxPassword.Text = "EDJds21DS#$kD&";
            textBoxCodePosition.Text = "1";
            //������������ � ��
            /// ����������: ������ ������������ ��� string connectionString = @"Data Source=FADGER;Initial Catalog=AccEventsAndSeminars;Integrated Security=True";
            var myConnectionString = _configuration.GetConnectionString("MyConnectionString");
            SqlConnection connection = new SqlConnection(myConnectionString);
            //��������� ����������
            try
            {
                // ��������� �����������
                connection.Open();
                labelState.Text = "�����������: " + Convert.ToString(connection.State);//������� ��������� �����������
            }
            catch (SqlException ex)
            {
                FormError formError = new FormError("������ " + ex.Message + "\n������������� ���������� � �������� ����������� ������");
                formError.Show();
            }
            finally
            {
                // ��������� �����������
                connection.Close();
            }
        }
    }
}