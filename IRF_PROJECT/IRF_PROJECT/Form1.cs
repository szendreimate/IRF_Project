using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRF_PROJECT
{
    public partial class Form1 : Form
    {
        Database1Entities context = new Database1Entities();
        public int valsztottId;
       
        public Form1()
        {
            InitializeComponent();
            
            jelszoTextBox.PasswordChar = '*';

            AdatBetöltés();
        }

        

        private void Belepo_button_Click(object sender, EventArgs e)
        {
            HelyesJelszo();
            
            
            
        }

        private void felhasznalocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (felhasznalocomboBox.SelectedIndex!=-1)
            {
                ValasztottFelhasználóId();

            }
            
        }

        private void jelszoTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void AdatBetöltés()
        {
            context.FelhasznaloAdatok.Load();
            foreach (var s in context.FelhasznaloAdatok)
            {
                felhasznalocomboBox.Items.Add(s.felhasznalonev);
            }
        }
        private void ValasztottFelhasználóId()
        {
            var felhasznaloId = from s in context.FelhasznaloAdatok
                                where s.felhasznalonev == felhasznalocomboBox.Text
                                select s.Id;
        }

        private void HelyesJelszo()
        {
            var jelszo = from j in context.FelhasznaloAdatok
                         where j.felhasznalonev == felhasznalocomboBox.Text
                         select j.jelszo;
            if (jelszoTextBox.Text == jelszo.First())
            {
                MessageBox.Show("Siker");

                if (jelszoTextBox.Text=="admin")
                {
                    AdminMegnyitasa();
                }
                else
                {
                    TevékenységFelületBetöltés();
                }
                
            }
            else
            {
                MessageBox.Show("Nem Siker");
            }
        }

        private void TevékenységFelületBetöltés()
        {
            tevékenység tev = new tevékenység();
            tev.Show();
        }

        private void AdminMegnyitasa()
        {
            //this.Close()
            Adminfelület af = new Adminfelület();
            Form1 f1 = new Form1();
            f1.Close();
            af.Show();
        }
    }
}
