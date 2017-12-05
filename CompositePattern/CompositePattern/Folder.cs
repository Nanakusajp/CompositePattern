using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Folder : IEntry
    {
        private String name;
        private List<IEntry> fileList = new List<IEntry>();

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
            foreach(IEntry directory in fileList){
                directory.Output(depth+1);
            }

        }

        public void AddComponent(IEntry explorer)
        {
            fileList.Add(explorer);
        }
    }
}
