using System;

namespace AutoCoder
{
    //メンバ変数を定義するクラス
    public partial class ClassVariable : Variable
    {
        public Class menberOf = null;                             //変数を持つクラス
        public E_AccessLevel accessLevel = E_AccessLevel.PRIVATE; //アクセスレベル
        public ClassVariable() { }
    };
}