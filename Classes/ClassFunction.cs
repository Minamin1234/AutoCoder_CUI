using System;

namespace AutoCoder
{
    //�����o�֐��̒�`���i�[���Ă����N���X
    public partial class ClassFunction : Function
    {
        public Class? memberOf { get; set;}             //�֐������N���X
        public E_AccessLevel? accessLevel { get; set;}  //�֐��̃A�N�Z�X���x��
        public ClassFunction() { }
    };
}