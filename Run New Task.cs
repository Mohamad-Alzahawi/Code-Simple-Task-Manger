using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Simple_Task_Manger
{
    public partial class Run_New_Task : Form
    {
        public Run_New_Task()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtOpen.Text))
            {
                Process proc = new Process();
                proc.StartInfo.FileName = txtOpen.Text;
                proc.Start();
            }
        }
    }
}
