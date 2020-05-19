using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СshGit4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nВведите 15 элементов (цифры и символы): ");
            List<char> col = new List<char>();
            char[] col1 = new char[15];

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("\nВведите " + (i + 1) + " элемент коллекции: ");
                col1[i] = char.Parse(Console.ReadLine());
                
            }
            
            for(int i = 0; i < 15; i++)
            {
                col.Add(col1[i]);
            }

            var col2 = new List<char>();
            int z = 0;

            for (int i = 0; i < 15; i++)
            {
                if (char.IsUpper(col[i]))
                {
                    z++;
                    if (z > 0)
                    {
                        col2.Add(col[i]);
                    }
                }
            }

            List<char> col3 = new List<char>();

            int nd = 0;
            for(int i = 0; i < 15; i++)
            { 
                if (Char.IsDigit(col[i]) )
                {
                    nd++;
                    if (nd>0)
                    {
                        col3.Add(col[i]);
                    }
                }
            }

            Console.WriteLine("\nКоллекция, состоящая только из чисел:");
            for(int i =0; i < nd; i++)
            {
                Console.WriteLine(col3[i]);
            }

            Console.WriteLine("\nКоллекция, состоящая только из заглавных букв:");
            for(int i = 0; i<z; i++)
            {
                Console.WriteLine(col2[i]);
            }
        }
    }
}
