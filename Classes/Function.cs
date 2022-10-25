using System;

namespace AutoCoder
{
    //関数の定義を格納しておくクラス
    public partial class Function : Element
    {
        public string functionName { get{ return this.name;} set{ this.name = value;}} //関数名
        public List<Arg> args = null;                                                  //引数リスト
        public List<Function> exes = null;                                             //関数内処理リスト
        public Function() { }

        //関数呼び出しとしてコード生成します。
        public string on_call() { return "";}
    };
}