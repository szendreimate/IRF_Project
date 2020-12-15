using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace IRF_PROJECT
{
    public partial class Form1 : Form
    {
        Database1Entities1 context = new Database1Entities1();
        List<Penztarca> p = new List<Penztarca>();
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        Excel.Range xlRange;
        public Form1()
        {
            InitializeComponent();
            AdatokBetöltése();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdatokBetöltése();
        }

        public void AdatokBetöltése()
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            //List<Penztarca> p = new List<Penztarca>();
            PenztarcaBeolvasas pbe = new PenztarcaBeolvasas();
            //p = pbe.fillpenztarca();

            //try
            //{
            //if (string.IsNullOrEmpty(textBox1.Text.ToString()))
            //{
            //    MessageBox.Show("Szar");
            //    return;
            //}
            //else
            //{
            p = pbe.fillFilteredPenztarca(textBox1.Text.ToString());
            //AdatokBeallitas(p);
            var sorszam = (from s in context.Penztarcak
                           where s.masodlagoskod.Contains(textBox1.Text)
                           select s.Id).Count();

            //MegjelenoUserControl muc = new MegjelenoUserControl(p[1]);
            for (int i = 0; i < sorszam; i++)
            {
                panel1.Visible = true;
                MegjelenoUserControl1 muc = new MegjelenoUserControl1(p[i]);
                muc.Top = (panel1.Top + 20) * i;
                muc.Width = panel1.Width;
                panel1.Controls.Add(muc);
                panel1.Show();
                //MessageBox.Show(p[i].ToString());
            }
            //for (int i = 0; i < 3; i++)
            //{
            //    UserControlproba uc = new UserControlproba();
            //    uc.Top = (panel1.Top+10) * i;

            //    panel1.Controls.Add(uc);
            //}
            //    }

            //}
            //catch (Exception)
            //{

            //    throw;
            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            Robot_ablak ra = new Robot_ablak();
            dr = ra.ShowDialog();

            if (dr==DialogResult.OK)
            {
                MessageBox.Show("Sikeres megerősítés");
                CreateExcel();
            }
        }
        private void CreateExcel()
        {
            xlApp = new Excel.Application();


            xlWB = xlApp.Workbooks.Add(Missing.Value);


            xlSheet = xlWB.ActiveSheet;
            //CreateTable();

            xlApp.Visible = true;
            xlApp.UserControl = true;
        }

        
    }
}
