using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCoder
{
    //プロジェクトのデータを格納する為のクラス
    public partial class MProject
    {
        public string ProjectName = "project";//プロジェクト名
        public List<MNamespace> Namespaces = new List<MNamespace>(); //プロジェクト内にある名前空間一覧
        public MProject()
        {

        }

        //プロジェクトの初期化とプロジェクト名を指定します。
        public MProject(string name)
        {
            this.ProjectName = name;
        }

        //プロジェクトに名前空間を追加します。
        public void AddNewNamespace(MNamespace newnamespace)
        {
            this.Namespaces.Add(newnamespace);
        }

    }
}