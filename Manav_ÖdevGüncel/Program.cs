using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Manav_ÖdevGüncel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            Manav manav = new Manav();
            Toptancı toptancı = new Toptancı();
            while (true)
            {

            
            Console.WriteLine("HALE HOŞGELDİNİZ Meyve İçin (M) Sebze için (S) ye basınız");
            string sec = Console.ReadLine().ToUpper();
                Console.Clear();

            if (sec == "M")
            {
                toptancı.Meyvelistele();
                while (true)
                {
                    Console.WriteLine("Almak isteğiniz Ürünü Seçiniz ");
                    string YeniMeyve = Console.ReadLine();
                        
                    Console.WriteLine("Kaç Kilo Almak İstiyorsunuz");
                    int MeyveKg = Convert.ToInt16(Console.ReadLine());
                        Console.Clear();
                        manav.MeyveEkle(YeniMeyve, MeyveKg);
                    Console.WriteLine("Başka Arzunuz Varmı Evet İçin  (E) Hayır (H) Basınız  ");
                        string Sec1 = Console.ReadLine().ToUpper();
                        if (Sec1 == "E")
                        {
                            break;
                        }
                        else if (Sec1 =="H")
                        {


                            while (true)
                            {
                                Console.WriteLine("****** Manava HoşGeldiniz Meyveler İçin (M) Sebzeler İçin (S) Basınız ******");
                                string Sec = Console.ReadLine().ToUpper();
                                Console.Clear();
                                while (true)
                                {
                                    if (Sec == "M")
                                    {
                                        manav.MeyeveListele();

                                        Console.WriteLine("Almak İsteğiniz Ürünün Sıra Numarasını Giriniz ");
                                        int ürün = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("Kaç Kg Alıcaksınız ");
                                        int kg = Convert.ToInt16(Console.ReadLine());
                                        
                                        if (manav.Meyveler.Count > 0)
                                        {
                                            manav.UrunArama(ürün,kg);

                                        }
                                        else
                                        {
                                            Console.WriteLine("Eklenecek ürün bulunamadı...");
                                        }
                                        Console.WriteLine("Başka bir arzunu var mı? Evet (E) veya Hayır (H)");
                                        string SEC = Console.ReadLine().ToUpper();
                                        if (SEC == "E")
                                        {
                                            break;
                                        }
                                        else
                                        {

                                            Console.WriteLine("Müşteri Sepet İçerisinde bulunan Ürünler ");

                                            manav.MusteriSepet();
                                            Console.WriteLine("*** İYİ GÜNLER *** ");
                                            Console.ReadLine();
                                            Environment.Exit(0);

                                        }



                                    }
                                    if (Sec == "S")
                                    {
                                        manav.SebzeListele();
                                        Console.WriteLine("Almak İstediğiniz Ürünün Sıra Numarasını Giriniz");
                                        int ürün = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("Kaç Kg Alıcaksınız ?");
                                        int kg = Convert.ToInt32(Console.ReadLine());
                                        
                                        if (manav.Sebzeler.Count > 0)
                                        {
                                            manav.UrunArama(ürün, kg);
                                            
                                        }
                                        else
                                        {
                                            Console.WriteLine("Eklenicek Ürün Bulunamadı...");
                                        }
                                        Console.WriteLine("Başka bir arzunu var mı? Evet (E) veya Hayır (H)");
                                        string SEC = Console.ReadLine().ToUpper();
                                        if (SEC == "E")
                                        {
                                            break;
                                        }
                                        else
                                        {

                                            Console.WriteLine("Müşteri Sepet İçerisinde bulunan Ürünler ");

                                            manav.MusteriSepet();
                                            Console.WriteLine("*** İYİ GÜNLER *** ");
                                            Console.ReadLine();
                                            Environment.Exit(0);
                                        }
                                    }


                                }       
                               

                            }


                        }
                   
                }

            }
            else if(sec == "S")
            {
                    toptancı.SebzeListele();
                    while (true)
                    {
                        Console.WriteLine("Almak isteğiniz Ürünü Seçiniz ");
                        string YeniSebze = Console.ReadLine();

                        Console.WriteLine("Kaç Kilo Almak İstiyorsunuz");
                        int SebzeKg = Convert.ToInt16(Console.ReadLine());
                        Console.Clear();
                        manav.SebzeEkle(YeniSebze, SebzeKg);
                        Console.WriteLine("Başka Arzunuz Varmı Evet İçin  (E) Hayır (H) Basınız  ");
                        string Sec1 = Console.ReadLine().ToUpper();
                        if (Sec1 == "E")
                        {
                            break;
                        }
                        else if (Sec1 == "H")
                        {
                            while (true)
                            {
                                Console.WriteLine("****** Manava HoşGeldiniz Meyveler İçin (M) Sebzeler İçin (S) Basınız ******");
                                string Sec = Console.ReadLine().ToUpper();
                                Console.Clear();
                                while (true)
                                {
                                    if (Sec == "M")
                                    {
                                        manav.MeyeveListele();

                                        Console.WriteLine("Almak İsteğiniz Ürünün Sıra Numarasını Giriniz ");
                                        int ürün = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("Kaç Kg Alıcaksınız ? ");
                                        int kg = Convert.ToInt16(Console.ReadLine());

                                        if (manav.Meyveler.Count > 0)
                                        {
                                            manav.UrunArama(ürün, kg);

                                        }
                                        else
                                        {
                                            Console.WriteLine("Eklenecek ürün bulunamadı...");
                                        }
                                        Console.WriteLine("Başka bir arzunu var mı? Evet (E) veya Hayır (H)");
                                        string SEC = Console.ReadLine().ToUpper();
                                        if (SEC == "E")
                                        {
                                            break;
                                        }
                                        else
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Müşteri Sepet İçerisinde bulunan Ürünler ");

                                            manav.MusteriSepet();
                                            Console.WriteLine("*** İYİ GÜNLER *** ");
                                            Console.ReadLine();
                                            Environment.Exit(0);

                                        }



                                    }
                                    if (Sec == "S")
                                    {
                                        manav.SebzeListele();
                                        Console.WriteLine("Almak İstediğiniz Ürünün Sıra Numarasını Giriniz");
                                        int ürün = Convert.ToInt32(Console.ReadLine());

                                        Console.WriteLine("Kaç Kg Alıcaksınız ?");
                                        int kg = Convert.ToInt32(Console.ReadLine());

                                        if (manav.Sebzeler.Count > 0)
                                        {
                                            manav.UrunAramasebze(ürün, kg);

                                        }
                                        else
                                        {
                                            Console.WriteLine("Eklenicek Ürün Bulunamadı...");
                                        }
                                        Console.WriteLine("Başka bir arzunu var mı? Evet (E) veya Hayır (H)");
                                        string SEC = Console.ReadLine().ToUpper();
                                        if (SEC == "E")
                                        {
                                            Console.Clear();
                                            break;
                                            
                                        }
                                        
                                        else
                                        {
                                            Console.Clear();

                                            Console.WriteLine("Müşteri Sepet İçerisinde bulunan Ürünler ");

                                            manav.MusteriSepet();
                                            Console.WriteLine("*** İYİ GÜNLER *** ");
                                            Console.ReadLine();
                                            Environment.Exit(0);

                                        }
                                    }


                                }


                            }


                        }

                    }

                }
            }
           
            }

        
        }
    }

