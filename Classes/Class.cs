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
            return "";
        }

        //�N���X�Ăяo���Ƃ��Đ�������ۂɌĂ΂�܂��B
        public string on_Call() { return "";}
    };
}