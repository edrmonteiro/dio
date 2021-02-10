using System;

namespace Challenge
{
    class Program
    {
        public static void Main(string[] args)
        {
          int R = Convert.ToInt32(System.Console.ReadLine());
          int V = 0;
          while (V <= R)
          {
            V = Convert.ToInt32(System.Console.ReadLine());
          }
          int soma = R;
          int qtd = 1;
          while(soma <= V)
          {
            //System.Console.WriteLine(soma); 
            R++;
            qtd++;
            soma += R;
          }
          System.Console.WriteLine(qtd);          
        }
    }
}
