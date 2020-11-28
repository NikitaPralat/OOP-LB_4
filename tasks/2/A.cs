using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LB_4.tasks._2
{
    class A
    {
        B b1;
        B b2;
        B b3;

        public A(B b1, B b2)
        {
            this.b1 = b1;
            this.b2 = b2;
        }
        public A(B b1, B b2, B b3) :this(b1, b2) {
            this.b3 = b3;
        }

        public void AllInfo()
        {
            if (b3 != null)
            {
                Debug.WriteLine($"name - {b1.name}\n" +
                $"name - {b2.name}\n" +
                $"name - {b3.name}\n");
            } 
            else if (b3 == null)
            {
                Debug.WriteLine($"name - {b1.name}\n" +
                $"name - {b2.name}\n");
            }
            
        }
    }
}
