using System;
using System.Diagnostics;
using LB_4.tasks._1;
using LB_4.tasks._2;
using LB_4.tasks._3;

namespace LB_4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1
            Debug.WriteLine($"{new string('-', 20)} 1st Task: {new string('-', 20)}");

            Debug.WriteLine("http://human");
            Human human = new Human("Никита", "Пралат", "Мужчина", 18);
            human.Info();

            Debug.WriteLine("http://employee");
            Employee employee = new Employee("Андрей", "Ковальчук", "Мужчина", 23, "Дворник", 12344);
            employee.Info();

            Debug.WriteLine("http://human1");
            Human human1 = employee;
            human1.Info();

            Debug.WriteLine("http://employee1");
            Employee employee1 = (Employee)human1;
            employee1.Info();
            #endregion

            #region 2
            Debug.WriteLine($"{new string('-', 20)} 2nd Task: {new string('-', 20)}");

            B_1 b_1 = new B_1();
            B_2 b_2 = new B_2();
            B_3 b_3 = new B_3();

            A a1 = new A(b_1, b_2, b_3);
            a1.AllInfo();

            A a2 = new A(b_1, b_2);
            a2.AllInfo();

            #endregion

            #region 3
            Debug.WriteLine($"{new string('-', 20)} 3nd Task: {new string('-', 20)}");

            Unit unit = new Unit("Wolf", "Earth");
            unit.ShowInfo();

            Hero hero = new Hero("William", "Ship", 1200, "Sword", 15);
            hero.ShowInfo();

            Enemy enemy = new Enemy("Dragon", "Mountain", 20000, "Fire", 50);
            enemy.ShowInfo();
            #endregion

        }
    }
}
