using System;


namespace SBF_1
{
    class Program
    {
    static void Main(string[] args)
        {   
            //int i;
            Console.Write("x1: ");
            int x1 = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("y1: ");    
            int y1 = Convert.ToInt32(Console.ReadLine()); 
                
            int[] posicaoCliente = new int[2] {x1,y1};

            
            Console.WriteLine("{0},{1}" ,x1,y1);
            Console.WriteLine("{0},{1}", posicaoCliente[0], posicaoCliente[1]);
            

            

            

           
        }
    }
}
