using System;

namespace AutoCoder
{
    //�^��\���N���X
    public partial class Type : Element
    {
        public CommonType? commonType { get; set;}                                      //��ʌ^�̎��
        public string? typeName { get{ return this.name;} set{ this.name = value;}} //�^��
        public Type() { }
    };
}