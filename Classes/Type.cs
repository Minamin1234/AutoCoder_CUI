using System;

namespace AutoCoder
{
    //Œ^‚ð•\‚·ƒNƒ‰ƒX
    public partial class Type : Element
    {
        public CommonType? commonType { get; set;}                                      //ˆê”ÊŒ^‚ÌŽí—Þ
        public string? typeName { get{ return this.name;} set{ this.name = value;}} //Œ^–¼
        public Type() { }
    };
}