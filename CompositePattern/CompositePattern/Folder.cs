using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Folder : IExplorer
    {
        private String name;
        private List<IExplorer> fileList = new List<IExplorer>();

        public Folder(String name)
        {
            this.name = name;
        }

        public void Output(int depth)
        {
            for(int i=0; i < depth; i++)
            {
                Console.Write("  ");
            }
            Console.WriteLine("Folder:"+name);
            foreach(IExplorer directory in fileList){
                directory.Output(depth+1);
            }

        }

        public void AddComponent(IExplorer explorer)
        {
            fileList.Add(explorer);
        }
    }
}
