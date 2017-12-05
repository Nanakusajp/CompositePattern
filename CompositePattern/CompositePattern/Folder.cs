using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Folder : IEntry
    {
        private string name;
        private List<IEntry> entries = new List<IEntry>();

        public Folder(string name)
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
            foreach(IEntry entry in entries){
                entry.Output(depth+1);
            }

        }

        public void AddEntry(IEntry entry)
        {
            entries.Add(entry);
        }
    }
}
