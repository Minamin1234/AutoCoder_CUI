using System;

namespace AutoCoder
{
    //���ۓI�ȏ����E��`����C�ӂ̌���������I�ɐ�������v���O����
    public partial class AutoCoder
    {
        public Project? Current { get; set;}        //���݂̃v���W�F�N�g
        public AutoCoder() {}

        //��`�E�������ꂽ�f�[�^����\�[�X�R�[�h���r���h���܂��B
        public bool Build() { return true;}
    };
}