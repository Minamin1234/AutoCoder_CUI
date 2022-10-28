using System;

namespace AutoCoder
{
    //名前空間の定義を格納しておくクラス
    public partial class Namespace : Element,INestable
    {
        public Namespace fromNamespace = null;                                          //親の名前空間
        public string namespaceName { get{ return this.name;} set{ this.name = value;}}
        public List<Element> elements = null;                                           //名前空間内の要素
        public Namespace() { }
        public override string on_Build()
        {
            string res = string.Empty;
            res += this.Begin;
            res += this.language.s_namespace;
            res += this.language.s_space;
            res += this.namespaceName;
            res += this.NewLine;
            res += this.language.s_block_begin;
            res += this.NewLine;
            if (this.elements != null) res += this.on_Build_childs();
            res += this.NewLine;
            res += this.language.s_block_end;
            res += this.NewLine;

            return res;
        }

        public void add_ToChild(ref Element any)
        {
            any.level++;
            this.elements.Add(any);
        }

        public string on_Build_childs()
        {
            string res = string.Empty;
            if (this.elements == null) return res;
            foreach(var e in this.elements)
            {
                res += e.on_Build();
            }

            return res;
        }
    };
}