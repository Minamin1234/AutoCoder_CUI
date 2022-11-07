using System;
using System.Collections;
using System.Collections.Generic;

namespace AutoCoder
{
    //�֐��̒�`���i�[���Ă����N���X
    public partial class Function : Element
    {
        public Type returnType;                                                        //�߂�l�^
        public string functionName { get{ return this.name;} set{ this.name = value;}} //�֐���
        public List<Arg> args = null;                                                  //�������X�g
        public List<Function> exes = null;                                             //�֐����������X�g
        public Function() { }

        public override string on_Build()
        {
            string res = String.Empty;
            res += this.NewLine;
            
            res += this.returnType.on_Build();
            res += this.language.s_space;
            res += this.functionName;
            res += this.language.s_arg_begin;
            res += this.on_Build_args();
            res += this.language.s_arg_end;

            res += this.NewLine;
            res += this.language.s_block_begin;

            if(this.exes != null)
            {
                foreach(var e in this.exes)
                {
                    res += e.on_Build();
                }
            }

            res += this.NewLine;
            res += this.language.s_block_end;
            return res;
        }

        public string on_Build_args()
        {
            string res = string.Empty;
            if(this.args != null)
            {
                res += this.Begin;
                for(int i = 0;i < this.args.Count;i++)
                {
                    res += this.args[i].on_Build();
                    if(i != this.args.Count - 1)
                    {
                        res += this.language.s_space;
                        res += this.language.s_sprt_arg;
                    }
                }
            }

            return res;
        }

        public string on_build_exes()
        {
            string res = string.Empty;

            if(this.exes != null)
            {
                res += this.Begin;
                foreach(var e in this.exes)
                {
                    res += e.on_Build();
                    res += this.NewLine;
                }
            }

            return res;
        }

        //�֐��Ăяo���Ƃ��ăR�[�h�������܂��B
        public string on_call(Element from)
        {
            string result = string.Empty;
            result += from.Begin;
            result += this.functionName;
            result += this.language.s_arg_begin;
            return "";
        }
    }}