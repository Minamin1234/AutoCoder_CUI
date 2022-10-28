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

        //�N���X�Ăяo���Ƃ��Đ�������ۂɌĂ΂�܂��B
        public string on_Call() { return "";}
    };
}