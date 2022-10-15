using System;

namespace AutoCoder
{
    //ŠÖ”‚Ì’è‹`‚ğŠi”[‚µ‚Ä‚¨‚­ƒNƒ‰ƒX
    public partial class Function : Element
    {
        public string? functionName { get{ return this.name;} set{ this.name = value;}} //ŠÖ”–¼
        public List<Arg?>? args { get; set;}
        public Function() { }

        public string on_call() { return "";}
    };
}