using System;

namespace C_Algo_DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
                     
         var  quickUnion= new QuickUnion(5);
            quickUnion.union(3,4);
        Console.WriteLine(quickUnion.connected(3,4));
               }
    }
}
