using System;

namespace AutoCoder
{
    //����q�\�ł���N���X
    public interface INestable
    {
        //�q�v�f�ɒǉ����鏈��
        void add_ToChild(ref Element any);
        //�q�v�f���r���h����ۂ̏���
        string on_Build_childs();
    }
}