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
        
        public Form1()
        {
            InitializeComponent();
            AdatokBetöltése();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdatokBetöltése();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            Robot_ablak ra = new Robot_ablak();
            dr = ra.ShowDialog();

            if (dr == DialogResult.OK)
            {
                MessageBox.Show("Sikeres megerősítés");
                CreateExcel();
            }
        }
        public void AdatokBetöltése()
        {
            panel1.Controls.Clear();
            panel1.Visible = true;
            
            PenztarcaBeolvasas pbe = new PenztarcaBeolvasas();
      
            p = pbe.fillFilteredPenztarca(textBox1.Text.ToString());
           
            var sorszam = (from s in context.Penztarcak
                           where s.masodlagoskod.Contains(textBox1.Text)
                           select s.Id).Count();

           
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
           
        }

        
        private void CreateExcel()
        {
            xlApp = new Excel.Application();


            xlWB = xlApp.Workbooks.Add(Missing.Value);


            xlSheet = xlWB.ActiveSheet;
            CreateTable();

            xlApp.Visible = true;
            xlApp.UserControl = true;
        }
        private void CreateTable()
        {
            //fejléc
            string[] headers = new string[] {
             "Termék Neve",
             "Márka",
             "Ajánlott Nem",
             "Színe",
             "Másodlagoskód",
             "Link"
            };

            for (int i = 0; i < headers.Length; i++)
            {

                xlSheet.Cells[1, i + 1] = headers[i];

            }
           
            int szamlalo = 0;

            foreach (Penztarca elem in p)
            {
                xlSheet.Cells[2 + szamlalo, 1] = elem.Név;
                xlSheet.Cells[2 + szamlalo, 2] = elem.Márka;
                xlSheet.Cells[2 + szamlalo, 3] = elem.Nem;
                xlSheet.Cells[2 + szamlalo, 4] = elem.Szín;
                xlSheet.Cells[2 + szamlalo, 5] = elem.Másodlagoskod;
                xlSheet.Cells[2 + szamlalo, 6] = "https://www.markasbolt.hu/keres?gyorkeresoMezo=" + elem.Másodlagoskod;


                szamlalo++;
            }




            //fejléc kiemelése
            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            //szövegigazítás
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            //fejléc betűszín színezése
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.Red;
            //szegély
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

            Excel.Range teljestabla = xlSheet.get_Range(GetCell(1, 1), GetCell(xlSheet.UsedRange.Rows.Count, 6));
            teljestabla.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);
        }

        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;
            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();
            return ExcelCoordinate;
        }

        
    }
}
