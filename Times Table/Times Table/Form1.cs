using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Times_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimesTable_Click(object sender, EventArgs e)
        {
           

            txtTimesTable.Text = "";
            for (int i = 1; i <= 10; i++) {
                for (int j = i; j <= 10; j++) {
                    txtBigBox.Text = txtBigBox.Text + i * j + Environment.NewLine;
                }
            }
        }
    }
}
