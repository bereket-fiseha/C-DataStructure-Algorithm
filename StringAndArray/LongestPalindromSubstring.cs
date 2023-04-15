using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Algo_DataStructure.StringAndArray
{
    public class LongestPalindromSubstring
    {
        public String longestPalSubStr(string strn) {
            string longestPalSubStr = "";
            for (int i = 0; i < strn.Length; i++) {
                for (int j = i; j < strn.Length; i++) {
                    bool isPal = isPalindrom(strn.Substring(i, j-i));
                    if (isPal) {

                        longestPalSubStr = strn.Substring(i, j - i);

                    }
                }            
            }
            return longestPalSubStr;
        
        }

       private bool isPalindrom(string strn) => strn == reverseString(strn);

        string reverseString(string strn) {

            StringBuilder newStrn = new StringBuilder();

            for (int i = strn.Length - 1; i >= 0; i--) {

                newStrn.Append(i);
            }



            return newStrn.ToString();
        
        }

    }

}

