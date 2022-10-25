using System;

namespace AutoCoder
{
    public partial class CPP : Language
    {
        public CPP() { }

        //アクセスレベルからキーワード文字列を返します。
        public string accessLevelName(E_AccessLevel? accessLevel)
        {
            string res = string.Empty;
            if (accessLevel == null) return res;
            switch(accessLevel)
            {
                case E_AccessLevel.PRIVATE:
                    res = this.s_accesslevel_private;
                    break;
                case E_AccessLevel.PROTECTED:
                    res = this.s_accesslevel_protected;
                    break;
                case E_AccessLevel.PUBLIC:
                    res = this.s_accesslevel_public;
                    break;
                default:
                    break;
            }
            return res;
        }

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
            res += nmsp.on_Build();
            res += this.s_newline;
            res += this.s_block_end;

            return res;
        }

        public override string Class(Class cls)
        {
            string res = string.Empty;
            if (cls == null) return res;
            res += this.s_class;
            res += this.s_space;
            res += cls.className;
            res += this.s_newline;
            res += this.s_block_begin;
            res += this.s_newline;
            res += cls.on_Build();
            res += this.s_newline;
            res += this.s_block_end;

            return res;
        }

        public override string ClassFunction(ClassFunction clf)
        {
            string res = string.Empty;
            if (clf == null) return res;
            res += this.accessLevelName(clf.accessLevel);
            res += this.s_space;
            res += clf.returnType.on_Build();
            res += this.s_space;
            res += clf.functionName;
            res += clf.returnType.on_Build();
            res += this.s_newline;
            res += this.s_block_begin;
            res += this.s_newline;
            res += clf.on_Build();
            res += this.s_newline;
            res += this.s_block_end;

            return res;
        }
    }
}