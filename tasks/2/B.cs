using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LB_4.tasks._2
{
    class B
    {
        public string name;

        public B(string name)
        {
            this.name = name;
        }
        public virtual void Info()
        {
            Debug.WriteLine("Клас B");
        }
    }
}
