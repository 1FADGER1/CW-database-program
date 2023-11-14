using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Linq;
using System.Text;
using System.Text.Json;
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
                //Создаем новый DataTable с нужной структурой
                DataTable newDataTable = new DataTable("ФГАИС_\"Молодежь_России\"");
                newDataTable.Columns.Add("Event title", typeof(string));
                newDataTable.Columns.Add("Event date", typeof(string));
                newDataTable.Columns.Add("Сost contract for us", typeof(string));

                // Переносим данные из исходного DataTable в новый DataTable
                foreach (DataRow row in dataTable.Rows)
                {
                    DataRow newRow = newDataTable.NewRow();
                    newRow["Event title"] = row["Event title"];
                    newRow["Event date"] = row["Event date"];
                    newRow["Сost contract for us"] = row["Сost contract for us"];
                    newDataTable.Rows.Add(newRow);
                }
                newDataTable.WriteXml("D:\\разработка\\WinFormsApp1\\XML\\Completed.xml");
            }
        }
        public static async Task SavingJson()
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
                // сохранение данных
                // Создаем словарь спонсора
                Dictionary<string, List<Dictionary<string, object>>> sponsorDictionary = new Dictionary<string, List<Dictionary<string, object>>>();

                foreach (DataRow dr in dataTable.Rows)
                {
                    string eventSponsor = dr["Event sponsor"].ToString();

                    // Проверяем, есть ли уже запись для данного спонсора
                    if (!sponsorDictionary.ContainsKey(eventSponsor))
                    {
                        sponsorDictionary[eventSponsor] = new List<Dictionary<string, object>>();
                    }
                    // Создаем словарь события
                    Dictionary<string, object> eventDictionary = new Dictionary<string, object>();
                    foreach (DataColumn col in dataTable.Columns)
                    {
                        if (col.ColumnName != "Event sponsor")
                        {
                            eventDictionary[col.ColumnName] = dr[col];
                        }
                    }

                    // Добавляем словарь события в список для данного спонсора
                    sponsorDictionary[eventSponsor].Add(eventDictionary);
                }
                // Сохраняем данные
                using (FileStream fs = new FileStream("D:\\разработка\\WinFormsApp1\\JSON\\Completed.json", FileMode.OpenOrCreate))
                {
                    List<object> sponsorList = new List<object>();
                    foreach (var kvp in sponsorDictionary)
                    {
                        Dictionary<string, object> sponsorEntry = new Dictionary<string, object>();
                        sponsorEntry[kvp.Key] = kvp.Value;
                        sponsorList.Add(sponsorEntry);
                    }
                    var options = new JsonSerializerOptions
                    {
                        WriteIndented = true,
                        Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                    };
                    await JsonSerializer.SerializeAsync(fs, sponsorList, options);
                }
            }
        }
    }
}
