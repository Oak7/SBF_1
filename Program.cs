using System;


namespace SBF_1
{
    class Program
    {
    static void Main(string[] args)
        {   
            /*******  Vetor posicaoCliente  ***************/

            Console.Write("x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("y1: ");    
            int y1 = Convert.ToInt32(Console.ReadLine()); 
                
            //int[,] posicaoCliente = new int[x1, y1];
            int[] posicaoCliente = new int[2] {x1, y1};

                       
         
            /*******  Vetor Plano  ***************/

            Console.Write("M: ");
            int M = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("N: ");    
            int N = Convert.ToInt32(Console.ReadLine()); 
                
            //int[,] plano = new int[M,N];
            int[] plano = new int[2] {M, N};  

                     
            
            /********matriz lojas ****************/
            Console.Write("x2: ");
            int x2 = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("y2: ");    
            int y2 = Convert.ToInt32(Console.ReadLine()); 

            //int[,] lojas = new int[x2,y2];
            int[] lojas = new int[2] {x2, y2};

           /**********Cálculo da distência entre cliente e lojas ****************/

           var distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
          // Array.Sort();
          Console.WriteLine(distance);

        }
    }
}
