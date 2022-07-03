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
        protected MProject Project = null;//現在のプロジェクト
        protected MNamespace CurrentNamespace = null;
        public AutoCoder()
        {

        }

        //新しくプロジェクトを作成します。
        public void NewProject(string name)
        {
            this.Project = new MProject(name);
        }

        //現在のプロジェクト名を返します。
        public string GetProjectName()
        {
            return this.Project.ProjectName;
        }

        //新規に名前空間を作成します。
        public void NewNamespace(string name)
        {
            this.CurrentNamespace = new MNamespace(name);
        }

        //現在の作成中の名前空間名を返します。
        public string GetNamespaceName()
        {
            return this.CurrentNamespace.NamespaceName;
        }

        //現在作成中の名前空間を現在のプロジェクトに追加します。
        public void AddNmspToProject()
        {
            if(this.CurrentNamespace == null) return;
            this.Project.AddNewNamespace(this.CurrentNamespace);
        }
    }
}