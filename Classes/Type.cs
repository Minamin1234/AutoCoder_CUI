using System;

namespace AutoCoder
{
    //�^��\���N���X
    public partial class Type : Element
    {
        public CommonType commonType = CommonType.NONE;                            //��ʌ^�̎��
        public bool isRef = false;                                                 //�Q�ƌ^�Ƃ��Ă̐錾
        public bool isPtr = false;                                                 //�|�C���^�[�^�Ƃ��Ă̐錾
        public string typeName { get{ return this.name;} set{ this.name = value;}} //�^��
        public string initialValue = "";                                           //�����l
        public Type() { }

        public override string on_Build() { return "";}
    };
}