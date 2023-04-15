using System;
using C_Algo_DataStructure.Implementation;
using System.Collections.Generic;
using C_Algo_DataStructure.PatternSlidingWindow;
using C_Algo_DataStructure.StringAndArray;
using C_Algo_DataStructure.ElementsOfProgramming;
using C_Algo_DataStructure.Implementation.LinkedList;

namespace C_Algo_DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {var sll=new SingleLinkedList<int>(new Node<int>(10));

        sll.InsertToEnd(new Node<int>(5));
        
        sll.InsertToEnd(new Node<int>(7));
        
        sll.InsertToEnd(new Node<int>(9));
        
        sll.InsertToEnd(new Node<int>(3));
        
        sll.InsertToEnd(new Node<int>(2));
        sll.reverse();
      var strn=  sll.ToString();
Console.WriteLine(strn);
        }
    }
}
