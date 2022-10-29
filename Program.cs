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
            Language lng = new Language();
            nmsp.language = lng;
            nmsp.namespaceName = "Test";
            nmsp.elements = new List<Element>();
            Class cls = new Class();
            cls.className = "Class1";
            cls.language = lng;

            ClassFunction clf = new ClassFunction();
            clf.language = lng;
            clf.functionName = "func1";
            clf.accessLevel = E_AccessLevel.PUBLIC;
            Type tp = new Type();
            tp.typeName = "aa";
            clf.returnType = tp;
            var clfres = clf.on_Build();
            Console.WriteLine(clfres);
            
            nmsp.add_ToChild(cls);
            var res = nmsp.on_Build();
            Console.WriteLine(res);
        }
    }
}