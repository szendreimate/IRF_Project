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
    public partial class Adminfelület : Form
    {
        Database1Entities context = new Database1Entities();
        string generaltjelszo;
        public Adminfelület()
        {

            InitializeComponent();
            
            

        }

        private void AdatokBetöltése()
        {
            felhasznaloAdatokTableAdapter1.Insert(NévtextBox.Text, EmailtextBox.Text, VárostextBox.Text, CímtextBox.Text, FelhasznaloNévtextBox.Text, generaltjelszo);
            MessageBox.Show("sikeres mentés!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var felhasznaloletezik = (from fl in context.FelhasznaloAdatok
                                         where fl.felhasznalonev == FelhasznaloNévtextBox.Text
                                         select fl.felhasznalonev).Count();
                if (felhasznaloletezik!=0)
                {
                    MessageBox.Show("Ez a felhasználónév már létezik: " + FelhasznaloNévtextBox.Text);
                    return;
                }
                if (string.IsNullOrEmpty(NévtextBox.Text))
                {
                    MessageBox.Show("Töltsd ki a Teljes Nevét!");
                    return;
                }
                if (string.IsNullOrEmpty(EmailtextBox.Text))
                {
                    MessageBox.Show("Töltsd ki az Email címét!");
                    return;
                }
                if (string.IsNullOrEmpty(VárostextBox.Text))
                {
                    MessageBox.Show("Töltsd ki a Városát!");
                    return;
                }
                if (string.IsNullOrEmpty(CímtextBox.Text))
                {
                    MessageBox.Show("Töltsd ki a Címét!");
                    return;
                }
                if (string.IsNullOrEmpty(FelhasznaloNévtextBox.Text))
                {
                    MessageBox.Show("Töltsd ki a Felhasználó nevet!");
                    return;
                }
                generaltjelszo = Guid.NewGuid().ToString();
                AdatokBetöltése();
            }
            
            catch (Exception)
            {

                throw;
            }
        }
    }
}
