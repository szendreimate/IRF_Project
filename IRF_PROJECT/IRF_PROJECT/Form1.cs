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
        List<Penztarca> p = new List<Penztarca>();
        public Form1()
        {
            InitializeComponent();
           // MegjelenoUserControl1 muc = new MegjelenoUserControl1(p);
        }
       
    }
}
