using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace metodlar
{
    internal class magaza
    {

        static double bakiye = 0;

        static string[] urunler = { "Elbise", "Ayakkabı", "Çanta", "Aksesuar","Süveter", "Gömlek","Kot Pantol"  };
        static double[] fiyatlar = { 150.0, 200.0, 300.0, 50.0, 120.0, 130.0, 180.0 };
        static void Main(string[] args)
        {
            String secim="";

          
            
            while (true)
            {
                Console.WriteLine("----- Aslı'm Butik -----");
                Console.WriteLine("1: Bakiye sorgulama");
                Console.WriteLine("2: Para yatırma");
                Console.WriteLine("3: Satın alma");
                Console.WriteLine("4: Çıkış");
                Console.Write("yapmak istediğiniz işlemi seçiniz: ");
                secim=Console.ReadLine();
                
              
                if (secim == "1")
                {
                    bakiyeSorgulama();
                }
                else if (secim == "2")
                {
                    paraYatirma();
                }
                else if (secim == "3")
                {
                    Urunlerilistele();
                    
                }
                else if (secim == "4")
                {
                    Console.WriteLine("çıkış yapılıyor...");
                    break;
                }
                else
                {
                    Console.WriteLine("geçersiz seçim, lütfen tekrar deneyiniz.");
                }
            }
        }
        

        static void bakiyeSorgulama()
        {
            Console.WriteLine($"Bakiyeniz:{bakiye} ");
        }

        static void paraYatirma()
        {
            Console.Write("Yatırmak istediğiniz tutarı giriniz(%2 komisyon alınmaktadır): ");
            double tutar=double.Parse(Console.ReadLine());
            double komisyon = tutar * 0.02;
            bakiye += tutar - komisyon;
            Console.WriteLine($" para yatırma işlemi başarılı. Güncel bakiyeniz: {bakiye}");
        }


        static void Urunlerilistele()
        {
            
                while (true)
                {
                   
                    Console.WriteLine("--- Raflardaki Ürünler ---");
                    Console.WriteLine($"{"No",-5} {"Ürün Adı",-20} {"Fiyat"}");
                    Console.WriteLine("------------------------------------");

                    for (int i = 0; i < urunler.Length; i++)
                    {
                        Console.WriteLine($"{i + 1,-5} {urunler[i],-20} {fiyatlar[i]} TL");
                    }
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("0: ANA MENÜYE DÖN");
                    Console.WriteLine($"Güncel Bakiyeniz: {bakiye} TL");

                    Console.Write("Satın almak istediğiniz ürün numarasını giriniz: ");

                    
                    try
                    {
                        int urunNo = int.Parse(Console.ReadLine());

                    
                        if (urunNo == 0) return;

                        int index = urunNo - 1;

                        if (index < 0 || index >= urunler.Length)
                        {
                            Console.WriteLine("Geçersiz ürün numarası!");
                            continue;
                        }

                        Console.Write("Almak istediğiniz adedi giriniz: ");
                        int adet = int.Parse(Console.ReadLine());


                    if (adet <= 0)
                    {
                        Console.WriteLine("Adet en az 1 olmalıdır.");
                    }
                    else
                    {
                        double nihaifiyat = fiyatlar[index] * adet;

                        if (bakiye >= nihaifiyat)
                        {
                            bakiye -= nihaifiyat;
                            Console.WriteLine($"{urunler[index]} ürününden {adet} adet alındı. Kalan bakiye: {bakiye} TL");
                        }
                        else
                        {
                            double eksik = nihaifiyat - bakiye;
                            Console.WriteLine("YETERSİZ BAKİYE!");
                            Console.Write($"Eksik Tutar: {eksik} \n Bu menüden hızlıca para yatırmak ister misiniz(E/H)? ");
                            char choice = char.Parse(Console.ReadLine());
                            if (choice == 'E')
                            {
                                paraYatirma();

                                if (bakiye >= nihaifiyat)

                                {

                                    bakiye -= nihaifiyat;

                                    Console.WriteLine($"{nihaifiyat} satın alma işlemi başarılı. Kalan bakiyeniz: {bakiye}");
                                }

                                else

                                {
                                    Console.WriteLine("Yeterli bakiye hala yok. Satın alma işlemi iptal edildi.");
                                }

                            }
                        }

                    }         
                    }
                    catch
                    {
                        Console.WriteLine("Hatalı giriş yaptınız! Lütfen sadece sayı giriniz.");
                        Console.ReadKey();
                    }
                }
            

        }

    }
}
