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
            var phrase = @"One Two One Three Two One Three Four One Two Three Four Five Six Seven Ten Ten Eight,Nine:Eleven;Twelve,Thirteen,Fourteen;Fifteen";

            foreach (var word in FilterDuplicateWords(phrase))
            {
                Console.WriteLine(word.ToString());
            }
        }

        public static List<string> FilterDuplicateWords(string phrase)
        {
            var list = phrase.Split(new[] { ' ', ',', ':', ';' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
            
            return list;
        }
    }
}
