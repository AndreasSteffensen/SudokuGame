using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] SubMatix = new string[3, 3];
        SubMatix[0, 0] = form1.richTextBox1.Text;

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox2.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox3.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox4.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox5.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox6.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox7.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox8.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox9.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox10.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox11.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox12.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox13.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox14.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox15.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox16.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox17.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox18.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox19.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox20.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox21.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox22.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox23.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox24.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox25.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox26.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox27.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox28.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox29.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox30.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox31.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox32.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox33.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox34.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox35.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox36.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox37.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox38.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox39.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox40.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox41.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox42.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox43.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox44.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox45.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox46.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox47.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox48.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox49.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox50.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox51.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox52.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox53.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox54.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox55.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox56.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox57.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox58.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox59.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox60.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox61.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox62.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox63.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox64.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox65.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox66.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox67.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox68.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox69.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox70.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox71.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox72.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox73.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox74.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox75.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox76.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox77.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox78.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox79.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox80.SelectionAlignment = HorizontalAlignment.Center;
            richTextBox81.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
