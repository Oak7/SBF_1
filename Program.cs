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

                Console.Write("X1: ");
                int X1 = Convert.ToInt32(Console.ReadLine()); 

                Console.Write("Y1: ");    
                int Y1 = Convert.ToInt32(Console.ReadLine()); 
                    
                int[,] posicaoCliente = new int[X1, Y1];
                //int[] posicaoCliente = new int[2] {x1, y1};

                if((X1 >= 0 && X1<=M) && (Y1 >= 0 && Y1 <= N)){
                    
                     int[,] lojas = { { 40, 88 }, { 18, 56 }, { 99, 2 } };
                    //
                    /********matriz de lojas ****************/            
                    for (int p = 0; p < lojas.Length; p++)
                    {
                                      
                                       
                        int X2 = lojas[0,0];//p,p
                        int Y2 = lojas[0,1];

                        int X3 = lojas[1,0];
                        int Y3 = lojas[1,1];

                        int X4 = lojas[2,0];
                        int Y4 = lojas[2,1];

                        /***** Cálculo da distância entre cliente e lojas ****/

                        var distance = Math.Sqrt((Math.Pow(X1 - lojas[0,0], 2) + Math.Pow(Y1 - Y2, 2)));
                       

                        Console.WriteLine("{0:0}",distance);
                        double a = distance;
                        maisPerto[p]= a;
                       
                        
                        Console.WriteLine(maisPerto[p]);
                    } 
                }        
          
            }             
            Array.Sort(maisPerto);
            Console.WriteLine("[{0:0}]", maisPerto[0]); 
            Console.WriteLine("{0:0} é a 2ª loja mais próxima",maisPerto[1]);  
            Console.WriteLine("{0:0} é a 3ª loja mais próxima",maisPerto[2]);
        }    
    }
}
