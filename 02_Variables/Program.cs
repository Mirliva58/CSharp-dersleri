﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değişkenler (ders2 başlangıç)
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;
            //Console.WriteLine("Elma Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("Portakal Birim Fiyatı:" + orangePrice + "TL");
            //Console.WriteLine("Çilek Birim Fiyatı:" + strawberryPrice + " TL");
            //Console.WriteLine("Patates Birim Fiyatı:" + potatoPrice + "TL");
            //Console.WriteLine("Domates Birim Fiyatı:" + (tomatoPrice + " TL"));
            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;
            //Console.WriteLine();
            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;
            //Console.WriteLine("Alınan Ürün: Elma");
            //Console.WriteLine("Birim Fiyat: " + applePrice+ " TL");
            //Console.WriteLine("Gramaj: " + appleGram+ " Gr");
            //Console.WriteLine("Toplam Tutar: " + appleTotalPrice+ " TL");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Portakal");
            //Console.WriteLine("Birim Fiyat: " + orangePrice + " TL");
            //Console.WriteLine("Gramaj: " + orangeGram + " Gr");
            //Console.WriteLine("Toplam Tutar: " + orangeTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Çilek");
            //Console.WriteLine("Birim Fiyat: " + strawberryPrice + " TL");
            //Console.WriteLine("Gramaj: " + strawberryGram + " Gr");
            //Console.WriteLine("Toplam Tutar: " + strawberryTotalPrice + " TL");
            //Console.WriteLine(); 
            //Console.WriteLine("Alınan Ürün: Patates");
            //Console.WriteLine("Birim Fiyat: " + potatoPrice + " TL");
            //Console.WriteLine("Gramaj: " + potatoGram + " Gr");
            //Console.WriteLine("Toplam Tutar: " + potatoTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine("Alınan Ürün: Domates");
            //Console.WriteLine("Birim Fiyat: " + tomatoPrice + " TL");
            //Console.WriteLine("Gramaj: " + tomatoGram + "  Gr");
            //Console.WriteLine("Toplam Tutar: " + tomatoTotalPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();
            //double shoppingtotalPrice = tomatoTotalPrice + strawberryTotalPrice + potatoTotalPrice + orangeTotalPrice + appleTotalPrice;
            //Console.WriteLine("Toplam Ödenecek Tutar: " + shoppingtotalPrice + " TL");
            //Console.Read();
            #endregion
            #region Char Değişkenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            //Console.Read();
            #endregion
            #region Klavyeden veri girişleri string değişkenler
            //Console.WriteLine("**** Csharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcunun Soyadı: ");
            //passengerSurname = Console.ReadLine();
            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu yaş: ");
            //passengerAge = Console.ReadLine();
            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("Yolcu: "+ passengerName+ " " + passengerSurname);
            //Console.WriteLine("Yolcu TC No: " + passengerIdentityNumber);
            //Console.WriteLine("Yolcu Adres Bilgileri: " + passengerDistrict+" / " + passengerCity);
            #endregion
            #region Klavyeden Tam Sayı girişleri ve Dönüşümler
            //int shoesPrice, computerPrice, chairPrice, tvPrice; 
            //shoesPrice =1000;
            //computerPrice = 20000; 
            //chairPrice =5000; 
            //tvPrice =12000;
            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: "); 
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;
            //Console.Write("Toplam Ödemeniz Gereken Miktar: "+ totalPrice);



            #endregion
            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.WriteLine("Lütfen 1. Sınav notunu giriniz: ");
            //exam1= double.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen 2. Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen 3. Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //result=(exam1+exam2 + exam3)/3 ;
            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: "+ result);

            #endregion
            #region Klavyeden Karakter Girişleri (ders2 sonu)
            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender= char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion
        }
    }
}
