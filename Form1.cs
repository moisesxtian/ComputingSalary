using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class ComputeSalary : Form
    {
        public ComputeSalary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int conv1 = Convert.ToInt32(textBox5.Text);
            double conv2 = Convert.ToDouble(textBox6.Text);
            PartTimeEmployee pte = new PartTimeEmployee(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,conv1, conv2);
            label12.Text = pte.firstname;
            label11.Text = pte.lastname;
            label10.Text = pte.basicsalary.ToString();

        }
    }
}
