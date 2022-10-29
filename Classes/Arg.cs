using System;

namespace AutoCoder
{
    //�����̒�`���i�[���Ă����N���X�B
    public partial class Arg : Element
    {
        public string argName { get{ return this.name;} set{ this.name = value;}}  //������
        public Type argType = null;                                                //�����^
        public Arg() { }
        public override string on_Build()
        {
            string res = string.Empty;
            if(this.argType == null) return res;

            res += this.argType.on_Build();
            res += this.language.s_space;
            res += this.argName;

            return res;
        }
    };
}