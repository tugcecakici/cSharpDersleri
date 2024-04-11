using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Ankara";
            //string aslında bir char arrayidir.(karakter dizisi)
            Console.WriteLine(city[0]); //Ankaranın ilk elemanını yazdır demek.

            string city2 = "İstanbul";
            string result = city + city2;

            Console.WriteLine(result);

            Console.WriteLine(string.Format("{0},{1}", city, city2));

            //String properties dersi:
            string sentence = "My name is Tuğçe Çakıcı";
            var result2 = sentence.Length; //cümlenin kaç karakterden oluştuğunu verir.
            Console.WriteLine(result2);

            var result3 = sentence.Clone();
            //sentence = "My name is Demiroğ"; //sentence değiştirsek de result3 değişmemiş oluyor. İlk yazan cümleyi klonluyoruz.
            Console.WriteLine(result3);

            bool result4 = sentence.EndsWith("ğ");
            bool result5 = sentence.EndsWith("A");
            Console.WriteLine(result5); //A ile başlamadığı için false yazar.
            
            var result6 = sentence.IndexOf("name"); //name kelimesi kaçıncı karakterde başlıyor bulmak için kullanılır.
            //Bulamazsa eğer ekrana -1 çıkar.
            Console.WriteLine(result6);

            var result7 = sentence.IndexOf(" "); //boşluğu arattığımızda bulduğu ilk boşluğun sırasını yazar. Diğer boşluklara bakmaz.
            Console.WriteLine(result7);

            var result8 = sentence.LastIndexOf(" "); //aramaya sondan başlar.
            Console.WriteLine(result8);

            var result9 = sentence.Insert(0, "Hello, "); //0. karakterden sonra Hello, yazısını ekle demek.
            Console.WriteLine(result9);

            var result10 = sentence.Substring(3); //3.Karakterden itibaren böl demek, öncesi gidiyor.
            Console.WriteLine(result10);

            var result11 = sentence.ToLower(); //tüm karakterleri küçük harfli yazar.
            var result12 = sentence.ToUpper(); //tüm karakterleri büyük harfli yazar.

            var result13 = sentence.Replace(" ", "-"); //boşluk karakterini -'ye çevir demek.
            Console.WriteLine(result13);

            var result14 = sentence.Remove(2); //2. karakterden itibaren kalanları sil demek. Sadece my çıkar ekrana.
            Console.WriteLine(result14);


            Console.ReadLine();

        }
    }
}
