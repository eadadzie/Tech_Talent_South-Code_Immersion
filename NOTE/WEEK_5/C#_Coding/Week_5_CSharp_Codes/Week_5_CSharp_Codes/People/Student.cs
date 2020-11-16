using System;
using System.Collections.Generic;
using System.Text;

namespace Week_5_CSharp_Codes.People
{
    class Student
    {
        private string name;
        private int age;
        private string hometown;
        private string favoriteFood;

        public Student(string name, int age, string hometown, string favoriteFood)
        {
            this.name = name;
            this.age = age;
            this.hometown = hometown;
            this.favoriteFood = favoriteFood;
        }
    }
}
