using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherFormsApp
{
    /// <summary>
    /// static class to process token string
    /// </summary>
    public static class ProcessToken
    {
        //hardcoded increment count
        private const int incrementCount = 3;
        
        /// <summary>
        /// main function to get all chars of string and then process to encrypt or decrypt
        /// </summary>
        /// <param name="strEncryptedCode"></param>
        /// <param name="cipherType"></param>
        /// <returns></returns>
        public static string ProcessTokenCode(string strEncryptedCode, string cipherType)
        {
            //return empty if string is empty
            if (string.IsNullOrEmpty(strEncryptedCode))
            {
                return strEncryptedCode;
            }

            //get the length of string
            var strlength = strEncryptedCode.Length;

            //initialise char array as length of string
            var charArr = new char[strlength];

            //loop to process each char in string length
            for (int i = 0; i < strEncryptedCode.Length; i++)
            {
                //get processes char
                charArr[i] = ProcessChar(strEncryptedCode[i], cipherType);
            }

            //convert all char array to string and return
            return new string(charArr);
        }

        /// <summary>
        /// private function to process char value to get encrypted or decrypted value
        /// </summary>
        /// <param name="chrProcessChar"></param>
        /// <param name="cipherType"></param>
        /// <returns></returns>
        private static Char ProcessChar(char chrProcessChar, string cipherType)
        {
            //if char not a lower or upper alphabet -- dont process it
            if (!((chrProcessChar >= 'a' && chrProcessChar <= 'z') || (chrProcessChar >= 'A' && chrProcessChar <= 'Z')))
            {
                return chrProcessChar;
            }

            //determine if lower character flag
            var isLower = (chrProcessChar >= 'a' && chrProcessChar <= 'z');

            //convert the char to lower case irrespsective to process
            var processedChar = chrProcessChar.ToString().ToLower()[0];

            //calculate the bits to be added or subtracted based on modulus of total alphabets i.e 26
            var calculateBits = incrementCount % 26;

            if (cipherType == CipherType.Decrypt.ToString())
            {
                //if decrypt then subtract the count
                processedChar -= (char)(calculateBits);
                //check if processedChar bit value is less than lower a
                if (processedChar < 'a')
                {
                    //then add 26 to make it lower case alphabet instaed of alphanumeric character
                    processedChar += (char)26;
                }
            }
            else
            {
                //if encrypt then add the count
                processedChar += (char)(calculateBits);
                //check if processedChar bit value is greater than lower z
                if (processedChar > 'z')
                {
                    //then subtract 26 to make it lower case alphabet instaed of alphanumeric character
                    processedChar -= (char)26;
                }
            }

            //if not lower charcter flag
            if (!isLower)
            {
                //convert char to Upper case
                processedChar = processedChar.ToString().ToUpper()[0];
            }

            //return the processed char value
            return processedChar;
        }
    }
}
