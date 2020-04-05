using System;

namespace homeWorkLesson9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager1 = new Manager("Вася", "Петров");
            var manager2 = new Manager("Коля", "Сидоров") ;
            var programmer1 = new Programmer("Петя", "Иванов");
            var programmer2 = new Programmer("Света", "Захаров");
            var director = new Director("Виктор", "Ивченко");

            GetSomeData(manager2);

            Console.ReadKey();
        }

        static void GetSomeData(IPersonal personal)
        {
            var accessLevelAttribute = (AccessLevelAttribute)Attribute.GetCustomAttribute(personal.GetType(), typeof(AccessLevelAttribute));

            if (accessLevelAttribute.Level > 2)
            {
                Console.WriteLine("Защищенная секция");
            }
            else
            {
                Console.WriteLine("Уровень вашего доступа не позволяет просматривать данную секцию!");
            }
        }
    }
}
