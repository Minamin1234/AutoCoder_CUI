using System;

namespace AutoCoder
{
    //���ꖈ�̋L�q���@���i�[���Ă����N���X�B
    public partial class Language
    {
        public string? languageName { get; set;}  //���ꖼ
        public string s_include = "";             //���C�u�������̒ǉ��L�[���[�h
        public string s_namespace = "";           //���O��Ԃ̋L�q�L�[���[�h
        public string s_block_begin = "";         //�����L�q�u���b�N�̊J�n����
        public string s_block_end = "";           //�����L�q�u���b�N�̏I������
        public string s_arg_begin = "";           //�����L�q�̊J�n����
        public string s_arg_end = "";             //�����L�q�̏I������
        public string s_line_end = "";            //�����̍s������
        public string s_set = "";                 //�������
        public Language() {}
    };
}