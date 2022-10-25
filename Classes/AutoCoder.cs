using System;

namespace AutoCoder
{
    //抽象的な処理・定義から任意の言語を自動的に生成するプログラム
    public partial class AutoCoder
    {
        public Project Current = null;        //現在のプロジェクト
        public string Result = "";            //
        public AutoCoder() {}

        //定義・実装されたデータからソースコードをビルドします。
        public bool Build()
        {
            if(this.Current == null || this.Current.Elements == null) return false;
            foreach(var i in this.Current.Elements)
            {
                this.Result += i.on_Build();
            }
            return true;
        }
    };
}