using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            char[] cipheroutput = new char[text.Length];
            char[] charArray = text.ToCharArray();
            for (int i = 0; i < charArray.Length; i +=1 )
            {
                int ascii = 0;
                if (charArray[i] >= 65 && charArray[i] <= 90)
                {
                    ascii = charArray[i] + shiftKey;
                    if (ascii > 90)
                        ascii -= 26;
                }
                else if (charArray[i] >= 97 && charArray[i] <= 122)
                {
                    ascii = charArray[i] + shiftKey;
                    if (ascii > 122)
                        ascii -= 26;
                }
                else
                    ascii = charArray[i];
                cipheroutput[i] = (char)ascii;
            }
            return String.Concat(cipheroutput);
            //throw new NotImplementedException("You need to implement this function.");
        }
    }
}
