using System;

namespace AutoCoder
{
    //ソースコードに記述する全ての要素
    public partial class Element
    {
        public uint level = 1;                 //インデントレベル
        public string? name { get; set;}       //要素名
        public Language? language { get; set;} //記述する言語
        public string? content { get; set;}    //ビルドされた要素(文字列)
        public Element() { }

        public virtual void addToContent(string addstr)
        {
            this.content += (this.language.s_tab * this.level) + addstr;
        }

        public void operator<< (Element e1,string addstr)
        {
            el.content += (el.language.s_tab * el.level) + addstr;
        }

        //ソースコードが生成される際に呼ばれます。
        public virtual string on_Build() { return "";}
    };
}