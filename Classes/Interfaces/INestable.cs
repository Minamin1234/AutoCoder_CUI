using System;

namespace AutoCoder
{
    //入れ子可能であるクラス
    public interface INestable
    {
        //子要素に追加する処理
        void add_ToChild(ref Element any);
        //子要素をビルドする際の処理
        string on_Build_childs();
    }
}