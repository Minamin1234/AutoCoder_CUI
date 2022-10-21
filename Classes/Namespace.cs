using System;

namespace AutoCoder
{
    //名前空間の定義を格納しておくクラス
    public partial class Namespace : Element
    {
        public Namespace? fromNamespace { get; set;}   //親の名前空間
        public string? namespaceName { get{ return this.name;} set{ this.name = value;}}
        public List<Element?>? elements { get; set;}   //名前空間内の要素
        public Namespace() { }
        public override string on_Build()
        {
            return this.language.Namespace(ref this);
        }
    };
}