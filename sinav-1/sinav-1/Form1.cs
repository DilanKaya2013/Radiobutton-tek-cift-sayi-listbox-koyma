using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstSayilar.Items.Clear();


            //if (rbTek.Checked)
            //{
            //    for (int i = 1; i < 100; i += 2)
            //    {
            //        lstSayilar.Items.Add(i.ToString());
            //    }
            //}
            //else
            //{
            //    for(int i = 0; i < 100; i += 2)
            //    {
            //        lstSayilar.Items.Add(i.ToString());
            //    }
            //}

            int baaslangic = 0;
            if (rbTek.Checked)
            {
                baaslangic = 1;
            }
            
        }
    }
}
