using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_PROJECT
{

    public partial class PenztarcaBeolvasas
    {
        Database1Entities1 context = new Database1Entities1();
        /*
         static void Main(string[] args)
        {
            List<Penztarca> penztarcak = new List<Penztarca>();
            penztarcak.Add(new Penztarca());
            penztarcak[0].Név = "XY pénztárca";
            penztarcak[0].Márka = "Miana";
            penztarcak[0].Nem = "Női";
            penztarcak[0].Szín = "Piros";
            penztarcak[0].Másodlagoskod = "AB608";
        }
        */
        public PenztarcaBeolvasas()
        {

        }
        public List<Penztarca> fillFilteredPenztarca(string feltetel)
        {
            List<Penztarca> retval = new List<Penztarca>();
            //DB lekérdezés where = feltetel

            List<object> Adatok = new List<object>();
            //try
            //{
            //    if (string.IsNullOrEmpty(feltetel))
            //    {
            //        Console.WriteLine("szar2");
            //    }
            //    else
            //    {
            //var szurtadat = (from sz in context.Penztarcak
            //                 where sz.masodlagoskod.Contains(feltetel)
            //                 select sz).ToList();

            var szurtadat = (from sz in context.Penztarcak
                             where sz.masodlagoskod.Contains(feltetel)
                             select new
                             {
                                 nev = sz.nev.ToString(),
                                 marka = sz.marka.ToString(),
                                 nem = sz.nem.ToString(),
                                 szin = sz.szin.ToString(),
                                 masodlagos = sz.masodlagoskod.ToString()
                             }).ToList();
            var sorszam = (from s in context.Penztarcak
                           where s.masodlagoskod.Contains(feltetel)
                           select s.marka).Count();
            //List<FeltetelesAdatok> feltadd = new List<FeltetelesAdatok>();
            foreach (var item in szurtadat)
            {
                //feltadd.Add

                //    (new FeltetelesAdatok[] { (string)feltadd=item.nev, item.marka, item.nem, item.szin, item.masodlagos }
                //    );
                //for (int i = 0; i < sorszam; i++)
                //{
                //    retval.Add(new Penztarca());
                //    retval[i].Név = szurtadat[i].nev;
                //    retval[i].Márka = szurtadat[i].marka;
                //    retval[i].Nem = szurtadat[i].nem;
                //    retval[i].Szín = szurtadat[i].szin;
                //    retval[i].Másodlagoskod = szurtadat[i].masodlagos;

                //}
                Penztarca penz = new Penztarca();

                penz.Név = item.nev;
                penz.Márka = item.marka;
                penz.Nem = item.nem;
                penz.Szín = item.szin;
                penz.Másodlagoskod = item.masodlagos;

                retval.Add(penz);
            }


            
            return retval;

            //}

            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //return retval;


        }



    }


}

