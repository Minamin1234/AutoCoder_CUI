using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCoder
{
    //�v���W�F�N�g�̃f�[�^���i�[����ׂ̃N���X
    public partial class MProject
    {
        public string ProjectName = "project";//�v���W�F�N�g��
        public List<MNamespace> Namespaces = new List<MNamespace>(); //�v���W�F�N�g���ɂ��閼�O��Ԉꗗ
        public MProject()
        {

        }

        //�v���W�F�N�g�̏������ƃv���W�F�N�g�����w�肵�܂��B
        public MProject(string name)
        {
            this.ProjectName = name;
        }

        //�v���W�F�N�g�ɖ��O��Ԃ�ǉ����܂��B
        public void AddNewNamespace(MNamespace newnamespace)
        {
            this.Namespaces.Add(newnamespace);
        }

    }
}