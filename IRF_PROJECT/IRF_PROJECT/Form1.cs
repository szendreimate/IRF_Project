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
        IRF_PROJECTEntities context = new IRF_PROJECTEntities();
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
            context.Felhasznalok.Load();
            foreach (var s in context.Felhasznalok)
            {
                felhasznalocomboBox.Items.Add(s.Felhasznalo);
            }
        }
        private void ValasztottFelhasználóId()
        {
            var felhasznaloId = from s in context.Felhasznalok
                                where s.Felhasznalo == felhasznalocomboBox.Text
                                select s.Id;
        }

        private void HelyesJelszo()
        {
            var jelszo = from j in context.Felhasznalok
                         where j.Felhasznalo == felhasznalocomboBox.Text
                         select j.jelszo;
            if (jelszoTextBox.Text == jelszo.First())
            {
                MessageBox.Show("Siker");
            }
            else
            {
                MessageBox.Show("Nem Siker");
            }
        }
    }
}
