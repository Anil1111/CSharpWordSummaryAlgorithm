using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpWordSummaryAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really very long text.";
            //The method is on the StringUtility class for reusabillity purposes
            var summary = StringUtility.SummerizeText(sentence, 25);
            Console.WriteLine(summary);

        }
    }
}
