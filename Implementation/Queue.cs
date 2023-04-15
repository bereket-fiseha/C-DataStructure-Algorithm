using C_Algo_DataStructure.Interface;
using System;
using System.Collections.Generic;


namespace C_Algo_DataStructure.Implementation {




public class MyQueue<T> : IMyQueue<T> 
    {

private readonly  IList<T>  arrayList ; 

public MyQueue(IList<T> list){

arrayList= list;


}

        public  void Push(T item)
        {

            arrayList.Add(item);
            Queue<string> que = new Queue<string>(); 

        }
      public   T Pop()
        {
            var firstItem = arrayList[0];
            arrayList.RemoveAt(0);

            return firstItem;
        }

        public IList<T> GetAllItems() => arrayList;
    }

}