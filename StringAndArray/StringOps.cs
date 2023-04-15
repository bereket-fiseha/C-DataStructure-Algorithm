using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Algo_DataStructure.StringAndArray
{
  public  class StringOps
    {
        private static string changeIntToHex(int count)
        {
            string hex = "";
            switch (count)
            {
                case 10:
                    hex = "A";
                    break;
                case 11:
                    hex = "B";
                    break;
                case 12:
                    hex = "C";
                    break;
                case 13:
                    hex = "D";
                    break;
                case 14:
                    hex = "E";
                    break;
                case 15:
                    hex = "F";
                    break;
                case 16:
                    hex = "G";
                    break;

                default:
                    hex = count.ToString();
                    break;

            }

            return hex;
        }

        private static string reverseString(string givenString)
        {

            var reversedStr = "";
            for (int i = givenString.Length - 1; i >= 0; i--)
            {
                reversedStr += givenString[i];

            }
            return reversedStr;
        }
        public static string EncryptString(string givenString)
        {
            int count = 1;
            StringBuilder newStr = new StringBuilder();

            for (int i = 0; i < givenString.Length; i++)
            {

                if (i+1!=givenString.Length&&givenString[i + 1] == givenString[i])
                {
                    count++;
                }
                else
                {
                    newStr.Append($"{givenString[i]}{changeIntToHex(count)}");
                    count = 1;

                }

            }







            return reverseString(newStr.ToString());
        }

        public static bool VerifyIPV4(string givenString) {
            List<int> splittedString = new List<int>();
            var octave = "";
            
            for (int i = 0; i < givenString.Length; i++) {

                
                if (givenString[i] == '.'|| i == givenString.Length - 1)
                {
                    if (i == givenString.Length - 1)
                           octave += givenString[i];
                    if (int.TryParse(octave, out int result))
                    {
                        if ( result>0 && result < 255)
                        {
                            splittedString.Add(result);
                        }
                        else
                        {
                            return false;

                        }
                    
                    }
                    else {
                        return false;
                    }
                    octave = "";

                }



                else {

                    octave += givenString[i];
                    }

            
            }
            Console.WriteLine(splittedString[0].ToString());
            Console.WriteLine(splittedString[2].ToString());
            Console.WriteLine(splittedString[3].ToString());

            return splittedString.Count == 4;
        }

public static string ReverseString(string givenString){
            List<string> splittedString = new List<string>() ;
            var word = "";

            for (int i = 0; i < givenString.Length; i++) {
                if (givenString[i] == ' ')
                {
                    splittedString.Add(word);
                    word = "";
                }
                else {
                    word = word + givenString[i];
                }
                
            }
            splittedString.Add(word);

            Console.WriteLine(splittedString.Count);
            StringBuilder reversedStrn = new StringBuilder();
            for (int i = splittedString.Count-1; i >=0; i--) {
                reversedStrn.Append(splittedString[i]);
            reversedStrn.Append(" ");
            }

            return reversedStrn.ToString();
}

public static string Compress(string givenString){
    var compressedString=new List<char>();
for(int i=0;i<givenString.Length;i++){
var currentChar=givenString[i];
                var count = 1;
                while (i < givenString.Length - 1 && givenString[i + 1] == currentChar)
                {

                    count++;
                    i++;

                }
                compressedString.Add(currentChar);
                var countStr = count.ToString();
                foreach (var ch in countStr)
                {
                    compressedString.Add(ch);
                }
}
            displayArrayOfChar(compressedString);

            if (compressedString.Count<givenString.Length)
           return compressedString.ToString();
            return givenString;  
}

        public static void displayArrayOfChar(List<char> charArray) {

            foreach (var ch in charArray) {
                Console.Write(ch);
            }
        }

        public static char[] URLify(string givenString)
        {
            var totalCharLength = 0;
            for(int i = 0; i < givenString.Length; i++)
            {
                if (givenString[i] == ' ')
                    totalCharLength += 3;
                else
                    totalCharLength += 1;

            }

           givenString= givenString.TrimEnd();

            char[] stringChars=new char[totalCharLength];
            int j = 0;
            for (int i = 0; i < givenString.Length; i++)
            {

                if (givenString[i] == ' ')
                {
                    stringChars[j] = '%';
                    stringChars[j + 1] = '2';
                    stringChars[j + 2] = '0';
                    j = j + 3;
                }
                else
                {
                    stringChars[j] = givenString[i];

                    j++;
                }
                      
            }

            return stringChars;
        }


    }
}

