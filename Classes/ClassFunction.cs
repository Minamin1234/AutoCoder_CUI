using System;

namespace AutoCoder
{
    //メンバ関数の定義を格納しておくクラス
    public partial class ClassFunction : Function
    {
        public Class memberOf = null;                              //関数を持つクラス
        public E_AccessLevel accessLevel = E_AccessLevel.PRIVATE;  //関数のアクセスレベル
        public ClassFunction() { }
        public override string on_Build()
        {
            var res = base.on_Build();
            res = this.language.AccessLevel(this.accessLevel) + this.language.s_space + res;

            return res;
        }
    };
}