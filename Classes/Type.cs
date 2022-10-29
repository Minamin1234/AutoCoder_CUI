using System;

namespace AutoCoder
{
    //�^��\���N���X
    public partial class Type : Element
    {
        public CommonType commonType = CommonType.NONE;                            //��ʌ^�̎��
        public bool isRef = false;                                                 //�Q�ƌ^�Ƃ��Ă̐錾
        public bool isPtr = false;                                                 //�|�C���^�[�^�Ƃ��Ă̐錾
        public string typeName { get{ return this.name;} set{ this.name = value;}} //�^��
        public string initialValue = "";                                           //�����l
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

        //�g�ݍ��݌^�̖��̂�Ԃ��܂��B
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