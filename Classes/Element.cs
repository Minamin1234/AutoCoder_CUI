using System;

namespace AutoCoder
{
    //ソースコードに記述する全ての要素
    public partial class Element
    {
        public uint level = 1;                 //インデントレベル
        public string name = "element";        //要素名
        public Language language = null;       //記述する言語
        public string content  = "";           //ビルドされた要素(文字列)
        public Element() { }

        //ソースコードが生成される際に呼ばれます。
        public virtual string on_Build() { return "";}
    };
}