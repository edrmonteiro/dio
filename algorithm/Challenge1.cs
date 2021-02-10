using System;
namespace algorithm
{
    public class squareCubic
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(System.Console.ReadLine());
            for (var i = 1; i <= n;i++)
              System.Console.WriteLine(i.ToString() + " " + (Math.Pow(i, 2)).ToString() + " " + (Math.Pow(i, 3)).ToString());
        }        
    }
}