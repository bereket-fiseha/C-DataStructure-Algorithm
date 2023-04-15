
using System.Collections.Generic;

namespace C_Algo_DataStructure.PatternSlidingWindow
{
public class MaxSumSubArray{


public int MaxSumSubArrayBruteForce(List<int> inputArray,int k){
var max=0;
for(int i=0;i<inputArray.Count-k;i++){
    int sum=0;
for(int j=i;j<k+i;j++){

sum+=inputArray[j];
}
if (sum>max)
     max=sum;
}

return max;
}


public int MaxSumSubArrayEfficient(List<int> inputArray,int k){
var max=0;
var sum=0;
for(int i=0;i<inputArray.Count;i++){
    sum+=inputArray[i];
if(i<k){
    max=sum;
   continue;
}
else{
sum-=inputArray[i-k];
//sum+=inputArray[i+1];
if (sum>max)
     max=sum;
}
}

return max;
}



}

}