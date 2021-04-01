using System;

namespace VigenereCipher
{
    public class VigenereCipher
    {
        /*  Ci = Ti + Ki (mod m)
         *  --------
         *  Ci - i-tý znak šifrovaného 
         *  Ti - i-tý znak otevřeného 
         *  Ki - i-tý znak hesla textu (v případě, že je heslo kratší než text (což je obvyklé) dochází k opakování hesla
         *  m - délka abecedy
        */
        public static string Encipher(string text, string key)
        {


            string encryptedText = "";
            return encryptedText;
        }
        public static string Decipher(string encryptedText, string key)
        {
            string decryptedText = "";
            return decryptedText;
        }

    }
}
