using System;

namespace AutoCoder // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Namespace nmsp = new Namespace();
            nmsp.namespaceName = "Test";
            var res = nmsp.on_Build();
            Console.WriteLine(res);
        }
    }
}