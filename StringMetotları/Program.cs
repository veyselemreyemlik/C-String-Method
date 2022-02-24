using System;

namespace StringMetotları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SPLİT ile belirlenen noktadan itibaren gelen yazıları dizi halinde yazdırır.
            string cizgiler = new string('-' , 50);
            string deger = "Kocaeli Üniversitesi Bilişim Sistemleri Mühendisliği";
            string[] donus = deger.Split("Kocaeli"); //Boşluktan itibaren böler ve geri kalanı dizi halinde yazdırır
            foreach (var item in donus)
            {
                Console.WriteLine(item);
            }

            // Substring belirlenen indexten itibaren istenilen yere kadar yazdırır.
            Console.WriteLine(deger.Substring(0,4));

            // Replace belirlenen yerlerin yerine istenileni koyar
            Console.WriteLine(deger.Replace(" " , "-"));

            //Insert istenilen yere ekleme yapar.
            Console.WriteLine(deger.Length);
            Console.WriteLine(deger.Insert( deger.Length, "Veysel..."));
        }
    }
}
