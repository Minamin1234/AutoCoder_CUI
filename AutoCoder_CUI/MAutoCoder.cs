using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MCommandCS;
using AutoCoder;

namespace AutoCoder_CUI
{
    /// <summary>
    /// 数学コマンドを提供するモジュールクラス
    /// </summary>
    public class MAutoCoder : MModule
    {
        protected AutoCoder.AutoCoder autocoder = new AutoCoder.AutoCoder();
        public MAutoCoder()//~~~~~コマンド定義したら分岐処理を追加する事~~~~~
        {
            this.ModuleName = "autocoder";
            this.Commands.Add("new");
            this.Commands.Add("load");
            this.Commands.Add("project");
            this.Commands.Add("newnamespace");
            this.Commands.Add("addnmsp");
            this.Commands.Add("nmsp");
            this.Commands.Add("help");
        }

        public override void ExecuteCommand(List<string> args)
        {
            //autocoder.new [name]　指定した名称でプロジェクトを作成します。
            if(args[1] == this.Commands[0])
            {
                try
                {
                    this.autocoder.NewProject(args[2]);
                    Console.WriteLine("Created Project: " + this.autocoder.GetProjectName());
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Not enough arg: name");
                    return;
                }
                
            }//autocoder.load　既に作成されたプロジェクトをロードします。
            else if(args[1] == this.Commands[1])
            {

            }//autocoder.project　プロジェクト名を表示します。
            else if(args[1] == this.Commands[2])
            {
                Console.WriteLine("Project_Name: " + this.autocoder.GetProjectName());
            }//autocoder.newnamespace [name]　指定した名称で新規に名前空間を作成します。
            else if(args[1] == this.Commands[3])
            {
                try
                {
                    this.autocoder.NewNamespace(args[2]);
                    Console.WriteLine("Created Namespace: " + this.autocoder.GetNamespaceName());
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Not enough arg: name");
                    return;
                }
            }//autocoder.addnmsp　現在のプロジェクトに現在の名前空間を追加します。
            else if(args[1] == this.Commands[4])
            {
                this.autocoder.AddNmspToProject();
                Console.WriteLine("Added current namespace to project: " + autocoder.GetNamespaceName());
            }//autocoder.nmsp　現在作成中の名前空間の名称を表示します。
            else if(args[1] == this.Commands[5])
            {
                Console.WriteLine("Namespace_Name: " + this.autocoder.GetNamespaceName());
            }//autocoder.help　AutoCoderのコマンド一覧を表示させます。
            else if(args[1] == this.Commands[6])
            {
                this.ShowHelp();
            }
            //~~~~~分岐追加したらコマンド追加する事~~~~~
        }
    }
}