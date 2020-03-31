using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstSynchroApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // After one click value of numericBoxes increment by 1
        private void button1_Click(object sender, EventArgs e)
        {
            //if (numericUpDown1.Value < 9223372036854775807 || numericUpDown3.Value < 9223372036854775807)
            //{
               try
               {
                   long tmp1 = (long)numericUpDown1.Value;
                   long tmp2 = (long)numericUpDown3.Value;
                   tmp1++;
                   tmp2++;
                   numericUpDown1.Value = tmp1;
                   numericUpDown3.Value = tmp2;
                   Console.WriteLine(long.MaxValue);
               }
               catch (Exception exception)
               {
                   MessageBox.Show(exception.Message + "\n Maksymalna wartosc to 9223372036854775807");
                   numericUpDown1.Value = 9223372036854775807;
                   numericUpDown3.Value = 9223372036854775807;
               }
            //}
        }
        //Method which set numericBox3 value when numericBox1 value changed. 
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value != numericUpDown3.Value)
            {
                numericUpDown3.Value = numericUpDown1.Value;
                //numericUpDown3.Refresh();
            }

        }
        //Method which set numericBox1 value when numericBox3 value changed. 
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value != numericUpDown3.Value)
            {
                numericUpDown1.Value = numericUpDown3.Value;
                //numericUpDown1.Refresh();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
