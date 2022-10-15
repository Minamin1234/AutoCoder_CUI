using System;

namespace AutoCoder
{
    //名前空間の定義を格納しておくクラス
    public partial class Namespace : Element
    {
        public Namespace? fromNamespace { get; set;}   //親の名前空間
        public List<Element?>? elements { get; set;}   //名前空間内の定義
        public Namespace() { }
    };
}