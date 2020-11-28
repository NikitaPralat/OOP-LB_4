using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LB_4.tasks._1
{
    class Human
    {
        public Human() { }
        public Human(string Name, string LastName, string Gender, int Age)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Gender = Gender;
            this.Age = Age;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public void Info()
        {
            Debug.WriteLine(
                $"Имя: {Name}\n" +
                $"Фамилия: {LastName}\n" +
                $"Пол: {Gender}\n" +
                $"Возраст: {Age}\n");
        }
    }
}
