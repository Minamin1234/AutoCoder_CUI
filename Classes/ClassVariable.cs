using System;

namespace AutoCoder
{
    //�����o�ϐ����`����N���X
    public partial class ClassVariable : Variable
    {
        public Class menberOf = null;                             //�ϐ������N���X
        public E_AccessLevel accessLevel = E_AccessLevel.PRIVATE; //�A�N�Z�X���x��
        public ClassVariable() { }
    };
}