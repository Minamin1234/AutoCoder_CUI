using System;

namespace AutoCoder
{
    //���O��Ԃ̒�`���i�[���Ă����N���X
    public partial class Namespace : Element
    {
        public Namespace? fromNamespace { get; set;}   //�e�̖��O���
        public string? namespaceName { get{ return this.name;} set{ this.name = value;}}
        public List<Element?>? elements { get; set;}   //���O��ԓ��̗v�f
        public Namespace() { }
        public override string on_Build()
        {
            return this.language.Namespace(ref this);
        }
    };
}