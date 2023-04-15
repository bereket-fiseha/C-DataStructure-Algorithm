using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Algo_DataStructure.StringAndArray
{
    public class MultiplyTwoArrayInts
    {

        public int[] multiply(int[] arr1, int[] arr2) {

            var result = new int[arr1.Length + arr2.Length];
           // var num = multiplySingleNumWithArray(9, new int[] { 9, 8, 7, },1);
            //  var num = addTwoArray(arr1, arr2);
            //   var num = addZerosAtBackOfArr(2,new int[] { 3, 4, 5 });
            // return num;

            for (int i = 0; i < arr1.Length; i++)
             {
                result = addTwoArray(result, multiplySingleNumWithArray(arr1[i], arr2,i));

             }
            return result;
            }

        private int[] addZerosInfrontOfArr(int numOfZeros, int[] arr)
        {

            if (numOfZeros == 0)
                return arr;
            int[] newArr = new int[numOfZeros + arr.Length];
            int j = arr.Length - 1;
            foreach (int num in arr) {

                newArr[j] = num;
                j--;
            }

            return newArr;
        }

        private int[] addZerosAtBackOfArr(int numOfZeros, int[] arr)
        {

            if (numOfZeros == 0)
                return arr;
            int[] newArr = new int[numOfZeros + arr.Length];
            int j = 0;
            foreach (int num in arr)
            {

                newArr[j] = num;
                j++;
            }

            return newArr;
        }


        private int[] addTwoArray(int[] arr1, int[] arr2) {
            int maxLength = arr1.Length > arr2.Length ? arr1.Length : arr2.Length;

       int[]  newArr1 = addZerosInfrontOfArr(maxLength - arr1.Length, arr1);
        int[]    newAarr2 = addZerosInfrontOfArr(maxLength - arr2.Length, arr2);
            var result = new int[maxLength+1];
            int carry = 0;
            for (int i = maxLength - 1; i >= 0; i--)
            {
                int j = i + 1;
                int sum = newArr1[i] + newAarr2[i] + carry;
                if (i == 0)
                {
                    if (sum > 9)
                    {
                        result[1] = sum - (((int)(sum / 10)) * 10);
                        result[0] = (int)(sum / 10);

                    }
                    else
                        result[1] = sum;

                }
                else
                {
                    if (sum > 9)
                    {
                        result[j] = sum - (((int)(sum / 10)) * 10);
                        carry = (int)(sum / 10);
                    }
                    else
                    {
                        result[j] = sum;
                        carry = 0;

                    }

                }
            }

                return result;
            
            }


        
        
        
         
        private int[] multiplySingleNumWithArray(int num, int[] arr,int index) {

            var result = new int[arr.Length+1];
            int carry = 0;
            for (int i = arr.Length-1; i >= 0; i--) {
                var j = i + 1;
                var mul = (arr[i] * num )+carry;
                if (i == 0)
                {
                    if (mul > 9)
                    {
                        result[j] = mul - ((int)(mul / 10) * 10);
                        result[i] = (int)(mul / 10);
                    }
                    else
                    {


                        result[j] = mul;

                    }


                }
                else {
                    if (mul> 9)
                    {
                        result[j] = mul - ((int)(mul / 10) * 10);
                    carry = (int)(mul / 10);
                    }
                    else
                    {
                        result[j] = mul;
                        carry = 0;
                        

                    }



                }

            }

            if (index > 0)
              result=  addZerosAtBackOfArr(index,result);

            return result;
        }
    }
}
