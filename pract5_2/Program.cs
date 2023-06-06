using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != text[text.Length - i - 1])
                {
                    proverka = false;
                    break;
                } 
            }
            if (proverka)
            {
                Console.WriteLine("Введеное слово является перевертышем");
            }
            else
            {
                Console.WriteLine("Введеное слово не является перевертышем");
            }
        }
    }
}
