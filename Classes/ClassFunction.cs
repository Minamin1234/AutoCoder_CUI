using System;

namespace AutoCoder
{
    //�����o�֐��̒�`���i�[���Ă����N���X
    public partial class ClassFunction : Function
    {
        public Class memberOf = null;                              //�֐������N���X
        public E_AccessLevel accessLevel = E_AccessLevel.PRIVATE;  //�֐��̃A�N�Z�X���x��
        public ClassFunction() { }
    };
}