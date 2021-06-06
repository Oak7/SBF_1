using System;


namespace SBF_1
{
    class Program
    {
    static void Main(string[] args)
        {   
            /*******  Vetor Plano  ***************/

            Console.Write("M: ");
            int M = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("N: ");    
            int N = Convert.ToInt32(Console.ReadLine()); 
                
            //int[,] plano = new int[M,N];
            int[] plano = new int[2] {M, N};  

            double[] maisPerto = new double[M];  
            if(M >= 0 && N >= 0){
                

                /*******  Vetor posicaoCliente  ***************/

                Console.Write("X: ");
                int X = Convert.ToInt32(Console.ReadLine()); 

                Console.Write("Y: ");    
                int Y = Convert.ToInt32(Console.ReadLine()); 
                    
                int[,] posicaoCliente = new int[X, Y];
                //int[] posicaoCliente = new int[2] {x1, y1};

                if((X >= 0 && X<=M) && (Y >= 0 && Y <= N)){
                    

                    //
                } 
            }

                  
         
                 
            
            /********matriz de lojas ****************/            
            for (int p = 0; p < N; p++)
            {

                int[,] lojas = { { 40, 88 }, { 18, 56 }, { 99, 2 } };
                //int[,] lojas = new int[2,N];

               
                int x2 = lojas[0,0];
                int y2 = lojas[0,1];
            
            

                        

          

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
