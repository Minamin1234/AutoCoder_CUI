using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCommandCS
{
    /// <summary>
    /// コマンドモジュールを定義する為の基底クラス．
    /// </summary>
    public class MModule
    {
        /// <summary>
        /// モジュールの名称．コマンドでモジュールを指定する際のキーワードになります．
        /// </summary>
        public string ModuleName = "module";
        /// <summary>
        /// モジュール内のコマンド一覧
        /// </summary>
        public List<string> Commands = new List<string>();

        public MModule()
        {

        }

        /// <summary>
        /// このモジュールが呼ばれ，コマンドを実行されようとする時．
        /// </summary>
        /// <param name="args">モジュール名，コマンド，引数が含まれる文字列リスト</param>
        virtual public void ExecuteCommand(List<string> args)
        {

        }

        /// <summary>
        /// このモジュールのコマンド一覧を出力します．
        /// </summary>
        virtual public void ShowHelp()
        {
            Console.WriteLine("----------Commands----------");
            foreach(var cmd in this.Commands)
            {
                Console.WriteLine(this.ModuleName + "." + cmd);
            }
        }
    }
}