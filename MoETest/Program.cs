using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoETest
{
    class Program
    {
        static void Main(string[] args)
        {
            var phrase = @"one two one three two one three four one two three four five six seven ten Ten eight,nine:eleven;twelve,thirteen,fourteen;fifteen";
            FilterDuplicateWords(phrase);
        }

        public static void FilterDuplicateWords(string phrase)
        {
            var list = phrase.Split(new[] { ' ', ',', ':', ';' }).ToList();
            
                list = list.Distinct().ToList();

            foreach(var word in list)
            {
               Console.WriteLine(word);
            }
            
 
        }
    }
}
