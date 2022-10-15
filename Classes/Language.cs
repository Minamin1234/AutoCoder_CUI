using System;

namespace AutoCoder
{
    //言語毎の記述方法を格納しておくクラス。
    public partial class Language
    {
        public string? languageName { get; set;}  //言語名
        public string s_include = "";             //ライブラリ等の追加キーワード
        public string s_namespace = "";           //名前空間の記述キーワード
        public string s_block_begin = "";         //処理記述ブロックの開始文字
        public string s_block_end = "";           //処理記述ブロックの終了文字
        public string s_arg_begin = "";           //引数記述の開始文字
        public string s_arg_end = "";             //引数記述の終了文字
        public string s_line_end = "";            //処理の行末文字
        public string s_set = "";                 //代入文字
        public Language() {}
    };
}