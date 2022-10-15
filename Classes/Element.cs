using System;

namespace AutoCoder
{
    //ソースコードに記述する全ての要素
    public partial class Element
    {
        public string? name { get; set;}       //要素名
        public Language? language { get; set;} //記述する言語
        public Element() { }

        //ソースコードが生成される際に呼ばれます。
        public virtual string on_Build() { return "";}
    };
}