using System;

namespace AutoCoder
{
    //��`�A�������̑S�f�[�^���i�[���Ă����N���X
    public partial class Project
    {
        public AutoCoder Owner = null;        //�v���W�F�N�g�̏��L��
        public string projectName = "";       //�v���W�F�N�g��
        public List<Element> Elements = null; //�v�f���X�g
        public Project() { }
        public bool Build() { return true;}
    };
}