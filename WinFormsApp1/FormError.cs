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
    public partial class FormError : Form
    {
        public FormError()
        {
            InitializeComponent();
        }
        public FormError(string s)
        {
            InitializeComponent();
            labelErrorMessage.Text = s;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
