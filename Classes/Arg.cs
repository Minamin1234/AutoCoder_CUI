using System;

namespace AutoCoder
{
    //引数の定義を格納しておくクラス。
    public partial class Arg : Element
    {
        public string argName { get{ return this.name;} set{ this.name = value;}}  //引数名
        public Type argType = null;                                                //引数型
        public Arg() { }
        public override string on_Build() { return "";}
    };
}