using System;

namespace AutoCoder
{
    //���O��Ԃ̒�`���i�[���Ă����N���X
    public partial class Namespace : Element
    {
        public Namespace? fromNamespace { get; set;}   //�e�̖��O���
        public List<Element?>? elements { get; set;}   //���O��ԓ��̒�`
        public Namespace() { }
    };
}