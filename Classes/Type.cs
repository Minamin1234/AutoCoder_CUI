using System;

namespace AutoCoder
{
    //型を表すクラス
    public partial class Type : Element
    {
        public CommonType? commonType { get; set;}                                      //一般型の種類
        public bool isRef { get; set;}                                                  //参照型としての宣言
        public bool isPtr { get; set;}                                                  //ポインター型としての宣言
        public string? typeName { get{ return this.name;} set{ this.name = value;}}     //型名
        public string? initialValue { get; set;}                                        //初期値
        public Type() { }

        public override string on_Build() { return "";}
    };
}