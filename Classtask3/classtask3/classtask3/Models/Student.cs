using System;
namespace classtask3.Models

{
    internal class Student:Person
    {
        private int _Point;
        public int Point
        {
            get { return _Point; }
            set
            { if (value <=0 && value >=100)

                   Console.WriteLine("menfi ola bilmez");

                _Point = value;
            }
        }




        public Student(int point,string name,int age):base(name,age)
        {
            Point = point;
            Name = name;
            Age= age;
        }

        
    }
}
