using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Manav_ÖdevGüncel
{
    public class Manav
    {
       
        public ArrayList Meyveler = new ArrayList();
        public ArrayList MeyveKg = new ArrayList();
       
        
        
        public  ArrayList Sebzeler = new ArrayList();
        public ArrayList SebzeKg = new ArrayList();
        Musteri musteri = new Musteri();

        public void MeyveEkle(string meyveAd , int Meyvekg)
        {
            Meyveler.Add(meyveAd);
            MeyveKg.Add(Meyvekg);

        }
        public void SebzeEkle(string sebzead,int Sebzekg)
        {
            Sebzeler.Add(sebzead);
            SebzeKg.Add(Sebzekg);
        }

        public void MeyeveListele()
        {
            for (int i = 0; i < Meyveler.Count; i++)
            {
                Console.WriteLine(i+1 + ". MeyveAdı :  " + Meyveler[i] + " Meyve Kg :" + MeyveKg[i]);

            }
            
        }
        public void SebzeListele()
        {
            for (int i = 0; i <Sebzeler.Count; i++)
            {
                Console.WriteLine(i + 1 + ". Sebzeler : " + Sebzeler[i] + "Sebze Kg :" + SebzeKg[i]);
            }
        }
     
        public void UrunArama(int ürün,int kg )
        {
           
            int listekg =Convert.ToInt32(MeyveKg[ürün-1]);

            if (Meyveler.Count > 0 && listekg >=kg )
            {

                
                

                musteri.Sepet.Add(Meyveler[ürün-1]);
                musteri.Sepet.Add(kg);

                MeyveKg[ürün - 1] = listekg - kg;
            }
            else
            {
                Console.WriteLine("Elimizde Belirtiğiniz Kg Meyve yok ");
            }

            Console.WriteLine("---------------------------------");        



        }
        public void UrunAramasebze(int ürün, int kg)
        {

            int listekg = Convert.ToInt32(SebzeKg[ürün - 1]);

            if (Sebzeler.Count > 0 && listekg >= kg)
            {




                musteri.Sepet.Add(Sebzeler[ürün - 1]);
                musteri.Sepet.Add(kg);

                SebzeKg[ürün - 1] = listekg - kg;
            }
            else
            {
                Console.WriteLine("Elimizde Belirtiğiniz Kg Meyve yok ");
            }

            Console.WriteLine("---------------------------------");
        }
            public void MusteriSepet()
            {
            
            for (int i = 0; i < musteri.Sepet.Count; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine("Ürün Adı : " + musteri.Sepet[i]);
                }
                else
                {
                    Console.WriteLine("Ürün Kg : "+ musteri.Sepet[i]);
                }


            }
         
            

            
                
              
            
        }
      
        
    }

      
    }
    