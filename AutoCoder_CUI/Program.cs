using System;

using MCommandCS;

namespace AutoCoder_CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MCommand CmdDev = new MCommand();
            MAutoCoder mAutoCoder = new MAutoCoder();
            CmdDev.IncludeNewModule(mAutoCoder);
            CmdDev.Run();
        }
    }
}