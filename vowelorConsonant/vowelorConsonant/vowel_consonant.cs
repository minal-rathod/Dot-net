using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowelorConsonant
{
    class vowel_consonant
    {
        public void vowel_or_consonant()
        {
            Console.WriteLine("Enter the alphabet:");
            char alphabet = Convert.ToChar(Console.ReadLine().ToLower());
            if(alphabet == 'a'|| alphabet == 'e' || alphabet=='i' || alphabet=='o'|| alphabet=='u')
            {
                Console.WriteLine("Alphabet {0} is vowel.", alphabet);
            }
            else
            {
                Console.WriteLine("Alphabet {0} is consonant.", alphabet);
            }
            Console.ReadLine();
        }
         
    }
}



