using System;

namespace AutoCoder
{
    //���ۓI�ȏ����E��`����C�ӂ̌���������I�ɐ�������v���O����
    public partial class AutoCoder
    {
        public Project Current = null;        //���݂̃v���W�F�N�g
        public string Result = "";            //
        public AutoCoder() {}

        //��`�E�������ꂽ�f�[�^����\�[�X�R�[�h���r���h���܂��B
        public bool Build()
        {
            if(this.Current == null || this.Current.Elements == null) return false;
            foreach(var i in this.Current.Elements)
            {
                this.Result += i.on_Build();
            }
            return true;
        }
    };
}