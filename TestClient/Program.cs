using System;
namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string GetAll = "GetAll";

            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            Console.WriteLine("Getting all");
            //GetAll = int.Parse(Console.ReadLine());

        }
    }
}
