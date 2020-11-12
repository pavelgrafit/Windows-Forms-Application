using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_lab7_8
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form11 = Application.OpenForms[0];
            form11.Show();
            this.Close();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form form11 = Application.OpenForms[0];
            form11.Show();
            this.Close();
        }
    }
}
