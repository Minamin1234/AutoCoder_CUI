using System;

namespace AutoCoder
{
    //�֐��̒�`���i�[���Ă����N���X
    public partial class Function : Element
    {
        public string? functionName { get{ return this.name;} set{ this.name = value;}} //�֐���
        public List<Arg?>? args { get; set;}                                            //�������X�g
        public List<Function?>? exes { get; set;}                                       //�֐����������X�g
        public Function() { }

        //�֐��Ăяo���Ƃ��ăR�[�h�������܂��B
        public string on_call() { return "";}
    };
}