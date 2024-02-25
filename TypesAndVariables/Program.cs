using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {  // Value Types (Değer Tipleri)

            // Tam sayı veri tipleri.
            // byte < short < int < long
            byte number1 = 255;
            short number2 = 32767; 
            int number3 = 2147483647;
            long number4 = 2147483648;

            // Koşul veri tipi boolean
            bool condition = true;

            // Karakter veri tipi char
            char character = 'A';

            // Ondalıklı sayı veri tipleri
            // double < decimal
            double number5 = 10.4;
            decimal number6 = 10.4M; // tanımlamasında sonuna m harfi koymamız gerekmekte.

            // var tipi : İçerisine koyulan değere göre otomatik değişkeni atar.
            var number7 = 10;
            number7 = 'A';

            Console.WriteLine("Number 1 is {0}", number1);
            Console.WriteLine("Number 2 is {0}", number2);
            Console.WriteLine("Number 3 is {0}", number3);
            Console.WriteLine("Number 4 is {0}", number4);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("Character is {0}", (int)character); // A karakterinin ASCII kodunu verir.
            Console.WriteLine("Number 5 is {0}", number5);
            Console.WriteLine("Number 6 is {0}", number6);
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);
            Console.WriteLine(number7);
            Console.ReadLine();
        }
    }
    // Enum tanımlama. Bir nevi class oluşturup istediğimiz zaman birden fazla kez ulaşabiliyoruz.
    enum Days
    {
        Monday,Sunday,Tuesday,Wednesday,Thursday,Friday,Saturday
    }
}
