using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCoder
{
    public partial class MNamespace : MObject
    {
        public string NamespaceName //名前空間名
        {
            get{return this.Name;}
            set{this.Name = value;}
        }
        public MNamespace()
        {

        }

        public MNamespace(string name)
        {
            this.NamespaceName = name;
        }
    }
}