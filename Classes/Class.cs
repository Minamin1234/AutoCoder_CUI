using System;
using System.Collections.Generic;

namespace AutoCoder
{
    //クラス定義を格納しておくクラス
    public partial class Class : Element
    {
        public Class? from { get; set;}                                               //継承元
        public Namespace? fromNamespace { get; set;}                                  //所属する名前空間
        public string? className { get{ return this.name;} set{ this.name = value;}}  //クラス名
        public ClassFunction? construct { get; set;}                                  //コンストラクタ
        public ClassFunction? destruct { get; set;}                                   //デストラクタ   
        public List<ClassFunction?>? funcs { get; set;}                               //メンバ関数
        public List<ClassVariable?>? vars { get; set;}                                //メンバ変数
        public Class() { }

        public override string on_Build()
        {
            string res = string.Empty;
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
            res += this.language.s_newline;
            res += this.language.s_block_begin;
            res += this.language.s_newline;
            
            res += this.construct.on_Build();
            res += this.language.s_newline;

            res += this.destruct.on_Build();
            res += this.language.s_newline;

            foreach(var v in this.vars)
            {
                res += v.on_Build();
            }
            res += this.language.s_newline;

            foreach(var f in this.funcs)
            {
                res += f.on_Build();
                res += this.language.s_space;
            }
            res += this.language.s_newline;
            res += this.language.s_block_end;
            
            return "";
        }

        //クラス呼び出しとして生成する際に呼ばれます。
        public string on_Call() { return "";}
    };
}