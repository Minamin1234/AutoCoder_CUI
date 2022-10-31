using System;
using System.Collections.Generic;

namespace AutoCoder
{
    //�N���X��`���i�[���Ă����N���X
    public partial class Class : Element
    {
        public Class from = null;                                                     //�p����
        public Namespace fromNamespace = null;                                        //�������閼�O���
        public string? className { get{ return this.name;} set{ this.name = value;}}  //�N���X��
        public ClassFunction construct = null;                                        //�R���X�g���N�^
        public ClassFunction destruct = null;                                         //�f�X�g���N�^   
        public List<ClassFunction> funcs = null;                                      //�����o�֐�
        public List<ClassVariable> vars = null;                                       //�����o�ϐ�
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

        //�N���X�Ăяo���Ƃ��Đ�������ۂɌĂ΂�܂��B
        public string on_Call() { return "";}
    };
}