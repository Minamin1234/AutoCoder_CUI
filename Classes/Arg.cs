using System;

namespace AutoCoder
{
    //�����̒�`���i�[���Ă����N���X�B
    public partial class Arg : Element
    {
        public string? argName { get{ return this.name;} set{ this.name = value;}}  //������
        public Type? argType { get; set;}                                           //�����^
        public Arg() { }
    };
}