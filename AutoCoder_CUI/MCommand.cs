using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCommandCS
{
    public partial class MCommand
    {
        public string Version = "v1.0";
        protected List<MModule> Modules = new List<MModule>();
        protected List<string> DefaultCommands = new List<string>();
        protected char ModuleSprt = '.';
        protected char SprtInArgs = ',';
        protected char Sprt = ' ';

        public MCommand()
        {
            this.Initialize();
        }

        virtual protected void Initialize()
        {
            this.DefaultCommands.Add("help");
            this.DefaultCommands.Add("quit");
            this.IncludeNewModule(new MStd());
            this.IncludeNewModule(new MMath());
        }

        public void IncludeNewModule(MModule newmodule)
        {
            if (newmodule == null) throw new ArgumentNullException();
            this.Modules.Add(newmodule);
        }

        public void Run()
        {
            while(true)
            {
                string cmd = Console.ReadLine();
                var args = this.DecodeArgs(cmd);
                this.ExecuteCommand(args);
                if (args[0] == "quit") break;
            }
        }

        public List<string> DecodeArgs(string words)
        {
            var args = new List<string>();
            args.Add("");
            int level = 0;
            bool modulefrag = false;
            foreach(var w in words)
            {
                if(w == this.ModuleSprt && modulefrag == false)
                {
                    level++;
                    args.Add("");
                    modulefrag = true;
                    continue;
                }
                else if(w == this.SprtInArgs)
                {
                    level++;
                    args.Add("");
                    continue;
                }
                else if(w == '(')
                {
                    level++;
                    args.Add("");
                    continue;
                }
                else if(w == ')')
                {
                    level++;
                    args.Add("");
                    continue;
                }
                else if(w == this.Sprt)
                {
                    level++;
                    args.Add("");
                    continue;
                }

                args[level] += w;
            }

            return args;
        }

        public void ShowAllModuleCommandInfo()
        {
            foreach(var module in this.Modules)
            {
                module.ShowHelp();
            }
        }

        public void ShowAllDefaultCommands()
        {
            Console.WriteLine("----------DefaultCommands----------");
            foreach(var cmd in this.DefaultCommands)
            {
                Console.WriteLine(cmd);
            }
        }

        public void ExecuteCommand(List<string> args)
        {
            Console.WriteLine("");
            if (args[0] == this.DefaultCommands[0])
            {
                this.ShowAllDefaultCommands();
                return;
            }
            
            foreach(var module in this.Modules)
            {
                if(args[0] == module.ModuleName)
                {
                    module.ExecuteCommand(args);
                    return;
                }
            }
        }

        //指定したインデックスに引数が存在するかどうかを返します。
        public static bool IsExistAt(in List<string> args,int at)
        {
            try
            {
                var At = args[at];
            }
            catch(IndexOutOfRangeException)
            {
                return false;
            }
            return true;
        }
    }
}