using System.Collections.Generic;

namespace C_Algo_DataStructure.PatternSlidingWindow
{
class SmallestSubArray{


public int SmallestSubArrayBruteForce(List<int> inputArray,int givenSum){

            int count = 0;
            bool smallestSubArrayFound = false;
            for (int k = 0; k < inputArray.Count; k++) {
            count++;
                for (int i = 0; i < inputArray.Count; i++)
                {
                    var sum = 0;

                    if (i + count <= inputArray.Count)
                    {
        
        
        
                        for (int j = i; j < i + count; j++)
                        {
                            sum += inputArray[j];

                        }
                    }
                    if (sum >= givenSum)
                    {
                        smallestSubArrayFound = true;
                        break;
                    }
                }
                if (smallestSubArrayFound)
                    break;
}
            return count;
}



}


}