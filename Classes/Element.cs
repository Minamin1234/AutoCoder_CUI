using System;

namespace AutoCoder
{
    //�\�[�X�R�[�h�ɋL�q����S�Ă̗v�f
    public partial class Element
    {
        public uint level = 1;                 //�C���f���g���x��
        public string name = "element";        //�v�f��
        public Language language = null;       //�L�q���錾��
        public string content  = "";           //�r���h���ꂽ�v�f(������)
        public Element() { }

        //�\�[�X�R�[�h�����������ۂɌĂ΂�܂��B
        public virtual string on_Build() { return "";}
    };
}