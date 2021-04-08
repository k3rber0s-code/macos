using System;
using System.IO;
namespace VigenereCipher
{
    class Programme
    {
        /*
         */
        static void Main(string[] args)
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string key = Console.ReadLine();
            int pointer = 0;

            var alphabetArray = alphabet.ToCharArray();
            var keyArray = key.ToCharArray();


            using (StreamReader sr = File.OpenText("a.txt"))
            using (StreamWriter sw = File.AppendText("b.txt"))
            {
                var read = sr.Read();
                while (read != -1)
                {
                    char c = (char)read;
                    if (IsEnglishLetter(c))
                    {
                        char e = Encipher(c, pointer, keyArray, alphabetArray);
                        pointer = ++pointer % key.Length;
                        sw.Write(e);
                    }
                    else
                    {
                        sw.Write(c);
                    }
                    read = sr.Read();
                }
            }


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




