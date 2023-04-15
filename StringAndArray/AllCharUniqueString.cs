using System.Collections.Generic;

namespace C_Algo_DataStructure.StringAndArray
{
    class AllCharUniqueString
    {


        public static bool AllCharUniqueStringBruteForce(string givenString)
        {


            for (int i = 0; i < givenString.Length; i++)
            {
                char cible = givenString[i];
                for (int j = i; j < givenString.Length; j++)
                {

                    if (cible == givenString[j])
                        return false;

                }


            }

            return true;
        }


    }
}