using System;

namespace AutoCoder
{
    //型を表すクラス
    public partial class Type : Element
    {
        public CommonType commonType = CommonType.NONE;                            //一般型の種類
        public bool isRef = false;                                                 //参照型としての宣言
        public bool isPtr = false;                                                 //ポインター型としての宣言
        public string typeName { get{ return this.name;} set{ this.name = value;}} //型名
        public string initialValue = "";                                           //初期値
        public Type() { }

        public override string on_Build()
        {
            string res = string.Empty;
            if(this.isRef)
            {
                res += this.language.s_ref;
            }
            else if(this.isPtr)
            {
                res += this.language.s_ptr;
            }

            if(this.commonType == CommonType.NONE)
            {
                res += this.typeName;
            }
            else
            {
                res += this.get_commonTypename();
            }
            return res;
        }

        //組み込み型の名称を返します。
        public string get_commonTypename()
        {
            string res = string.Empty;
            switch(this.commonType)
            {
                case CommonType.NONE:
                    break;
                case CommonType.BOOL:
                    res = this.language.s_bool;
                    break;
                case CommonType.INT:
                    res = this.language.s_int;
                    break;
                case CommonType.LINT:
                    res = this.language.s_lint;
                    break;
                case CommonType.FLOAT:
                    res = this.language.s_float;
                    break;
                case CommonType.LFLOAT:
                    res = this.language.s_lfloat;
                    break;
                case CommonType.CHAR:
                    res = this.language.s_char;
                    break;
                case CommonType.STRING:
                    res = this.language.s_string;
                    break;
                case CommonType.ENUM:
                    res = this.language.s_enum;
                    break;
                case CommonType.STRUCT:
                    res = this.language.s_struct;
                    break;
                case CommonType.OBJECT:
                    res = this.language.s_object;
                    break;
            }

            return res;
        }
    };
}