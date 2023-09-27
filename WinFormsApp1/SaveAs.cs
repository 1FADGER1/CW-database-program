using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal class SaveAs
    {
        public SaveAs(DataGridView dataGridView) 
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
                        sb.AppendLine(string.Join(";", headers.Select(column => column.HeaderText).ToArray()));
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            var cells = row.Cells.Cast<DataGridViewCell>();
                            sb.AppendLine(string.Join(";", cells.Select(cell => cell.Value).ToArray()));
                        }
                    }
                    else
                    {
                        sb.AppendLine(string.Join("/", headers.Select(column => "\"" + column.HeaderText + "\"").ToArray()));
                        foreach (DataGridViewRow row in dataGridView.Rows)
                        {
                            var cells = row.Cells.Cast<DataGridViewCell>();
                            sb.Append(string.Join("/", cells.Select(cell => cell.Value).ToArray())).AppendLine("@");
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
    }
}
