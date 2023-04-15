using System.Collections.Generic;

namespace C_Algo_DataStructure.PatternSlidingWindow
{


    //Given a string, find the length of the longest substring in it with no more than K distinct characters.
    class MaxFruitCountOf2Types
    {
        public int findLength(char[] inputString){
            int maxCount = 0;
            int K=2;
            for(int i = 0; i < inputString.Length; i++)
            {
                if (maxCount >= inputString.Length - i)
                    break;
                var uniqueChars = new List<char>();
                for (int j = i; j < inputString.Length; j++) {
                    if (uniqueChars.Contains(inputString[j])) {
                        if (j == inputString.Length - 1) {

                            if ((j - i) > maxCount)
                            {
                                maxCount = j - i;

                            }
                        }

                        continue;
                    }
                    uniqueChars.Add(inputString[j]);
                    if (uniqueChars.Count > K ) {

                        if ((j - i) > maxCount) {
                            maxCount = j - i;
                          
                        }
                        break;
                    }
                }
            }
            return maxCount;

}
}



}


