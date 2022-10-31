using System;
using System.Collections;
using System.Collections.Generic;

namespace AutoCoder
{
    //�\�[�X�R�[�h�ɋL�q����S�Ă̗v�f
    public partial class Element
    {
        public uint level = 0;                 //�C���f���g���x��
        public string name = "element";        //�v�f��
        public Language language = null;       //�L�q���錾��
        public string content  = "";           //�r���h���ꂽ�v�f(������)
        public string Begin                    //�J�n����
        {
            get
            {
                var res = "";
                for(int i = 0;i < this.level;i++) res += this.language.s_tab;
                return res;
            }
        }
        public string NewLine                  //�C���f���g���܂މ��s����
        {
            get
            {
                var res = "";
                res += this.language.s_newline;
                for (int i = 0;i < this.level;i++) res += this.language.s_tab;
                return res;
            }
        }
        public Element() { }

        //�\�[�X�R�[�h�����������ۂɌĂ΂�܂��B
        public virtual string on_Build() { return "";}
        //�v�f�̃��X�g�Ȃǂɒǉ����ꂽ�ۂɌĂ΂�܂��B
        public virtual void on_Added(Element on)
        {
            this.level = on.level + 1;
        }
    };
}