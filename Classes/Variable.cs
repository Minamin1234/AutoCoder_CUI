using System;

namespace AutoCoder
{
    //�ϐ��̒�`���i�[���Ă����N���X
    public partial class Variable : Element
    {
        public string? variableName { get{ return this.name;} set{ this.name = value;}} //�ϐ���
        public Type? variableType { get; set;}                                           //�ϐ��^
        public Variable() { }
    };
}