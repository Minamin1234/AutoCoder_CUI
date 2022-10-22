using System;

namespace AutoCoder
{
    //�\�[�X�R�[�h�ɋL�q����S�Ă̗v�f
    public partial class Element
    {
        public uint level = 1;                 //�C���f���g���x��
        public string? name { get; set;}       //�v�f��
        public Language? language { get; set;} //�L�q���錾��
        public string? content { get; set;}    //�r���h���ꂽ�v�f(������)
        public Element() { }

        public virtual void addToContent(string addstr)
        {
            this.content += (this.language.s_tab * this.level) + addstr;
        }

        public void operator<< (Element e1,string addstr)
        {
            el.content += (el.language.s_tab * el.level) + addstr;
        }

        //�\�[�X�R�[�h�����������ۂɌĂ΂�܂��B
        public virtual string on_Build() { return "";}
    };
}