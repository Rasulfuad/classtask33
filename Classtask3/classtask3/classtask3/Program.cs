using System;
using classtask3.Models;
namespace classtask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[1];

            
             
            

            Console.Write("Ad daxil edin: ");
            string name = Console.ReadLine();

            Console.Write("Soyad daxil edin: ");
            string surname = Console.ReadLine();

            Console.Write("Yasinizi daxil edin: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Point  daxil edin: ");
            int point = Convert.ToInt32(Console.ReadLine());

        }
    }
}
