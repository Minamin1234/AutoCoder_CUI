using System;

namespace AutoCoder
{
    //関数の定義を格納しておくクラス
    public partial class Function : Element
    {
        public string? functionName { get{ return this.name;} set{ this.name = value;}} //関数名
        public List<Arg?>? args { get; set;}
        public Function() { }

        public string on_call() { return "";}
    };
}