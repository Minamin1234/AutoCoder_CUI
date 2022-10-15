using System;

namespace AutoCoder
{
    //型を表すクラス
    public partial class Type : Element
    {
        public CommonType? commonType { get; set;}                                      //一般型の種類
        public string? typeName { get{ return this.name;} set{ this.name = value;}} //型名
        public Type() { }
    };
}