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
            FilterDuplicateWords();
        }

        public static void FilterDuplicateWords()
        {
             string phrase = @"one two one three two one three four one two three four five six seven";
            var list = phrase.Split(' ').ToList();
            
                list = list.Distinct().ToList();

            foreach(var word in list)
            {
               Console.WriteLine(word);
            }
            
 
        }
    }
}
