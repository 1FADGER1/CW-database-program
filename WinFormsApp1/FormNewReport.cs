using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormNewReport : Form
    {
        string tableName;
        MainForm mainForm;
        EventsForm eventsForm;
        AllUserForm allUserForm;
        AccountingСontractsForm accountingForm;
        public FormNewReport()
        {
            InitializeComponent();
        }
        public FormNewReport(MainForm formM)
        {
            InitializeComponent();
            mainForm = formM;
        }
        public FormNewReport(string table, MainForm formM)
        {
            InitializeComponent();
            tableName = table;
            mainForm = formM;
        }
        public FormNewReport(string table, EventsForm formE)
        {
            InitializeComponent();
            tableName = table;
            eventsForm = formE;
        }
        public FormNewReport(string table, AccountingСontractsForm formA)
        {
            InitializeComponent();
            tableName = table;
            accountingForm = formA;
        }
        public FormNewReport(string table, AllUserForm formU)
        {
            InitializeComponent();
            tableName = table;
            allUserForm = formU;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (tableName == "[Schedule events]")
            {
                eventsForm?.AddReport(textBox1.Text, eventsForm.dataGridView1);
            }
            else if (tableName == "[System User]")
            {
                allUserForm?.AddReport(textBox1.Text, allUserForm.dataGridView1);
            }
            else if (tableName == "[Accounting contracts]")
            {
                accountingForm?.AddReport(textBox1.Text, accountingForm.dataGridView1);
            }
            else
            {
                mainForm.AddReport(textBox1.Text, mainForm.dataGridView1);
            }
            this.Close();
        }
    }
}
