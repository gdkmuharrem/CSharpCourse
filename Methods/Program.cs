using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            Add();
            Add2(3, 4);
            Add2(124, 15);
            Add3(124, 15);
            Console.WriteLine(Add3(14, 21));
            Console.WriteLine(Add4(14, 21));
            Console.WriteLine(Add4());
            Console.WriteLine("------------------");

            // Ref keyword
            int number1 = 10;
            int number2 = 100;
            // ref olarak kullandığımız için metodun içerisinde number1'in değerinde bir değişiklik
            // olursa otomatik olarak global olan number1'in değeri de değişcektir çünkü globale referans
            // gösterilmektedir.
            var result = Add5(ref number1, number2);
            Console.WriteLine(result);

            // out keyword
            int number3 = 10;
            int number4 = 100;
            // out olarak kullandığımız zaman aynı ref'deki mantık işlemektedir. Fakat ref ile out
            // arasındaki en temel fark :
            // ref => ilk değer ataması yapılmak zorundadır.!!!
            // out => ilk değeri yerine metod içerisinde değer atanması gerekmektedir.!!!
            var result2 = Add6(out number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine("------------------");

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 6));
            Console.WriteLine(Sum(2, 4, 6,5,12,516,21,42,51,24));



            Console.ReadLine();
        }
        static void Add()
        { // Parametre almıyor ve döndürmüyor ekrana yazı yazıyor.
            Console.WriteLine("Added !!!");
        }
        static void Add2(int number1, int number2)
        { // Parametre alıyor fakat döndürmüyor direkt ekrana basıyor.
            Console.WriteLine(number1 + number2);
        }
        static int Add3(int number1, int number2)
        { // Parametre alıyor işlemi gerçekleştirip geriye döndürüyor.
            return number1 + number2;
        }
        static int Add4(int number1 = 10, int number2 = 20)
        { // Default değeri var parametre alabilir de almayabilir de geriye döndürüyor.
            number1 = 30; // değişkenin değerini tekrar değiştirdik en son hali önemlidir.
            return number1 + number2;
        }
        static int Add5(ref int number1, int number2)
        { // Default değeri var parametre alabilir de almayabilir de geriye döndürüyor.
            number1 = 30; // değişkenin değerini tekrar değiştirdik en son hali önemlidir.
            return number1 + number2;
        }
        static int Add6(out int number1, int number2)
        { // Default değeri var parametre alabilir de almayabilir de geriye döndürüyor.
            number1 = 30; // değişkenin değerini tekrar değiştirdik en son hali önemlidir.
            return number1 + number2;
        }

        // Method Overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        //Params keyword ile overloading daha kolay.
        static int Sum(int number1 ,params int[] numbers) // parametre metod tanımında en sonda olmalı!!!
        {
            // Gelecek olan tüm int parametreleri toplayıp return edecek.
            return numbers.Sum();
        }
    }
}
