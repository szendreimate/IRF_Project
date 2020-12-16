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
        
        public PenztarcaBeolvasas()
        {

        }
        public List<Penztarca> fillFilteredPenztarca(string feltetel)
        {
            List<Penztarca> retval = new List<Penztarca>();
            
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
            
            foreach (var sza in szurtadat)
            {
                //szűrt adatok átadása
                Penztarca penz = new Penztarca();

                penz.Név = sza.nev;
                penz.Márka = sza.marka;
                penz.Nem = sza.nem;
                penz.Szín = sza.szin;
                penz.Másodlagoskod = sza.masodlagos;

                retval.Add(penz);
            } 
            return retval;
        }



    }


}

