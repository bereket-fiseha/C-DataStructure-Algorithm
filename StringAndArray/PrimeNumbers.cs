using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Algo_DataStructure.StringAndArray
{
  public  class PrimeNumbers
    {


        public bool isPrime(int num) {

            
            if (num < 2)
                return false;

            for (int i = 2; i*i <= num; i++) {

                if (num % i == 0)
                    return false;
                
            
            }
            return true;
        }

        public List<int> EnumerateAllPrimesToN(int n) {
            var listOfPrimes = new List<int>();

            for(int i = 2; i < n; i++)
            {
                if (isPrime(i))

                {
                    listOfPrimes.Add(i);
                }


            }

            return listOfPrimes;
        }

    }
}
