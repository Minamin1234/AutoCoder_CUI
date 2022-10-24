using System;
using System.Collections.Generic;

namespace AutoCoder
{
    //�N���X��`���i�[���Ă����N���X
    public partial class Class : Element
    {
        public Class? from { get; set;}                                               //�p����
        public Namespace? fromNamespace { get; set;}                                  //�������閼�O���
        public string? className { get{ return this.name;} set{ this.name = value;}}  //�N���X��
        public ClassFunction? construct { get; set;}                                  //�R���X�g���N�^
        public ClassFunction? destruct { get; set;}                                   //�f�X�g���N�^   
        public List<ClassFunction?>? funcs { get; set;}                               //�����o�֐�
        public List<ClassVariable?>? vars { get; set;}                                //�����o�ϐ�
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

        //�N���X�Ăяo���Ƃ��Đ�������ۂɌĂ΂�܂��B
        public string on_Call() { return "";}
    };
}