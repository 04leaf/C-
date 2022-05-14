using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 二維陣列_班級成績_DataGridVeiw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] a =
            {
                {0,30,40,50},
                {1,40,50,60},
                {2,20,90,95}
            };
            for(int i=0;i<=2;i++)
            {
                dgv.Rows.Add();
                for(int j=0;j<=3;j++)
                {
                    DataGridViewCell cell = dgv.Rows[i].Cells[j];
                    cell.Value = a[i, j];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int b;
            b = int.Parse(dgv.Rows[1].Cells[2].Value.ToString());
            button2.Text = b.ToString();
        }
    }
}
