using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace LB_4.tasks._1
{
    class Employee : Human
    {
        public Employee() : base() { }
        public Employee(string Name, string LastName, string Gender, int Age, string Post, double Salary)
            : base(Name, LastName, Gender, Age)
        {
            this.Post = Post;
            this.Salary = Salary;
        }

        public string Post { get; set; }
        public double Salary { get; set; }

        public void Info()
        {
            Debug.WriteLine(
                $"Имя: {Name}\n" +
                $"Фамилие: {LastName}\n" +
                $"Пол: {Gender}\n" +
                $"Возраст: {Age}\n" +
                $"Должность: {Post}\n" +
                $"Зарплата: {Salary}\n");
        }
    }
}
