using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NGRAM
{
    class NGram
    {
        public String os; //original sentence
        public int n;  //value of n in N-Gram

        public List<String> ngrams(String os, int n)
        {
            List<String> ngrams = new  List<String>();
            String[] word = Regex.Split(os, @" ");
            for (int i = 0; i < word.Length - n + 1; i++)
            {
                ngrams.Add(after(word, i, i + n));
            }
            return ngrams;
        }
        public static String after(String[] words, int start, int end)
        {
            StringBuilder StringB = new StringBuilder();
            for (int i = start; i < end; i++)
            {
                StringB.Append((i > start ? " " : "") + words[i]);
            }
            return StringB.ToString();
        }

        //fail part
       /* public String after(String[] words, int start, int end)
        {
            StringBuilder StringB = new StringBuilder();

            for (int i = start; i < end; i++)
            {
                StringB.Append((i > start ? " " : "") + words[i]);
                int count = 1;
                for (int j = 0 ; j < end-start-1 ; j++)
                {
                    count++;
                    StringB.Append(" "+ words[j]);
                    if (count == n)
                        continue;
                }
                //StringB.Append((i > start ? " " : "") + words[i]);
            }
            return StringB.ToString();
        }*/
    }
}
