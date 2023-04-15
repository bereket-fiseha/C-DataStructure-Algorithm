using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Algo_DataStructure.StringAndArray
{
    public class ArrayOps
    {

        public static int[] arrayProduct(int[] givenArray)
        {

            var productOfArray = 1;
            foreach (var num in givenArray) {
                productOfArray *= num;
                
            }

            for (int i= 0;i<givenArray.Length;i++)
            {
                givenArray[i] = productOfArray / givenArray[i];
                Console.WriteLine(givenArray[i]);
            }

            return givenArray;
        }

        private int[] removeDuplicates(int[] givenArray) {

            Dictionary<int, bool> intAlreadyExists = new Dictionary<int, bool>();
            int[] newArray = new int[givenArray.Length];
          int  j = 0;
             for (int i = 0; i < givenArray.Length; i++) {

                if (!intAlreadyExists[givenArray[i]]) {

                    intAlreadyExists[givenArray[i]] = true;
                    newArray[j] = givenArray[i];
                    j++;
                }
            }

            return newArray;
        }
        private int[] mergeTwoSortedArray(int[] arr1,int[] arr2) {

            int[] newSortedArrry = new int[arr1.Length+arr2.Length];


            int j = 0;
            int i = 0;
            int maxLength = arr1.Length > arr2.Length ? arr1.Length : arr2.Length;
            for (int k = 0; k < arr1.Length+arr2.Length; k++) {
                if (i == arr1.Length - 1)
                {

                    newSortedArrry[k] = arr2[j];
                    j++;
                }
                else if (j == arr2.Length - 1) {


                    newSortedArrry[k] = arr2[i]; }

                if (arr1[i] < arr2[j]) {
                    newSortedArrry[k] = arr1[i];
                    i++;
                }

                else
                {
                    newSortedArrry[k] = arr1[j];
                    j++;



                }

            }

            return newSortedArrry;
        }
        private string changeIntToHex(int count)
        { string hex = "";
            switch (count)
            {
                case 9:
                    hex = "A";
                    break;
                case 10:
                    hex = "B";
                    break;
                default:
                    hex = count.ToString();
                    break;

            }

            return hex;
        }

        private string reverseString(string givenString) {

            var reversedStr = "";
            for (int i = givenString.Length - 1; i >= 0; i++) {
                reversedStr += givenString[i];
            
            }
            return reversedStr;
        }
        public string EncryptString(string givenString) {
            int count = 0;
            StringBuilder newStr = new StringBuilder();

            for (int i = 0; i < givenString.Length; i++) {
                if (givenString[i + 1] == givenString[i])
                {
                    count++;
                }
                else {
                    newStr.Append($"{givenString[i]}{changeIntToHex(count)}");
                    count = 1;

                }
            
            }







            return reverseString(newStr.ToString());
        }

        public void printOccuranceOfNum(dynamic[] arr) {

            dynamic[] uniqueNumArray =new dynamic[arr.Length];
            int[] uniqueCount =new int[arr.Length];
            Dictionary<dynamic, int> uniqueNumCount=new Dictionary<dynamic, int>();
            for (int i = 0; i < arr.Length; i++) {

                if (uniqueNumCount.Keys.ToList().Contains(arr[i]))
                {
                    uniqueNumCount[arr[i]] += 1;
                }
                else { 
                   
                uniqueNumCount[arr[i]]= 1;
                }
            }

            foreach(var key in uniqueNumCount.Keys)
            {

                Console.WriteLine(uniqueNumCount[key]);
            }

        
        }
        
        
        private bool isEven(int num) => num % 2 == 0;

        private void swapInts(int[] arr, int index1, int index2)
        {
            var temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;

        }

public int[] moveEvenNumbersToFrontDummy(int[] arr){
int[] evenArray=new int[arr.Length];
int[] oddArray=new int[arr.Length];
//for even
int j=0;
//for odd
int k=0;
for(int i=0;i<arr.Length;i++){
if(arr[i]%2==0){
evenArray[j]=arr[i];
j++;

}
else{
oddArray[k]=arr[i];
k++;

}

}

return mergeTwoArray(evenArray,oddArray);


}

int[]  mergeTwoArray(int[] arr1,int[] arr2) {

    int[] newArray=new int[arr1.Length+arr2.Length];
int k=0;
for(int i=0;i<arr1.Length;i++){

newArray[k]=arr1[i];
k++;
}

for(int i=0;i<arr2.Length;i++){

newArray[k]=arr2[i];
k++;
}
return newArray;
}
 

        public int[] moveEvenNumbersToFront(int[] arrayOfInts)
        {
            //breakdown the array to even subarray and odd subarray
            int evenSubArrayEnd = -1;
            int oddSubArrayStart = arrayOfInts.Length;
            for (int i = 0; i < arrayOfInts.Length; i++)
            {

                if (isEven(arrayOfInts[i]))
                    evenSubArrayEnd += 1;



                else
                {

                    if (isEven(arrayOfInts[oddSubArrayStart - 1]))
                        evenSubArrayEnd += 1;

                    swapInts(arrayOfInts, i, oddSubArrayStart - 1);



                }


            }
            return arrayOfInts;
        }
    }
}
