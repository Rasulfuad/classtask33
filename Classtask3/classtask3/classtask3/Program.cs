using System;
using classtask3.Models;
namespace classtask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[1];

            string name;
            string surname;
            int age;
            int point;

            Console.Write("Ad daxil edin: ");
            name = Console.ReadLine();

            Console.Write("Soyad daxil edin: ");
            surname = Console.ReadLine();

            Console.Write("Yasinizi daxil edin: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Point  daxil edin: ");
            point = int.Parse(Console.ReadLine());

        }
    }
}
