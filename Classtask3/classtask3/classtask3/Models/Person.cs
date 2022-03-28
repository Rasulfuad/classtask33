using System;

namespace classtask3.Models
{
    internal class Person
    {
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set
            {
                if (char.IsUpper(value[0])==false && 3 >= value.Length && value.Length >= 30)
                    Console.WriteLine("duzgun deyil");
                {
                    _Name = value;
                }
            }



        }

        

        private string _Surname;
        public string Surname
        {
            get { return _Surname; }
            set
            {
                if (char.IsUpper(value[0])==false && 3 >= value.Length && value.Length <= 35)

                    _Surname = value;
            }
        }


        public int Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
