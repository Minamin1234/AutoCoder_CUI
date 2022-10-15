using System;

namespace AutoCoder
{
    //•Ï”‚Ì’è‹`‚ğŠi”[‚µ‚Ä‚¨‚­ƒNƒ‰ƒX
    public partial class Variable : Element
    {
        public string? variableName { get{ return this.name;} set{ this.name = value;}} //•Ï”–¼
        public Type? variableType { get; set;}                                           //•Ï”Œ^
        public Variable() { }
    };
}