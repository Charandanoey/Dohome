namespace Factorial
{
    class Fact {         
        static void Main(string[] args)
        {
            int fac = 1, n;
            Console.Write("Input Facctorial");
            int num = Convert.ToInt32(Console.ReadLine());
            for(n=1;n<=num;n++)
            {
                fac=fac*n;
            }
            Console.Write( fac );
        }
    }
}