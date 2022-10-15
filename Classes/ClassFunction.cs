using System;

namespace AutoCoder
{
    //メンバ関数の定義を格納しておくクラス
    public partial class ClassFunction : Function
    {
        public Class? memberOf { get; set;}             //関数を持つクラス
        public E_AccessLevel? accessLevel { get; set;}  //関数のアクセスレベル
        public ClassFunction() { }
    };
}