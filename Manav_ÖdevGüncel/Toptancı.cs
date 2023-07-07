using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manav_ÖdevGüncel
{
    internal class Toptancı
    {
       ArrayList Meyveler = new ArrayList() {"Elma","Armut","Kivi","Portakal" };
        ArrayList Sebzeler = new ArrayList() {"Pırasa","Dometes","Soğan","Patates"};

        public  void Meyvelistele()
        {
            for (int i = 0; i < Meyveler.Count; i++)
            {
                Console.WriteLine(i+1+". "+Meyveler[i]);
            }
            
        }
        public void SebzeListele()
        {
            for (int i = 0; i <Sebzeler.Count; i++)
            {
                Console.WriteLine(i +1+"."+Sebzeler[i]);
            }
        }
    }
}
