using System;

namespace AutoCoder
{
    //言語毎の記述方法を格納しておくクラス。
    public partial class Language
    {
        public string? languageName { get; set;}  //言語名
        public string s_include = "";
        public string s_namespace = "";
        public string s_block_begin = "";
        public string s_block_end = "";
        public string s_arg_begin = "";
        public string s_arg_end = "";
        public string s_line_end = "";
        public string s_set = "";
        public Language() {}
    };
}