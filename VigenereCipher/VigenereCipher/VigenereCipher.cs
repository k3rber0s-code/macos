using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VigenereCipher
{
    class VigenereCipher
    {
        /*
         */
        static void Main(string[] args)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string text = "jak se máš? Ja se mam fajn.";
            string key = "sdasdasd";
            int pointer = 0;

            var alphabetArray = alphabet.ToCharArray();
            var keyArray = key.ToCharArray();

            foreach (char c in text.ToCharArray())
            {
                if (IsEnglishLetter(c))
                {
                    char e = Encipher(c, pointer, keyArray, alphabetArray);
                    pointer = ++pointer % key.Length;
                    Console.WriteLine(e);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
            Console.ReadKey();

        }
        private static bool IsEnglishLetter(char c)
        {
            return (((c > 64) && (c < 96)) || ((c > 96) && (c < 123)));
        }

        private static char Encipher(char c, int pointer, char[] keyArray, char[] alphabetArray)
        {
            int i = GetIndexInAlphabet(c);
            int p = (i + (GetKey(pointer, keyArray))) % 26;
            return Char.IsUpper(c) ? Char.ToLower(alphabetArray[p]) : alphabetArray[p];
        }

        private static int GetKey(int pointer, char[] keyArray)
        {
            //UpdatePointer(pointer);
            return GetIndexInAlphabet(keyArray[pointer]);

        }
        private static int GetIndexInAlphabet(char c)
        {
            c = char.ToUpper(c);
            int index = (int)c.CompareTo('A');
            return index;
        }
    }
}