using System;

namespace AutoCoder
{
    //Œ^‚ğ•\‚·ƒNƒ‰ƒX
    public partial class Type : Element
    {
        public CommonType? commonType { get; set;}                                      //ˆê”ÊŒ^‚Ìí—Ş
        public string? typeName { get{ return this.name;} set{ this.name = value;}}     //Œ^–¼
        public string? initialValue { get; set;}                                        //‰Šú’l
        public Type() { }
    };
}