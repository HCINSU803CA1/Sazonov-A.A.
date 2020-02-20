using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nextButton(object sender, EventArgs e)
        {
            if (Checker.Checked==true)
            {
                Form2 form = new Form2();
                form.Show();
                this.Hide();
            }
            else
            {
                label1.Text = "Вы не приняли условное соглашение";
            }
        }

        private void cancelButton(object sender, EventArgs e)
        {

        }

        private void checkedChanged(object sender, EventArgs e)
        {
            if (Checker.Checked == true)
            {
                label1.Text = "Лицензионное соглашение";
            }
        }
    }
}
