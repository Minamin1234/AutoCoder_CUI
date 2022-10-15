using System;

namespace AutoCoder
{
    //言語毎の記述方法を格納しておくクラス。
    public partial class Language
    {
        public string? languageName { get; set;}              //言語名
        public string s_include = "include";                  //ライブラリ等の追加キーワード
        public string s_define = "#";                         //マクロ定義文字
        public string s_namespace = "namespace";              //名前空間の記述キーワード
        public string s_block_begin = "{";                    //処理記述ブロックの開始文字
        public string s_block_end = "}";                      //処理記述ブロックの終了文字
        public string s_arg_begin = "(";                      //引数記述の開始文字
        public string s_arg_end = ")";                        //引数記述の終了文字
        public string s_line_end = ";";                       //処理の行末文字
        public string s_set = "=";                            //代入文字
        public string s_sprt_arg = ",";                       //引数内の区切文字
        public string s_bool_false = "false";                 //boolの偽値
        public string s_bool_true = "true";                   //boolの真値
        public string s_bool = "bool";                        //bool型キーワード
        public string s_int = "int";                          //int型キーワード
        public string s_lint = "long long";                   //int型より大きい型キーワード
        public string s_float = "float";                      //float型キーワード
        public string s_lfloat = "double";                    //float型より大きい型のキーワード
        public string s_decimal = "decimal";                  //decimal型のキーワード
        public string s_char = "char";                        //文字型キーワード
        public string s_string = "string";                    //文字列型キーワード
        public string s_object = "object";                    //オブジェクト基底クラスキーワード
        public string s_enum = "enum";                        //列挙体キーワード
        public string s_struct = "struct";                    //構造体キーワード
        public string s_class = "class";                      //クラスキーワード
        public string s_if = "if";                            //ifキーワード
        public string s_else = "else";                        //elseキーワード
        public string s_switch = "switch";                    //switchキーワード
        public string s_case = "case";                        //caseキーワード
        public string s_default = "default";                  //defaultキーワード
        public string s_for = "for";                          //forキーワード
        public string s_while = "while";                      //whileキーワード
        public string s_do = "do";                            //doキーワード
        public string s_try = "try";                          //tryキーワード
        public string s_except = "catch";                     //catchキーワード
        public string s_throw = "throw";                      //throwキーワード
        public string s_friend = "friend";                    //friendキーワード
        public string s_accesslevel_private = "private";      //アクセスレベルprivateキーワード
        public string s_accesslevel_protected = "protected";  //アクセスレベルprotectedキーワード
        public string s_accesslevel_public = "public";        //アクセスレベルpublicキーワード
        public string s_tab = "\t";                           //タブ
        public string s_newline = "\n";                       //改行
        public string s_space = " ";                          //空白
        public Language() {}
    };
}