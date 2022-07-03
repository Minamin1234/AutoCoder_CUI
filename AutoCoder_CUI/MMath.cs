using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCommandCS
{
    /// <summary>
    /// 数学コマンドを提供するモジュールクラス
    /// </summary>
    public class MMath : MModule
    {
        public MMath()
        {
            this.ModuleName = "math";
            this.Commands.Add("abs");
            this.Commands.Add("sin");
            this.Commands.Add("cos");
            this.Commands.Add("tan");
            this.Commands.Add("rad");
            this.Commands.Add("pow");
            this.Commands.Add("sqrt");
            this.Commands.Add("max");
            this.Commands.Add("min");
            this.Commands.Add("pi");
            this.Commands.Add("e");
            this.Commands.Add("help");
        }

        public override void ExecuteCommand(List<string> args)
        {
            float val1 = 0.0f;
            float val2 = 0.0f;
            if(args.Count >= 4)
            {
                if (args[2] != "")
                {
                    val1 = float.Parse(args[2]);
                }
                if(args[3] != "")
                {
                    val2 = float.Parse(args[3]);
                }
            }

            if(args[1] == this.Commands[0])
            {
                Console.WriteLine(MathF.Abs(val1));
            }
            else if(args[1] == this.Commands[1])
            {
                Console.WriteLine(MathF.Sin(val1));
            }
            else if(args[1] == this.Commands[2])
            {
                Console.WriteLine(MathF.Cos(val1));
            }
            else if (args[1] == this.Commands[3])
            {
                Console.WriteLine(MathF.Tan(val1));
            }
            else if (args[1] == this.Commands[4])
            {
                var rad = val1 * (MathF.PI / 180);
                Console.WriteLine(rad);
            }
            else if (args[1] == this.Commands[5])
            {
                Console.WriteLine(MathF.Pow(val1,val2));
            }
            else if (args[1] == this.Commands[6])
            {
                Console.WriteLine(MathF.Sqrt(val1));
            }
            else if (args[1] == this.Commands[7])
            {
                Console.WriteLine(MathF.Max(val1,val2));
            }
            else if (args[1] == this.Commands[8])
            {
                Console.WriteLine(MathF.Min(val1, val2));
            }
            else if (args[1] == this.Commands[9])
            {
                Console.WriteLine(MathF.PI);
            }
            else if (args[1] == this.Commands[10])
            {
                Console.WriteLine(MathF.E);
            }
            else if (args[1] == this.Commands[11])
            {
                this.ShowHelp();
            }
        }
    }
}