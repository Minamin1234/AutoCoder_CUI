using System;

namespace AutoCoder
{
    //�^��\���N���X
    public partial class Type : Element
    {
        public CommonType? commonType { get; set;}                                      //��ʌ^�̎��
        public bool isRef { get; set;}                                                  //�Q�ƌ^�Ƃ��Ă̐錾
        public bool isPtr { get; set;}                                                  //�|�C���^�[�^�Ƃ��Ă̐錾
        public string? typeName { get{ return this.name;} set{ this.name = value;}}     //�^��
        public string? initialValue { get; set;}                                        //�����l
        public Type() { }

        public override string on_Build() { return "";}
    };
}