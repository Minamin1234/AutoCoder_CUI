using System;

namespace AutoCoder
{
    //�����o�ϐ����`����N���X
    public partial class ClassVariable : Variable
    {
        public Class? menberOf { get; set;}             //�ϐ������N���X
        public E_AccessLevel? accessLevel { get; set;}  //�A�N�Z�X���x��
        public ClassVariable() { }
    };
}