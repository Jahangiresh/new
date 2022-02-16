using System;
namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Jahangir";
            student.surname = "Shirinov";
            student.gender = "male";
            student.group = 127;
            student.isgraduated = true;
            student.point = 77;
            student.age = 23;


            //Console.WriteLine(student.returnfullname());
           // Console.WriteLine(student.returnfullinfo());
            Console.WriteLine(student.secondexamchance());

        }
    }
    class Student
    {
        public string Name;
        public string surname;
        public string gender;
        public int age;
        public int point;
        public int group;
        public bool isgraduated;
        

        public string returnfullname()
        {
            // return Name +' '+ surname;
            return $"Name:{Name}\nSurname:{surname}";

        }
        public string returnfullinfo()
        {
            if (isgraduated)
            {
                // return Name + " " + surname + " " + gender + " " + age + " " + point + " " + group + " " + isgraduated;
                return $"Name:{Name}\nsurname: {surname}\ngender:{gender}\nage:{age}\npoint:{point}\ngroup: {group}\nisgraduated:{"graduated in 2020"}";
            }
            else
            {
                // return Name + " " + surname + " " + gender + " " + age + " " + point + " " + group;
                return $"Name:{Name}\nsurname: {surname}\ngender:{gender}\nage:{age}\npoint:{point}\ngroup: {group}\nisgraduated:{"still studing"}";
            }
        }
        public string secondexamchance()
        {
            string a = "DONT WORRY BE HAPPY - BOB MARLEY";
            string b = "second exam chance activated: GOOD LUCK";
            if (true)
            {
                return a;
            }
            else
            {
                return b;
            }
            
        }
    }

}
