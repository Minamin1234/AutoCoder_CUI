using System;

namespace AutoCoder
{
    //�\�[�X�R�[�h�ɋL�q����S�Ă̗v�f
    public partial class Element
    {
        public string? name { get; set;}
        public Language? language { get; set;}
        public Element() { }

        //�\�[�X�R�[�h�����������ۂɌĂ΂�܂��B
        public string on_Build() { return "";}
    };
}