using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstLetterCaps
{
    class firstLetter_caps
    {
        public void firstchar_caps()
        {
            char ch;
            do {
                Console.WriteLine("Enter the statement:");
                var text = Console.ReadLine();
                var newtext = "";
                foreach (var word in text.Split(' '))
                {
                    var newSentence = char.ToUpper(word[0]) + word.Substring(1);
                    newtext = newtext + " " + newSentence;
                }
                Console.WriteLine(newtext);
                Console.WriteLine("Do you want to continue?(y for continue)");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y');
        }
        
    }
}
