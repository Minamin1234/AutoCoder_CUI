using System;

namespace AutoCoder
{
    //���ꖈ�̋L�q���@���i�[���Ă����N���X�B
    public partial class Language
    {
        public string? languageName { get; set;}  //���ꖼ
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