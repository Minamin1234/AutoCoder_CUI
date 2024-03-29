using System;

namespace AutoCoder
{
    //変数の定義を格納しておくクラス
    public partial class Variable : Element
    {
        public string variableName { get{ return this.name;} set{ this.name = value;}} //変数名
        public Type variableType = null;                                               //変数型
        public Variable() { }
    };
}