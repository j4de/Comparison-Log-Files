using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparison_Log_Files
{
    public partial class AutomationForm : Form
    {
        public AutomationForm()
        {
            InitializeComponent();
        }

        private void Back_auto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browse_auto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBoxFiles.Items.Add(openFileDialog1.FileName);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBoxFiles.Items.Clear();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            for (int i = listBoxFiles.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBoxFiles.Items.Remove(listBoxFiles.SelectedItems[i]);
            }
        }
    }
}
