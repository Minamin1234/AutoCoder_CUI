using System;

namespace AutoCoder
{
    //���ꖈ�̋L�q���@���i�[���Ă����N���X�B
    public partial class Language
    {
        public string? languageName { get; set;}              //���ꖼ
        public string s_include = "include";                  //���C�u�������̒ǉ��L�[���[�h
        public string s_define = "#";                         //�}�N����`����
        public string s_namespace = "namespace";              //���O��Ԃ̋L�q�L�[���[�h
        public string s_block_begin = "{";                    //�����L�q�u���b�N�̊J�n����
        public string s_block_end = "}";                      //�����L�q�u���b�N�̏I������
        public string s_arg_begin = "(";                      //�����L�q�̊J�n����
        public string s_arg_end = ")";                        //�����L�q�̏I������
        public string s_line_end = ";";                       //�����̍s������
        public string s_set = "=";                            //�������
        public string s_sprt_arg = ",";                       //�������̋�ؕ���
        public string s_bool_false = "false";                 //bool�̋U�l
        public string s_bool_true = "true";                   //bool�̐^�l
        public string s_bool = "bool";                        //bool�^�L�[���[�h
        public string s_int = "int";                          //int�^�L�[���[�h
        public string s_lint = "long long";                   //int�^���傫���^�L�[���[�h
        public string s_float = "float";                      //float�^�L�[���[�h
        public string s_lfloat = "double";                    //float�^���傫���^�̃L�[���[�h
        public string s_decimal = "decimal";                  //decimal�^�̃L�[���[�h
        public string s_char = "char";                        //�����^�L�[���[�h
        public string s_string = "string";                    //������^�L�[���[�h
        public string s_object = "object";                    //�I�u�W�F�N�g���N���X�L�[���[�h
        public string s_enum = "enum";                        //�񋓑̃L�[���[�h
        public string s_struct = "struct";                    //�\���̃L�[���[�h
        public string s_class = "class";                      //�N���X�L�[���[�h
        public string s_if = "if";                            //if�L�[���[�h
        public string s_else = "else";                        //else�L�[���[�h
        public string s_switch = "switch";                    //switch�L�[���[�h
        public string s_case = "case";                        //case�L�[���[�h
        public string s_default = "default";                  //default�L�[���[�h
        public string s_for = "for";                          //for�L�[���[�h
        public string s_foreach = "";                         //foreach�L�[���[�h
        public string s_in = "";                              //in�L�[���[�h
        public string s_while = "while";                      //while�L�[���[�h
        public string s_do = "do";                            //do�L�[���[�h
        public string s_try = "try";                          //try�L�[���[�h
        public string s_except = "catch";                     //catch�L�[���[�h
        public string s_throw = "throw";                      //throw�L�[���[�h
        public string s_friend = "friend";                    //friend�L�[���[�h
        public string s_accesslevel_private = "private";      //�A�N�Z�X���x��private�L�[���[�h
        public string s_accesslevel_protected = "protected";  //�A�N�Z�X���x��protected�L�[���[�h
        public string s_accesslevel_public = "public";        //�A�N�Z�X���x��public�L�[���[�h
        public string s_tab = "\t";                           //�^�u
        public string s_newline = "\n";                       //���s
        public string s_space = " ";                          //��
        public string s_colon = ":";
        public Language() {}

        //���O��Ԃ𐶐����܂��B
        public virtual string Namespace(ref Namespace nmsp) { return "";}

        //�N���X��`�𐶐����܂��B
        public virtual string Class(Class cls) { return "";}
        //�����o�֐���`�𐶐����܂��B
        public virtual string ClassFunction(ClassFunction clf) { return "";}

        //�����o�ϐ��錾�𐶐����܂��B
        public virtual string ClassVariable(ClassVariable clv) { return "";}

        //If�X�e�[�g�����g�𐶐����܂��B
        public virtual string IfStatement(Function cond,Function then) { return "";}

        //If-else�X�e�[�g�����g�𐶐����܂��B
        public virtual string IfStatement(Function cond,Function then,Function Else) { return "";}

        //For���[�v�𐶐����܂��B
        public virtual string ForLoop(Function initialize,Function cond,Function addition,Function exes) { return "";}

        //While���[�v�𐶐����܂��B
        public virtual string WhileLoop(Function cond,Function exes,bool dowhile=false) { return "";}

        //foreach���[�v�𐶐����܂��B
        public virtual string ForEachLoop(Function initialize,Variable container) { return "";}

        //�֐���`�𐶐����܂��B
        public virtual string Function(Function f) { return "";}

        //�ϐ��錾�𐶐����܂��B
        public virtual string Variable(Variable v) { return "";}

        //�A�N�Z�X���x���̃L�[���[�h��Ԃ��܂��B
        public virtual string AccessLevel(E_AccessLevel al)
        {
            switch(al)
            {
                case E_AccessLevel.PRIVATE:
                    return this.s_accesslevel_private;
                    break;
                case E_AccessLevel.PROTECTED:
                    return this.s_accesslevel_protected;
                    break;
                case E_AccessLevel.PUBLIC:
                    return this.s_accesslevel_public;
                    break;
            }
            return this.s_accesslevel_private;
        }
    };
}