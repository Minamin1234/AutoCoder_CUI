using System;

namespace AutoCoder
{
    //メンバ変数を定義するクラス
    public partial class ClassVariable : Variable
    {
        public Class? menberOf { get; set;}             //変数を持つクラス
        public E_AccessLevel? accessLevel { get; set;}  //アクセスレベル
        public ClassVariable() { }
    };
}