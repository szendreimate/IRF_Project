using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_PROJECT
{
    public partial class MegjelenoUserControl1 : UserControl
    {
        public MegjelenoUserControl1()
        {
            InitializeComponent();
            //AdatokBeallitas();
        }

        private void AdatokBeallitas(Penztarca penztarca)
        {
            Nevlabel.Text = penztarca.Név;
            Markalabel.Text = penztarca.Márka;
            Nemlabel.Text = penztarca.Nem;
            labelSzin.Text = penztarca.Szín;
            Masodlagoslabel.Text = penztarca.Másodlagoskod;
        }
    }
}
