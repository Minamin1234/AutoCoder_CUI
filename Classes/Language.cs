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
        public Language() {}
    };
}