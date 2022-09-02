namespace Exponent
{
    class Exp {         
        static void Main(string[] args)
        {
            Console.Write("Input base num");
            int basenum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input exponent num");
            int expo = Convert.ToInt32(Console.ReadLine());
            double expresult = Math.Pow(basenum, expo);
            Console.Write(expresult);
        }
    }
}