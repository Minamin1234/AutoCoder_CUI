using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCommandCS
{
    /// <summary>
    /// 基本的なコマンドを提供するモジュールクラス
    /// </summary>
    public class MStd : MModule
    {
        public MStd()
        {
            this.ModuleName = "std";
            this.Commands.Add("print");
            this.Commands.Add("help");
        }

        public override void ExecuteCommand(List<string> args)
        {
            if(args[1] == this.Commands[0])
            {
                Console.WriteLine(args[2]);
            }
            else if(args[1] == this.Commands[1])
            {
                this.ShowHelp();
            }
        }
    }
}