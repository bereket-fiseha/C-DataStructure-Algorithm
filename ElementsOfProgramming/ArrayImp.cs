using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Algo_DataStructure.ElementsOfProgramming
{
    public class ArrayImp
    {
public int[] moveEvenToFront(int[] arr ){

            //exclusive
            int evenEndIndex = 0;

            //inclusive
            int unclassfiedStartIndex = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0) {

                    swapTowardsLeft(arr, i, evenEndIndex);

                    evenEndIndex++;
                }

                unclassfiedStartIndex++;
            }


            return arr;
}
        private void swapTowardsLeft(int[] arr, int indexOfNum, int desiredIndex) {

            while (indexOfNum != desiredIndex) {

                swapOnce(arr, indexOfNum);

                indexOfNum--;
            
            }
        


        }

        private void swapOnce(int[] arr, int indexOfNum) {

            int temp = arr[indexOfNum - 1];
            arr[indexOfNum - 1] = arr[indexOfNum];

            arr[indexOfNum] = temp;
        
        }

    }
}
