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
                
            int[] posicaoCliente = new int[2] {x1,y1};
            
            Array.Sort(posicaoCliente); //ordenação dos vetores
    
            foreach(int item in posicaoCliente)
            {
                Console.WriteLine(item);
            }
            
            

            /*******  Vetor Plano  ***************/

            Console.Write("M: ");
            int M = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("N: ");    
            int N = Convert.ToInt32(Console.ReadLine()); 
                
            int[] plano = new int[2] {M,N};
                        
    
            foreach(int item in plano)
            {
                Console.WriteLine(item);
            }
            Array.Sort(plano);

            

           
        }
    }
}
