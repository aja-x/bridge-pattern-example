using System;

namespace internalisasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new InterfaceSpecialization());
            client.doSomething();
        }
    }
}
