using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aGEtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDogAge_Click(object sender, EventArgs e)
        {
            int HumanAge;
            int DogAge;

            HumanAge = int.Parse(txtHumanAge.Text);
            DogAge = HumanAge * 7;
            txtAnimalAge.Text = DogAge.ToString(); 
        }

        private void btnTurtleAge_Click(object sender, EventArgs e)
        {
            int HumanAge;
            int TurtleAge;

            HumanAge = int.Parse(txtHumanAge.Text);
            TurtleAge = HumanAge / 2;
            txtAnimalAge.Text = TurtleAge.ToString();
        }

        private void btnCatAge_Click(object sender, EventArgs e)
        {
            int HumanAge;
            int CatAge;

            HumanAge = int.Parse(txtHumanAge.Text);
            CatAge = HumanAge * 4 + 11;
            txtAnimalAge.Text = CatAge.ToString();
        }
    }
}
