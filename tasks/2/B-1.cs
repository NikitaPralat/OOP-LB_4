using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LB_4.tasks._2
{
    class B_1 : B
    {
        public B_1() : base("B_1") { }
        public override void Info()
        {
            Debug.WriteLine("Клас B_1");
        }
    }
}
