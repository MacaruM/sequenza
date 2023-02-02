using System;
using System.Collections.Generic;
using System.Linq;

public static class Sequenza
{
    public static int[] Verifica( int N ) 
    {
         

        int[] vet = new int [N*(N+1)/2];
        int x = 0;
        int j = 0;
        if(N>=0){
       for(int i = 1; i<=N; i++)
        {
            
            for( ; j<=x; j++)
            {
             vet[j]=i;
             
            }
            x=j+i;
        }
        return vet;
        }
        return new int[0];

    }
}