using System;
using System.Collections;
using System.Collections.Generic;

namespace AutoCoder
{
    //ソースコードに記述する全ての要素
    public partial class Element
    {
        public uint level = 0;                 //インデントレベル
        public string name = "element";        //要素名
        public Language language = null;       //記述する言語
        public string content  = "";           //ビルドされた要素(文字列)
        public string Begin                    //開始文字
        {
            get
            {
                var res = "";
                for(int i = 0;i < this.level;i++) res += this.language.s_tab;
                return res;
            }
        }
        public string NewLine                  //インデントを含む改行文字
        {
            get
            {
                var res = "";
                res += this.language.s_newline;
                for (int i = 0;i < this.level;i++) res += this.language.s_tab;
                return res;
            }
        }
        public Element() { }

        //ソースコードが生成される際に呼ばれます。
        public virtual string on_Build() { return "";}
        //要素のリストなどに追加された際に呼ばれます。
        public virtual void on_Added(Element on)
        {
            this.level = on.level + 1;
        }
    };
}