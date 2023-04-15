using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Algo_DataStructure.StringAndArray
{
    public class BuySellStockOnce
    {


        public double MaxProfit(double[] arr) {
            int buyIndex = 0;
            int profitBuyIndex = 0;
            int sellIndex = 0;
            double maxProfit = 0;
            if (arr.Length == 0)
                return 0;

            else {

                
          
                for (int i = 0; i < arr.Length; i++) {
                    if (arr[i] < arr[buyIndex]) {
                        buyIndex =i;
                    }
                    else if (arr[i] > arr[buyIndex])
                    { var profit = arr[i] - arr[buyIndex];

                        if (profit > maxProfit) {
                            maxProfit = arr[i] - arr[buyIndex];
                            sellIndex = i;
                            profitBuyIndex = buyIndex;
                        }
                           }
                }
  
            }


            Console.WriteLine($"you should  buy at index {profitBuyIndex}(value ${arr[profitBuyIndex]}) and sell at index {sellIndex}(value ${arr[sellIndex]}) ");

            return maxProfit;
        }
    }
}
