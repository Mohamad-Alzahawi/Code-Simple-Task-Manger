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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process[] pro;

        void GetAllProcess()
        {
            pro = Process.GetProcesses();
            listBox.Items.Clear();
            foreach (Process pr in pro)
                listBox.Items.Add(pr.ProcessName);
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcess();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tastNewRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Run_New_Task rnt = new Run_New_Task())
            {
                if (rnt.ShowDialog() == DialogResult.OK)
                    GetAllProcess();
            }
        }

        private void btnEnd_Click_1(object sender, EventArgs e)
        {
            try
            {
                pro[listBox.SelectedIndex].Kill();
                GetAllProcess();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listBox_Click(object sender, EventArgs e)
        {
            btnEnd.Enabled = true;
        }
    }
}
