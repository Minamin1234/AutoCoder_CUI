using System;

namespace AutoCoder
{
    //�\�[�X�R�[�h�ɋL�q����S�Ă̗v�f
    public partial class Element
    {
        public string? name { get; set;}       //�v�f��
        public Language? language { get; set;} //�L�q���錾��
        public Element() { }

        //�\�[�X�R�[�h�����������ۂɌĂ΂�܂��B
        public virtual string on_Build() { return "";}
    };
}