using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_PROJECT
{
    
    public partial class PenztarcaBeolvasas
    {
        Database1Entities context = new Database1Entities();
        
    }
    public List<Penztarca> fillpenztarca()
    {
        List<Penztarca> retval = new List<Penztarca>();

        //for ciklus eleje
        retval.Add(new Penztarca());
        retval[0].Név = "XY pénztárca";
        retval[0].Márka = "Miana";
        retval[0].Nem = "Női";
        retval[0].Szín = "Piros";
        retval[0].Másodlagoskod = "AB608";
        //for ciklus vege
        return retval;
    }
}
