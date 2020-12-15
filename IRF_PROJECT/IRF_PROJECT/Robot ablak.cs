using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_PROJECT
{
    public partial class Robot_ablak : Form
    {
        int megerositoszam;
        public bool sikeres = false;
        public Robot_ablak()
        {
            InitializeComponent();
            Random rng = new Random();
            megerositoszam = rng.Next(0, 9999);
            megerositolabel.Text = megerositoszam.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (megerositoszam == Convert.ToInt32(textBox1.Text))
            {
                sikeres = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
