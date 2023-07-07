using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav_ÖdevGüncel
{
    
    public class Musteri
    {
       
      public  ArrayList Sepet = new ArrayList();
       
       
        public void SepetListele()
        {
            for (int i = 0; i < Sepet.Count; i++)
            {
                Console.Write($"ürün adı : {Sepet[i]} alınan kg : {Sepet[i+1]}");
                break;
            }
        }

    }
}
