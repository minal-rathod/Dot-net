using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkvowelinWord
{
    class vowel__in_word
    {
        public void word_vowel()
        {
            string word;
            char ch;
            do
            {
                Console.WriteLine("Enter the word:");
                word = (Console.ReadLine());
                char[] arr = word.ToCharArray();
                foreach (char c in arr)
                {
                    if (c != 'a' && c != 'e' && c != 'o' && c != 'i' && c != 'u' && c != 'A' && c != 'E' && c != 'O' && c != 'I' && c != 'U')
                    {
                        Console.Write(c);
                    }
                }
                Console.WriteLine("Do you want to continue??(y to continue)");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y');
         

        }
    }
}
