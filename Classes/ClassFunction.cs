using System;

namespace AutoCoder
{
    //メンバ関数の定義を格納しておくクラス
    public partial class ClassFunction : Function
    {
        public Class memberOf = null;                              //関数を持つクラス
        public E_AccessLevel accessLevel = E_AccessLevel.PRIVATE;  //関数のアクセスレベル
        public Type returnType = null;                             //関数の戻り値型
        public ClassFunction() { }
    };
}