using System;

namespace AutoCoder
{
    //定義、処理等の全データを格納しておくクラス
    public partial class Project
    {
        public AutoCoder Owner = null;        //プロジェクトの所有者
        public string projectName = "";       //プロジェクト名
        public List<Element> Elements = null; //要素リスト
        public Project() { }
        public bool Build() { return true;}
    };
}