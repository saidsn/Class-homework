using System;

namespace Class_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array homework
            //int[] numbers = new int[6];

            //numbers[0] = 3;
            //numbers[1] = 5;
            //numbers[2] = 100;

            //Array.Resize(ref numbers, 20);
            //numbers[19] = 50;

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] nums = { 1, 2, 5, 6, 7, 55, 4 };
            //Array.Sort(nums);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}


            //int[,] arr = {
            //    {1,2},
            //    {3,4},
            //    {5,6}
            //};
            //Console.WriteLine(arr[2,1]);
            #endregion

            #region Object homework
            //string name1 = "Seid";
            //string surname1 = "Nuraliyev";
            //int age = 33;

            //string name2 = "Orxan";
            //string surname2 = "Ekberov";
            //int age2 = 26;

            //string name3 = "Emil";
            //string surname3 = "Abdullayev";
            //int age3 = 20;

            //Console.WriteLine(name1 + " " + surname1);


            //var obj1 = new
            //{
            //    name = "Seid",
            //    surname = "Nuraliyev",
            //    age = 33
            //};

            //var obj2 = new
            //{
            //    name = "Orxan",
            //    Surname = "Ekberov",
            //    age = 26
            //};
            //Console.WriteLine(obj1.name + " " + obj1.surname + " " + obj1.age );
            //Console.WriteLine($"{obj1.name} {obj1.surname} {obj1.age}");
            #endregion


            #region  Object homework
            //Student st1 = new Student(77, "baki");
            //st1.name = "Orxan";
            //st1.surname = "Ekberov";
            //st1.age = 26;
            //st1.address = "Baki";


            //Student st2 = new Student();
            //st2.name = "Emil";
            //st2.surname = "Abdullayev";
            //st2.age = 20;

            //Console.WriteLine(st2.name);
            //Console.WriteLine(st1.Fullname("baki"));
            //Console.WriteLine(st1.Fulldata());

            //Student st3 = new Student
            //{
            //    name = "Seid",
            //    surname = "Nuraliyev",
            //    age = 33

            //}; Console.WriteLine($"{st3.name} {st3.surname} {st3.age}");

            Student student = new Student();
            student.name = "Orxan";

            //Console.WriteLine(student.GetGroupInfo());

            var result = student.GetGroupInfo();

            Console.WriteLine(student.GetGroupInfo());
            #endregion
        }
    }
    #region Class student homework
    class Student

    {
        #region class homework
        public string name;
        public string surname;
        public int age;
        public string address;

        //public Student()
        //{
        //    Console.WriteLine("Empty");
        //}

        //public Student(int age, string address):this(address)
        //{
        //    this.address = address;
        //    Console.WriteLine("Age:" + age);
        //}
        //public Student(string adds):this(true)
        //{
        //    Console.WriteLine("address:" + adds);
        //}
        //public Student(bool isMarried)
        //{
        //    Console.WriteLine("Married");
        //}


        //public Student(string studentName,int studentAge)
        //{
        //    name = studentName;
        //    age = studentAge;
        //    Console.WriteLine(name + " " + age);
        //}


        //public string Fullname()
        //{
        //    return name + " " + surname;
        //}

        //public string Fulldata()
        //{
        //    return name + " " + surname + " " + age;
        //}

        public string GetGroupInfo()
        {
            Teacher teacher = new Teacher();
            teacher.name = "Cavid";

            return $"Teacher name: {teacher.GetTeacherName()} Student name: {name}";
            #endregion


        }



    }
    #endregion


    #region Class Teacher homework
    class Teacher
    {
        public string name;
        public decimal salary;

        public string GetTeacherName()
        {
            return name;
        }


    }
    #endregion




}
