using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _019_NumericUpDown_Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorProvider1.BlinkRate = 400;
            errorProvider1.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;

            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = 255;

            numericUpDown4.Minimum = 0;
            numericUpDown4.Maximum = 255;

            numericUpDown5.Minimum = 0;
            numericUpDown5.Maximum = 255;

            numericUpDown3.Increment = 10;//10'nar 10'nar arttırıp azaltacagiz
            numericUpDown4.Increment = 10;//10'nar 10'nar arttırıp azaltacagiz
            numericUpDown5.Increment = 10;//10'nar 10'nar arttırıp azaltacagiz

            textBox1.Enabled = false;


        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value<0 || numericUpDown3.Value>255 )
            {
                errorProvider1.SetError(numericUpDown3, "0-255 arasinda deger olmalidir!");
            }
            else
            {
                errorProvider1.Clear();
            }

            textBox1.BackColor = Color.FromArgb(int.Parse(numericUpDown3.Value.ToString()), (int.Parse(numericUpDown4.Value.ToString())), 
                (int.Parse(numericUpDown5.Value.ToString())));

        }
    }
}
