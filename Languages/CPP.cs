using System;

namespace AutoCoder
{
    public partial class CPP : Language
    {
        public CPP() { }
        public override string Namespace(ref Namespace nmsp)
        {
            string res = string.Empty;
            if (nmsp == null) return res;
            res += this.s_namespace;
            res += this.s_space;
            res += nmsp.namespaceName;
            res += this.s_newline;
            res += this.s_block_begin;
            res += this.s_newline;
            res += this.s_tab;
            
        }
    }
}