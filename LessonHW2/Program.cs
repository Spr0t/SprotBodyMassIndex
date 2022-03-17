using System;

namespace LessonHW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя: фамилию, имя, возраст, вес, рост.

            //Высчитать ИМТ(индекс массы тела) по формуле ИМТ = вес(кг) / (рост(м) * рост(м))

            //Сформировать единую строку, в следующем формате:

            //Your profile:
            //Full Name: фамилия, имя
            //Age: возраст
            //Weight: вес
            //Height: рост
            //Body Mass Index: ИМТ

            //Вывести сформированную строку на консоль.

            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string lastname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш вес:");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост:");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);

            Console.WriteLine("Your profile:");
            Console.WriteLine($"Full Name: {lastname} {name}");
            Console.WriteLine($"Age: {age} years old");
            Console.WriteLine($"Weight: {weight} kg");
            Console.WriteLine($"Height: {height} m");
            Console.WriteLine($"Body Mass Index: {bmi}");
            Console.ReadLine();
            
        }
    }
}
