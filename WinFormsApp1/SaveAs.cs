using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinFormsApp1
{
    internal class SaveAs
    {
        public SaveAs(DataGridView dataGridView, string FindIs = "") 
        {
            var filePath = string.Empty;
            var sb = new StringBuilder();
            var headers = dataGridView.Columns.Cast<DataGridViewColumn>();

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "txt files (*.txt)|*.txt|csv file (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Получаем путь к указаному файлу
                    filePath = saveFileDialog.FileName;

                    //Считывает содержимое файла в поток
                    var fileStream = saveFileDialog.OpenFile();
                    //получаем расширение файла и исходя из него строим техт
                    if (Path.GetExtension(filePath).ToString() == ".csv")
                    {
                        sb.AppendLine(string.Join(",", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            var cells = row.Cells.Cast<DataGridViewCell>();
                            //var filteredCells = cells.Where(cell => !string.IsNullOrWhiteSpace(cell.Value.ToString()));
                            if (cells.Any(cell => cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString())))
                                sb.AppendLine(string.Join(",", cells.Select(cell => "\"" + cell.Value + "\"").ToArray()));
                        }
                    }
                    else
                    {
                        sb.AppendLine(FindIs);
                        sb.AppendLine($"{dataGridView.RowCount - 1}");
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            var cells = row.Cells.Cast<DataGridViewCell>();
                            if (cells.Any(cell => cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString())))
                                sb.Append(string.Join("\n", cells.Select(cell => cell.Value?.ToString()).Where(value => !string.IsNullOrWhiteSpace(value) && value != FindIs))).AppendLine("@");
                        }
                    }
                    //записываем нужные данные в файл
                    using (StreamWriter writer = new StreamWriter(fileStream))
                    {
                        writer.WriteLine(sb);
                    }
                }
            }
        }

        public static async Task SavingXML()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=AccEventsAndSeminars;Integrated Security=True";
            string sql = "use AccEventsAndSeminars " +
                 "select distinct s.[Event title], s.[Event date], " +
                 "s.[Event sponsor], c.[Сost contract for us] " +
                 "from [Schedule events] AS s, [Accounting contracts] AS c " +
                 "where s.[Contract number] = c.[Contract number] and s.[Event sponsor] = 'ФГАИС \"Молодежь России\"'";
            DataTable dataTable = new DataTable("EventData");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                dataTable.WriteXml("D:\\разработка\\WinFormsApp1\\XML\\Completed.xml");
            }
        }
    }
}
