using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {// Arrays(Diziler)
            // Tek tek tüm stringleri tanımlamak yerine dizi kullanırız.
            string student1 = "Muharrem";
            string student2 = "Ahmet";
            string student3 = "Mehmet";

            // 1.Array tanımı
            string[] students = new string[3];
            students[0] = "Muharrem";
            students[1] = "Ahmet";
            students[2] = "Mehmet";

            foreach (string s in students)
            {
                Console.WriteLine(s);
            }

            // 2. Array tanımı
            string[] students2 = { "Muharrem", "Mehmet", "Ahmet" };
            // Aşağıdaki tanımlamayı yapmak istediğimiz zaman hata verecektir çünkü ilk tanımlamada dizinin
            // boyutunun ne kadar olacağını belirtmemiz gerekmekte ve biz 3 karakter ile tanımlama 
            // yaptığımız için fazladan bir index ekleyemeyiz.
            //students2[3] = "Abdullah";

            //Çok boyutlu diziler
            string[,] regions = new string[5, 3]
            {
                { "İstanbul","İzmit","Balıkesir"},
                { "Ankara","Konya","Kırıkkale"},
                { "Antalya","Adana","Mersin"},
                { "Rize","Trabzon","Samsun"},
                { "İzmir","Mugla","Manisa"}
            };
            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("**********");
            }



            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
