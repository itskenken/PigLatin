using System;
using System.Text.RegularExpressions;
using static System.Console;
namespace PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string outpt = "";
            
            string word;
            WriteLine("Enter a word");

            word = Console.ReadLine();
            word = word.ToLower();

            outpt += word + " in pig latin is:\n ";
            WriteLine(outpt);
            pigLatin(word);
            string sentence;
            outpt = "\n\nNow enter a sentence.";
            WriteLine(outpt);
            sentence = ReadLine();
            sentence = sentence.ToLower();
            string[] words = Regex.Split(sentence, @" .?!,");
            foreach (string w in words)
            {
                pigLatin(w);
                
            }
            


            ReadKey();
        }
        public static Boolean isConsonant (char ch)
        {
            string vowels = "aeiouy"; 
            for (int v = 0; v < vowels.Length; v++)
            {
                if (vowels[v] != ch)
                    return true;
                break;
            }
            return false;
        }
        public static void pigLatin(string s)
        {
            string outpt = "";
            
            
            if (isConsonant(s[0]))
            {
                outpt = s.Substring(1);
                outpt += s[0] + "ay";
            }
            else
                outpt += s + "ay";
                        Write(outpt + " ");
        }
     
    }
}
