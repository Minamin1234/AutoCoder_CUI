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
            
            res += this.construct.on_Build();
            res += this.NewLine;

            res += this.destruct.on_Build();
            res += this.NewLine;

            foreach(var v in this.vars)
            {
                res += v.on_Build();
            }
            res += this.NewLine;

            foreach(var f in this.funcs)
            {
                res += f.on_Build();
                res += this.language.s_space;
            }
            res += this.NewLine;
            res += this.language.s_block_end;
            
            return res;
        }

        //クラス呼び出しとして生成する際に呼ばれます。
        public string on_Call() { return "";}
    };
}