using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MCommandCS;

namespace AutoCoder
{
    public class AutoCoder
    {
        protected MProject Project = null;//���݂̃v���W�F�N�g
        protected MNamespace CurrentNamespace = null;
        public AutoCoder()
        {

        }

        //�V�����v���W�F�N�g���쐬���܂��B
        public void NewProject(string name)
        {
            this.Project = new MProject(name);
        }

        //���݂̃v���W�F�N�g����Ԃ��܂��B
        public string GetProjectName()
        {
            return this.Project.ProjectName;
        }

        //�V�K�ɖ��O��Ԃ��쐬���܂��B
        public void NewNamespace(string name)
        {
            this.CurrentNamespace = new MNamespace(name);
        }

        //���݂̍쐬���̖��O��Ԗ���Ԃ��܂��B
        public string GetNamespaceName()
        {
            return this.CurrentNamespace.NamespaceName;
        }

        //���ݍ쐬���̖��O��Ԃ����݂̃v���W�F�N�g�ɒǉ����܂��B
        public void AddNmspToProject()
        {
            if(this.CurrentNamespace == null) return;
            this.Project.AddNewNamespace(this.CurrentNamespace);
        }
    }
}