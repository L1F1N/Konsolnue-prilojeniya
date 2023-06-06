using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите слово: ");
            string word = Console.ReadLine();
            bool proverka = true;
            for(int i = 0; i < word.Length/2; i++)
            {
                if (word[i] != word[word.Length-i-1])
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
