using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Algo_DataStructure.Implementation.LinkedList
{

   public class SingleLinkedList<T>{
        private Node<T> head;
public SingleLinkedList(Node<T> node){

    head=node;
}
public SingleLinkedList(){

 }
        private Node<T> GetLastNode()
        {
            var lastNode = head;
            while (lastNode.Next != null)
            {
                lastNode = lastNode.Next;
            }
            return lastNode;
        }

     public override  string  ToString(){
        var next=head;
        StringBuilder builder=new StringBuilder();
while(next!=null){

builder.Append($"{next.getValue}-->");
next=next.Next;
}
return builder.ToString();
       }
   public   void reverse(){

var current=head.Next;
var next=current.Next;
current.Next=head;
head.Next=null;

while(next.Next!=null){
var temp=next.Next;
next.Next=current;
current=next;
next=temp;

}
head=next;

}  
public void InsertToEnd(Node<T> node){
var lastNode=GetLastNode();
if(head==null)
      head=node;
else
  lastNode.Next=node;

}

public void InsertToFront(Node<T> node){
node.Next=head;
head=node;

}

public void InsertAtIndex(Node<T> node,int index){
var i=0;
Node<T> temp=head;

while(i!=index-1&&temp.Next!=null){
temp=temp.Next;
i++;
}
var n=temp.Next;
temp.Next=node;
node.Next= n;

}

private void deleteTheLastNode(){

var lastNode=GetLastNode();
var node=head;
while(node.Next!=lastNode){
node=node.Next;
}

node.Next=null;
}

private void deleteTheFirstNode(){

head=head.Next;


}
private void deleteAtIndex(int index){

var i=0;
Node<T> node=head;

while(i!=index-1&&node.Next!=null){
node=node.Next;
i++;
}
var nodeToBeDeleted=node.Next;
var nextNode=nodeToBeDeleted.Next;
node.Next=nextNode;

}

bool Exists(T value){
var node=head;
while(node.getValue.Equals(value)&&node.Next!=null){

node=node.Next;
}
return node.getValue.Equals(value);
}

}

   public  class Node<T> {
        private T value;
        public Node<T> Next;
   public      Node(T value) {

            this.value = value;
        }

        public T getValue
        {
            get {
                return this.value;
            }
            
        }

    
    }
}
