using System;

namespace AutoCoder
{
    //�֐��̒�`���i�[���Ă����N���X
    public partial class Function : Element
    {
        public string? functionName { get{ return this.name;} set{ this.name = value;}} //�֐���
        public List<Arg?>? args { get; set;}
        public Function() { }

        public string on_call() { return "";}
    };
}