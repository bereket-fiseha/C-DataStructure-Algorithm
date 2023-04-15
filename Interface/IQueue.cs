

using System.Collections.Generic;

namespace C_Algo_DataStructure.Interface
{
   
   
   public interface IMyQueue<T>{

 T Pop();
         
 void Push(T item);

IList<T> GetAllItems();

   } 
}