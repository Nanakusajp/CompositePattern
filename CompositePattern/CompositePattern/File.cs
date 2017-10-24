﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class File : IExplorer
    {
        private string name;

        public File(String name)
        {
            this.name = name;
        }

        public void Output(int depth)
        {
            for (int i = 0; i < depth; i++)
            {
                Console.Write("  ");
            }
            Console.WriteLine("File:" + name);
        }

        public void AddComponent(IExplorer explorer) => throw new Exception();
    }
}