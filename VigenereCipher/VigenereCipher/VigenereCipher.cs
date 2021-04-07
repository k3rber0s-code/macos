//using System;

//namespace VigenereCipher
//{
//    public class VigenereCipher
//    {
//        /*  Ci = Ti + Ki (mod m)
//         *  --------
//         *  Ci - i-tý znak šifrovaného 
//         *  Ti - i-tý znak otevřeného 
//         *  Ki - i-tý znak hesla textu (v případě, že je heslo kratší než text (což je obvyklé) dochází k opakování hesla
//         *  m - délka abecedy
//        */
//        public static string Encipher(char c, char k)
//        {
//            index = mod(alphabet.IndexOf(text[i]) + secretNums[i % secretNums.Length], 26);

//            string encryptedText = "";
//            return encryptedText;
//        }
//        private static int GetPWKey(char [] password, int passwordLenght, int i)
//        {

//            i++;
//            if (i == passwordLenght)
//            {
//                i = 0;
//            }
//            return key;
//        }
//        private static int Mod(int n, int b)
//        {
//            return n - b * (int)Math.Floor((double)n / b);

//        }
//        public static string Decipher(string encryptedText, string key)
//        {
//            string decryptedText = "";
//            return decryptedText;
//        }

//    }
//}
