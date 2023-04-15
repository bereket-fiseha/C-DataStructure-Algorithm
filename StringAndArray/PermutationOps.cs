using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Algo_DataStructure.StringAndArray
{
  public   class PermutationOps
    {


     public static string   RemoveWhiteSpace(string givenString) {

            //            string result;
            string[] trimedString = givenString.Split(' ');
            Console.WriteLine(trimedString);
            string joinedString = "";
            foreach (var str in trimedString) {
                joinedString.Concat(str);
            }
            Console.WriteLine(joinedString);

            return joinedString;
        }

        public static char[] ReverseString(string givenString) {
            Char[] strChars = new char[givenString.Length];
            int strLength = givenString.Length;
            for(int i = 0; i < strLength; i++)
            {
                strChars[i] = givenString[strLength - (i+1)];
            }

            return strChars;
        }

        public static bool IsPalindromePermutation(string givenString)
        {
            var reversedString =ReverseString(RemoveWhiteSpace(givenString));
            var trimmedString = RemoveWhiteSpace(givenString);
            Console.WriteLine(trimmedString);
            for (int i = 0; i < trimmedString.Length; i++) {
                if (trimmedString[i] != reversedString[i])
                    return false;
            }

            return true;
        }

        public static int CountChar(Char givenChar,String str){
            int count=0;
            for (int i = 0; i < str.Length; i++) {
                if (givenChar == str[i])
                    count++;
            }

            return count;
}

        public static bool IsPermutationOfAGivenStringImp2(string givenString,string testString)
        {
            for (int i = 0; i < testString.Length; i++) {
                Console.WriteLine($"{testString[i]}{CountChar(testString[i], testString)}  {CountChar(testString[i], givenString)} ");

                if (CountChar(testString[i], testString) != CountChar(testString[i], givenString))
                {
                     return false;
                }
            }

            return true;
        }




        public static bool IsPermutationOfAGivenString(string givenString,string testString)
        {

            if (givenString.Length != testString.Length)
                   return false;


            for (int i = 0; i < testString.Length; i++)
            {

                //check if the character exists with in the given string
                var charExistsInGivenString = false;

                for (int j = 0; j < givenString.Length; j++)
                {
                     if (testString[i] == givenString[j]) {
                            charExistsInGivenString = true;
                    
                    }
                        

                }
                if (!charExistsInGivenString)
                    return false;
                
                

            }
           

            return true;
        }


    }
}
