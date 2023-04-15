

namespace C_Algo_DataStructure
{
public class QuickUnion{
private int[] id;
 public QuickUnion(int arrayLength){

id= new int[arrayLength];

for(int i=0;i<arrayLength;i++)
id[i]=i;
}
private int root(int i){

if(id[i] == i)
         return id[i];
  else        
        return root(id[i]);
}

public bool connected(int p,int q){

return root(p)==root(q);

}

public void union(int p,int q){

int rootOFP=root(p);
int rootOFQ=root(q);

id[rootOFP]=rootOFQ;


}


}}