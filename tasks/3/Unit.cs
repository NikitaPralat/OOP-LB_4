using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LB_4.tasks._3
{
    class Unit
    {
        public Unit() { }
        public Unit(string Name, string Location)
        {
            this.Name = Name;
            this.Location = Location;
        }

        public string Name { get; set; }
        public string Location { get; set; }

        public virtual void ShowInfo()
        {
            Debug.WriteLine(
                $"This is Class Unit:\n" +
                $"Name: {Name}\n" +
                $"Location: {Location}\n");
        }
    }
}
