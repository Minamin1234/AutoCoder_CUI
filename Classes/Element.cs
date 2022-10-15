using System;

namespace AutoCoder
{
    //ソースコードに記述する全ての要素
    public partial class Element
    {
        public string? name { get; set;}
        public Language? language { get; set;}
        public Element() { }

        //ソースコードが生成される際に呼ばれます。
        public string on_Build() { return "";}
    };
}