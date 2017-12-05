using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    interface IEntry
    {
        void Output(int depth);
        void AddComponent(IEntry explorer);
    }
}
