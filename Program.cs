using System;
using System.Collections;
using System.Collections.Generic;

namespace AutoCoder // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Namespace nmsp = new Namespace();
            Namespace nmsp2 = new Namespace();
            Language lng = new Language();
            nmsp.language = lng;
            nmsp.namespaceName = "Test";
            nmsp2.language = lng;
            nmsp2.namespaceName = "Test2";
            nmsp2.level++;
            nmsp.elements = new List<Element>();
            nmsp.elements.Add(nmsp2);
            var res = nmsp.on_Build();
            Console.WriteLine(res);
        }
    }
}