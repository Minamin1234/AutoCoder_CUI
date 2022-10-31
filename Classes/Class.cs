using System;
using System.Collections.Generic;

namespace AutoCoder
{
    //クラス定義を格納しておくクラス
    public partial class Class : Element
    {
        public Class from = null;                                                     //継承元
        public Namespace fromNamespace = null;                                        //所属する名前空間
        public string? className { get{ return this.name;} set{ this.name = value;}}  //クラス名
        public ClassFunction construct = null;                                        //コンストラクタ
        public ClassFunction destruct = null;                                         //デストラクタ   
        public List<ClassFunction> funcs = null;                                      //メンバ関数
        public List<ClassVariable> vars = null;                                       //メンバ変数
        public Class() { }

        public override string on_Build()
        {
            string res = string.Empty;
            res += this.Begin;
            res += this.language.s_class;
            res += this.language.s_space;
            res += this.className;
            if (this.from != null)
            {
                res += this.language.s_space;
                res += this.language.s_colon;
                res += this.language.s_space;
                res += this.from.className;
            }
            res += this.NewLine;
            res += this.language.s_block_begin;
            res += this.NewLine;
            
            if(this.construct != null)
            {
                res += this.construct.on_Build();
                res += this.NewLine;
            }

            if(this.destruct != null)
            {
                res += this.destruct.on_Build();
                res += this.NewLine;
            }

            var pri = string.Empty;
            var pro = string.Empty;
            var pub = string.Empty;

            pri += this.language.s_accesslevel_private;
            pri += this.language.s_colon;
            pri += this.NewLine;

            pro += this.language.s_accesslevel_protected;
            pro += this.language.s_colon;
            pro += this.NewLine;

            pub += this.language.s_accesslevel_public;
            pub += this.language.s_colon;
            pub += this.NewLine;

            if(this.vars != null)
            {
                foreach(var v in this.vars)
                {
                    switch(v.accessLevel)
                    {
                        case E_AccessLevel.PRIVATE:
                            pri += v.on_Build();
                            pri += this.NewLine;
                            break;
                        case E_AccessLevel.PROTECTED:
                            pro += v.on_Build();
                            pro += this.NewLine;
                            break;
                        case E_AccessLevel.PUBLIC:
                            pub += v.on_Build();
                            pub += this.NewLine;
                            break;
                    }
                }
            }
            
            res += this.NewLine;

            if(this.funcs != null)
            {
                foreach(var f in this.funcs)
                {
                    switch(f.accessLevel)
                    {
                        case E_AccessLevel.PRIVATE:
                            pri += f.on_Build();
                            pri += this.NewLine;
                            break;
                        case E_AccessLevel.PROTECTED:
                            pro += f.on_Build();
                            pro += this.NewLine;
                            break;
                        case E_AccessLevel.PUBLIC:
                            pub += f.on_Build();
                            pub += this.NewLine;
                            break;
                    }
                }
            }

            res += pri;
            res += this.NewLine;
            res += pro;
            res += this.NewLine;
            res += pub;
            
            res += this.NewLine;
            res += this.language.s_block_end;
            res += this.language.s_line_end;
            
            return res;
        }

        //クラス呼び出しとして生成する際に呼ばれます。
        public string on_Call() { return "";}
    };
}