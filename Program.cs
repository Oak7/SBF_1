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
                
            int[,] posicaoCliente = new int[x1, y1];
            //int[] posicaoCliente = new int[2] {x1, y1};

                       
         
            /*******  Vetor Plano  ***************/

            Console.Write("M: ");
            int M = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("N: ");    
            int N = Convert.ToInt32(Console.ReadLine()); 
                
            //int[,] plano = new int[M,N];
            int[] plano = new int[2] {M, N};  

            double[] maisPerto = new double[M];       
            
            /********matriz de lojas ****************/            
            for (int p = 0; p < M; p++)
            {
                
                Console.Write("w: ");
                int x2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("z: ");    
                int y2 = Convert.ToInt32(Console.ReadLine()); 

                int[,] lojas = new int[x2,y2];
                //int[,] lojaB = new int[18,56];
                //int[,] lojaC = new int[99,2];
            

                //int[] lojas = new int[2] {x2, y2};          

          

                /***** Cálculo da distância entre cliente e lojas ****/
                

                var distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
                // Array.Sort();

                Console.WriteLine("{0:0}",distance);
                double a = distance;
                maisPerto[p]= a;
                //double maisPerto = distance;
                //quero colocar os resultados do cálculo dentro de um vetor
                
                Console.WriteLine(maisPerto[p]);
                
                
          
            } 
            
            Array.Sort(maisPerto);
           Console.WriteLine("{0:0} é a loja mais próxima", maisPerto[0]); 
           Console.WriteLine("{0:0} é a 2ª loja mais próxima",maisPerto[1]);  
           Console.WriteLine("{0:0} é a 3ª loja mais próxima",maisPerto[2]);
                
        }            
    }
}
