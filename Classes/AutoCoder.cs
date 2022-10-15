using System;

namespace AutoCoder
{
    //抽象的な処理・定義から任意の言語を自動的に生成するプログラム
    public partial class AutoCoder
    {
        public Project? Current { get; set;}        //現在のプロジェクト
        public AutoCoder() {}

        //定義・実装されたデータからソースコードをビルドします。
        public bool Build() { return true;}
    };
}