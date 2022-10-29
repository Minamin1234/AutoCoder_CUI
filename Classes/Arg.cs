using System;

namespace AutoCoder
{
    //ˆø”‚Ì’è‹`‚ğŠi”[‚µ‚Ä‚¨‚­ƒNƒ‰ƒXB
    public partial class Arg : Element
    {
        public string argName { get{ return this.name;} set{ this.name = value;}}  //ˆø”–¼
        public Type argType = null;                                                //ˆø”Œ^
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