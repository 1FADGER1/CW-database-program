using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Xml;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    class ClassEditDB
    {
        //public void
        public static object Building()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile(@"D:\\разработка\\WinFormsApp1\\appsettings.json");
            return builder.Build();
        }

        //метод для переименования колонок в гриде
        public static void SetColumnHeaders(DataGridView dataGridView, string[] columnNames, string[] headers)
        {
            for (int i = 0; i < columnNames.Length; i++)
            {
                columnNames[i] = columnNames[i].Replace("[", "").Replace("]", "").Replace("A.", "").Replace("U.", "");
            }
            for (int i = 0; i < columnNames.Length; i++)
            {
                dataGridView.Columns[columnNames[i]].HeaderText = headers[i];
            }
        }

        //метод для создания коллонок в DataGrid
        public static void CreateDBGrid(string[] columnNames, EnumTableName tableName, SqlConnection connection, DataGridView dataGridView, string likeString)
        {
            string columns = string.Join(", ", columnNames);
            string nameTable;
            string WhereNotAdditionalServices = "U.Code_event = A.Code_Event";
            switch(tableName)
            {
                case EnumTableName.ScheduleEvents:
                    nameTable = "[Schedule events]";
                    break;
                case EnumTableName.SystemUser:
                    nameTable = "[System User]";
                    break;
                case EnumTableName.AccountingСontracts:
                    nameTable = "[Accounting contracts]";
                    break;
                case EnumTableName.EventAttendanceAccounting:
                    nameTable = "[Event attendance accounting] U, [Schedule events] A";
                    break;
                case EnumTableName.ParticipantsHostingEvent:
                    nameTable = "[Participants hosting event] U, [Schedule events] A";
                    break;
                case EnumTableName.Sponsors:
                    nameTable = "Sponsors U, [Schedule events] A";
                    break;
                case EnumTableName.AdditionalServices:
                    nameTable = "[Additional services] U, [Accounting contracts] A";
                    WhereNotAdditionalServices = "U.[Contract number] = A.[Contract number]";
                    break;
                case EnumTableName.AboutEvent:
                    nameTable = "[About event] U, [Schedule events] A";
                    break;
                default:
                    nameTable = "[Schedule events]";
                    break;
            }
            string query;
            if (nameTable == "[Schedule events]" || nameTable == "[System User]" || nameTable == "[Accounting contracts]")
                query = $"SELECT {columns} FROM {nameTable} {likeString}";
            else
                query = $"SELECT {columns} FROM {nameTable} WHERE {WhereNotAdditionalServices} {likeString}";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView.DataSource = table;
        }

        public static void CreateDBGrid(string[] columnNames, string[] tableNames, SqlConnection connection, DataGridView dataGridView, string likeString)
        {
            string columns = string.Join(", ", columnNames);
            string tables = "";
            string where = "where";
            foreach (string table in tableNames)
            {
                switch (table)
                {
                    case "Расписание мероприятий":
                        tables += "[Schedule events] schedule,";
                        break;
                    case "Пользователи системы":
                        tables += "[System User] users,";
                        break;
                    case "Учет договоров":
                        if (tables.Contains("[Schedule events] schedule,"))
                            where += " schedule.[Contract number] = contract.[Contract number] AND";
                        tables += "[Accounting contracts] contract,";
                        break;
                    case "Учет посещения мероприятия":
                        if (tables.Contains("[Schedule events] schedule,"))
                            where += " schedule.Code_event = attendance.Code_Event AND";
                        tables += "[Event attendance accounting] attendance,";
                        break;
                    case "Участники проводящие мероприятие":
                        if (tables.Contains("[Schedule events] schedule,"))
                            where += " schedule.Code_event = participant.Code_Event AND";
                        tables += "[Participants hosting event] participant,";
                        break;
                    case "Спонсоры":
                        if (tables.Contains("[Schedule events] schedule,"))
                            where += " schedule.Code_event = sponsor.Code_Event AND";
                        tables += "Sponsors sponsor,";
                        break;
                    case "Дополнительные услуги":
                        if (tables.Contains("[Accounting contracts] contract,"))
                            where += " service.[Contract number] = contract.[Contract number] AND";
                        if(tables.Contains("[Schedule events] schedule,"))
                            where += " service.[Contract number] = schedule.[Contract number] AND";
                        tables += "[Additional services] service,";
                        break;
                    case "О мероприятие":
                        if (tables.Contains("[Schedule events] schedule,"))
                            where += " schedule.Code_event = about.Code_Event AND";
                        tables += "[About event] about,";
                        break;
                    default:
                        tables += "[Schedule events] schedule,";
                        break;
                }
            }
            where = new string(where.Reverse().SkipWhile(x => x != ' ').Reverse().ToArray());
            tables = tables.TrimEnd(',');
            string query;
            if (tables != "[Schedule events] schedule,[System User] user")
                query = $"SELECT DISTINCT {columns} FROM {tables} {where} {likeString}";
            else
                query = $"SELECT DISTINCT {columns} FROM {tables} {likeString}";
            MessageBox.Show(query); //отлавливаем ошибки с запросом
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tableDB = new DataTable();
            adapter.Fill(tableDB);
            dataGridView.DataSource = tableDB;
        }

        //метод для добавления данных в таблицу
        public static void InsertItoTable(EnumTableName tableName, SqlConnection connection, object[] parameterValues)
        {
            //массивы для работы с полями данных таблицы
            string[] columnNamesScheduleEvents = { "[Event title]", "[Event date]", "[Event time]", "[Invited guests]",
                "[Event sponsor]", "[Contract number]", "[Allocated budget]", "[Closedness event]",
                "[Number people attending event]", "[Total revenue]", "[Event evaluation]", "Note" };
            
            string[] columnNamesSystemUser = { "[Full_name employee]", "[Code position held]", "[Position held]", "Login",
                "Password", "[Number phone]", "[Recovery code]", "E_mail", "Note" };
            
            string[] columnNamesAccountingСontracts = { "[Event title]", "[Event sponsor]", "[Сost contract for us]",
                "[Agreement status]", "[Contract start time]", "[Contract expiration time]", "[Contract clauses]", "Note" };
            
            string[] columnNamesEventAttendanceAccounting = { "Code_event", "[Full_name visitor]", "[Visit mark]",
                "Seat", "[Invited guest]", "[Guest evaluation event]", "Note" };
            
            string[] columnNamesAboutEvent = { "Code_event", "[Performance time]", "Topic",
                "[Cost visiting]", "[Full_name participant]", "[Break time]", "Note" };
            
            string[] columnNamesSponsors = { "Code_event", "[Name company]", "[Allocated budget]",
                "[Legal address company]", "TIN", "[Assessment cooperation organization]", "Note" };
            
            string[] columnNamesParticipantsHostingEvent = { "[Full_name participant]", "Topic", "Code_event",
                "[Start time]", "Duration", "[Participant salary]", "[Short description]", "Note" };
            
            string[] columnNamesAdditionalServices = { "[Title service]", "[Contract number]",
                "[Service provider company name]","[Assessment cooperation organization]", "Note" };
            //присваиваем значение исходя из необходимой таблицы используя словарь
            Dictionary<EnumTableName, TableData> tableDataDictionary = new Dictionary<EnumTableName, TableData>
            {
                {EnumTableName.ScheduleEvents, new TableData("[Schedule events]", columnNamesScheduleEvents)},
                {EnumTableName.SystemUser, new TableData("[System User]", columnNamesSystemUser)},
                {EnumTableName.AccountingСontracts, new TableData("[Accounting contracts]", columnNamesAccountingСontracts)},
                {EnumTableName.EventAttendanceAccounting, new TableData("[Event attendance accounting]", columnNamesEventAttendanceAccounting)},
                {EnumTableName.ParticipantsHostingEvent, new TableData("[Participants hosting event]", columnNamesParticipantsHostingEvent)},
                {EnumTableName.Sponsors, new TableData("Sponsors", columnNamesSponsors)},
                {EnumTableName.AdditionalServices, new TableData("[Additional services]", columnNamesAdditionalServices)},
                {EnumTableName.AboutEvent, new TableData("[About event]", columnNamesAboutEvent)}
            };

            if (!tableDataDictionary.TryGetValue(tableName, out var currentTable))
            {
                currentTable = new TableData("[Schedule events]", new string[]
                {
                    "[Event title]", "[Event date]", "[Event time]", "[Invited guests]", "[Event sponsor]", "[Contract number]",
                    "[Allocated budget]", "[Closedness event]", "[Number people attending event]", "[Total revenue]", "[Event evaluation]",
                    "Note"
                });
            }
            string[] valueParametr = currentTable.ColumnNames.Select(n => $"@{n.Replace("[", "").Replace("]", "").Replace(" ", "")}").ToArray();
            //создаем запрос на добавление
            try
            {
                string sqlCommandText = $"INSERT INTO {currentTable.TableName} ({string.Join(", ", currentTable.ColumnNames)}) VALUES ({string.Join(", ", valueParametr)})";
                SqlCommand cmd = new SqlCommand(sqlCommandText, connection);
                // выполнение SQL-запроса
                using (var command = new SqlCommand(sqlCommandText, connection))
                {
                    for (int i = 0; i < valueParametr.Length; i++)
                    {
                        command.Parameters.Add(new SqlParameter(valueParametr[i], parameterValues[i]));
                    }
                    //Выполняем запрос и получаем количество добавленных записей
                    int addedRowsCount = command.ExecuteNonQuery();
                    //Выводим результат добавления записи
                    MessageBox.Show($"Добавлено строк: {addedRowsCount}");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка " + ex.Message + " Не верно полученные параметры");
            }
        }

        //метод для удаления данных из таблицы 
        public static void DeleteToTable(EnumTableName tableName, SqlConnection connection, string parametr)
        {
            string nameTable;
            string whereClause = "[Event title]";
            switch (tableName)
            {
                case EnumTableName.ScheduleEvents:
                    nameTable = "[Schedule events]";
                    break;
                case EnumTableName.SystemUser:
                    nameTable = "[System User]";
                    whereClause = "[Full_name employee]";
                    break;
                case EnumTableName.AccountingСontracts:
                    nameTable = "[Accounting contracts]";
                    break;
                case EnumTableName.EventAttendanceAccounting:
                    nameTable = "[Event attendance accounting]";
                    break;
                case EnumTableName.ParticipantsHostingEvent:
                    nameTable = "[Participants hosting event]";
                    break;
                case EnumTableName.Sponsors:
                    nameTable = "Sponsors";
                    break;
                case EnumTableName.AdditionalServices:
                    nameTable = "[Additional services]";
                    whereClause = "[Title service]";
                    break;
                case EnumTableName.AboutEvent:
                    nameTable = "[About event]";
                    break;
                default:
                    nameTable = "[Schedule events]";
                    break;
            }

            try
            {
                connection.Open(); // открываем соединение с базой данных
                string sqlCommandText = $"DELETE FROM {nameTable} WHERE {whereClause} LIKE  @parametr";
                using (var command = new SqlCommand(sqlCommandText, connection))
                {
                    command.Parameters.AddWithValue("@parametr", parametr);
                    // сохраняем количество удаленных строк
                    int rowsDeleted = command.ExecuteNonQuery();
                    // выводим количество удаленных строк
                    MessageBox.Show("Колличество удаленных строк: " + rowsDeleted);
                }
                string resetQuery = $"DBCC CHECKIDENT ('{nameTable}', RESEED)";
                SqlCommand commandReset = new SqlCommand(resetQuery, connection);
                int affectedRows = commandReset.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка {ex.Message}. Не удалось удалить данные.");
            }
            finally
            {
                connection.Close(); // закрываем соединение с базой данных
            }
        }
        public static void UpdateInTable(EnumTableName tableName, SqlConnection connection, Dictionary<string, object> valuesToUpdate, string whereClause)
        {
             Dictionary<EnumTableName, TableData> tableDataDictionary = new Dictionary<EnumTableName, TableData> 
            { 
            {EnumTableName.ScheduleEvents, new TableData("[Schedule events]", new string[] { "[Event title]", "[Event date]", "[Event time]", "[Invited guests]", "[Event sponsor]", "[Contract number]", "[Allocated budget]", "[Closedness event]", "[Number people attending event]", "[Total revenue]", "[Event evaluation]", "Note" })}, 
            {EnumTableName.SystemUser, new TableData("[System User]", new string[] { "[Full_name employee]", "[Code position held]", "[Position held]", "Login", "Password", "[Number phone]", "[Recovery code]", "E_mail", "Note" })}, 
            {EnumTableName.AccountingСontracts, new TableData("[Accounting contracts]", new string[] { "[Event title]", "[Event sponsor]", "[Сost contract for us]", "[Agreement status]", "[Contract start time]", "[Contract expiration time]", "[Contract clauses]", "Note" })}, 
            {EnumTableName.EventAttendanceAccounting, new TableData("[Event attendance accounting]", new string[] { "Code_event", "[Full_name visitor]", "[Visit mark]", "Seat", "[Invited guest]", "[Guest evaluation event]", "Note" })}, 
            {EnumTableName.ParticipantsHostingEvent, new TableData("[Participants hosting event]", new string[] { "[Full_name participant]", "Topic", "Code_event", "[Start time]", "Duration", "[Participant salary]", "[Short description]", "Note" })}, 
            {EnumTableName.Sponsors, new TableData("Sponsors", new string[] { "Code_event", "[Name company]", "[Allocated budget]", "[Legal address company]", "TIN", "[Assessment cooperation organization]", "Note" })}, 
            {EnumTableName.AdditionalServices, new TableData("[Additional services]", new string[] { "[Service number]", "[Title service]", "[Contract number]", "[Service provider company name]", "[Assessment cooperation organization]", "Note" })}, 
            {EnumTableName.AboutEvent, new TableData("[About event]", new string[] { "Code_event", "[Performance time]", "Topic", "[Cost visiting]", "[Full_name participant]", "[Break time]", "Note" })} 
            };
            if (!tableDataDictionary.TryGetValue(tableName, out var currentTable))
            {
                throw new InvalidOperationException($"Table '{tableName}' not supported.");
            }

            string columnNames = string.Join(", ", currentTable.ColumnNames);
            string setClause = string.Join(", ", valuesToUpdate.Select(kvp => $"{kvp.Key}=@{kvp.Key.Replace("[", "").Replace("]", "").Replace(" ", "")}"));
            string sqlCommandText = $"UPDATE {currentTable.TableName} SET {setClause} {whereClause}";
            try
            {
                using (var command = new SqlCommand(sqlCommandText, connection))
                {
                    // Цикл по всем ключам в словаре valuesToUpdate, добавляем параметры в запрос
                    foreach (var key in valuesToUpdate.Keys)
                    { // проверяем, является ли значение null
                        if (valuesToUpdate[key] != null)
                        { // создаем новый SqlParameter со значением ключа и его значением из valuesToUpdate
                            SqlParameter parameter = new SqlParameter($"@{key.Replace("[", "").Replace("]", "").Replace(" ", "")}", valuesToUpdate[key]);
                            //добавляем параметр к команде
                            command.Parameters.Add(parameter);
                        }
                    }
                    int updatedRowsCount = command.ExecuteNonQuery();
                    MessageBox.Show($"Обновлено строк: {updatedRowsCount}");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        public static void AddIfNotEmpty(Dictionary<string, object> dictionary, string[] columnNames, object[] values)
        {
            for (int i = 0; i < columnNames.Length; i++)
            {
                if (values[i] != null && !string.IsNullOrWhiteSpace(values[i].ToString().Trim()))
                {
                    if (!dictionary.ContainsKey(columnNames[i]))
                    {
                        dictionary.Add(columnNames[i], values[i]);
                    }
                    else
                    {
                        dictionary[columnNames[i]] = values[i];
                    }
                }
            }
        }

        private class TableData
        {
            public string TableName { get; }
            public string[] ColumnNames { get; }

            public TableData(string tableName, string[] columnNames)
            {
                TableName = tableName;
                ColumnNames = columnNames;
            }
        }
    }
}
