using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Algo_DataStructure.ElementsOfProgramming
{
    public class StringImp
    {

        private int alphaToInt(char givenChar)
        {
            switch (givenChar)
            {

                case 'A':
                    return 1;

                case 'B':
                    return 2;
                case 'C':
                    return 3;
                case 'D':
                    return 4;
                case 'E':
                    return 5;
                case 'Y':
                    return 25;
                case 'Z':
                    return 26;

                default:
                    return 0;

            }

        }



        public int spreadSheetColumnEndcoding(string givenColumnStrn)
        {
            var encondedInt = 0;
            for (int i = givenColumnStrn.Length - 1; i >= 0; i--)
            {

                encondedInt += alphaToInt(givenColumnStrn[i]) * (int)Math.Pow(26, givenColumnStrn.Length - 1 - i);
            }
            return encondedInt;
        }
    }
}