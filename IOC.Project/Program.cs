using System;

namespace IOC.Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            BL bl = new BL();
            bl.GetProducts().ForEach(p =>
            {
                Console.WriteLine($"{p.Id} - {p.Name} - {p.Price} - {p.Stock}");
            });


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
