using System;

namespace AutoCoder
{
    //�����o�֐��̒�`���i�[���Ă����N���X
    public partial class ClassFunction : Function
    {
        public Class memberOf = null;                              //�֐������N���X
        public E_AccessLevel accessLevel = E_AccessLevel.PRIVATE;  //�֐��̃A�N�Z�X���x��
        public ClassFunction() { }
        public override string on_Build()
        {
            var res = base.on_Build();
            res = this.language.AccessLevel(this.accessLevel) + this.language.s_space + res;

            return res;
        }
    };
}