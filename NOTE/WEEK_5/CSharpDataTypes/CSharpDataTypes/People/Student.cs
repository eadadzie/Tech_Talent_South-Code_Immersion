namespace CSharpDataTypes.People
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

        public Student()
        {
            this.name = null;
            this.name = "";
        }

        public Student(string name)
        {
            this.name = name;
        }
    }
}
