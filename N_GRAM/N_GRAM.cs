using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using NGRAM;

namespace N_GRAM
{
    class N_GRAM
    {
        static void Main(string[] args)
        {
            NGram NG = new NGram();

            Console.WriteLine("original sentence:");
            NG.os = Console.ReadLine();
            Console.WriteLine("value of n:");
            NG.n = int.Parse(Console.ReadLine());

            Console.WriteLine("\nFrom 1-gram to n-gram:\n");
            if (NG.n>=1 && NG.n<=NG.os.Length )
            {
                for (int n=1;n<=NG.n;n++)
                {
                    Console.WriteLine("[{0}-gram]", n);
                    foreach (String ngram in NG.ngrams(NG.os,n))
                    {
                        Console.WriteLine(ngram);
                    }
                    Console.WriteLine("\n");
                }
            }

            Console.ReadLine();
        }
    }

}
