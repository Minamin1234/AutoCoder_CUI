using System;

namespace AutoCoder
{
    //��`�A�������̑S�f�[�^���i�[���Ă����N���X
    public partial class Project
    {
        public AutoCoder? Owner { get; set;}           //�v���W�F�N�g�̏��L��
        public string? projectName { get; set;}        //�v���W�F�N�g��
        public List<Element?>? Elements { get; set;}   //�v�f���X�g
        public Project() { }
        public bool Build() { return true;}
    };
}